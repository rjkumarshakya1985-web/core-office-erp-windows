using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain.Responses;

namespace CoreOffice.Win.Modules.PackingSlip
{
    public partial class FrmVisitorScanner : Form
    {
        private readonly IVisitorService _visitorService;
        private readonly FrmPackingSlip _frmPackingSlip;
        public FrmVisitorScanner(IVisitorService visitorService, FrmPackingSlip frmPackingSlip)
        {
            InitializeComponent();
            _visitorService = visitorService;
            _frmPackingSlip = frmPackingSlip;
        }

        private void FrmVisitorScanner_Load(object sender, EventArgs e)
        {
            rdScanner.Checked = true;
            txtScanner.Focus();
        }



        private async void txtScanner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
                return;

            e.Handled = true; // prevent beep sound

            var text = txtScanner.Text.Trim();
            if (string.IsNullOrWhiteSpace(text))
                return;

            try
            {
                AppLoader.Show();

                VisitorResponse? response;

                if (rdMobile.Checked)
                {
                    response = await _visitorService.GetVisitorByMobile(text);
                }
                else
                {
                    if (!int.TryParse(text, out int visitorId))
                    {
                        MessageBox.Show("Invalid visitor code.");
                        txtScanner.Clear();
                        return;
                    }

                    response = await _visitorService.GetVisitor(visitorId);
                }

                if (response == null)
                {
                    MessageBox.Show("Visitor not found.");
                    txtScanner.Clear();
                    return;
                }

                _frmPackingSlip.SetVisitorInfo(
                    response.Id,
                    response.Name,
                    response.Mobile,
                    response.CustomerType ?? 0
                );

                txtScanner.Clear();
                Close();
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
    }
}
