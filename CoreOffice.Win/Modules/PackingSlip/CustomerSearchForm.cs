using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain.Responses.Customers;
using Microsoft.Extensions.DependencyInjection;

namespace CoreOffice.Win.Modules.PackingSlip
{
    public class CustomerSearchForm : Form
    {
        private readonly FrmPackingSlip _frmPackingSlip;
        private readonly IServiceProvider _serviceProvider;
        private readonly ICustomerService _customerService;
        private readonly ComboBox cmbCustomer = new();
        private readonly Button btnSelect = new();
        private readonly Button btnAdd = new();
        private readonly Button btnClose = new();
        private List<CustomerResponse> _customers = new();

        public CustomerSearchForm(
            FrmPackingSlip frmPackingSlip,
            IServiceProvider serviceProvider,
            ICustomerService customerService)
        {
            _frmPackingSlip = frmPackingSlip;
            _serviceProvider = serviceProvider;
            _customerService = customerService;

            InitializeForm();
        }

        private void InitializeForm()
        {
            Text = "Customer Search";
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(560, 135);
            MaximizeBox = false;

            var groupBox = new GroupBox
            {
                Text = "Search customer by name or phone number",
                Dock = DockStyle.Top,
                Height = 78
            };

            cmbCustomer.Font = new Font("Segoe UI", 12F);
            cmbCustomer.Location = new Point(16, 28);
            cmbCustomer.Size = new Size(525, 29);
            cmbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbCustomer.KeyDown += cmbCustomer_KeyDown;
            groupBox.Controls.Add(cmbCustomer);

            btnSelect.Text = "Select";
            btnSelect.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelect.Location = new Point(16, 88);
            btnSelect.Size = new Size(110, 34);
            btnSelect.Click += btnSelect_Click;

            btnAdd.Text = "Add Customer";
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.Location = new Point(132, 88);
            btnAdd.Size = new Size(135, 34);
            btnAdd.Click += btnAdd_Click;

            btnClose.Text = "Close";
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.Location = new Point(273, 88);
            btnClose.Size = new Size(110, 34);
            btnClose.Click += (_, _) => Close();

            Controls.Add(groupBox);
            Controls.Add(btnSelect);
            Controls.Add(btnAdd);
            Controls.Add(btnClose);

            Load += CustomerSearchForm_Load;
        }

        private async void CustomerSearchForm_Load(object? sender, EventArgs e)
        {
            if (AppCache.BillingCustomers == null || AppCache.BillingCustomers.Count == 0)
            {
                AppCache.BillingCustomers = await _customerService.GetBillingCustomersAsync();
            }

            BindCustomers();
            cmbCustomer.Focus();
        }

        private void BindCustomers()
        {
            _customers = AppCache.BillingCustomers ?? new List<CustomerResponse>();

            var source = new AutoCompleteStringCollection();
            source.AddRange(_customers.Select(GetDisplayText).ToArray());
            source.AddRange(_customers.Select(x => x.Name).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());
            source.AddRange(_customers.Select(x => x.Mobile).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());

            cmbCustomer.AutoCompleteCustomSource = source;
            cmbCustomer.Items.Clear();
            cmbCustomer.Items.AddRange(_customers.Select(GetDisplayText).ToArray());
        }

        private void SelectCustomer()
        {
            var text = cmbCustomer.Text.Trim();
            if (string.IsNullOrWhiteSpace(text))
                return;

            var customer = FindCustomer(text);
            if (customer == null)
            {
                var confirm = MessageBox.Show(
                    "Customer not found. Do you want to add new customer?",
                    "Customer",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    OpenAddCustomerForm(text);
                }

                return;
            }

            _frmPackingSlip.SetCustomerInfo(customer);
            Close();
        }

        private CustomerResponse? FindCustomer(string text)
        {
            return _customers.FirstOrDefault(x =>
                string.Equals(GetDisplayText(x), text, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x.Name, text, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(x.Mobile, text, StringComparison.OrdinalIgnoreCase));
        }

        private void OpenAddCustomerForm(string searchText = "")
        {
            var form = ActivatorUtilities.CreateInstance<CustomerAddForm>(_serviceProvider);
            form.SetInitialSearchText(searchText);
            form.OnCustomerCreated = customer =>
            {
                _frmPackingSlip.SetCustomerInfo(customer);
                Close();
            };
            form.ShowDialog(this);
            BindCustomers();
        }

        private static string GetDisplayText(CustomerResponse customer)
        {
            return $"{customer.Name} - {customer.Mobile}";
        }

        private void btnSelect_Click(object? sender, EventArgs e)
        {
            SelectCustomer();
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            OpenAddCustomerForm(cmbCustomer.Text.Trim());
        }

        private void cmbCustomer_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.Handled = true;
            e.SuppressKeyPress = true;
            SelectCustomer();
        }
    }
}
