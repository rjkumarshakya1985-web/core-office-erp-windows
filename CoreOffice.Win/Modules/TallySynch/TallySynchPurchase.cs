
using CoreOffice.Win.Session;
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses.Tally;
using CoreOfficeERP.Tally.Interfaces;
namespace CoreOffice.Win.Modules.TallySynch

{
    public partial class TallySynchPurchase : Form
    {
      
        private readonly ITallyProcessOrchestratorService _tallyProcessOrchestrator;
        private readonly ITallyTransactionService _tallyTransactionsService;
        private readonly ITallyConfigService _tallyConfigService;        
        private readonly ITallyProcessService _tallyProcessService;

        public TallySynchPurchase(IServiceProvider serviceProvider, ITallyTransactionService tallyTransactionsService, ITallyProcessOrchestratorService tallyProcessOrchestrator, ITallyProcessService tallyProcessService, ITallyConfigService tallyConfigService)
        {
            InitializeComponent();          
          
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
            this.txtVoucher.Focus();
            dataGridInvoice.DataSource = null;
            dataGridInvoice.Refresh();
            lblSupplier.Text = "NA";
            lblSupplierCode.Text = "NA";
            lblTallyName.Text = "NA";
            lblGSTIN.Text = "NA";
            lblPAN.Text = "NA";
            lblAddress.Text = "NA";
            lblState.Text = "NA";
            lblPIN.Text = "NA";
            lblMobile.Text = "NA";
            lblEmail.Text = "NA";
            lblAgentName.Text = "NA";
            lblATallyName.Text = "NA";
            lblContactPer.Text = "NA";
            lblAMobile.Text = "NA";
            lblAGSTIN.Text = "NA";
            lblAPAN.Text = "NA";
            lblCreditDays.Text = "NA";
            lblCreditLimit.Text = "NA";
            lblGSTTreatment.Text = "NA";
            lblDiscount.Text = "NA";
            txtSBillNumber.Text=string.Empty;
            //Clear Summary
            lblNetAmount.Text = "0.00";
            lblTotalDiscount.Text = "0.00";
            lblTaxable.Text = "0.00";
            lblCGSTTotal.Text = "0.00";
            lblSGSTTotal.Text = "0.00";
            lblIGSTTotal.Text = "0.00";
            lblPayableAmount.Text = "0.00";


        }

        private async void TallySynchPurchase_Load(object sender, EventArgs e)
        {
            AppLoader.Show();
            if (AppCache.Companies != null && AppCache.Companies.Any())
            {
                cmbFiananceYear.DataSource = AppCache.Companies;
                cmbFiananceYear.DisplayMember = "Name";
                cmbFiananceYear.ValueMember = "Id";
                cmbFiananceYear.SelectedValue = 1;
            }
            else
            {
                MessageBox.Show("No companies found");
            }
            if (AppCache.TallyCompanies != null && AppCache.TallyCompanies.Any())
            {
                cmbCompanies.DataSource = AppCache.TallyCompanies;
                cmbCompanies.DisplayMember = "Name";
                cmbCompanies.ValueMember = "Id";
                cmbCompanies.SelectedValue = UserSession.TallyCompId;
            }
            else
            {
                try
                {
                    var result = await _tallyConfigService.GetAllCompanies();
                    if (result == null)
                    {
                        MessageBox.Show("No data from API");
                        return;
                    }

                    if (!result.Any())
                    {
                        MessageBox.Show("No companies found");
                        return;
                    }
                    if (result != null && result.Any())
                    {
                        AppCache.TallyCompanies = result.ToList();
                        cmbCompanies.DataSource = AppCache.TallyCompanies;
                        cmbCompanies.DisplayMember = "Name";
                        cmbCompanies.ValueMember = "Id";

                        var activeComp = result.FirstOrDefault();
                        if (activeComp != null)
                        {
                            UserSession.TallyCompId = activeComp.Id;
                            UserSession.TallyCompanyName = activeComp.Name;
                        }
                    }
                    else
                    {
                        //  lblCompanyInfo.Text = "No Active Financial Year";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading financial year: " + ex.Message);
                }
                this.txtVoucher.Focus();
                AppLoader.Hide();
            }
        }

        private async void btnSynch_Click(object sender, EventArgs e)
        {

            if (_currentPurchase == null || _tallyConfig == null)
            {
                MessageBox.Show("No voucher loaded. Please enter voucher first.");
                return;
            }
            if (txtSBillNumber.Text=="" || txtSBillNumber.Text==string.Empty)
            {
                MessageBox.Show("Please enter Supplier's Bill Number");
                this.txtSBillNumber.Focus();
                return;
            }
            btnSynch.Enabled = false;
            AppLoader.Show();
            List<TallyProcessRequest> logs = new();
            var completedPurchase = _currentPurchase; // ✅ store reference
            bool isSuccess = false;
            try
            {
                // ✅ Call orchestrator (NO Task.Run)
                logs = await _tallyProcessOrchestrator
                    .ExecutePurchase(_currentPurchase, _tallyConfig, Convert.ToInt32(cmbFiananceYear.SelectedValue.ToString()),txtSBillNumber.Text.Trim());
                // ✅ Determine success
                isSuccess = logs != null && logs.Any() && logs.All(x => x.IsSuccess);
                if (isSuccess)
                {
                    MessageBox.Show("Voucher successfully sent to Tally!", "SSBD",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // ✅ Modify response AFTER success
                    MapLedgerNames(completedPurchase);
                    // ✅ Clear after success
                    _currentPurchase = null;
                    ClearData();
                }
                else
                {
                    var failedStep = logs.FirstOrDefault(x => !x.IsSuccess);

                    MessageBox.Show(
                        $"Process failed at Step {failedStep?.Step}: {failedStep?.ErrorMessage}",
                        "SSBD",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                try
                {
                    // ✅ SINGLE API CALL (logs)
                    if (logs != null && logs.Any())
                    {
                        await _tallyProcessService.CreateAsync(logs);
                    }

                    // ✅ NEW: Send updated purchase via PUT
                    // ✅ ONLY update if success
                    if (isSuccess && completedPurchase != null)
                    {
                        //    var updateResult = await _tallyTransactionsService.TallyDataUpdate(completedPurchase?.SaleVoucherPrint?.Id, completedPurchase);
                        var bulkRequest = BuildTallyNameRequests(completedPurchase);

                        if (bulkRequest.Any())
                        {
                            await _tallyTransactionsService.TallyDataUpdate(completedPurchase.SaleVoucherPrint.Id,bulkRequest);
                        }
                    }
                }
                catch (Exception apiEx)
                {
                    MessageBox.Show("Log API failed: " + apiEx.Message);
                }

                btnSynch.Enabled = true;
                AppLoader.Hide();
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

            if (txtVoucher.Text == string.Empty || txtVoucher.Text == null)
            {
                MessageBox.Show("Please Enter Voucher No first");
                this.txtVoucher.Focus();
                return;
            }
            e.Handled = true;

            int.TryParse(txtVoucher.Text.Trim(), out int id);
            try
            {
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
                int config = Convert.ToInt32(cmbCompanies.SelectedValue);
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
                BindSummary();
                txtVoucher.Clear();

                // Optional: UI feedback
                //  MessageBox.Show("Voucher Loaded Successfully. Click Process to send to Tally.");  
                btnSynch.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading voucher: " + ex.Message);
            }
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
            txtSBillNumber.Text=_currentPurchase.SaleVoucherPrint.SupplierBillNumber;

            //Binding Agent Data
            lblAgentName.Text = _currentPurchase.SupplierResponse.AgentObj.Name;
            lblATallyName.Text = _currentPurchase.SupplierResponse.AgentObj.TallyLedgerName;
            lblContactPer.Text = _currentPurchase.SupplierResponse.AgentObj.ContactPersonName;
            lblAMobile.Text = _currentPurchase.SupplierResponse.AgentObj.ContactPersonMobile;
            lblAGSTIN.Text = _currentPurchase.SupplierResponse.AgentObj.GSTIN;
            lblAPAN.Text = _currentPurchase.SupplierResponse.AgentObj.PAN;
            lblCreditDays.Text = _currentPurchase.SupplierResponse.CreditDays.ToString();
            lblCreditLimit.Text = _currentPurchase.SupplierResponse.CreditLimit.ToString();
            lblGSTTreatment.Text = _currentPurchase.SupplierResponse.RegType == 1 ? "Regular" : _currentPurchase.SupplierResponse.RegType == 2 ? "Composition" : "Unregistered";
            lblDiscount.Text = _currentPurchase.SupplierResponse.Discount.ToString("0.00");

        }
        private void BindGrid()
        {

            var data = _currentPurchase.StockitemResponse.Select(x => new
            {
                Product = x.ProductName,
                HSN = x.HsnCode,
                Quantity = x.Quantity,
                Rate = x.PurchasePrice,
                GST = x.Gst,
                Amount = x.Total,
                Discount=x.Discount,
                Taxable=x.DiscountAmount,
                CGST=x.CGST,
                SGST=x.SGST,
                IGST=x.IGST,
                PAYBLE=x.PayableAmount
            }).ToList();

            dataGridInvoice.DataSource = data;

        }
        private void BindSummary()
        {
            var items = _currentPurchase.StockitemResponse;

            lblNetAmount.Text = items.Sum(x => x.Total).ToString("0.00");

            lblTotalDiscount.Text = items.Sum(x => x.DiscountAmount).ToString("0.00");

            lblTaxable.Text = items.Sum(x => x.Total - x.DiscountAmount).ToString("0.00");

            lblCGSTTotal.Text = items.Sum(x => x.CGST).ToString("0.00");

            lblSGSTTotal.Text = items.Sum(x => x.SGST).ToString("0.00");

            lblIGSTTotal.Text = items.Sum(x => x.IGST).ToString("0.00");

            lblPayableAmount.Text = items.Sum(x => x.PayableAmount).ToString("0.00");
        }
        private void MapLedgerNames(TallyPurchaseResponse data)
        {
            if (data == null) return;

            // Supplier
            if (data.SupplierResponse != null)
            {
                data.SupplierResponse.TallyLedgerName = data.SupplierResponse.Name;
            }

            // Stock Groups
            foreach (var group in data.StockGroupResponse ?? new List<StockGroupResponse>())
            {
                group.TallyLedgerName = group.Name;
            }

            // Stock Categories
            foreach (var category in data.StockCategoryResponse ?? new List<StockCategoryResponse>())
            {
                category.TallyLedgerName = category.Name;
            }

            // Stock Items
            foreach (var item in data.StockitemResponse ?? new List<StockitemResponse>())
            {
                item.TallyLedgerName = item.ProductName;
            }
        }
        private List<TallyNameRequest> BuildTallyNameRequests(TallyPurchaseResponse data)
        {
            var list = new List<TallyNameRequest>();

            // ✅ Supplier
            if (data.SupplierResponse != null)
            {
                list.Add(new TallyNameRequest
                {
                    Id = data.SupplierResponse.Id.ToString(),
                    Name = data.SupplierResponse.Name,
                    TallyName = data.SupplierResponse.TallyLedgerName,
                    Type = TallyType.Supplier
                });
            }

            // ✅ Agent
            if (data.SupplierResponse?.AgentObj != null)
            {
                list.Add(new TallyNameRequest
                {
                    Id = data.SupplierResponse.AgentObj.Id.ToString(),
                    Name = data.SupplierResponse.AgentObj.Name,
                    TallyName = data.SupplierResponse.AgentObj.TallyLedgerName,
                    Type = TallyType.Agent
                });
            }

            // ✅ Stock Groups
            foreach (var group in data.StockCategoryResponse ?? new())
            {
                list.Add(new TallyNameRequest
                {
                    Id = group.Id.ToString(),
                    Name = group.Name,
                    TallyName = group.TallyLedgerName,
                    Type = TallyType.StockGroup
                });
            }

            // ✅ Items (if needed)
            foreach (var item in data.StockitemResponse ?? new())
            {
                list.Add(new TallyNameRequest
                {
                    Id = item.Id.ToString(),
                    Name = item.ProductName,
                    TallyName = item.TallyLedgerName,
                    Type = TallyType.StockItem
                });
            }

            return list;
        }
        private void setFormForSaleVoucher(TallyPurchaseResponse purchaseResponse)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close this window?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            { 
            this.Close();
            }
        }
    }
}
