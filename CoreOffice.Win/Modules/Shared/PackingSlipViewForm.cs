using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Domain.Responses.PackingSlip;

namespace CoreOffice.Win.Modules.Shared
{
    public partial class PackingSlipViewForm : Form
    {
        private readonly IPackingSlipService _packingSlipService;
        public string PackingSlipNumber;
        public PackingSlipViewForm(IPackingSlipService packingSlipService)
        {
            InitializeComponent();
            _packingSlipService = packingSlipService;
        }

        private async void PackingSlipViewForm_Load(object sender, EventArgs e)
        {
            txtPackingSlip.Text = PackingSlipNumber;
            await LoadPackingSlip(PackingSlipNumber);
        }

        private async Task LoadPackingSlip(string packingSlipNumber)
        {
            if (string.IsNullOrEmpty(packingSlipNumber)) return;
            try
            {
                AppLoader.Show();

                var packingSlip = await _packingSlipService
                    .GetByPackingSlipNumberAsync(packingSlipNumber);

                if (packingSlip != null)
                {

                    LoadPackingSlip(packingSlip);
                }
                else
                {
                    MessageBox.Show(
                        "Packing slip not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    dataGridPackingSlip.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dataGridPackingSlip.Rows.Clear();
            }
            finally
            {
                AppLoader.Hide();
            }
        }

        private async void txtPackingSlip_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode != Keys.Enter)
                return;
            e.Handled = true; // prevent ding sound
            if (txtPackingSlip.Text.Trim() == "")
                return;
            await LoadPackingSlip(txtPackingSlip.Text.Trim());
        }

        public void LoadPackingSlip(PackingSlipResponse response)
        {
            if (response == null)
                return;

            // Reset form first
            Clear();


            // Visitor Info
            SetVisitorInfo(
               response.Visitor);


            // Load Items into Grid
            foreach (var item in response.Items)
            {
                dataGridPackingSlip.Rows.Add(
                    item.StockId,      // Id column (hidden)
                    item.BarCode,
                    item.StockGroup,
                    item.ProductName,
                    item.Qty,
                    item.SaleRate,
                    item.TaxableAmount,
                    item.GstValue,
                    item.Amount,
                    item.AvailableQty,
                    item.GstValue
                );
            }


            CalculatePackingSlip();

        }


        public void SetVisitorInfo(VisitorResponse? response)
        {
            if (response == null)
            {

                lblPhone.Text = "......";
                lblCompanyName.Text = "......";
                lblVisitorType.Text = "......";

            }
            else
            {

                lblPhone.Text = response.Mobile;
                lblCompanyName.Text = response.Name;
                lblVisitorType.Text = response.CustomerType == 1 ? "W" : "R";

            }
        }


        public void Clear()
        {
            if (dataGridPackingSlip.Rows.Count > 0)
            {
                dataGridPackingSlip.Rows.Clear();
            }

            lblCompanyName.Text = "-";
            lblPhone.Text = "-";
    
            lblTotalPcs.Text = "0";
            lblVisitorType.Text = "-";
            lblTotalAmount.Text = "0.00";
            lblTotalPcs.Text = "0.00";
            lblTaxableAmount.Text = "0.00";

        }

        private void CalculatePackingSlip()
        {
            int totalPcs = 0;
            decimal totalTaxable = 0;
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dataGridPackingSlip.Rows)
            {
                if (row.IsNewRow) continue;

                decimal taxable = Convert.ToDecimal(row.Cells["TaxableAmount"].Value);
                int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int qty);
                decimal gstPercent = Convert.ToDecimal(row.Cells["GstValue"].Value);
                decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);


                // 🔹 Totals
                totalTaxable += taxable;
                totalAmount += amount;
                totalPcs += qty;
            }

            lblTotalAmount.Text = totalAmount.ToString("0.00");
            lblTotalPcs.Text = totalPcs.ToString();
            lblTaxableAmount.Text = totalTaxable.ToString("0.00"); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
