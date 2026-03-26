using CoreOffice.Win.Session;
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain.Responses.DeliveryChallanToInvoice;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using System.Data;

namespace CoreOffice.Win.Modules.Cashier
{
    public partial class DeliveryChallanToInvoiceForm : Form
    {
        private Guid? CustomerId;
        private readonly IDeliveryChallanToInvoiceService _deliveryChallanToInvoiceService;
        public DeliveryChallanToInvoiceForm(IDeliveryChallanToInvoiceService deliveryChallanToInvoiceService)
        {
            InitializeComponent();
            _deliveryChallanToInvoiceService = deliveryChallanToInvoiceService;
        }

        private async void txtDeliveryChallanNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.Handled = true;

            var slipNo = txtDeliveryChallanNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(slipNo))
                return;

            try
            {

                bool alreadyExists = dataGridInvoice.Rows
                    .Cast<DataGridViewRow>()
                    .Any(r => string.Equals(
                        r.Cells["DeliveryChallanNo"].Value?.ToString(),
                        slipNo,
                        StringComparison.OrdinalIgnoreCase));

                if (alreadyExists)
                {
                    MessageBox.Show("This delivery challan no is already scanned",
                        "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDeliveryChallanNo.Clear();
                    txtDeliveryChallanNo.Focus();
                    return;
                }

                AppLoader.Show();

                var deliverChallan = await _deliveryChallanToInvoiceService
                    .GetDeliveryChallanForInvoiceByNumber(slipNo, UserSession.FinanceYearId);

                if (deliverChallan == null)
                {
                    MessageBox.Show("No packing slip found with the given number.",
                        "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtDeliveryChallanNo.Clear();
                    txtDeliveryChallanNo.Focus();
                    return;
                }

                if (deliverChallan.Customer == null)
                {
                    MessageBox.Show("Delivery challan without customer not allowed.",
                        "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDeliveryChallanNo.Clear();
                    txtDeliveryChallanNo.Focus();
                    return;
                }
                // ✅ Visitor validation (correct logic)
                if (CustomerId != null && deliverChallan.Customer.Id != CustomerId)
                {
                    MessageBox.Show("Different customer delivery challan not allowed.",
                        "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                setFormForDeilveryChallan(deliverChallan);
                txtDeliveryChallanNo.Clear();
                txtDeliveryChallanNo.Focus();
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

        private void setFormForDeilveryChallan(DeliverChallanToInvoiceResponse deliverChallan)
        {
            if (deliverChallan == null)
                return;

            if (deliverChallan.Customer != null)
            {
                lblCustomerMobile.Text = deliverChallan.Customer.Mobile;
                lblCustomerName.Text = deliverChallan.Customer.Name;
                CustomerId = deliverChallan.Customer.Id;
            }



            dataGridInvoice.Rows.Add(
                 deliverChallan.DeliveryChallanId,
                 deliverChallan.DeiliverChallanNo,
                 deliverChallan.Quantity,
                 deliverChallan.ReturnQty,
                 deliverChallan.AvailableInvoiceQty,
                 deliverChallan.TotalAmount
             );
            CalculatePackingSlip();
        }

        private void CalculatePackingSlip()
        {
            int TotalPcs = 0;
            decimal TotalAmount = 0;

            dataGridInvoice.Rows.Cast<DataGridViewRow>().ToList().ForEach(row =>
            {
                decimal amount = Convert.ToDecimal(row.Cells["Amount"].Value);
                int.TryParse(row.Cells["InvoiceQty"].Value?.ToString(), out int qty);


                TotalAmount += amount;
                TotalPcs += qty;
            });

            lblGrandTotal.Text = TotalAmount.ToString("0.00");
            lblTotalPcs.Text = TotalPcs.ToString();
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
    }
}
