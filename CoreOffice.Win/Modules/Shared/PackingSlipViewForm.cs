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
        private decimal? VisitorDiscount;
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
                   item.StockGroup + "\n" + item.ProductName,
                   item.Qty,
                   item.SaleRate,
                   item.TaxableAmount,
                   item.DiscountAmount,
                   item.NetAmount,
                   item.GstPercent,
                   item.TotalAmount,
                   item.AvailableQty
               );
            }

            VisitorDiscount = response.Items.Count == 0 ? null : response.Items.First().DiscountPercent;

            lblDiscount.Text = VisitorDiscount.HasValue ? $"{VisitorDiscount.Value}%" : "0%";
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

                decimal rate = Convert.ToDecimal(row.Cells["Rate"].Value);
                int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int qty);
                decimal gstPercent = Convert.ToDecimal(row.Cells["GstPer"].Value);





                decimal taxable = Math.Round(rate * qty, 2, MidpointRounding.AwayFromZero);


                var discountPercent = VisitorDiscount ?? 0;

                var discountAmount = Math.Round(
                    taxable * discountPercent / 100,
                    2,
                    MidpointRounding.AwayFromZero
                );

                // ✅ Net after discount
                decimal netAmount = Math.Round(taxable - discountAmount, 2, MidpointRounding.AwayFromZero);

                // ✅ GST on NET
                decimal gstAmount = Math.Round(netAmount * gstPercent / 100, 2, MidpointRounding.AwayFromZero);

                // ✅ Final
                decimal total = Math.Round(netAmount + gstAmount, 2, MidpointRounding.AwayFromZero);

                // 🔹 Update grid
                row.Cells["Taxable"].Value = taxable;
                row.Cells["NetTaxable"].Value = netAmount;
                row.Cells["Amount"].Value = total;
                row.Cells["Discount"].Value = discountAmount;

                // 🔹 Totals
                totalTaxable += netAmount;
                totalAmount += total;
                totalPcs += qty;
            }

            lblTotalAmount.Text = Math.Round(totalAmount, 0, MidpointRounding.AwayFromZero).ToString("0.00");
            lblTotalPcs.Text = totalPcs.ToString();
            lblTaxableAmount.Text = Math.Round(totalTaxable, 0, MidpointRounding.AwayFromZero).ToString("0.00");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
