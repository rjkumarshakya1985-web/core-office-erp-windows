using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Domain.Requests.PackingSlip;
using CoreOfficeERP.Domain.Responses;
using Microsoft.Extensions.DependencyInjection;


namespace CoreOffice.Win.Modules.PackingSlip
{
    public partial class FrmPackingSlip : Form
    {
        private readonly IPackingSlipService _packingSlipService;
        private readonly IServiceProvider _serviceProvider;
        private readonly IStockService _stockService;
        private int? VisitorId;
        private int? PackingSlipId;
        private CustomerTypeEnum? VisitorType;

        public FrmPackingSlip(IPackingSlipService packingSlipService,
            IServiceProvider serviceProvider,
            IStockService stockService)
        {
            InitializeComponent();
            _packingSlipService = packingSlipService;
            _serviceProvider = serviceProvider;
            _stockService = stockService;
            FormSetting();
        }

        private void StyleButton(Button btn, Color backColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.BackColor = backColor;
            btn.ForeColor = Color.White;

            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            btn.Height = 42;
            btn.Width = 130;

            btn.Cursor = Cursors.Hand;

            btn.TextAlign = ContentAlignment.MiddleCenter;

            btn.FlatAppearance.MouseOverBackColor = ControlPaint.Light(backColor);
            btn.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(backColor);
        }

        private void FormSetting()
        {
            dataGridPackingSlip.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPackingSlip.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridPackingSlip.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridPackingSlip.Columns["Quantity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPackingSlip.Columns["Amount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridPackingSlip.Columns["Total"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridPackingSlip.Columns["Amount"].DefaultCellStyle.Format = "N2";
            dataGridPackingSlip.Columns["Total"].DefaultCellStyle.Format = "N2";

            dataGridPackingSlip.Columns["Id"].Visible = false;

            dataGridPackingSlip.EnableHeadersVisualStyles = false;

            dataGridPackingSlip.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridPackingSlip.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridPackingSlip.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridPackingSlip.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            txtBarcodeScanner.Font = new Font("Segoe UI", 14, FontStyle.Bold);



            // Buttons styling
            StyleButton(btnVisitor, Color.SteelBlue);
            StyleButton(btnRemoved, Color.IndianRed);
            StyleButton(btnClear, Color.DarkOrange);
            StyleButton(btnClose, Color.DimGray);
            StyleButton(btnSave, Color.Green);


            btnClose.Text = "Close";
            btnRemoved.Text = "Remove Item";
        }
        private async void button1_Click(object sender, EventArgs e)
        {
        }

        private void FrmPackingSlip_Load(object sender, EventArgs e)
        {

        }

        private void btnVisitor_Click(object sender, EventArgs e)
        {
            var childForm = ActivatorUtilities.CreateInstance<FrmVisitorScanner>(_serviceProvider, this);
            childForm.Show();
        }

        public void SetVisitorInfo(int visitorId, string name, string mobile, int type)
        {
            VisitorId = visitorId;
            lblPhone.Text = mobile;
            lblCompanyName.Text = name;
            lblVisitorType.Text = type == 1 ? "R" : "W";
            VisitorType = (CustomerTypeEnum)type;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            dataGridPackingSlip.Rows.Clear();
            CalculatePackingSlip();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }


        private void Clear(object sender, EventArgs e)
        {
            if (dataGridPackingSlip.Rows.Count > 0)
            {
                dataGridPackingSlip.Rows.Clear();
            }
        }





        private void AddNewItemToGrid(CurrentStockResponse item)
        {
            var price = VisitorType == CustomerTypeEnum.Retail ? item.RetailRate : item.WholeSaleRate;

            foreach (DataGridViewRow row in dataGridPackingSlip.Rows)
            {
                if (row.Cells["Barcode"].Value?.ToString() == item.BarCode)
                {
                    int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                    row.Cells["Quantity"].Value = qty + 1;
                    CalculatePackingSlip();
                    return;
                }
            }

            dataGridPackingSlip.Rows.Add(
                item.Id,
                item.BarCode,
                item.StockGroup,
                item.ProductName,
                1,
                price,
                price,
                item.AvailableQty
            );

            CalculatePackingSlip();
        }

        private void CalculatePackingSlip()
        {
            int TotalPcs = 0;
            decimal TotalAmount = 0;

            dataGridPackingSlip.Rows.Cast<DataGridViewRow>().ToList().ForEach(row =>
            {
                decimal price = Convert.ToDecimal(row.Cells["Amount"].Value);
                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);

                decimal total = price * qty;

                row.Cells["Total"].Value = total;

                TotalAmount += total;
                TotalPcs += qty;
            });

            lblGrandTotal.Text = TotalAmount.ToString("0.00");
            lblTotalPcs.Text = TotalPcs.ToString();
        }

        private async void txtBarcodeScanner_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode != Keys.Enter)
                return;

            if (VisitorType == null)
            {
                MessageBox.Show("Please select visitor first");
                return;
            }
            e.Handled = true;

            var barcode = txtBarcodeScanner.Text.Trim();

            if (string.IsNullOrWhiteSpace(barcode))
                return;

            var stockItems = await _stockService.GetStockItemsByBarcode(barcode);

            if (stockItems == null || !stockItems.Any())
            {
                MessageBox.Show("Product not found");
                txtBarcodeScanner.Clear();
                return;
            }
            if (stockItems.Count() > 1)
            {
                var productNames = string.Join(", ", stockItems.Select(s => s.ProductName));
                MessageBox.Show($"Multiple products found for barcode {barcode}: {productNames}");
                txtBarcodeScanner.Clear();
                return;
            }

            var item = stockItems.First();

            if (item.AvailableQty < 1)
            {
                MessageBox.Show("Stock not available");
                txtBarcodeScanner.Clear();
                return;
            }

           
            txtBarcodeScanner.Clear();

            AddNewItemToGrid(item);
            e.SuppressKeyPress = true;
        }

        private void dataGridPackingSlip_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPackingSlip.Columns[e.ColumnIndex].Name == "Quantity")
            {
                var row = dataGridPackingSlip.Rows[e.RowIndex];

                int qty = Convert.ToInt32(row.Cells["Quantity"].Value);
                int availableQty = Convert.ToInt32(row.Cells["AvailableQty"].Value);

                //  Zero or negative quantity
                if (qty <= 0)
                {
                    MessageBox.Show("Quantity must be greater than 0");

                    row.Cells["Quantity"].Value = 1;
                    CalculatePackingSlip();
                    return;
                }

                //  Stock exceeded
                if (qty > availableQty)
                {
                    MessageBox.Show($"Only {availableQty} items available in stock");

                    row.Cells["Quantity"].Value = availableQty;
                    CalculatePackingSlip();
                    return;
                }

                CalculatePackingSlip();
            }
        }

        private void dataGridPackingSlip_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridPackingSlip.IsCurrentCellDirty)
            {
                dataGridPackingSlip.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnRemoved_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridPackingSlip.CurrentRow == null)
                    return;

                var result = MessageBox.Show(
                    "Remove selected item?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    dataGridPackingSlip.Rows.Remove(dataGridPackingSlip.CurrentRow);
                    CalculatePackingSlip();
                }
            }
            catch
            { }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridPackingSlip.Rows.Count == 0)
                {
                    MessageBox.Show("Add items first");
                    return;
                }

                var packingSlipItems = new List<PackingSlipItemRequest>();

                foreach (DataGridViewRow row in dataGridPackingSlip.Rows)
                {
                    if (row.IsNewRow) continue;

                    packingSlipItems.Add(new PackingSlipItemRequest
                    {
                        StockId = Guid.Parse(row.Cells["Id"].Value.ToString()),
                        Qty = Convert.ToInt32(row.Cells["Quantity"].Value),
                        SaleRate = Convert.ToDecimal(row.Cells["Amount"].Value)
                    });
                }

                var packingSlipRequest = new PackingSlipRequest()
                {
                    Id = PackingSlipId ?? 0,
                    VisitorId = VisitorId,
                    Items = packingSlipItems
                };

                if (PackingSlipId == null)
                {
                    var id = await _packingSlipService.CreateAsync(packingSlipRequest);
                    MessageBox.Show($"Packing Slip Created : {id}");
                }
                else
                {
                   
                    MessageBox.Show("Packing Slip Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
