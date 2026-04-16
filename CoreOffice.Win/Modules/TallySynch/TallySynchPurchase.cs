
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Application.Services;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using CoreOfficeERP.Domain.Responses.Tally;
using CoreOfficeERP.Tally.Interfaces;
using CoreOfficeERP.Tally.Services;
using Microsoft.Extensions.DependencyInjection;
namespace CoreOffice.Win.Modules.TallySynch

{
    public partial class TallySynchPurchase : Form
    {
        private readonly ITallyPurchaseService _tallyPurchaseService;
        private readonly ITallyProcessOrchestratorService _tallyProcessOrchestrator;
        private readonly ITallyTransactionService _tallyTransactionsService;
        private readonly ITallyConfigService _tallyConfigService;
        private readonly IServiceProvider _serviceProvider;
        private TallyProcessType? ProcessType;
        private readonly ITallyProcessService _tallyProcessService;

        public TallySynchPurchase(ITallyPurchaseService tallyPurchaseService, IServiceProvider serviceProvider, ITallyTransactionService tallyTransactionsService, ITallyProcessOrchestratorService tallyProcessOrchestrator, ITallyProcessService tallyProcessService,ITallyConfigService tallyConfigService)
        {
            InitializeComponent();
            this._tallyPurchaseService = tallyPurchaseService;
            this._serviceProvider = serviceProvider;
            _tallyTransactionsService = tallyTransactionsService;
            _tallyProcessOrchestrator = tallyProcessOrchestrator;
            _tallyProcessService = tallyProcessService;
            _tallyConfigService = tallyConfigService;
            btnSynch.Enabled = false;
            txtVoucher.Focus();
        }
       
        private void ClearData()
        {
            txtVoucher.Text = string.Empty;
            //  lbllrdate.Text = "NA";           
            //  dataGridView1.Rows.Clear();
            // dataGridView1.Refresh();
            // dataGridView1.Rows.Add(200);            

        }

        private void TallySynchPurchase_Load(object sender, EventArgs e)
        {

        }

        private async void btnSynch_Click(object sender, EventArgs e)
        {
            
            if (_currentPurchase == null || _tallyConfig == null)
            {
                MessageBox.Show("No voucher loaded. Please enter voucher first.");
                return;
            }
            btnSynch.Enabled = false;
            AppLoader.Show();
            List<TallyProcessRequest> logs = new();
           
            try
            {               
                logs = await Task.Run(() =>
                _tallyProcessOrchestrator.ExecutePurchase(_currentPurchase, _tallyConfig));
                MessageBox.Show("Voucher successfully sent to Tally!","SSBD",MessageBoxButtons.OK,MessageBoxIcon.Information);

                // ✅ Clear after success
                _currentPurchase = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                try
                {
                    if (logs != null && logs.Any())
                    {
                        var request = new TallyProcessBatchRequest
                        {
                            VoucherId = _currentPurchase?.SaleVoucherPrint?.Id ?? 0,
                            Steps = logs
                        };
                        var result = await _tallyProcessService.CreateAsync(request);
                       
                    }
                }
                catch (Exception apiEx)
                {
                    MessageBox.Show("Log API failed: " + apiEx.Message);
                }

                btnSynch.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        private TallyPurchaseResponse _currentPurchase;
        private TallyConfigResponse _tallyConfig;
        private async void txtVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;       
           
            if (txtVoucher.Text == string.Empty|| txtVoucher.Text==null)
            {
                MessageBox.Show("Please Enter Voucher No first");
                this.txtVoucher.Focus();
                return;
            }
            e.Handled = true;

          int.TryParse(txtVoucher.Text.Trim(), out int id);

            // 1. Get Purchase Data
            var vouchers = await _tallyTransactionsService.GetTallyPurchase(id);

            if (vouchers == null)
            {
                MessageBox.Show("Sale Voucher not Found",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtVoucher.Clear();
                return;
            }
            // 2. Get Tally Config (IMPORTANT)
            int config = 1;
            var tallyConfig = await _tallyConfigService.GetTallyConfig(config);
          

            if (tallyConfig == null)
            {
                MessageBox.Show("Tally Configuration not found");
                return;
            }
            txtVoucher.Clear();

            e.SuppressKeyPress = true;
            // ✅ Store in memory
            _currentPurchase = vouchers;
            _tallyConfig = tallyConfig;
            // ✅ Bind UI
            BindHeader();
            BindGrid();
            txtVoucher.Clear();

            // Optional: UI feedback
            MessageBox.Show("Voucher Loaded Successfully. Click Process to send to Tally.");  
            btnSynch.Enabled = true;

        }
        private void BindHeader()
        {
            //Binding Supplier data
            lblSupplier.Text = _currentPurchase.SupplierResponse.Name;
            lblTallyName.Text = _currentPurchase.SupplierResponse.TallyLedgerName;
            lblGSTIN.Text = _currentPurchase.SupplierResponse.GstIn;
            lblPAN.Text = _currentPurchase.SupplierResponse.PAN;
            lblAddress.Text = _currentPurchase.SupplierResponse.Address;
            lblState.Text = _currentPurchase.SupplierResponse.State;
            lblPIN.Text = _currentPurchase.SupplierResponse.Pincode;
            lblMobile.Text = _currentPurchase.SupplierResponse.Mobile;
            lblEmail.Text = _currentPurchase.SupplierResponse.Email;


            //Binding Agent Data
            lblAgentName.Text= _currentPurchase.SupplierResponse.AgentObj.Name;
            lblATallyName.Text= _currentPurchase.SupplierResponse.AgentObj.TallyLedgerName;
            lblContactPer.Text= _currentPurchase.SupplierResponse.AgentObj.ContactPersonName;
            lblAMobile.Text = _currentPurchase.SupplierResponse.AgentObj.ContactPersonMobile;
            lblAGSTIN.Text= _currentPurchase.SupplierResponse.AgentObj.GSTIN;
            lblAPAN.Text=   _currentPurchase.SupplierResponse.AgentObj.PAN;
            lblCreditDays.Text = _currentPurchase.SupplierResponse.CreditDays.ToString();
            lblCreditLimit.Text = _currentPurchase.SupplierResponse.CreditLimit.ToString();
            lblGSTTreatment.Text=_currentPurchase.SupplierResponse.RegType == 1 ? "Regular" : _currentPurchase.SupplierResponse.RegType == 2 ? "Composition" : "Unregistered";
            lblDiscount.Text = _currentPurchase.SupplierResponse.Discount.ToString("0.00");

        }
        private void BindGrid()
        {          

            var data = _currentPurchase.StockitemResponse.Select(x => new
            {
                Product = x.ProductName,
                HSN= x.HsnCode,
                Quantity = x.Quantity,
                Rate = x.PurchasePrice,
                GST = x.Gst,
                Amount = x.Total                
            }).ToList();

            dataGridInvoice.DataSource = data;
          
        }
        private void setFormForSaleVoucher(TallyPurchaseResponse purchaseResponse)
        {
            
        }
    }
}
