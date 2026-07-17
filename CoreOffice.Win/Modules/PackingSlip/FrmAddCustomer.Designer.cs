namespace CoreOffice.Win.Modules.PackingSlip
{
    partial class FrmAddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            erpHeader1 = new CoreOffice.Win.Shared.Controls.ERPHeader();
            btnClose = new CoreOffice.Win.Shared.Controls.ERPButton();
            btnSave = new CoreOffice.Win.Shared.Controls.ERPButton();
            erpCard1 = new CoreOffice.Win.Shared.Controls.ERPCard();
            txtName = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtPhone = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtEmail = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtGSTIN = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtPan = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtGroupName = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            cmbCustomerType = new CoreOffice.Win.Shared.Controls.ERPComboBox();
            cmbRegistrationType = new CoreOffice.Win.Shared.Controls.ERPComboBox();
            erpCard2 = new CoreOffice.Win.Shared.Controls.ERPCard();
            txtBillingAddress = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtShippingAddress = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            cmbState = new CoreOffice.Win.Shared.Controls.ERPComboBox();
            cmbCity = new CoreOffice.Win.Shared.Controls.ERPComboBox();
            txtPinCode = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtContactPerson = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            erpCard3 = new CoreOffice.Win.Shared.Controls.ERPCard();
            erpCard4 = new CoreOffice.Win.Shared.Controls.ERPCard();
            txtOpeningBalance = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtCreditDays = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtCreditLimits = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtDiscount = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtRemarks = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtPrintName = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtAlias = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            txtLedgerName = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            erpLabel1 = new CoreOffice.Win.Shared.Controls.ERPLabel();
            erpTextBox1 = new CoreOffice.Win.Shared.Controls.ERPTextBox();
            erpHeader1.SuspendLayout();
            SuspendLayout();
            // 
            // erpHeader1
            // 
            erpHeader1.BackColor = Color.FromArgb(18, 45, 90);
            erpHeader1.Controls.Add(btnClose);
            erpHeader1.Controls.Add(btnSave);
            erpHeader1.Dock = DockStyle.Top;
            erpHeader1.Location = new Point(0, 0);
            erpHeader1.Name = "erpHeader1";
            erpHeader1.Size = new Size(986, 70);
            erpHeader1.SubTitle = "Add / Edit Customer";
            erpHeader1.TabIndex = 0;
            erpHeader1.Title = "Customer Information";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(220, 53, 69);
            btnClose.ButtonType = Win.Shared.Controls.ERPButtonType.Danger;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(870, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(104, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close(ESC)";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.ButtonType = Win.Shared.Controls.ERPButtonType.Save;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(646, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(218, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Customer(CTRL+S)";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // erpCard1
            // 
            erpCard1.BackColor = Color.White;
            erpCard1.Font = new Font("Segoe UI", 10F);
            erpCard1.ForeColor = Color.FromArgb(40, 40, 40);
            erpCard1.Location = new Point(6, 74);
            erpCard1.Margin = new Padding(10);
            erpCard1.Name = "erpCard1";
            erpCard1.Padding = new Padding(15, 45, 15, 15);
            erpCard1.Size = new Size(975, 155);
            erpCard1.TabIndex = 1;
            erpCard1.Title = "General Information";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Caption = "Name";
            txtName.CharacterCasing = CharacterCasing.Normal;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Icon = Win.Shared.Controls.ERPIconType.Customer;
            txtName.LabelFont = new Font("Segoe UI", 9F);
            txtName.Location = new Point(33, 114);
            txtName.MaxLength = 32767;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.Placeholder = "Enter customer name";
            txtName.Required = true;
            txtName.Size = new Size(209, 50);
            txtName.TabIndex = 0;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Caption = "Phone";
            txtPhone.CharacterCasing = CharacterCasing.Normal;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Icon = Win.Shared.Controls.ERPIconType.Phone;
            txtPhone.LabelFont = new Font("Segoe UI", 9F);
            txtPhone.Location = new Point(267, 114);
            txtPhone.MaxLength = 32767;
            txtPhone.Name = "txtPhone";
            txtPhone.PasswordChar = '\0';
            txtPhone.Placeholder = "Enter phone number";
            txtPhone.Size = new Size(209, 50);
            txtPhone.TabIndex = 1;
            txtPhone.TextAlign = HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Caption = "Email";
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Icon = Win.Shared.Controls.ERPIconType.Email;
            txtEmail.LabelFont = new Font("Segoe UI", 9F);
            txtEmail.Location = new Point(735, 113);
            txtEmail.MaxLength = 32767;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.Placeholder = "Enter email address";
            txtEmail.Size = new Size(209, 50);
            txtEmail.TabIndex = 3;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            // 
            // txtGSTIN
            // 
            txtGSTIN.BackColor = Color.White;
            txtGSTIN.Caption = "GSTIN";
            txtGSTIN.CharacterCasing = CharacterCasing.Normal;
            txtGSTIN.Font = new Font("Segoe UI", 10F);
            txtGSTIN.Icon = Win.Shared.Controls.ERPIconType.GST;
            txtGSTIN.LabelFont = new Font("Segoe UI", 9F);
            txtGSTIN.Location = new Point(735, 384);
            txtGSTIN.MaxLength = 32767;
            txtGSTIN.Name = "txtGSTIN";
            txtGSTIN.PasswordChar = '\0';
            txtGSTIN.Placeholder = "";
            txtGSTIN.Size = new Size(209, 50);
            txtGSTIN.TabIndex = 16;
            txtGSTIN.TextAlign = HorizontalAlignment.Left;
            // 
            // txtPan
            // 
            txtPan.BackColor = Color.White;
            txtPan.Caption = "PAN";
            txtPan.CharacterCasing = CharacterCasing.Normal;
            txtPan.Font = new Font("Segoe UI", 10F);
            txtPan.Icon = Win.Shared.Controls.ERPIconType.PAN;
            txtPan.LabelFont = new Font("Segoe UI", 9F);
            txtPan.Location = new Point(735, 440);
            txtPan.MaxLength = 32767;
            txtPan.Name = "txtPan";
            txtPan.PasswordChar = '\0';
            txtPan.Placeholder = "";
            txtPan.Size = new Size(209, 50);
            txtPan.TabIndex = 17;
            txtPan.TextAlign = HorizontalAlignment.Left;
            // 
            // txtGroupName
            // 
            txtGroupName.BackColor = Color.White;
            txtGroupName.Caption = "Group Name";
            txtGroupName.CharacterCasing = CharacterCasing.Normal;
            txtGroupName.Font = new Font("Segoe UI", 10F);
            txtGroupName.Icon = Win.Shared.Controls.ERPIconType.Group;
            txtGroupName.LabelFont = new Font("Segoe UI", 9F);
            txtGroupName.Location = new Point(735, 170);
            txtGroupName.MaxLength = 32767;
            txtGroupName.Name = "txtGroupName";
            txtGroupName.PasswordChar = '\0';
            txtGroupName.Placeholder = "Enter group name";
            txtGroupName.Size = new Size(209, 50);
            txtGroupName.TabIndex = 7;
            txtGroupName.TextAlign = HorizontalAlignment.Left;
            // 
            // cmbCustomerType
            // 
            cmbCustomerType.BackColor = Color.White;
            cmbCustomerType.Caption = "Customer Type";
            cmbCustomerType.DisplayMember = "";
            cmbCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomerType.Font = new Font("Segoe UI", 12F);
            cmbCustomerType.Icon = Win.Shared.Controls.ERPIconType.Customer;
            cmbCustomerType.Location = new Point(735, 269);
            cmbCustomerType.Name = "cmbCustomerType";
            cmbCustomerType.Size = new Size(209, 50);
            cmbCustomerType.TabIndex = 14;
            cmbCustomerType.ValueMember = "";
            // 
            // cmbRegistrationType
            // 
            cmbRegistrationType.BackColor = Color.White;
            cmbRegistrationType.Caption = "Registration Type";
            cmbRegistrationType.DisplayMember = "";
            cmbRegistrationType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegistrationType.Font = new Font("Segoe UI", 12F);
            cmbRegistrationType.Icon = Win.Shared.Controls.ERPIconType.Product;
            cmbRegistrationType.Location = new Point(735, 328);
            cmbRegistrationType.Name = "cmbRegistrationType";
            cmbRegistrationType.Size = new Size(209, 50);
            cmbRegistrationType.TabIndex = 15;
            cmbRegistrationType.ValueMember = "";
            // 
            // erpCard2
            // 
            erpCard2.BackColor = Color.White;
            erpCard2.Font = new Font("Segoe UI", 10F);
            erpCard2.ForeColor = Color.FromArgb(40, 40, 40);
            erpCard2.Location = new Point(6, 231);
            erpCard2.Margin = new Padding(10);
            erpCard2.Name = "erpCard2";
            erpCard2.Padding = new Padding(15, 45, 15, 15);
            erpCard2.Size = new Size(700, 184);
            erpCard2.TabIndex = 13;
            erpCard2.Title = "Address Information";
            // 
            // txtBillingAddress
            // 
            txtBillingAddress.BackColor = Color.White;
            txtBillingAddress.Caption = "Billing Address *";
            txtBillingAddress.CharacterCasing = CharacterCasing.Normal;
            txtBillingAddress.Font = new Font("Segoe UI", 10F);
            txtBillingAddress.Icon = Win.Shared.Controls.ERPIconType.Address;
            txtBillingAddress.LabelFont = new Font("Segoe UI", 9F);
            txtBillingAddress.Location = new Point(33, 269);
            txtBillingAddress.MaxLength = 32767;
            txtBillingAddress.Multiline = true;
            txtBillingAddress.Name = "txtBillingAddress";
            txtBillingAddress.PasswordChar = '\0';
            txtBillingAddress.Placeholder = "Enter billing address";
            txtBillingAddress.Size = new Size(314, 77);
            txtBillingAddress.TabIndex = 8;
            txtBillingAddress.TextAlign = HorizontalAlignment.Left;
            txtBillingAddress.TextChanged += txtBillingAddress_TextChanged;
            // 
            // txtShippingAddress
            // 
            txtShippingAddress.BackColor = Color.White;
            txtShippingAddress.Caption = "Shipping Address *";
            txtShippingAddress.CharacterCasing = CharacterCasing.Normal;
            txtShippingAddress.Font = new Font("Segoe UI", 10F);
            txtShippingAddress.Icon = Win.Shared.Controls.ERPIconType.Supplier;
            txtShippingAddress.LabelFont = new Font("Segoe UI", 9F);
            txtShippingAddress.Location = new Point(384, 269);
            txtShippingAddress.MaxLength = 32767;
            txtShippingAddress.Multiline = true;
            txtShippingAddress.Name = "txtShippingAddress";
            txtShippingAddress.PasswordChar = '\0';
            txtShippingAddress.Placeholder = "Enter billing address";
            txtShippingAddress.Size = new Size(314, 77);
            txtShippingAddress.TabIndex = 9;
            txtShippingAddress.TextAlign = HorizontalAlignment.Left;
            // 
            // cmbState
            // 
            cmbState.BackColor = Color.White;
            cmbState.Caption = "State";
            cmbState.DisplayMember = "";
            cmbState.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbState.Font = new Font("Segoe UI", 12F);
            cmbState.Icon = Win.Shared.Controls.ERPIconType.State;
            cmbState.Location = new Point(33, 357);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(155, 45);
            cmbState.TabIndex = 10;
            cmbState.ValueMember = "";
            cmbState.SelectedIndexChanged += cmbState_SelectedIndexChanged;
            // 
            // cmbCity
            // 
            cmbCity.BackColor = Color.White;
            cmbCity.Caption = "City";
            cmbCity.DisplayMember = "";
            cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCity.Font = new Font("Segoe UI", 12F);
            cmbCity.Icon = Win.Shared.Controls.ERPIconType.City;
            cmbCity.Location = new Point(194, 357);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(155, 45);
            cmbCity.TabIndex = 11;
            cmbCity.ValueMember = "";
            // 
            // txtPinCode
            // 
            txtPinCode.BackColor = Color.White;
            txtPinCode.Caption = "Pin Code";
            txtPinCode.CharacterCasing = CharacterCasing.Normal;
            txtPinCode.Font = new Font("Segoe UI", 10F);
            txtPinCode.Icon = Win.Shared.Controls.ERPIconType.Company;
            txtPinCode.LabelFont = new Font("Segoe UI", 9F);
            txtPinCode.Location = new Point(361, 357);
            txtPinCode.MaxLength = 32767;
            txtPinCode.Name = "txtPinCode";
            txtPinCode.PasswordChar = '\0';
            txtPinCode.Placeholder = "Enter pincode";
            txtPinCode.Required = true;
            txtPinCode.Size = new Size(155, 45);
            txtPinCode.TabIndex = 12;
            txtPinCode.TextAlign = HorizontalAlignment.Left;
            // 
            // txtContactPerson
            // 
            txtContactPerson.BackColor = Color.White;
            txtContactPerson.Caption = "Contact Person";
            txtContactPerson.CharacterCasing = CharacterCasing.Normal;
            txtContactPerson.Font = new Font("Segoe UI", 10F);
            txtContactPerson.Icon = Win.Shared.Controls.ERPIconType.User;
            txtContactPerson.LabelFont = new Font("Segoe UI", 9F);
            txtContactPerson.Location = new Point(522, 357);
            txtContactPerson.MaxLength = 32767;
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.PasswordChar = '\0';
            txtContactPerson.Placeholder = "Enter contact person";
            txtContactPerson.Size = new Size(176, 45);
            txtContactPerson.TabIndex = 13;
            txtContactPerson.TextAlign = HorizontalAlignment.Left;
            // 
            // erpCard3
            // 
            erpCard3.BackColor = Color.White;
            erpCard3.Font = new Font("Segoe UI", 10F);
            erpCard3.ForeColor = Color.FromArgb(40, 40, 40);
            erpCard3.Location = new Point(711, 231);
            erpCard3.Margin = new Padding(10);
            erpCard3.Name = "erpCard3";
            erpCard3.Padding = new Padding(15, 45, 15, 15);
            erpCard3.Size = new Size(270, 269);
            erpCard3.TabIndex = 20;
            erpCard3.Title = "Tax Information";
            // 
            // erpCard4
            // 
            erpCard4.BackColor = Color.White;
            erpCard4.Font = new Font("Segoe UI", 10F);
            erpCard4.ForeColor = Color.FromArgb(40, 40, 40);
            erpCard4.Location = new Point(6, 421);
            erpCard4.Margin = new Padding(10);
            erpCard4.Name = "erpCard4";
            erpCard4.Padding = new Padding(15, 45, 15, 15);
            erpCard4.Size = new Size(700, 176);
            erpCard4.TabIndex = 21;
            erpCard4.Title = "Credit Information";
            // 
            // txtOpeningBalance
            // 
            txtOpeningBalance.BackColor = Color.White;
            txtOpeningBalance.Caption = "Opening Balance";
            txtOpeningBalance.CharacterCasing = CharacterCasing.Normal;
            txtOpeningBalance.Font = new Font("Segoe UI", 10F);
            txtOpeningBalance.Icon = Win.Shared.Controls.ERPIconType.Amount;
            txtOpeningBalance.LabelFont = new Font("Segoe UI", 9F);
            txtOpeningBalance.Location = new Point(33, 461);
            txtOpeningBalance.MaxLength = 32767;
            txtOpeningBalance.Name = "txtOpeningBalance";
            txtOpeningBalance.PasswordChar = '\0';
            txtOpeningBalance.Placeholder = "0.00";
            txtOpeningBalance.Required = true;
            txtOpeningBalance.Size = new Size(155, 50);
            txtOpeningBalance.TabIndex = 18;
            txtOpeningBalance.TextAlign = HorizontalAlignment.Left;
            // 
            // txtCreditDays
            // 
            txtCreditDays.BackColor = Color.White;
            txtCreditDays.Caption = "Credit Days";
            txtCreditDays.CharacterCasing = CharacterCasing.Normal;
            txtCreditDays.Font = new Font("Segoe UI", 10F);
            txtCreditDays.Icon = Win.Shared.Controls.ERPIconType.Credit;
            txtCreditDays.LabelFont = new Font("Segoe UI", 9F);
            txtCreditDays.Location = new Point(194, 461);
            txtCreditDays.MaxLength = 32767;
            txtCreditDays.Name = "txtCreditDays";
            txtCreditDays.PasswordChar = '\0';
            txtCreditDays.Placeholder = "0";
            txtCreditDays.Required = true;
            txtCreditDays.Size = new Size(155, 50);
            txtCreditDays.TabIndex = 19;
            txtCreditDays.TextAlign = HorizontalAlignment.Left;
            // 
            // txtCreditLimits
            // 
            txtCreditLimits.BackColor = Color.White;
            txtCreditLimits.Caption = "Credit Limit";
            txtCreditLimits.CharacterCasing = CharacterCasing.Normal;
            txtCreditLimits.Font = new Font("Segoe UI", 10F);
            txtCreditLimits.Icon = Win.Shared.Controls.ERPIconType.Amount;
            txtCreditLimits.LabelFont = new Font("Segoe UI", 9F);
            txtCreditLimits.Location = new Point(382, 461);
            txtCreditLimits.MaxLength = 32767;
            txtCreditLimits.Name = "txtCreditLimits";
            txtCreditLimits.PasswordChar = '\0';
            txtCreditLimits.Placeholder = "0.00";
            txtCreditLimits.Required = true;
            txtCreditLimits.Size = new Size(155, 50);
            txtCreditLimits.TabIndex = 20;
            txtCreditLimits.TextAlign = HorizontalAlignment.Left;
            // 
            // txtDiscount
            // 
            txtDiscount.BackColor = Color.White;
            txtDiscount.Caption = "Discount (%)";
            txtDiscount.CharacterCasing = CharacterCasing.Normal;
            txtDiscount.Font = new Font("Segoe UI", 10F);
            txtDiscount.Icon = Win.Shared.Controls.ERPIconType.Discount;
            txtDiscount.LabelFont = new Font("Segoe UI", 9F);
            txtDiscount.Location = new Point(543, 461);
            txtDiscount.MaxLength = 32767;
            txtDiscount.Name = "txtDiscount";
            txtDiscount.PasswordChar = '\0';
            txtDiscount.Placeholder = "0.00";
            txtDiscount.Required = true;
            txtDiscount.Size = new Size(155, 50);
            txtDiscount.TabIndex = 21;
            txtDiscount.TextAlign = HorizontalAlignment.Left;
            // 
            // txtRemarks
            // 
            txtRemarks.BackColor = Color.White;
            txtRemarks.Caption = "Remarks";
            txtRemarks.CharacterCasing = CharacterCasing.Normal;
            txtRemarks.Font = new Font("Segoe UI", 10F);
            txtRemarks.Icon = Win.Shared.Controls.ERPIconType.None;
            txtRemarks.LabelFont = new Font("Segoe UI", 9F);
            txtRemarks.Location = new Point(33, 517);
            txtRemarks.MaxLength = 32767;
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.PasswordChar = '\0';
            txtRemarks.Placeholder = "Enter remarks (optional)";
            txtRemarks.Size = new Size(665, 68);
            txtRemarks.TabIndex = 22;
            txtRemarks.TextAlign = HorizontalAlignment.Left;
            // 
            // txtPrintName
            // 
            txtPrintName.BackColor = Color.White;
            txtPrintName.Caption = "Print Name";
            txtPrintName.CharacterCasing = CharacterCasing.Normal;
            txtPrintName.Font = new Font("Segoe UI", 10F);
            txtPrintName.Icon = Win.Shared.Controls.ERPIconType.None;
            txtPrintName.LabelFont = new Font("Segoe UI", 9F);
            txtPrintName.Location = new Point(33, 170);
            txtPrintName.MaxLength = 32767;
            txtPrintName.Name = "txtPrintName";
            txtPrintName.PasswordChar = '\0';
            txtPrintName.Placeholder = "Enter print name";
            txtPrintName.Size = new Size(209, 50);
            txtPrintName.TabIndex = 4;
            txtPrintName.TextAlign = HorizontalAlignment.Left;
            // 
            // txtAlias
            // 
            txtAlias.BackColor = Color.White;
            txtAlias.Caption = "Alias";
            txtAlias.CharacterCasing = CharacterCasing.Normal;
            txtAlias.Font = new Font("Segoe UI", 10F);
            txtAlias.Icon = Win.Shared.Controls.ERPIconType.None;
            txtAlias.LabelFont = new Font("Segoe UI", 9F);
            txtAlias.Location = new Point(267, 170);
            txtAlias.MaxLength = 32767;
            txtAlias.Name = "txtAlias";
            txtAlias.PasswordChar = '\0';
            txtAlias.Placeholder = "Enter alias";
            txtAlias.Size = new Size(209, 50);
            txtAlias.TabIndex = 5;
            txtAlias.TextAlign = HorizontalAlignment.Left;
            // 
            // txtLedgerName
            // 
            txtLedgerName.BackColor = Color.White;
            txtLedgerName.Caption = "Ledger Name";
            txtLedgerName.CharacterCasing = CharacterCasing.Normal;
            txtLedgerName.Font = new Font("Segoe UI", 10F);
            txtLedgerName.Icon = Win.Shared.Controls.ERPIconType.None;
            txtLedgerName.LabelFont = new Font("Segoe UI", 9F);
            txtLedgerName.Location = new Point(501, 170);
            txtLedgerName.MaxLength = 32767;
            txtLedgerName.Name = "txtLedgerName";
            txtLedgerName.PasswordChar = '\0';
            txtLedgerName.Placeholder = "Enter ledger name";
            txtLedgerName.Size = new Size(209, 50);
            txtLedgerName.TabIndex = 6;
            txtLedgerName.TextAlign = HorizontalAlignment.Left;
            // 
            // erpLabel1
            // 
            erpLabel1.AutoSize = true;
            erpLabel1.BackColor = Color.Cornsilk;
            erpLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            erpLabel1.ForeColor = Color.FromArgb(40, 40, 40);
            erpLabel1.Location = new Point(728, 510);
            erpLabel1.Name = "erpLabel1";
            erpLabel1.Size = new Size(237, 75);
            erpLabel1.TabIndex = 30;
            erpLabel1.Text = "\r\n🛈 Note\r\n• Fields marked with * are mandatory\r\n• Duplicate Name or GSTIN is not allowed\r\n\r\n";
            // 
            // erpTextBox1
            // 
            erpTextBox1.BackColor = Color.White;
            erpTextBox1.Caption = "Mobile";
            erpTextBox1.CharacterCasing = CharacterCasing.Normal;
            erpTextBox1.Font = new Font("Segoe UI", 10F);
            erpTextBox1.Icon = Win.Shared.Controls.ERPIconType.Mobile;
            erpTextBox1.LabelFont = new Font("Segoe UI", 9F);
            erpTextBox1.Location = new Point(501, 113);
            erpTextBox1.MaxLength = 32767;
            erpTextBox1.Name = "erpTextBox1";
            erpTextBox1.PasswordChar = '\0';
            erpTextBox1.Placeholder = "Enter mobile number";
            erpTextBox1.Size = new Size(209, 50);
            erpTextBox1.TabIndex = 2;
            erpTextBox1.TextAlign = HorizontalAlignment.Left;
            // 
            // FrmAddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(986, 632);
            Controls.Add(cmbCustomerType);
            Controls.Add(erpTextBox1);
            Controls.Add(erpLabel1);
            Controls.Add(txtLedgerName);
            Controls.Add(txtAlias);
            Controls.Add(txtPrintName);
            Controls.Add(txtRemarks);
            Controls.Add(txtDiscount);
            Controls.Add(txtCreditLimits);
            Controls.Add(txtCreditDays);
            Controls.Add(txtOpeningBalance);
            Controls.Add(erpCard4);
            Controls.Add(cmbRegistrationType);
            Controls.Add(txtPan);
            Controls.Add(txtGSTIN);
            Controls.Add(erpCard3);
            Controls.Add(txtContactPerson);
            Controls.Add(txtPinCode);
            Controls.Add(cmbCity);
            Controls.Add(cmbState);
            Controls.Add(txtShippingAddress);
            Controls.Add(txtBillingAddress);
            Controls.Add(erpCard2);
            Controls.Add(txtGroupName);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(erpCard1);
            Controls.Add(erpHeader1);
            Name = "FrmAddCustomer";
            Text = "FrmAddCustomer";
            Load += FrmAddCustomer_Load;
            erpHeader1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Win.Shared.Controls.ERPHeader erpHeader1;
        private Win.Shared.Controls.ERPCard erpCard1;
        private Win.Shared.Controls.ERPTextBox txtName;
        private Win.Shared.Controls.ERPTextBox txtPhone;
        private Win.Shared.Controls.ERPTextBox txtEmail;
        private Win.Shared.Controls.ERPTextBox txtGSTIN;
        private Win.Shared.Controls.ERPTextBox txtPan;
        private Win.Shared.Controls.ERPTextBox txtGroupName;
        private Win.Shared.Controls.ERPComboBox cmbCustomerType;
        private Win.Shared.Controls.ERPComboBox cmbRegistrationType;
        private Win.Shared.Controls.ERPCard erpCard2;
        private Win.Shared.Controls.ERPTextBox txtBillingAddress;
        private Win.Shared.Controls.ERPTextBox txtShippingAddress;
        private Win.Shared.Controls.ERPComboBox cmbState;
        private Win.Shared.Controls.ERPComboBox cmbCity;
        private Win.Shared.Controls.ERPTextBox txtPinCode;
        private Win.Shared.Controls.ERPTextBox txtContactPerson;
        private Win.Shared.Controls.ERPCard erpCard3;
        private Win.Shared.Controls.ERPCard erpCard4;
        private Win.Shared.Controls.ERPTextBox txtOpeningBalance;
        private Win.Shared.Controls.ERPTextBox txtCreditDays;
        private Win.Shared.Controls.ERPTextBox txtCreditLimits;
        private Win.Shared.Controls.ERPTextBox txtDiscount;
        private Win.Shared.Controls.ERPTextBox txtRemarks;
        private Win.Shared.Controls.ERPTextBox txtPrintName;
        private Win.Shared.Controls.ERPTextBox txtAlias;
        private Win.Shared.Controls.ERPTextBox txtLedgerName;
        private Win.Shared.Controls.ERPLabel erpLabel1;
        private Win.Shared.Controls.ERPButton btnClose;
        private Win.Shared.Controls.ERPButton btnSave;
        private Win.Shared.Controls.ERPTextBox erpTextBox1;
    }
}