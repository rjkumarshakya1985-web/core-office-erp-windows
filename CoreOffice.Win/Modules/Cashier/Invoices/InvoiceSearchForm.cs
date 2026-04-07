using CoreOffice.Win.Session;
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Common.Extensions;

namespace CoreOffice.Win.Modules.Cashier.Invoices
{
    public partial class InvoiceSearchForm : Form
    {
        private int? InvoiceId;

        private readonly IInvoiceService _invoiceService;

        public InvoiceSearchForm(IInvoiceService invoiceService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;

        }

        private async void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.Handled = true;

            var number = txtNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(number))
                return;


            try
            {
                AppLoader.Show();

                var detail = await _invoiceService
                    .GetInvoice(number, UserSession.FinanceYearId);

                dataGrid.Rows.Clear();
                lblDate.Text = "...........";
                lblCustomer.Text = ".........";
                lblGrandTotal.Text = "0.00";
                lblTotalPcs.Text = "0";
                InvoiceId = null;

                if (detail == null)
                {
                    btnCancel.Visible = false;
                    MessageBox.Show("Delivery Challan not found",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }



                btnCancel.Visible = detail.Status == InvoiceStatusEnum.Created;


                lblDate.Text = detail.Date.ToIstString();
                lblCustomer.Text = detail.CustomerName;
                InvoiceId = detail.Id;

                lblTotalPcs.Text = detail.TotalQuantity.ToString();
                lblGrandTotal.Text = detail.TotalAmount.ToString("0.00");
                lblStatus.Text = detail.Status.ToString();

                foreach (var item in detail.Items)
                {


                    dataGrid.Rows.Add(
                        item.Id,
                        item.StockId,
                        item.ProductCategory,
                        item.ProductName,
                         item.Qty,
                        item.SaleRate,
                        item.Amount
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
            if (InvoiceId == null)
            {
                MessageBox.Show("Please select an invoice first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            var confirm = MessageBox.Show(
                "Are you sure you want to cancel this invoice?\n\nThis action cannot be undone.",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                btnCancel.Enabled = false; // 🔥 prevent double click
                AppLoader.Show();

                var result = await _invoiceService.CancelInvoice(InvoiceId.Value);

                if (result)
                {
                    MessageBox.Show("Invoice cancelled successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGrid.Rows.Clear();
                    lblDate.Text = "...........";
                    lblCustomer.Text = ".........";
                    lblGrandTotal.Text = "0.00";
                    lblTotalPcs.Text = "0";
                    InvoiceId = null;
                }
                else
                {
                    MessageBox.Show("Unable to cancel invoice.",
                        "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong while cancelling the invoice.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCancel.Enabled = true;
                AppLoader.Hide();
            }
        }
    }
}
