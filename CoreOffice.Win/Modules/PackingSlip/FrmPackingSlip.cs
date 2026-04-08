using CoreOffice.Win.Modules.Shared;
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Domain.Requests.PackingSlip;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using CoreOfficeERP.Domain.Responses.SalesPersons;
using Microsoft.Extensions.DependencyInjection;


namespace CoreOffice.Win.Modules.PackingSlip
{
    public partial class FrmPackingSlip : Form
    {
        private readonly IPackingSlipService _packingSlipService;
        private readonly IServiceProvider _serviceProvider;
        private readonly IStockService _stockService;
        private readonly ISalesPersonService _salesPersonService;
        private int? VisitorId;
        private int? PackingSlipId;
        private CustomerTypeEnum? VisitorType;
        private string _selectedBarcode;
        private int _selectedQty;

        public FrmPackingSlip(IPackingSlipService packingSlipService,
            IServiceProvider serviceProvider,
            IStockService stockService, ISalesPersonService salesPersonService)
        {
            InitializeComponent();

            cmbSalesPerson.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSalesPerson.AutoCompleteSource = AutoCompleteSource.ListItems;

            _packingSlipService = packingSlipService;
            _serviceProvider = serviceProvider;
            _stockService = stockService;
            _salesPersonService = salesPersonService;
            FormSetting();
            dataGridPackingSlip.AllowUserToAddRows = false;
            btnDelete.Enabled = false;
            txtBarcodeScanner.Focus();
        }


        private async Task LoadSalesPersons()
        {
            var salesPersons = await _salesPersonService.GetActiveSalesPerson();

            if (salesPersons != null && salesPersons.Any())
            {
                // ✅ Insert blank option on top
                salesPersons.Insert(0, new SalePersonResponse
                {
                    Id = null,
                    Name = "",
                    PhoneNumber = "",
                    StateId = 0,
                    StateName = "",
                    CityId = 0,
                    CityName = "",
                    Address = "",
                    IsActive = false,
                    IsDeleted = false
                });

                cmbSalesPerson.DataSource = salesPersons;
                cmbSalesPerson.DisplayMember = "Name";
                cmbSalesPerson.ValueMember = "Id";
            }
        }



        private void FormSetting()
        {
            dataGridPackingSlip.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPackingSlip.Columns["Quantity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridPackingSlip.Columns["Amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridPackingSlip.Columns["Amount"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridPackingSlip.Columns["Taxable"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridPackingSlip.Columns["Taxable"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridPackingSlip.Columns["AvailableQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPackingSlip.Columns["AvailableQty"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridPackingSlip.Columns["GstValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridPackingSlip.Columns["GstValue"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridPackingSlip.Columns["Amount"].DefaultCellStyle.Format = "N2";
            dataGridPackingSlip.Columns["Taxable"].DefaultCellStyle.Format = "N2";

            dataGridPackingSlip.Columns["Id"].Visible = false;

            dataGridPackingSlip.EnableHeadersVisualStyles = false;

            dataGridPackingSlip.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridPackingSlip.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dataGridPackingSlip.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridPackingSlip.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            txtBarcodeScanner.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            btnRemoved.Text = "Remove Item";
        }

        private async void FrmPackingSlip_Load(object sender, EventArgs e)
        {
            await LoadSalesPersons();
        }


        private void btnVisitor_Click(object sender, EventArgs e)
        {
            var childForm = ActivatorUtilities.CreateInstance<FrmVisitorScanner>(_serviceProvider, this);
            childForm.Show();
        }

        public void SetVisitorInfo(VisitorResponse? response)
        {
            if (response == null)
            {
                VisitorId = null;
                lblPhone.Text = "......";
                lblCompanyName.Text = "......";
                lblVisitorType.Text = "......";
                VisitorType = null;
            }
            else
            {
                VisitorId = response.Id;
                lblPhone.Text = response.Mobile;
                lblCompanyName.Text = response.Name;
                lblVisitorType.Text = response.CustomerType == 1 ? "W" : "R";
                VisitorType = (CustomerTypeEnum)response.CustomerType;
            }
        }






        public void Clear()
        {
            if (dataGridPackingSlip.Rows.Count > 0)
            {
                dataGridPackingSlip.Rows.Clear();
            }
            VisitorId = null;
            PackingSlipId = null;
            VisitorType = null;
            lblCompanyName.Text = "-";
            lblPhone.Text = "-";
            lblTotalAmount.Text = "0.00";
            lblTaxableAmount.Text = "0";
            lblVisitorType.Text = "-";
            btnDelete.Enabled = false;
            txtBarcodeScanner.Clear();
            cmbSalesPerson.SelectedIndex = 0;
        }





        private void AddNewItemToGrid(CurrentStockResponse item, int Qty)
        {
            var price = VisitorType == CustomerTypeEnum.Retail ? item.RetailRate : item.WholeSaleRate;

            var gstPercent = VisitorType == CustomerTypeEnum.Retail ? item.GstRPercent : item.GstWPercent;

            var amount = Math.Round(price * Qty, 2, MidpointRounding.AwayFromZero);

            var gstAmount = Math.Round(amount * gstPercent / 100, 2, MidpointRounding.AwayFromZero);

            var totalAmount = Math.Round(amount + gstAmount, 2, MidpointRounding.AwayFromZero);
            dataGridPackingSlip.Rows.Add(
                item.Id,
                item.BarCode,
                item.StockGroup ,
                item.ProductName,
                Qty,
                price,
                amount,
                gstPercent,
                totalAmount,
                item.AvailableQty
            );

            CalculatePackingSlip();
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
                decimal gstPercent = Convert.ToDecimal(row.Cells["GstValue"].Value);

               
                decimal taxable = Math.Round(rate * qty, 2, MidpointRounding.AwayFromZero);

                // 🔹 GST amount
                decimal gstAmount = Math.Round(taxable * gstPercent / 100, 2, MidpointRounding.AwayFromZero);

                // 🔹 Final total
                decimal total = Math.Round(taxable + gstAmount, 2, MidpointRounding.AwayFromZero);

                // 🔹 Set values in grid
                row.Cells["Taxable"].Value = taxable;
                row.Cells["Amount"].Value = total;

                // 🔹 Totals
                totalTaxable += taxable;
                totalAmount += total;
                totalPcs += qty;
            }

            lblTotalAmount.Text = totalAmount.ToString("0.00");
            lblTotalPcs.Text = totalPcs.ToString();
            lblTaxableAmount.Text = totalTaxable.ToString("0.00"); // 🔥 fix (pehle galat tha)
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

            foreach (DataGridViewRow row in dataGridPackingSlip.Rows)
            {
                if (row.Cells["Barcode"].Value?.ToString() == barcode)
                {
                    MessageBox.Show("Product already added. You can change quantity from the grid.");
                    txtBarcodeScanner.Clear();
                    return;
                }
            }
            var stockItems = await _stockService.GetStockItemsByBarcode(barcode);

            if (stockItems == null || !stockItems.Any())
            {
                MessageBox.Show("Product not found");
                txtBarcodeScanner.Clear();
                return;
            }


            if (stockItems.Count() > 1)
            {
                var frm = new FrmMultipleStockProduct();
                frm.frm = this;
                frm.StockResponseList = stockItems.ToList();
                frm.ShowDialog();
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

            e.SuppressKeyPress = true;

            new FrmProductQty(this, item).ShowDialog();
        }

        public void AddSingleItemToGrid(CurrentStockResponse item)
        {
            new FrmProductQty(this, item).ShowDialog();
        }

        public void SetProductQty(CurrentStockResponse item, int Qty)
        {

            AddNewItemToGrid(item, Qty);
        }

        private void dataGridPackingSlip_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridPackingSlip.Columns[e.ColumnIndex].Name == "Quantity")
            {
                var row = dataGridPackingSlip.Rows[e.RowIndex];

                int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int qty);
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
                AppLoader.Show();



                if (dataGridPackingSlip.Rows.Count == 0)
                {
                    MessageBox.Show("Add items first");

                    return;
                }

                if (string.IsNullOrEmpty(cmbSalesPerson.Text))
                {
                    MessageBox.Show("Select Sales Person Firstly");
                    cmbSalesPerson.Focus();
                    return;
                }

                var packingSlipItems = new List<PackingSlipItemRequest>();

                foreach (DataGridViewRow row in dataGridPackingSlip.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["Id"].Value == null ||
                        row.Cells["Quantity"].Value == null ||
                        row.Cells["Amount"].Value == null)
                        continue;

                    packingSlipItems.Add(new PackingSlipItemRequest
                    {
                        StockId = Guid.Parse(row.Cells["Id"].Value.ToString()),
                        Qty = Convert.ToInt32(row.Cells["Quantity"].Value),
                        SaleRate = Convert.ToDecimal(row.Cells["Rate"].Value),
                        GstValue = Convert.ToDecimal(row.Cells["GstValue"].Value)
                    });
                }

                if (!packingSlipItems.Any())
                {
                    MessageBox.Show("No valid items found");
                    return;
                }

                var request = new PackingSlipRequest
                {
                    Id = PackingSlipId ?? 0,
                    VisitorId = VisitorId,
                    SalesPersonId = (Guid?)cmbSalesPerson.SelectedValue,
                    Items = packingSlipItems
                };

                if (PackingSlipId == null)
                {
                    var id = await _packingSlipService.CreateAsync(request);
                    MessageBox.Show($"Packing Slip Created : {id}");
                }
                else
                {
                    await _packingSlipService.UpdateAsync(PackingSlipId, request);
                    MessageBox.Show("Packing Slip Updated");
                }

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                AppLoader.Hide();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var childForm = ActivatorUtilities.CreateInstance<FrmPackingSlipNumber>(_serviceProvider, this);
            childForm.Show();
        }

        public void LoadPackingSlip(PackingSlipResponse response)
        {
            if (response == null)
                return;

            // Reset form first
            Clear();

            // Set PackingSlipId (Edit mode)
            PackingSlipId = response.Id;

            // Visitor Info
            SetVisitorInfo(
               response.Visitor);

            if (response.SalesPersonId != null)
                cmbSalesPerson.SelectedValue = response.SalesPersonId.Value;

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
                       item.AvailableQty
                   
                );
            }


            CalculatePackingSlip();
            btnDelete.Enabled = true; // Show delete button in edit mode
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!PackingSlipId.HasValue)
            {
                MessageBox.Show("Packing slip not selected");
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this packing slip?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                AppLoader.Show();

                var status = await _packingSlipService.DeleteAsync(PackingSlipId.Value);

                if (status)
                {
                    MessageBox.Show("Packing slip deleted successfully");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Failed to delete packing slip");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                AppLoader.Hide();
                Clear();
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridPackingSlip.Rows.Clear();
            CalculatePackingSlip();
            Clear();
        }


        private void dataGridPackingSlip_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dataGridPackingSlip.Rows[e.RowIndex];

            _selectedBarcode = row.Cells["Barcode"].Value?.ToString();
            _selectedQty = Convert.ToInt32(row.Cells["Quantity"].Value ?? 0);


        }

        public void UpdateQty(int qty)
        {
            foreach (DataGridViewRow row in dataGridPackingSlip.Rows)
            {
                if (row.IsNewRow) continue;

                var rowBarcode = row.Cells["Barcode"].Value?.ToString();

                if (rowBarcode == _selectedBarcode)
                {
                    row.Cells["Quantity"].Value = qty;
                    CalculatePackingSlip(); // update totals
                    return; // exit loop early 🚀
                }
            }
        }

        private void dataGridPackingSlip_KeyDown(object sender, KeyEventArgs e)
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

            var row = dataGridPackingSlip.CurrentRow;

            if (row == null)
                return;

            var availableQty = Convert.ToInt32(row.Cells["AvailableQty"].Value);

            var item = new CurrentStockResponse
            {
                BarCode = _selectedBarcode,
                AvailableQty = PackingSlipId == null
                    ? availableQty
                    : availableQty + _selectedQty
            };
            new FrmProductQty(this, item, true).ShowDialog();
            txtBarcodeScanner.Focus();
        }

        private void dataGridPackingSlip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            OpenQtyPopup();
        }

        private void btnPendingPackingSlips_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<PendingPackingSlipForm>();
            childForm._frmPackingSlip = this;
            childForm.ShowDialog();
        }
    }

}
