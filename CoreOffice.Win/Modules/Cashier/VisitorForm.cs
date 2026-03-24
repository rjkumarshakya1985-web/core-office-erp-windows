namespace CoreOffice.Win.Modules.Cashier
{
    public partial class VisitorForm : Form
    {
        public Action<int>? OnVisitorSelected;

        public VisitorForm()
        {
            InitializeComponent();
            rdScanner.Checked = true;
        }

        private void txtScanner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (rdScanner.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtScanner.Text))
                    return;

                int.TryParse(txtScanner.Text.Trim(), out int visitorId);

                // ✅ Call whoever is listening
                OnVisitorSelected?.Invoke(visitorId);
            }

            Close();
        }
    }
}
