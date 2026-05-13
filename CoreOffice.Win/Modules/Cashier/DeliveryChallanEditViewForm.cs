using CoreOffice.Win.Modules.PackingSlip;
using CoreOffice.Win.Modules.Shared;
using CoreOffice.Win.Session;
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Common.Extensions;
using CoreOfficeERP.Domain.Responses;
namespace CoreOffice.Win.Modules.Cashier
{
    public partial class DeliveryChallanEditViewForm : Form
    {
        private int? DeliveryChallanId;
        private decimal? DiscountPercent;
        private CustomerTypeEnum? CustomerType;
        private readonly IDeliveryChallanService _deliveryChallanService;
        private readonly IStockService _stockService;
        private string _selectedBarcode;
        private int _selectedQty;

        public DeliveryChallanEditViewForm(IDeliveryChallanService deliveryChallanService,
             IStockService stockService)
        {
            InitializeComponent();
            _deliveryChallanService = deliveryChallanService;
            _stockService = stockService;
        }

        private void DeliveryChallanEditViewForm_Load(object sender, EventArgs e)
        {
            txtBarcode.Enabled = false;
            btnUpdate.Visible = false;
            btnDeleteProduct.Visible = false;
        }

        public async void callForm(string deliverChallanNumber)
        {
            txtNumber.Text = deliverChallanNumber;
            await LoadDeliverChallanDetails(deliverChallanNumber);
            btnCancel.Visible = false;
        }

        private async void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.Handled = true;

            var number = txtNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(number))
                return;

            await LoadDeliverChallanDetails(number);

        }

        public async Task LoadDeliverChallanDetails(string number)
        {
            try
            {
                AppLoader.Show();

                var detail = await _deliveryChallanService
                    .GetDeliveryChallan(number, UserSession.FinanceYearId);

                dataGrid.Rows.Clear();
                lblDate.Text = "...........";
                lblCustomer.Text = ".........";
                lblGrandTotal.Text = "0.00";
                lblTotalPcs.Text = "0";
                DeliveryChallanId = null;

                if (detail == null)
                {
                    btnCancel.Visible = false;
                    MessageBox.Show("Delivery Challan not found",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (detail.Status == DeliveryChallanStatusEnum.PartiallyReturned
                    || detail.Status == DeliveryChallanStatusEnum.FullyReturned)
                {
                    dataGrid.Columns["ReturnQty"].Visible = true;
                    dataGrid.Columns["Balance"].Visible = true;
                }
                else
                {
                    dataGrid.Columns["ReturnQty"].Visible = false;
                    dataGrid.Columns["Balance"].Visible = false;
                }

                btnCancel.Visible = detail.Status <= DeliveryChallanStatusEnum.Dispatched;


                lblDate.Text = detail.DeliveryChallanDate.ToIstString();
                lblCustomer.Text = detail.CustomerName;
                DeliveryChallanId = detail.DeliveryChallanId;
                DiscountPercent = detail.DiscountPercent;
                lblTotalPcs.Text = detail.TotalQuantity.ToString();
                lblGrandTotal.Text = detail.TotalAmount.ToString("0.00");
                lblStatus.Text = detail.Status.ToString();
                lblDiscountPercent.Text = detail.DiscountPercent.HasValue
                    ? $"{detail.DiscountPercent:0.00} %"
                    : "0.00 %";
                lblCustomerType.Text = detail.CustomerType == 1 ? "W" : "R";
                CustomerType = (CustomerTypeEnum)detail.CustomerType;


                txtBarcode.Enabled = detail.Status <= DeliveryChallanStatusEnum.Dispatched;
                btnUpdate.Visible = detail.Status <= DeliveryChallanStatusEnum.Dispatched;
                btnDeleteProduct.Visible = detail.Status <= DeliveryChallanStatusEnum.Dispatched;

                foreach (var item in detail.Items)
                {
                    if (item.Balance <= 0)
                        continue;

                    dataGrid.Rows.Add(
                        item.DeliveryChallanItemId,
                        item.StockId,
                        item.BarCode,
                        item.ProductCategory,
                        item.ProductName,
                        item.SaleRate,
                        item.Qty,
                        item.Returned,
                        item.Balance,
                        item.TaxableAmount.ToString("0.00"),
                        item.DiscountAmount.ToString("0.00"),
                        item.NetAmount.ToString("0.00"),
                        item.GstPercent.ToString("0"),
                        item.Amount.ToString("0.00"),
                        item.StockQty
                    );
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

        private async void btnCancel_Click(object sender, EventArgs e)
        {
            if (DeliveryChallanId == null)
            {
                MessageBox.Show("No Delivery Challan selected.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔴 Confirmation Dialog
            var confirm = MessageBox.Show(
                "Are you sure you want to cancel this Delivery Challan?\n\nThis action cannot be undone.",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                AppLoader.Show();

                var result = await _deliveryChallanService.CancelDeliveryChallan(DeliveryChallanId.Value);

                if (result)
                {
                    MessageBox.Show("Delivery Challan cancelled successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    dataGrid.Rows.Clear();
                    lblDate.Text = "...........";
                    lblCustomer.Text = ".........";
                    lblGrandTotal.Text = "0.00";
                    lblTotalPcs.Text = "0";
                    DeliveryChallanId = null;
                    txtNumber.Clear();
                    btnCancel.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to cancel Delivery Challan.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // 🔍 Debug/log purpose (optional)
                // Logger.LogError(ex);
            }
            finally
            {
                AppLoader.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DeliveryChallanId == null)
            {
                MessageBox.Show("No Delivery Challan selected.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGrid.Rows.Count == 0)
            {
                MessageBox.Show("No items to update.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private async void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;
            e.Handled = true;
            e.SuppressKeyPress = true;
            await ScanBarcode();
        }

        public async Task ScanBarcode()
        {
            var barcode = txtBarcode.Text.Trim();

            if (string.IsNullOrWhiteSpace(barcode))
                return;

            // Duplicate check
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells["Barcode"].Value?.ToString() == barcode)
                {
                    MessageBox.Show(
                        "Product already added. You can change quantity from the grid.");

                    txtBarcode.Clear();
                    txtBarcode.Focus();
                    return;
                }
            }

            var stockItems = await _stockService
                .GetStockItemsByBarcode(barcode);

            if (stockItems == null || !stockItems.Any())
            {
                MessageBox.Show("Product not found");

                txtBarcode.Clear();
                txtBarcode.Focus();

                return;
            }

            // Multiple stock popup
            if (stockItems.Count() > 1)
            {
                var frm = new FrmMultipleStockProduct();
                frm.StockResponseList = stockItems.ToList();
                frm.deliveryChallanEditViewForm = this;
                frm.ShowDialog();

                return;
            }

            var stock = stockItems.First();

            if (stock.AvailableQty < 1)
            {
                MessageBox.Show("Stock not available");

                txtBarcode.Clear();
                txtBarcode.Focus();

                return;
            }

            OpenQtyForm(stock);
        }

        private void OpenQtyForm(CurrentStockResponse stock)
        {
            txtBarcode.Clear();

            var qtyForm = new AddUpdateProductQtyForm(stock);

            qtyForm.OnQtyCreate = (item, qty) =>
            {
                AddProductToGrid(item, qty);
            };

            qtyForm.ShowDialog();

            txtBarcode.Focus();
        }

        private void AddProductToGrid(CurrentStockResponse item, int qty)
        {


            var price = CustomerType == CustomerTypeEnum.Retail
                ? item.RetailRate
                : item.WholeSaleRate;

            var gstPercent = CustomerType == CustomerTypeEnum.Retail
                ? item.GstRPercent
                : item.GstWPercent;

            var amount = Math.Round(price * qty, 0, MidpointRounding.AwayFromZero);

            // ✅ FIXED Discount
            var discountPercent = DiscountPercent ?? 0;

            var discountAmount = Math.Round(
                amount * discountPercent / 100,
                2,
                MidpointRounding.AwayFromZero
            );

            var netAmount = Math.Round(amount - discountAmount, 0, MidpointRounding.AwayFromZero);

            // ✅ GST AFTER DISCOUNT
            var gstAmount = Math.Round(netAmount * gstPercent / 100, 0, MidpointRounding.AwayFromZero);

            var totalAmount = Math.Round(netAmount + gstAmount, 0, MidpointRounding.AwayFromZero);

            dataGrid.Rows.Add(
                null,
                item.Id,
                item.BarCode,
                item.StockGroup,
                item.ProductName,
                price,
                 qty,
                 null,
                 null,
                amount.ToString("0.00"),           // Taxable
                discountAmount.ToString("0.00"),   // Discount
                netAmount.ToString("0.00"),        // Net Taxable
                gstPercent.ToString("0"),       // GST %
                totalAmount.ToString("0.00"),      // ✅ Final Amount (Net + GST)
                item.AvailableQty
            );

            CalculatePackingSlip();
        }


        private void CalculatePackingSlip()
        {
            int totalPcs = 0;
            decimal totalTaxable = 0;
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.IsNewRow)
                    continue;

                decimal rate = Convert.ToDecimal(row.Cells["SalePrice"].Value);

                int.TryParse(
                    row.Cells["TotalQty"].Value?.ToString(),
                    out int qty);

                decimal gstPercent =
                    Convert.ToDecimal(row.Cells["GstPer"].Value);

                // Taxable
                decimal taxable = Math.Round(
                    rate * qty,
                    2,
                    MidpointRounding.AwayFromZero);

                // Discount
                decimal discountPercent = DiscountPercent ?? 0;

                decimal discountAmount = Math.Round(
                    taxable * discountPercent / 100,
                    2,
                    MidpointRounding.AwayFromZero);

                // Net
                decimal netAmount = Math.Round(
                    taxable - discountAmount,
                    2,
                    MidpointRounding.AwayFromZero);

                // GST
                decimal gstAmount = Math.Round(
                    netAmount * gstPercent / 100,
                    2,
                    MidpointRounding.AwayFromZero);

                // Final
                decimal total = Math.Round(
                    netAmount + gstAmount,
                    2,
                    MidpointRounding.AwayFromZero);

                // Update Grid
                row.Cells["TaxableAmount"].Value = taxable.ToString("0.00");
                row.Cells["NetTaxable"].Value = netAmount.ToString("0.00");
                row.Cells["TotalAmount"].Value = total.ToString("0.00");
                row.Cells["Discount"].Value = discountAmount.ToString("0.00");

                // Totals
                totalTaxable += netAmount;
                totalAmount += total;
                totalPcs += qty;
            }

            // Final Labels
            // lblGrandTotal.Text = totalAmount.ToString("0.00");
            lblTotalPcs.Text = totalPcs.ToString();
            lblGrandTotal.Text = Math.Round(totalAmount, 0, MidpointRounding.AwayFromZero).ToString("0.00");
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {


                var result = MessageBox.Show(
                    "Remove selected item?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dataGrid.Rows.Remove(dataGrid.CurrentRow);
                    CalculatePackingSlip();
                }
            }
            catch
            { }
        }

        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                OpenQtyPopup();
            }
        }

        private void OpenQtyPopup()
        {
            if (string.IsNullOrEmpty(_selectedBarcode))
                return;

            var row = dataGrid.CurrentRow;

            if (row == null)
                return;

            var availableQty = Convert.ToInt32(row.Cells["TotalQty"].Value);

            var item = new CurrentStockResponse
            {
                BarCode = _selectedBarcode,
                AvailableQty = DeliveryChallanId == null
                    ? availableQty
                    : availableQty + _selectedQty
            };
            new AddUpdateProductQtyForm(item, true).ShowDialog();
            txtBarcode.Focus();
        }

        private void dataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dataGrid.Rows[e.RowIndex];

            _selectedBarcode = row.Cells["Barcode"].Value?.ToString();
            _selectedQty = Convert.ToInt32(row.Cells["Balance"].Value ?? 0);
        }

        public void AddSingleItemToGrid(CurrentStockResponse item)
        {
            OpenQtyForm(item);
        }
    }
}
