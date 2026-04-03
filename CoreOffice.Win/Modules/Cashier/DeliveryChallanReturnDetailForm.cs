using CoreOffice.Win.Session;
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Extensions;
using CoreOfficeERP.Domain.Requests.DeliveryChallan;

namespace CoreOffice.Win.Modules.Cashier
{
    public partial class DeliveryChallanReturnDetailForm : Form
    {
        private int? DeliveryChallanId;
        private Guid? CustomerId;
        private readonly IDeliveryChallanService _deliveryChallanService;
        public DeliveryChallanReturnDetailForm(IDeliveryChallanService deliveryChallanService)
        {
            InitializeComponent();

            _deliveryChallanService = deliveryChallanService;

            FormSetting();

        }


        private void FormSetting()
        {
           
            dataGridReturn.Columns["SaleRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridReturn.Columns["SaleRate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridReturn.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridReturn.Columns["Qty"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridReturn.Columns["Returned"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridReturn.Columns["Returned"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridReturn.Columns["Balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridReturn.Columns["Balance"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var col = dataGridReturn.Columns["ReturnQty"];

            // Alignment
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Editable feel color
            col.DefaultCellStyle.BackColor = Color.LightYellow;
            col.DefaultCellStyle.SelectionBackColor = Color.Khaki;

            // Text color thoda strong
            col.DefaultCellStyle.ForeColor = Color.Black;

            // Optional: font thoda bold
            col.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridReturn.Columns["CurrentQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridReturn.Columns["CurrentQty"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        
            dataGridReturn.Columns["SaleRate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridReturn.Columns["SaleRate"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridReturn.Columns["TaxableAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridReturn.Columns["TaxableAmount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;


            dataGridReturn.Columns["GstPer"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridReturn.Columns["GstPer"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridReturn.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridReturn.Columns["Amount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;


            dataGridReturn.Columns["Product"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridReturn.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
                    .GetDeliveryChallanForReturn(number, UserSession.FinanceYearId);

                dataGridReturn.Rows.Clear();
                lblDate.Text = "...........";
                lblCustomer.Text = ".........";
                DeliveryChallanId = null;

                if (detail == null)
                {
                    MessageBox.Show("Delivery Challan not found",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                lblDate.Text = detail.DeliveryChallanDate.ToIstString();
                lblCustomer.Text = detail.CustomerName;
                DeliveryChallanId = detail.DeliveryChallanId;
                CustomerId = detail.CustomerId;

                foreach (var item in detail.Items)
                {
                    if (item.Balance <= 0)
                        continue;

                    dataGridReturn.Rows.Add(
                        item.DeliveryChallanItemId,
                        item.StockId,
                        item.BarCode + "\n"+item.ProductCategory + "\n" + item.ProductName,
                        item.SaleRate,
                        item.Qty,
                        item.Returned,
                        item.Balance,
                        item.ReturnQty,
                        item.Balance,
                        item.TaxableAmount,
                        item.GstValue.ToString("0"),
                        item.Amount
                    );
                }

                lblTaxableAmount.Text = detail.TotalTaxableAmount.ToString("0.00");
                lblTotalAmount.Text = detail.TotalAmount.ToString("0.00");
                lblTotalPcs.Text = detail.TotalQuantity.ToString();
                dataGridReturn.Focus();
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
        private async void btnGenerateDeliveryChallan_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeliveryChallanId == null)
                {
                    MessageBox.Show("Please load Delivery Challan first",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var request = new DeliveryChalanReturnRequest
                {
                    DeliveryChallanId = DeliveryChallanId.Value,
                    FinanceYearId = UserSession.FinanceYearId,
                    CustomerId = CustomerId.Value,
                    DeliveryChallanReturnItems = new List<DeliveryChallanReturnItem>()
                };

                foreach (DataGridViewRow row in dataGridReturn.Rows)
                {
                    if (row.IsNewRow) continue;

                    int returnQty = Convert.ToInt32(row.Cells["ReturnQty"].Value);

                    //  Skip zero qty
                    if (returnQty <= 0)
                        continue;

                    int balance = Convert.ToInt32(row.Cells["Balance"].Value);

                    //  Safety validation
                    if (returnQty > balance)
                    {
                        MessageBox.Show("Return Qty cannot be greater than Balance",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    decimal saleRate = Convert.ToDecimal(row.Cells["SaleRate"].Value);

                    var item = new DeliveryChallanReturnItem
                    {
                        DeliveryChallanItemId = Convert.ToInt32(row.Cells["Id"].Value),
                        StockId = (Guid)row.Cells["StockId"].Value,
                        ReturnQty = returnQty,
                        SaleRate = saleRate,
                        Amount = returnQty * saleRate,

                    };

                    request.DeliveryChallanReturnItems.Add(item);
                }

                //  No items selected
                if (!request.DeliveryChallanReturnItems.Any())
                {
                    MessageBox.Show("Please enter at least one return quantity",
                        "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AppLoader.Show();



                //  API Call
                var result = await _deliveryChallanService.SaveDeliveryChallanReturn(request);



                MessageBox.Show("Delivery Challan Return saved successfully",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear();

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

        private void dataGridReturn_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridReturn.Columns[e.ColumnIndex].Name != "ReturnQty")
                return;

            var row = dataGridReturn.Rows[e.RowIndex];

            if (!int.TryParse(Convert.ToString(e.FormattedValue), out int returnQty))
            {
                MessageBox.Show("Please enter valid number",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
                return;
            }

            int balance = Convert.ToInt32(row.Cells["Balance"].Value);

            if (returnQty > balance)
            {
                MessageBox.Show("Return Qty cannot be greater than Balance",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Cancel = true; // ❌ edit cancel
            }
        }

        private void dataGridReturn_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridReturn.Columns[e.ColumnIndex].Name != "ReturnQty")
                return;

            var row = dataGridReturn.Rows[e.RowIndex];

            int returnQty = Convert.ToInt32(row.Cells["ReturnQty"].Value);
            int balance = Convert.ToInt32(row.Cells["Balance"].Value);

            if (returnQty > balance)
            {
                row.Cells["ReturnQty"].Value = balance;

                MessageBox.Show("Return Qty adjusted to Balance",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal saleRate = Convert.ToDecimal(row.Cells["SaleRate"].Value);
                decimal gstPer = Convert.ToDecimal(row.Cells["GstPer"].Value);

                var currentQty = balance - returnQty;
                row.Cells["CurrentQty"].Value = currentQty;

                // Taxable
                decimal taxable = currentQty * saleRate;
                taxable = Math.Round(taxable, 2); // ✅ 2 decimal round
                row.Cells["TaxableAmount"].Value = taxable;

                // GST Amount
                decimal gstAmt = taxable * gstPer / 100;
                gstAmt = Math.Round(gstAmt, 2);

                // Final Amount
                decimal total = taxable + gstAmt;
                total = Math.Round(total, 2);

                row.Cells["Amount"].Value = total;
                CalculateTotalAmount();
            }
        }

        private void CalculateTotalAmount()
        {
            decimal total = 0;
            decimal taxable = 0;
            int totalPcs = 0;   
            foreach (DataGridViewRow row in dataGridReturn.Rows)
            {
                if (row.IsNewRow) continue;
                decimal amount = 0;
                decimal.TryParse(Convert.ToString(row.Cells["Amount"].Value), out amount);
                total += amount;
                decimal taxAmount = 0;
                decimal.TryParse(Convert.ToString(row.Cells["TaxableAmount"].Value), out taxAmount);
                taxable+= taxAmount;
                int qty = 0;
                int.TryParse(Convert.ToString(row.Cells["CurrentQty"].Value), out qty);
                totalPcs += qty;

            }
            lblTotalAmount.Text = total.ToString("0.00");
            lblTaxableAmount.Text = taxable.ToString("0.00");
            lblTotalPcs.Text = totalPcs.ToString();
        }

        private void dataGridReturn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                int colIndex = dataGridReturn.Columns["ReturnQty"].Index;
                int rowIndex = dataGridReturn.CurrentCell.RowIndex;

                // Next row pe move karo
                if (rowIndex < dataGridReturn.Rows.Count - 1)
                {
                    dataGridReturn.CurrentCell = dataGridReturn.Rows[rowIndex + 1].Cells[colIndex];
                }
                else
                {
                    // Last row → same row me reh sakte ho ya loop karwa sakte ho
                    dataGridReturn.CurrentCell = dataGridReturn.Rows[rowIndex].Cells[colIndex];
                }

                // Edit mode ON
                dataGridReturn.BeginEdit(true);
            }
        }


        private void CalculateTotalReturnQty()
        {
            int total = 0;

            foreach (DataGridViewRow row in dataGridReturn.Rows)
            {
                if (row.IsNewRow) continue;

                int qty = 0;
                int.TryParse(Convert.ToString(row.Cells["ReturnQty"].Value), out qty);

                total += qty;
            }

            lblTotalReturnQty.Text = total.ToString();
        }

        private void dataGridReturn_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridReturn.Columns[e.ColumnIndex].Name == "ReturnQty")
            {
                CalculateTotalReturnQty();
            }
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            dataGridReturn.Rows.Clear();
            lblTotalReturnQty.Text = "0";
            txtNumber.Clear();
            lblCustomer.Text = ".........";
            lblDate.Text = "..........";
            DeliveryChallanId = null;
            CustomerId = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeliveryChallanReturnDetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
