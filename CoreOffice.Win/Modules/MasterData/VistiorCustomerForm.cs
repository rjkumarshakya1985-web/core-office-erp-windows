using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Common.Hepler;
using CoreOfficeERP.Domain.Requests.Customers;
using CoreOfficeERP.Domain.Responses.Customers;
using System.Threading.Tasks;

namespace CoreOffice.Win.Modules.MasterData
{
    public partial class VistiorCustomerForm : Form
    {
        public int? VisitorId;
        private readonly IVisitorService _visitorService;
        private readonly IMasterService _masterService;
        private readonly ICustomerService _customerService;
        public Action<CustomerResponse>? OnCustomerCreated;

        public VistiorCustomerForm(IVisitorService visitorService, 
            IMasterService masterService,ICustomerService customerService)
        {
            InitializeComponent();
            _visitorService = visitorService;
            _masterService = masterService;
            _customerService = customerService;
           
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
        private async Task LoadStates(int stateId)
        {
            var states = await _masterService.GetStates();
            if (states != null)
            {
                cmbState.DataSource = states;
                cmbState.DisplayMember = "Name";
                cmbState.ValueMember = "Id";
                cmbState.SelectedValue = stateId;
              
            }


        }
        private async Task LoadCities(int stateId,int cityId)
        {
            var cities = await _masterService.GetCityByState(stateId);
            if (cities != null)
            {
                cmbCity.DataSource = cities;
                cmbCity.DisplayMember = "Name";
                cmbCity.ValueMember = "Id";
                cmbCity.SelectedValue = cityId;
            }


        }

        public async Task LoadVisitor(int visitorId)
        {
            VisitorId = visitorId;

            var visitor = await _visitorService.GetVisitor(visitorId);
            if (visitor == null) return;

            BindCustomerType();
            BindRegistrationType();
            // Basic Info
            txtName.Text = visitor.Name;
            txtAlias.Text = visitor.Name;
            txtPrintName.Text = visitor.Name;
            txtLedgerName.Text = visitor.Name;
            txtGroupName.Text = visitor.Name;

            txtMobile.Text = visitor.Mobile;
            txtPhoneno.Text = visitor.Mobile;

            if(visitor.CustomerType!=null)
            cmbCustomerType.SelectedValue = visitor.CustomerType.Value;

            // State Load
            if (visitor!=null && visitor.StateId.HasValue)
            {
                await LoadStates(visitor.StateId.Value);
            }

            // City Load (safe check)
            if (visitor.CityId.HasValue && visitor.StateId.HasValue)
            {
                await LoadCities(visitor.StateId.Value,visitor.CityId.Value);
            }
        }
        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                var request = BindRequest();

                if (VisitorId != null)
                {
                    var visitorResponse = await _customerService.CreateAsync(request, VisitorId.Value);


                    if (visitorResponse != null && visitorResponse.CustomerResponse != null)
                    {
                        // ✅ Parent ko data bhejo
                        OnCustomerCreated?.Invoke(visitorResponse.CustomerResponse);

                        this.Close(); // form close karo
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        private CustomerRequest BindRequest()
        {
            return new CustomerRequest
            {
                Name = txtName.Text?.Trim(),
                PrintName = txtPrintName.Text?.Trim(),
                LedgerName = txtLedgerName.Text?.Trim(),
                Alias = txtAlias.Text?.Trim(),
                GroupName = txtGroupName.Text?.Trim(),
                GstIn = txtGSTIN.Text?.Trim(),
                Pan = txtPanNo.Text?.Trim(),

                RegType = Convert.ToInt32(cmbRegistrationType.SelectedValue?.ToString()),

                BillingAddress = txtBillingAddress.Text?.Trim(),
                ShippingAddress = txtShippingAddress.Text?.Trim(),

                CityId = Convert.ToInt32(cmbCity.SelectedValue),

                PinCode = txtPinCode.Text?.Trim(),
                Phone = txtPhoneno.Text?.Trim(),
                Mobile = txtMobile.Text?.Trim(),
                Email = txtEmail.Text?.Trim(),

                CreditDays = int.TryParse(txtCreditDays.Text, out var days) ? days : 0,

                CreditLimit = decimal.TryParse(txtCreditLimits.Text, out var limit) ? limit : 0,

                CustomerType = Convert.ToInt32(cmbCustomerType.SelectedValue?.ToString())
            };
        }
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                ShowError("Name is required", txtName);
                return false;
            }

            if (cmbState.SelectedIndex == -1)
            {
                ShowError("State is required", cmbState);
                return false;
            }

            if (cmbCity.SelectedIndex == -1)
            {
                ShowError("City is required", cmbCity);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPinCode.Text))
            {
                ShowError("Pin Code is required", txtPinCode);
                return false;
            }

            if (cmbRegistrationType.SelectedIndex == -1)
            {
                ShowError("Registration Type is required", cmbRegistrationType);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCreditDays.Text) ||
                !int.TryParse(txtCreditDays.Text, out _))
            {
                ShowError("Credit Days is required and Credit Days must be numeric", txtCreditDays);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCreditLimits.Text) ||
                !decimal.TryParse(txtCreditLimits.Text, out _))
            {
                ShowError("Credit Limit is required and Credit Limit must be numeric", txtCreditLimits);
                return false;
            }

            return true;
        }

        private void ShowError(string message, Control control)
        {
            MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
        }
        private void VistiorCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
