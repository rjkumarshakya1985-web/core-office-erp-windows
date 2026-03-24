using CoreOffice.Win.Session;
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain.Requests.DeliveryChallan;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using System.Data;

namespace CoreOffice.Win.Modules.Cashier
{
    public partial class DeliveryNoteForm : Form
    {
        public int? VisitorId;
        public Guid? CustomerId;
        private readonly IServiceProvider _serviceProvider;
        private readonly IPackingSlipService _packingSlipService;
        private readonly IDeliveryChallanService _deliveryChallanService;
        public DeliveryNoteForm(IServiceProvider serviceProvider
            , IPackingSlipService packingSlipService,
           IDeliveryChallanService deliveryChallanService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _packingSlipService = packingSlipService;
            _deliveryChallanService = deliveryChallanService;
            lblVisitorName.Text = DefaultLabelText();
            lblVisitorMobile.Text = DefaultLabelText();
            lblCustomerName.Text = DefaultLabelText();
            lblCustomerMobile.Text = DefaultLabelText();

        }

        private void DeliveryNoteForm_Load(object sender, EventArgs e)
        {

        }

        private async void txtPackingSlip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.Handled = true;

            var slipNo = txtPackingSlip.Text.Trim();
            if (string.IsNullOrWhiteSpace(slipNo))
                return;

            try
            {

                bool alreadyExists = dataGridInvoice.Rows
                    .Cast<DataGridViewRow>()
                    .Any(r => string.Equals(
                        r.Cells["PackingSlip"].Value?.ToString(),
                        slipNo,
                        StringComparison.OrdinalIgnoreCase));

                if (alreadyExists)
                {
                    MessageBox.Show("This packing slip is already scanned",
                        "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPackingSlip.Clear();
                    return;
                }

                AppLoader.Show();

                var fetchedPackingSlip = await _packingSlipService
                    .GetPackingSlipNumberForBillingAsync(slipNo, UserSession.FinanceYearId);

                if (fetchedPackingSlip == null)
                {
                    MessageBox.Show("No packing slip found with the given number.",
                        "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtPackingSlip.Clear();
                    txtPackingSlip.Focus();
                    return;
                }

                if (fetchedPackingSlip.Visitor == null)
                {
                    MessageBox.Show("Packing slip without visitor not allowed.",
                        "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPackingSlip.Clear();
                    txtPackingSlip.Focus();
                    return;
                }
                // ✅ Visitor validation (correct logic)
                if (VisitorId != null && fetchedPackingSlip.Visitor.Id != VisitorId)
                {
                    MessageBox.Show("Different visitor packing slip not allowed.",
                        "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                setFormForPackingSlip(fetchedPackingSlip);

                txtPackingSlip.Clear();
                txtPackingSlip.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                AppLoader.Hide();
            }
        }
        private void setFormForPackingSlip(PackingSlipResponse packingSlipResponse)
        {
            if (packingSlipResponse == null)
                return;

            if (packingSlipResponse.Visitor != null)
            {
                lblVisitorName.Text = packingSlipResponse.Visitor.Name;
                lblVisitorMobile.Text = packingSlipResponse.Visitor.Mobile;
                VisitorId = packingSlipResponse.Visitor.Id;
            }

            if (packingSlipResponse.Visitor?.CustomerResponse != null)
            {
                lblCustomerName.Text = packingSlipResponse.Visitor.CustomerResponse.Name;
                lblCustomerMobile.Text = packingSlipResponse.Visitor.CustomerResponse.Mobile;
                CustomerId = packingSlipResponse.Visitor.CustomerResponse.Id;
            }

            dataGridInvoice.Rows.Add(
                 packingSlipResponse.Id,
                 packingSlipResponse.SlipNumber,
                 packingSlipResponse.TotalQuantity,
                 packingSlipResponse.TotalAmount.ToString(".00")
             );
            CalculatePackingSlip();
        }

        private void CalculatePackingSlip()
        {
            int TotalPcs = 0;
            decimal TotalAmount = 0;

            dataGridInvoice.Rows.Cast<DataGridViewRow>().ToList().ForEach(row =>
            {
                decimal amount = Convert.ToDecimal(row.Cells["Total"].Value);
                int.TryParse(row.Cells["Qty"].Value?.ToString(), out int qty);


                TotalAmount += amount;
                TotalPcs += qty;
            });

            lblGrandTotal.Text = TotalAmount.ToString("0.00");
            lblTotalPcs.Text = TotalPcs.ToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtPackingSlip.Clear();
            lblVisitorName.Text = DefaultLabelText();
            lblVisitorMobile.Text = DefaultLabelText();
            lblCustomerName.Text = DefaultLabelText();
            lblCustomerMobile.Text = DefaultLabelText();
            dataGridInvoice.Rows.Clear();
            lblGrandTotal.Text = "0.00";
            lblTotalPcs.Text = "0";
            CustomerId = null;
            VisitorId = null;
            txtPackingSlip.Focus();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Basic validations
                if (VisitorId == null)
                {
                    MessageBox.Show("Visitor is required.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                if (dataGridInvoice.Rows.Count == 0)
                {
                    MessageBox.Show("Please add at least one packing slip.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var packingSlipIds = dataGridInvoice.Rows
                    .Cast<DataGridViewRow>()
                    .Select(r => Convert.ToInt32(r.Cells["Id"].Value))
                    .ToList();

                if (!packingSlipIds.Any())
                {
                    MessageBox.Show("Invalid packing slip data.",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Confirm before save
                var confirm = MessageBox.Show(
                    "Are you sure you want to create delivery challan?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                AppLoader.Show();

                var request = new BillingRequest
                {
                    VisitorId = VisitorId.Value,
                    CustomerId = CustomerId,
                    FinanceYearId = UserSession.FinanceYearId,
                    PackingSlipIds = packingSlipIds
                };

                var result = await _deliveryChallanService.CreateAsync(request);

                if (result > 0)
                {
                    AppLoader.Hide();
                    MessageBox.Show("Invoice created successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to create invoice.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                AppLoader.Hide();
            }
        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            var form = new VisitorForm();

            form.OnVisitorSelected = async (visitorId) =>
            {
                await LoadBillByVisitor(visitorId);
            };

            form.ShowDialog();

        }

        public async Task LoadBillByVisitor(int visitorId)
        {
            Clear();
            AppLoader.Show();
            var packingSlips = await _packingSlipService.GetPackingSlipsNumberForBillingByVisitorIdAsync(visitorId, UserSession.FinanceYearId);
            AppLoader.Hide();
            if (packingSlips == null || !packingSlips.PackingSlips.Any())
            {
                MessageBox.Show($"Packing slip not found for the visitor. Packing slip number: {packingSlips.PackingSlips.First().SlipNumber}", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var packingSlip = packingSlips?.PackingSlips.FirstOrDefault();

            if (packingSlip.Visitor != null)
            {
                lblVisitorName.Text = packingSlip.Visitor.Name;
                lblVisitorMobile.Text = packingSlip.Visitor.Mobile;
                VisitorId = packingSlip.Visitor.Id;
            }

            if (packingSlip.Visitor?.CustomerResponse != null)
            {
                lblCustomerName.Text = packingSlip.Visitor.CustomerResponse.Name;
                lblCustomerMobile.Text = packingSlip.Visitor.CustomerResponse.Mobile;
                CustomerId = packingSlip.Visitor.CustomerResponse.Id;
            }

            foreach (var p in packingSlips.PackingSlips)
            {
                dataGridInvoice.Rows.Add(
                 p.Id,
                 p.SlipNumber,
                 p.TotalQuantity,
                 p.TotalAmount.ToString(".00")
             );
            }

            lblGrandTotal.Text = packingSlips.PackingSlips.Sum(x => x.TotalAmount).ToString("0.00");
            lblTotalPcs.Text = packingSlips.PackingSlips.Sum(x => x.TotalQuantity).ToString();
            txtPackingSlip.Clear();
            txtPackingSlip.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridInvoice.Rows.Count == 1)
                {
                    return;
                }
                if (dataGridInvoice.CurrentRow == null)
                    return;

                var result = MessageBox.Show(
                    "Remove selected item?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dataGridInvoice.Rows.Remove(dataGridInvoice.CurrentRow);
                    CalculatePackingSlip();
                }
            }
            catch
            { }
        }

        public string DefaultLabelText()
        {
            return $".........................................";
        }

    }
}
