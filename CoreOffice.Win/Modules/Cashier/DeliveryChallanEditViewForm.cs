using CoreOffice.Win.Session;
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Common.Extensions;
namespace CoreOffice.Win.Modules.Cashier
{
    public partial class DeliveryChallanEditViewForm : Form
    {
        private int? DeliveryChallanId;
        private Guid? CustomerId;
        private readonly IDeliveryChallanService _deliveryChallanService;
        public DeliveryChallanEditViewForm(IDeliveryChallanService deliveryChallanService)
        {
            InitializeComponent();
            _deliveryChallanService = deliveryChallanService;
        }

        private void DeliveryChallanEditViewForm_Load(object sender, EventArgs e)
        {

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
                CustomerId = detail.CustomerId;
                lblTotalPcs.Text = detail.TotalQuantity.ToString();
                lblGrandTotal.Text = detail.TotalAmount.ToString("0.00");

                foreach (var item in detail.Items)
                {
                    if (item.Balance <= 0)
                        continue;

                    dataGrid.Rows.Add(
                        item.DeliveryChallanItemId,
                        item.StockId,
                        item.ProductCategory,
                        item.ProductName,
                        item.SaleRate,
                        item.Qty,
                        item.Returned,
                        item.Balance,
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
    }
}
