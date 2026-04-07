using CoreOfficeERP.Domain.Responses;

namespace CoreOffice.Win.Modules.PackingSlip
{
    public partial class FrmMultipleStockProduct : Form
    {

        public List<CurrentStockResponse> StockResponseList;
        public FrmPackingSlip frm;
        public FrmMultipleStockProduct()
        {
            InitializeComponent();
        }

        private void FrmMultipleStockProduct_Load(object sender, EventArgs e)
        {

            foreach (var item in StockResponseList)
            {
                dataGrid.Rows.Add(
                    item.Id,      // Id column (hidden)
                    item.BarCode,
                    item.WholeSaleRate,
                    item.RetailRate,
                    item.MrpRate,
                    item.AvailableQty
                );
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow == null)
                return;

            Guid selectedId = (Guid)dataGrid.CurrentRow.Cells["Id"].Value;

            var item = StockResponseList.FirstOrDefault(x => x.Id == selectedId);

            if (item != null)
            {
                frm.AddSingleItemToGrid(item);
                this.Close();
            }
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid.Rows[e.RowIndex];

                Guid selectedId = (Guid)row.Cells["Id"].Value;

                var result = MessageBox.Show(
                    "Do you want to select this item?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var item = StockResponseList.FirstOrDefault(x => x.Id == selectedId);

                    if (item != null)
                    {
                        frm.AddSingleItemToGrid(item);
                        this.Close();
                    }
                }
            }
        }
    }
}
