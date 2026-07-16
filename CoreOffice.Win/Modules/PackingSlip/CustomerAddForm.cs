using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Application.Services;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Common.Hepler;
using CoreOfficeERP.Domain.Requests.Customers;
using CoreOfficeERP.Domain.Responses.MasterData;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace CoreOffice.Win.Modules.PackingSlip;

public partial class CustomerAddForm : BaseForm
{
    private readonly ICustomerService _customerService;
    private readonly IMasterService _masterService;

    public CustomerAddForm(ICustomerService customerService, IMasterService masterService)
    {
        InitializeComponent();
        _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        _masterService = masterService ?? throw new ArgumentNullException(nameof(masterService));
    }
    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public string CustomerName { get; set; } = string.Empty;
    #region shortcut commands mapping
    
    //Save Packingslip: Ctrl + S
    protected override async Task SaveAsync()
    {
        await SaveCustomerAsync();
    }
   
    //Reset Form: Ctrl + R
    protected override void ResetForm()
    {
        Clear();
    }  
    protected override void CloseForm()
    {
        Close();
    }
    #endregion
    private async void CustomerAddForm_Load(object? sender, EventArgs e)
    {
        txtName.Text = CustomerName;

        if (!string.IsNullOrWhiteSpace(CustomerName))
        {
            txtName.Focus(); // or whichever field should be next
        }
        BindCustomerType();
        BindRegistrationType();
        txtOpeningBalance.Text = "0";
        txtCreditDays.Text = "0";
        txtCreditLimits.Text = "0";
        txtDiscount.Text = "0";

        try
        {
            var states = (await _masterService.GetStates())?.ToList() ?? new List<StateResponse>();
            cmbState.DataSource = states;
            cmbState.DisplayMember = "Name";
            cmbState.ValueMember = "Id";

            if (states.Count > 0)
            {
                cmbState.SelectedIndex = 0;
                await LoadCitiesAsync(states[0].Id);
            }
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }
    public void Clear()
    {
        txtName.Text=string.Empty;
        txtPrintName.Text=string.Empty;
        txtAlias.Text=string.Empty;
        txtLedgerName.Text=string.Empty;
        txtGroupName.Text=string.Empty;
        txtGSTIN.Text=string.Empty;
        txtPan.Text=string.Empty;
        txtEmail.Text=string.Empty;
        txtPhone.Text=string.Empty;
        txtMobile.Text=string.Empty;
        txtBillingAddress.Text=string.Empty;
        txtShippingAddress.Text=string.Empty;
        txtPinCode.Text=string.Empty;
        txtContactPerson.Text=string.Empty;
        txtOpeningBalance.Text = "0";
        txtCreditDays.Text = "0";
        txtCreditLimits.Text = "0";
        txtDiscount.Text = "0";
        txtRemarks.Text = string.Empty;

    }
    private void BindCustomerType()
    {
        cmbCustomerType.DataSource = Enum.GetValues<CustomerTypeEnum>()
            .Select(value => new { Value = (int)value, Text = Helper.GetEnumDescription(value) }).ToList();
        cmbCustomerType.DisplayMember = "Text";
        cmbCustomerType.ValueMember = "Value";
    }

    private void BindRegistrationType()
    {
        cmbRegistrationType.DataSource = Enum.GetValues<RegistrationTypeEnum>()
            .Select(value => new { Value = (int)value, Text = Helper.GetEnumDescription(value) }).ToList();
        cmbRegistrationType.DisplayMember = "Text";
        cmbRegistrationType.ValueMember = "Value";
    }

    private void txtName_TextChanged(object? sender, EventArgs e)
    {
        var customerName = txtName.Text.Trim();
        txtPrintName.Text = customerName;
        txtAlias.Text = customerName;
        txtLedgerName.Text = customerName;
    }

    private void txtBillingAddress_TextChanged(object? sender, EventArgs e)
    {
        txtShippingAddress.Text = txtBillingAddress.Text;
    }

    private async void cmbState_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cmbState.SelectedValue is not int stateId)
            return;

        try
        {
            await LoadCitiesAsync(stateId);
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
    }

    private async Task LoadCitiesAsync(int stateId)
    {
        cmbCity.DataSource = (await _masterService.GetCityByState(stateId))?.ToList() ?? new List<CityResponse>();
        cmbCity.DisplayMember = "Name";
        cmbCity.ValueMember = "Id";
    }
    private async Task SaveCustomerAsync()
    {
        if (!ValidateCustomer())
            return;

        if (HasDuplicateCustomer())
            return;

        try
        {
            btnSave.Enabled = false;
            var customer = await _customerService.CreateCustomerAsync(new CustomerRequest
            {
                Name = txtName.Text.Trim(),
                PrintName = txtPrintName.Text.Trim(),
                Alias = txtAlias.Text.Trim(),
                LedgerName = txtLedgerName.Text.Trim(),
                GroupName = txtGroupName.Text.Trim(),
                GstIn = txtGSTIN.Text.Trim(),
                Pan = txtPan.Text.Trim(),
                RegType = (int)cmbRegistrationType.SelectedValue,
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Mobile = txtMobile.Text.Trim(),
                BillingAddress = txtBillingAddress.Text.Trim(),
                ShippingAddress = txtShippingAddress.Text.Trim(),
                CityId = (int)cmbCity.SelectedValue,
                PinCode = txtPinCode.Text.Trim(),
                ContactPerson = txtContactPerson.Text.Trim(),
                OpeningBalance = decimal.Parse(txtOpeningBalance.Text),
                CreditDays = int.Parse(txtCreditDays.Text),
                CreditLimit = decimal.Parse(txtCreditLimits.Text),
                Discount = decimal.Parse(txtDiscount.Text),
                CustomerType = (int)cmbCustomerType.SelectedValue,
                Remarks = txtRemarks.Text.Trim()
            });

            if (customer is null)
            {
                ShowError("Customer could not be saved.");
                return;
            }

            AppCache.BillingCustomers.Add(customer);
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            ShowError(ex.Message);
        }
        finally
        {
            btnSave.Enabled = true;
        }
    }
    private async void btnSave_Click(object? sender, EventArgs e)
    {
        await SaveAsync();
    }

    private bool ValidateCustomer()
    {
        if (string.IsNullOrWhiteSpace(txtName.Text)) return ShowValidationError("Customer name is required.", txtName);
        if (string.IsNullOrWhiteSpace(txtPrintName.Text)) return ShowValidationError("Print name is required.", txtPrintName);
        if (string.IsNullOrWhiteSpace(txtAlias.Text)) return ShowValidationError("Alias is required.", txtAlias);
        if (string.IsNullOrWhiteSpace(txtLedgerName.Text)) return ShowValidationError("Ledger name is required.", txtLedgerName);
        if (string.IsNullOrWhiteSpace(txtGroupName.Text)) return ShowValidationError("Group name is required.", txtGroupName);
        // Allow empty, but if filled, it must be exactly 15 characters
        if (!string.IsNullOrWhiteSpace(txtGSTIN.Text) && txtGSTIN.Text.Trim().Length != 15)
            return ShowValidationError("GSTIN must be exactly 15 digits.", txtGSTIN);
        // Allow empty, but if filled, it must be exactly 15 characters
        if (!string.IsNullOrWhiteSpace(txtPan.Text) && txtPan.Text.Trim().Length != 8)
            return ShowValidationError("PAN must be exactly 8 digits.", txtPan);
        if (!string.IsNullOrWhiteSpace(txtMobile.Text) && txtMobile.Text.Trim().Length != 10)
            return ShowValidationError("Mobile must be exactly 10 digits.", txtMobile);
        //if (string.IsNullOrWhiteSpace(txtBillingAddress.Text)) return ShowValidationError("Billing address is required.", txtBillingAddress);
       // if (string.IsNullOrWhiteSpace(txtShippingAddress.Text)) return ShowValidationError("Shipping address is required.", txtShippingAddress);
        if (cmbCity.SelectedValue is not int) return ShowValidationError("Please select a city.", cmbCity);
        if (string.IsNullOrWhiteSpace(txtPinCode.Text)) return ShowValidationError("Pin code is required.", txtPinCode);
       // if (string.IsNullOrWhiteSpace(txtContactPerson.Text)) return ShowValidationError("Contact person is required.", txtContactPerson);
        if (!decimal.TryParse(txtOpeningBalance.Text, out _)) return ShowValidationError("Opening balance must be numeric.", txtOpeningBalance);
        if (!int.TryParse(txtCreditDays.Text, out _)) return ShowValidationError("Credit days must be numeric.", txtCreditDays);
        if (!decimal.TryParse(txtCreditLimits.Text, out _)) return ShowValidationError("Credit limit must be numeric.", txtCreditLimits);
        if (!decimal.TryParse(txtDiscount.Text, out _)) return ShowValidationError("Discount must be numeric.", txtDiscount);
        return true;
    }

    private bool HasDuplicateCustomer()
    {
        var customerName = txtName.Text.Trim();
        var gstIn = txtGSTIN.Text.Trim();

        if (AppCache.BillingCustomers.Any(customer =>
            string.Equals(customer.Name, customerName, StringComparison.OrdinalIgnoreCase)))
        {
            ShowValidationError("A customer with this name already exists.", txtName);
            return true;
        }

        if (!string.IsNullOrWhiteSpace(gstIn) && AppCache.BillingCustomers.Any(customer =>
            string.Equals(customer.GSTIN, gstIn, StringComparison.OrdinalIgnoreCase)))
        {
            ShowValidationError("A customer with this GSTIN already exists.", txtGSTIN);
            return true;
        }

        return false;
    }

    private static bool ShowValidationError(string message, Control control)
    {
        MessageBox.Show(message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        control.Focus();
        return false;
    }

    private static void ShowError(string message) => MessageBox.Show(message, "Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);

    private void btnClose_Click(object sender, EventArgs e)
    {
        CloseForm();
    }
}
