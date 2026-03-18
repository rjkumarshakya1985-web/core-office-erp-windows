using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;

namespace CoreOffice.Win.Modules.PackingSlip
{
    public partial class FrmPackingSlipNumber : Form
    {

        private readonly IPackingSlipService _packingSlipService;
        private readonly FrmPackingSlip _frmPackingSlip;
        public FrmPackingSlipNumber(IPackingSlipService packingSlipService, FrmPackingSlip frmPackingSlip)
        {
            InitializeComponent();
            _packingSlipService = packingSlipService;
            _frmPackingSlip = frmPackingSlip;
            txtScanner.Focus();
        }

        private void FrmPackingSlipNumber_Load(object sender, EventArgs e)
        {

        }

        private async void txtScanner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.Handled = true; 

            var text = txtScanner.Text.Trim();
            if (string.IsNullOrWhiteSpace(text))
                return;

            try
            {
                AppLoader.Show();

                var packingSlip = await _packingSlipService
                    .GetByPackingSlipNumberAsync(text);

                if (packingSlip != null)
                {
                    _frmPackingSlip.LoadPackingSlip(packingSlip);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Packing slip not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    _frmPackingSlip.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                _frmPackingSlip.Clear();
            }
            finally
            {
                AppLoader.Hide();
            }
        }
    }
}
