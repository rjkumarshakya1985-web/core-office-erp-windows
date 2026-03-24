using CoreOfficeERP.Domain.Responses;

namespace CoreOffice.Win.Modules.PackingSlip
{
    public partial class FrmProductQty : Form
    {
        private readonly FrmPackingSlip _frmPackingSlip;
        private readonly CurrentStockResponse? _currentStockResponse;
        private readonly bool _isEditMode;
        public FrmProductQty(FrmPackingSlip? frmPackingSlip,CurrentStockResponse? currentStockResponse=null,bool isEdit=false)
        {
            InitializeComponent();
            _frmPackingSlip = frmPackingSlip;
            _currentStockResponse = currentStockResponse;
            _isEditMode = isEdit;
        }

        private void txtProductQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.Handled = true;
            e.SuppressKeyPress = true;

            if (!ValidateQuantity(out int qty))
                return;

            if (_isEditMode)
            {

                _frmPackingSlip.UpdateQty(qty);
            }
            else
            {
                _frmPackingSlip.SetProductQty(_currentStockResponse, qty);
            }
            this.Close();
        }

        private bool ValidateQuantity(out int qty)
        {
            qty = 0;

            //  Safe parsing
            if (!int.TryParse(txtProductQty.Text.Trim(), out qty))
            {
                MessageBox.Show("Please enter valid numeric quantity");
                return false;
            }

            int availableQty = _currentStockResponse.AvailableQty;

            if (qty <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0");
                return false;
            }

            if (qty > availableQty)
            {
                MessageBox.Show($"Only {availableQty} items available in stock");
                return false;
            }

            return true;
        }
    }
}
