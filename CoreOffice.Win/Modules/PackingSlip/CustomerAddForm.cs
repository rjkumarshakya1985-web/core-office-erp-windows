using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Common.Hepler;
using CoreOfficeERP.Domain.Requests.Customers;
using CoreOfficeERP.Domain.Responses.Customers;

namespace CoreOffice.Win.Modules.PackingSlip
{
    public class CustomerAddForm : Form
    {
        private readonly ICustomerService _customerService;
        private readonly IMasterService _masterService;
        private readonly ComboBox cmbCustomerType = new();
        private readonly ComboBox cmbRegistrationType = new();
        private readonly ComboBox cmbState = new();
        private readonly ComboBox cmbCity = new();
        private readonly TextBox txtName = new();
        private readonly TextBox txtMobile = new();
        private readonly TextBox txtPhone = new();
        private readonly TextBox txtPinCode = new();
        private readonly TextBox txtDiscount = new();
        private readonly TextBox txtCreditDays = new();
        private readonly TextBox txtCreditLimit = new();
        private readonly TextBox txtBillingAddress = new();
        private readonly TextBox txtShippingAddress = new();
        private readonly Button btnSave = new();
        private readonly Button btnClose = new();
        private bool _loading;

        public Action<CustomerResponse>? OnCustomerCreated;

        public CustomerAddForm(ICustomerService customerService, IMasterService masterService)
        {
            _customerService = customerService;
            _masterService = masterService;

            InitializeForm();
        }

        public void SetInitialSearchText(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return;

            if (searchText.All(char.IsDigit))
            {
                txtMobile.Text = searchText;
                txtPhone.Text = searchText;
            }
            else
            {
                txtName.Text = searchText;
            }
        }

        private void InitializeForm()
        {
            Text = "Add Customer";
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(760, 420);
            MaximizeBox = false;

            AddLabel("Customer Type", 16, 24);
            AddLabel("Name", 16, 64);
            AddLabel("Mobile", 390, 64);
            AddLabel("Phone", 16, 104);
            AddLabel("Registration", 390, 104);
            AddLabel("State", 16, 144);
            AddLabel("City", 390, 144);
            AddLabel("Pin Code", 16, 184);
            AddLabel("Discount %", 390, 184);
            AddLabel("Credit Days", 16, 224);
            AddLabel("Credit Limit", 390, 224);
            AddLabel("Billing Address", 16, 264);
            AddLabel("Shipping Address", 390, 264);

            AddControl(cmbCustomerType, 125, 20, 220);
            AddControl(txtName, 125, 60, 220);
            AddControl(txtMobile, 500, 60, 220);
            AddControl(txtPhone, 125, 100, 220);
            AddControl(cmbRegistrationType, 500, 100, 220);
            AddControl(cmbState, 125, 140, 220);
            AddControl(cmbCity, 500, 140, 220);
            AddControl(txtPinCode, 125, 180, 220);
            AddControl(txtDiscount, 500, 180, 220);
            AddControl(txtCreditDays, 125, 220, 220);
            AddControl(txtCreditLimit, 500, 220, 220);

            txtBillingAddress.Multiline = true;
            txtShippingAddress.Multiline = true;
            AddControl(txtBillingAddress, 125, 260, 220, 70);
            AddControl(txtShippingAddress, 500, 260, 220, 70);

            btnSave.Text = "Save";
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Location = new Point(125, 350);
            btnSave.Size = new Size(110, 38);
            btnSave.Click += btnSave_Click;

            btnClose.Text = "Close";
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.Location = new Point(241, 350);
            btnClose.Size = new Size(110, 38);
            btnClose.Click += (_, _) => Close();

            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Load += CustomerAddForm_Load;
            cmbState.SelectedValueChanged += cmbState_SelectedValueChanged;
        }

        private async void CustomerAddForm_Load(object? sender, EventArgs e)
        {
            _loading = true;
            BindCustomerType();
            BindRegistrationType();
            await LoadStates();
            txtCreditDays.Text = "0";
            txtCreditLimit.Text = "0";
            txtDiscount.Text = "0";
            _loading = false;

            if (cmbState.SelectedValue is int stateId)
                await LoadCities(stateId);
        }

        private void BindCustomerType()
        {
            cmbCustomerType.DataSource = Enum.GetValues(typeof(CustomerTypeEnum))
                .Cast<CustomerTypeEnum>()
                .Select(e => new
                {
                    Value = (int)e,
                    Text = Helper.GetEnumDescription(e)
                }).ToList();

            cmbCustomerType.DisplayMember = "Text";
            cmbCustomerType.ValueMember = "Value";
        }

        private void BindRegistrationType()
        {
            cmbRegistrationType.DataSource = Enum.GetValues(typeof(RegistrationTypeEnum))
                .Cast<RegistrationTypeEnum>()
                .Select(e => new
                {
                    Value = (int)e,
                    Text = Helper.GetEnumDescription(e)
                }).ToList();

            cmbRegistrationType.DisplayMember = "Text";
            cmbRegistrationType.ValueMember = "Value";
        }

        private async Task LoadStates()
        {
            var states = await _masterService.GetStates();
            cmbState.DataSource = states.ToList();
            cmbState.DisplayMember = "Name";
            cmbState.ValueMember = "Id";
        }

        private async Task LoadCities(int stateId)
        {
            var cities = await _masterService.GetCityByState(stateId);
            cmbCity.DataSource = cities.ToList();
            cmbCity.DisplayMember = "Name";
            cmbCity.ValueMember = "Id";
        }

        private async void cmbState_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (_loading)
                return;

            if (cmbState.SelectedValue is int stateId)
                await LoadCities(stateId);
        }

        private async void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                AppLoader.Show();

                var request = BindRequest();
                var customer = await _customerService.CreateCustomerAsync(request);

                if (customer == null)
                {
                    MessageBox.Show("Customer not created.");
                    return;
                }

                AppCache.BillingCustomers.RemoveAll(x => x.Id == customer.Id);
                AppCache.BillingCustomers.Add(customer);
                OnCustomerCreated?.Invoke(customer);
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

        private CustomerRequest BindRequest()
        {
            var name = txtName.Text.Trim();
            var mobile = txtMobile.Text.Trim();

            return new CustomerRequest
            {
                Name = name,
                PrintName = name,
                LedgerName = name,
                Alias = name,
                GroupName = name,
                RegType = Convert.ToInt32(cmbRegistrationType.SelectedValue),
                CityId = Convert.ToInt32(cmbCity.SelectedValue),
                PinCode = txtPinCode.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Mobile = mobile,
                BillingAddress = txtBillingAddress.Text.Trim(),
                ShippingAddress = txtShippingAddress.Text.Trim(),
                CreditDays = int.TryParse(txtCreditDays.Text, out var days) ? days : 0,
                CreditLimit = decimal.TryParse(txtCreditLimit.Text, out var limit) ? limit : 0,
                CustomerType = Convert.ToInt32(cmbCustomerType.SelectedValue),
                Discount = decimal.TryParse(txtDiscount.Text, out var discount) ? discount : 0
            };
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
                return ShowValidation("Name is required", txtName);

            if (string.IsNullOrWhiteSpace(txtMobile.Text))
                return ShowValidation("Mobile is required", txtMobile);

            if (cmbState.SelectedIndex < 0)
                return ShowValidation("State is required", cmbState);

            if (cmbCity.SelectedIndex < 0)
                return ShowValidation("City is required", cmbCity);

            if (string.IsNullOrWhiteSpace(txtPinCode.Text))
                return ShowValidation("Pin code is required", txtPinCode);

            return true;
        }

        private bool ShowValidation(string message, Control control)
        {
            MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            return false;
        }

        private void AddLabel(string text, int x, int y)
        {
            Controls.Add(new Label
            {
                Text = text,
                Location = new Point(x, y + 4),
                Size = new Size(105, 22)
            });
        }

        private void AddControl(Control control, int x, int y, int width, int height = 28)
        {
            control.Location = new Point(x, y);
            control.Size = new Size(width, height);
            control.Font = new Font("Segoe UI", 10F);
            Controls.Add(control);
        }
    }
}
