namespace CoreOffice.Win.Modules.PackingSlip;

partial class CustomerAddForm
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing)
            components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        pnlHeader = new Panel();
        btnClose = new CoreOffice.Win.Shared.Controls.ERPButton();
        btnSave = new CoreOffice.Win.Shared.Controls.ERPButton();
        lblTitle = new Label();
        pnlContent = new Panel();
        txtGroupName = new TextBox();
        lblGroupName = new Label();
        cmbRegistrationType = new ComboBox();
        txtEmail = new TextBox();
        txtPrintName = new TextBox();
        lblRegistrationType = new Label();
        cmbCustomerType = new ComboBox();
        txtAlias = new TextBox();
        lblEmail = new Label();
        lblAlias = new Label();
        txtLedgerName = new TextBox();
        txtGSTIN = new TextBox();
        txtPan = new TextBox();
        lblPrintName = new Label();
        txtPhone = new TextBox();
        lblCustomerType = new Label();
        txtName = new TextBox();
        txtMobile = new TextBox();
        txtBillingAddress = new TextBox();
        lblName = new Label();
        txtShippingAddress = new TextBox();
        cmbState = new ComboBox();
        cmbCity = new ComboBox();
        txtPinCode = new TextBox();
        txtContactPerson = new TextBox();
        txtOpeningBalance = new TextBox();
        lblLedgerName = new Label();
        txtCreditDays = new TextBox();
        txtCreditLimits = new TextBox();
        txtDiscount = new TextBox();
        txtRemarks = new TextBox();
        lblGSTIN = new Label();
        lblMobile = new Label();
        lblPan = new Label();
        lblBillingAddress = new Label();
        lblShippingAddress = new Label();
        lblPhone = new Label();
        lblState = new Label();
        lblCity = new Label();
        lblPinCode = new Label();
        lblContactPerson = new Label();
        lblOpeningBalance = new Label();
        lblCreditDays = new Label();
        lblCreditLimit = new Label();
        lblDiscount = new Label();
        lblRemarks = new Label();
        pnlHeader.SuspendLayout();
        pnlContent.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.BackColor = Color.FromArgb(18, 45, 90);
        pnlHeader.BorderStyle = BorderStyle.FixedSingle;
        pnlHeader.Controls.Add(btnClose);
        pnlHeader.Controls.Add(btnSave);
        pnlHeader.Controls.Add(lblTitle);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(969, 47);
        pnlHeader.TabIndex = 1;
        // 
        // btnClose
        // 
        btnClose.BackColor = Color.FromArgb(220, 53, 69);
        btnClose.ButtonType = Win.Shared.Controls.ERPButtonType.Danger;
        btnClose.FlatAppearance.BorderSize = 0;
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnClose.ForeColor = Color.White;
        btnClose.Location = new Point(855, 3);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(104, 40);
        btnClose.TabIndex = 3;
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
        btnSave.Location = new Point(724, 3);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(125, 40);
        btnSave.TabIndex = 2;
        btnSave.Text = "Save(CTRL+S)";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(15, 13);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(166, 20);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Customer Information";
        // 
        // pnlContent
        // 
        pnlContent.AutoScroll = true;
        pnlContent.BackColor = Color.FromArgb(250, 250, 250);
        pnlContent.Controls.Add(txtGroupName);
        pnlContent.Controls.Add(lblGroupName);
        pnlContent.Controls.Add(cmbRegistrationType);
        pnlContent.Controls.Add(txtEmail);
        pnlContent.Controls.Add(txtPrintName);
        pnlContent.Controls.Add(lblRegistrationType);
        pnlContent.Controls.Add(cmbCustomerType);
        pnlContent.Controls.Add(txtAlias);
        pnlContent.Controls.Add(lblEmail);
        pnlContent.Controls.Add(lblAlias);
        pnlContent.Controls.Add(txtLedgerName);
        pnlContent.Controls.Add(txtGSTIN);
        pnlContent.Controls.Add(txtPan);
        pnlContent.Controls.Add(lblPrintName);
        pnlContent.Controls.Add(txtPhone);
        pnlContent.Controls.Add(lblCustomerType);
        pnlContent.Controls.Add(txtName);
        pnlContent.Controls.Add(txtMobile);
        pnlContent.Controls.Add(txtBillingAddress);
        pnlContent.Controls.Add(lblName);
        pnlContent.Controls.Add(txtShippingAddress);
        pnlContent.Controls.Add(cmbState);
        pnlContent.Controls.Add(cmbCity);
        pnlContent.Controls.Add(txtPinCode);
        pnlContent.Controls.Add(txtContactPerson);
        pnlContent.Controls.Add(txtOpeningBalance);
        pnlContent.Controls.Add(lblLedgerName);
        pnlContent.Controls.Add(txtCreditDays);
        pnlContent.Controls.Add(txtCreditLimits);
        pnlContent.Controls.Add(txtDiscount);
        pnlContent.Controls.Add(txtRemarks);
        pnlContent.Controls.Add(lblGSTIN);
        pnlContent.Controls.Add(lblMobile);
        pnlContent.Controls.Add(lblPan);
        pnlContent.Controls.Add(lblBillingAddress);
        pnlContent.Controls.Add(lblShippingAddress);
        pnlContent.Controls.Add(lblPhone);
        pnlContent.Controls.Add(lblState);
        pnlContent.Controls.Add(lblCity);
        pnlContent.Controls.Add(lblPinCode);
        pnlContent.Controls.Add(lblContactPerson);
        pnlContent.Controls.Add(lblOpeningBalance);
        pnlContent.Controls.Add(lblCreditDays);
        pnlContent.Controls.Add(lblCreditLimit);
        pnlContent.Controls.Add(lblDiscount);
        pnlContent.Controls.Add(lblRemarks);
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(0, 47);
        pnlContent.Name = "pnlContent";
        pnlContent.Padding = new Padding(15);
        pnlContent.Size = new Size(969, 569);
        pnlContent.TabIndex = 0;
        // 
        // txtGroupName
        // 
        txtGroupName.BorderStyle = BorderStyle.FixedSingle;
        txtGroupName.Font = new Font("Segoe UI", 10F);
        txtGroupName.Location = new Point(13, 143);
        txtGroupName.Margin = new Padding(7, 22, 7, 7);
        txtGroupName.Name = "txtGroupName";
        txtGroupName.Size = new Size(233, 25);
        txtGroupName.TabIndex = 8;
        // 
        // lblGroupName
        // 
        lblGroupName.AutoSize = true;
        lblGroupName.BackColor = Color.FromArgb(250, 250, 250);
        lblGroupName.ForeColor = Color.FromArgb(75, 85, 99);
        lblGroupName.Location = new Point(13, 121);
        lblGroupName.Margin = new Padding(10, 4, 3, 3);
        lblGroupName.Name = "lblGroupName";
        lblGroupName.Size = new Size(75, 15);
        lblGroupName.TabIndex = 28;
        lblGroupName.Text = "Group Name";
        // 
        // cmbRegistrationType
        // 
        cmbRegistrationType.AccessibleName = "Registration type";
        cmbRegistrationType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbRegistrationType.Font = new Font("Segoe UI", 10F);
        cmbRegistrationType.Location = new Point(730, 37);
        cmbRegistrationType.Margin = new Padding(7, 22, 7, 7);
        cmbRegistrationType.Name = "cmbRegistrationType";
        cmbRegistrationType.Size = new Size(230, 25);
        cmbRegistrationType.TabIndex = 3;
        // 
        // txtEmail
        // 
        txtEmail.BorderStyle = BorderStyle.FixedSingle;
        txtEmail.Font = new Font("Segoe UI", 10F);
        txtEmail.Location = new Point(257, 89);
        txtEmail.Margin = new Padding(7, 22, 7, 7);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(223, 25);
        txtEmail.TabIndex = 5;
        // 
        // txtPrintName
        // 
        txtPrintName.BorderStyle = BorderStyle.FixedSingle;
        txtPrintName.Font = new Font("Segoe UI", 10F);
        txtPrintName.Location = new Point(258, 143);
        txtPrintName.Margin = new Padding(7, 22, 7, 7);
        txtPrintName.Name = "txtPrintName";
        txtPrintName.Size = new Size(223, 25);
        txtPrintName.TabIndex = 9;
        // 
        // lblRegistrationType
        // 
        lblRegistrationType.AutoSize = true;
        lblRegistrationType.BackColor = Color.FromArgb(250, 250, 250);
        lblRegistrationType.ForeColor = Color.FromArgb(75, 85, 99);
        lblRegistrationType.Location = new Point(734, 11);
        lblRegistrationType.Margin = new Padding(10, 4, 3, 3);
        lblRegistrationType.Name = "lblRegistrationType";
        lblRegistrationType.Size = new Size(98, 15);
        lblRegistrationType.TabIndex = 31;
        lblRegistrationType.Text = "Registration Type";
        // 
        // cmbCustomerType
        // 
        cmbCustomerType.AccessibleName = "Select Customer Type";
        cmbCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCustomerType.Font = new Font("Segoe UI", 10F);
        cmbCustomerType.Location = new Point(16, 37);
        cmbCustomerType.Margin = new Padding(7, 22, 7, 7);
        cmbCustomerType.Name = "cmbCustomerType";
        cmbCustomerType.Size = new Size(230, 25);
        cmbCustomerType.TabIndex = 0;
        // 
        // txtAlias
        // 
        txtAlias.BorderStyle = BorderStyle.FixedSingle;
        txtAlias.Font = new Font("Segoe UI", 10F);
        txtAlias.Location = new Point(487, 142);
        txtAlias.Margin = new Padding(7, 22, 7, 7);
        txtAlias.Name = "txtAlias";
        txtAlias.Size = new Size(230, 25);
        txtAlias.TabIndex = 10;
        // 
        // lblEmail
        // 
        lblEmail.AutoSize = true;
        lblEmail.BackColor = Color.FromArgb(250, 250, 250);
        lblEmail.ForeColor = Color.FromArgb(75, 85, 99);
        lblEmail.Location = new Point(254, 71);
        lblEmail.Margin = new Padding(10, 4, 3, 3);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(36, 15);
        lblEmail.TabIndex = 32;
        lblEmail.Text = "Email";
        // 
        // lblAlias
        // 
        lblAlias.AutoSize = true;
        lblAlias.BackColor = Color.FromArgb(250, 250, 250);
        lblAlias.ForeColor = Color.FromArgb(75, 85, 99);
        lblAlias.Location = new Point(493, 121);
        lblAlias.Margin = new Padding(10, 4, 3, 3);
        lblAlias.Name = "lblAlias";
        lblAlias.Size = new Size(32, 15);
        lblAlias.TabIndex = 26;
        lblAlias.Text = "Alias";
        // 
        // txtLedgerName
        // 
        txtLedgerName.BorderStyle = BorderStyle.FixedSingle;
        txtLedgerName.Font = new Font("Segoe UI", 10F);
        txtLedgerName.Location = new Point(737, 143);
        txtLedgerName.Margin = new Padding(7, 22, 7, 7);
        txtLedgerName.Name = "txtLedgerName";
        txtLedgerName.Size = new Size(223, 25);
        txtLedgerName.TabIndex = 11;
        // 
        // txtGSTIN
        // 
        txtGSTIN.BorderStyle = BorderStyle.FixedSingle;
        txtGSTIN.Font = new Font("Segoe UI", 10F);
        txtGSTIN.Location = new Point(491, 89);
        txtGSTIN.Margin = new Padding(7, 22, 7, 7);
        txtGSTIN.Name = "txtGSTIN";
        txtGSTIN.Size = new Size(230, 25);
        txtGSTIN.TabIndex = 6;
        // 
        // txtPan
        // 
        txtPan.BorderStyle = BorderStyle.FixedSingle;
        txtPan.Font = new Font("Segoe UI", 10F);
        txtPan.Location = new Point(732, 89);
        txtPan.Margin = new Padding(7, 22, 7, 7);
        txtPan.Name = "txtPan";
        txtPan.Size = new Size(228, 25);
        txtPan.TabIndex = 7;
        // 
        // lblPrintName
        // 
        lblPrintName.AutoSize = true;
        lblPrintName.BackColor = Color.FromArgb(250, 250, 250);
        lblPrintName.ForeColor = Color.FromArgb(75, 85, 99);
        lblPrintName.Location = new Point(261, 121);
        lblPrintName.Margin = new Padding(10, 4, 3, 3);
        lblPrintName.Name = "lblPrintName";
        lblPrintName.Size = new Size(67, 15);
        lblPrintName.TabIndex = 25;
        lblPrintName.Text = "Print Name";
        // 
        // txtPhone
        // 
        txtPhone.BorderStyle = BorderStyle.FixedSingle;
        txtPhone.Font = new Font("Segoe UI", 10F);
        txtPhone.Location = new Point(13, 90);
        txtPhone.Margin = new Padding(7, 22, 7, 7);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(233, 25);
        txtPhone.TabIndex = 4;
        // 
        // lblCustomerType
        // 
        lblCustomerType.AutoSize = true;
        lblCustomerType.BackColor = Color.FromArgb(250, 250, 250);
        lblCustomerType.ForeColor = Color.FromArgb(75, 85, 99);
        lblCustomerType.Location = new Point(12, 11);
        lblCustomerType.Margin = new Padding(10, 4, 3, 3);
        lblCustomerType.Name = "lblCustomerType";
        lblCustomerType.Size = new Size(87, 15);
        lblCustomerType.TabIndex = 23;
        lblCustomerType.Text = "Customer Type";
        // 
        // txtName
        // 
        txtName.BorderStyle = BorderStyle.FixedSingle;
        txtName.Font = new Font("Segoe UI", 10F);
        txtName.Location = new Point(254, 37);
        txtName.Margin = new Padding(5);
        txtName.Name = "txtName";
        txtName.Size = new Size(230, 25);
        txtName.TabIndex = 1;
        // 
        // txtMobile
        // 
        txtMobile.BorderStyle = BorderStyle.FixedSingle;
        txtMobile.Font = new Font("Segoe UI", 10F);
        txtMobile.Location = new Point(492, 37);
        txtMobile.Margin = new Padding(7, 22, 7, 7);
        txtMobile.Name = "txtMobile";
        txtMobile.Size = new Size(230, 25);
        txtMobile.TabIndex = 2;
        // 
        // txtBillingAddress
        // 
        txtBillingAddress.BorderStyle = BorderStyle.FixedSingle;
        txtBillingAddress.Font = new Font("Segoe UI", 10F);
        txtBillingAddress.Location = new Point(7, 190);
        txtBillingAddress.Margin = new Padding(7, 22, 7, 7);
        txtBillingAddress.Multiline = true;
        txtBillingAddress.Name = "txtBillingAddress";
        txtBillingAddress.Size = new Size(953, 70);
        txtBillingAddress.TabIndex = 12;
        txtBillingAddress.TextChanged += txtBillingAddress_TextChanged;
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.BackColor = Color.FromArgb(250, 250, 250);
        lblName.ForeColor = Color.FromArgb(75, 85, 99);
        lblName.Location = new Point(258, 11);
        lblName.Margin = new Padding(10, 4, 3, 3);
        lblName.Name = "lblName";
        lblName.Size = new Size(47, 15);
        lblName.TabIndex = 24;
        lblName.Text = "Name *";
        // 
        // txtShippingAddress
        // 
        txtShippingAddress.BorderStyle = BorderStyle.FixedSingle;
        txtShippingAddress.Font = new Font("Segoe UI", 10F);
        txtShippingAddress.Location = new Point(7, 283);
        txtShippingAddress.Margin = new Padding(7, 22, 7, 7);
        txtShippingAddress.Multiline = true;
        txtShippingAddress.Name = "txtShippingAddress";
        txtShippingAddress.Size = new Size(953, 70);
        txtShippingAddress.TabIndex = 13;
        // 
        // cmbState
        // 
        cmbState.AccessibleName = "Select State";
        cmbState.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbState.FlatStyle = FlatStyle.Flat;
        cmbState.Font = new Font("Segoe UI", 10F);
        cmbState.Location = new Point(10, 385);
        cmbState.Margin = new Padding(7, 22, 7, 7);
        cmbState.Name = "cmbState";
        cmbState.Size = new Size(230, 25);
        cmbState.TabIndex = 14;
        cmbState.SelectedIndexChanged += cmbState_SelectedIndexChanged;
        // 
        // cmbCity
        // 
        cmbCity.AccessibleName = "Select City";
        cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbCity.FlatStyle = FlatStyle.Flat;
        cmbCity.Font = new Font("Segoe UI", 10F);
        cmbCity.Location = new Point(272, 385);
        cmbCity.Margin = new Padding(7, 22, 7, 7);
        cmbCity.Name = "cmbCity";
        cmbCity.Size = new Size(248, 25);
        cmbCity.TabIndex = 15;
        // 
        // txtPinCode
        // 
        txtPinCode.BorderStyle = BorderStyle.FixedSingle;
        txtPinCode.Font = new Font("Segoe UI", 10F);
        txtPinCode.Location = new Point(534, 386);
        txtPinCode.Margin = new Padding(7, 22, 7, 7);
        txtPinCode.Name = "txtPinCode";
        txtPinCode.Size = new Size(245, 25);
        txtPinCode.TabIndex = 16;
        // 
        // txtContactPerson
        // 
        txtContactPerson.BorderStyle = BorderStyle.FixedSingle;
        txtContactPerson.Font = new Font("Segoe UI", 10F);
        txtContactPerson.Location = new Point(796, 384);
        txtContactPerson.Margin = new Padding(7, 22, 7, 7);
        txtContactPerson.Name = "txtContactPerson";
        txtContactPerson.Size = new Size(164, 25);
        txtContactPerson.TabIndex = 17;
        // 
        // txtOpeningBalance
        // 
        txtOpeningBalance.BorderStyle = BorderStyle.FixedSingle;
        txtOpeningBalance.Font = new Font("Segoe UI", 10F);
        txtOpeningBalance.Location = new Point(10, 438);
        txtOpeningBalance.Margin = new Padding(7, 22, 7, 7);
        txtOpeningBalance.Name = "txtOpeningBalance";
        txtOpeningBalance.Size = new Size(230, 25);
        txtOpeningBalance.TabIndex = 18;
        txtOpeningBalance.Text = "0";
        // 
        // lblLedgerName
        // 
        lblLedgerName.AutoSize = true;
        lblLedgerName.BackColor = Color.FromArgb(250, 250, 250);
        lblLedgerName.ForeColor = Color.FromArgb(75, 85, 99);
        lblLedgerName.Location = new Point(737, 121);
        lblLedgerName.Margin = new Padding(10, 4, 3, 3);
        lblLedgerName.Name = "lblLedgerName";
        lblLedgerName.Size = new Size(78, 15);
        lblLedgerName.TabIndex = 27;
        lblLedgerName.Text = "Ledger Name";
        // 
        // txtCreditDays
        // 
        txtCreditDays.BorderStyle = BorderStyle.FixedSingle;
        txtCreditDays.Font = new Font("Segoe UI", 10F);
        txtCreditDays.Location = new Point(269, 437);
        txtCreditDays.Margin = new Padding(7, 22, 7, 7);
        txtCreditDays.Name = "txtCreditDays";
        txtCreditDays.Size = new Size(248, 25);
        txtCreditDays.TabIndex = 19;
        txtCreditDays.Text = "90";
        // 
        // txtCreditLimits
        // 
        txtCreditLimits.BorderStyle = BorderStyle.FixedSingle;
        txtCreditLimits.Font = new Font("Segoe UI", 10F);
        txtCreditLimits.Location = new Point(534, 437);
        txtCreditLimits.Margin = new Padding(7, 22, 7, 7);
        txtCreditLimits.Name = "txtCreditLimits";
        txtCreditLimits.Size = new Size(250, 25);
        txtCreditLimits.TabIndex = 20;
        txtCreditLimits.Text = "0";
        // 
        // txtDiscount
        // 
        txtDiscount.BorderStyle = BorderStyle.FixedSingle;
        txtDiscount.Font = new Font("Segoe UI", 10F);
        txtDiscount.Location = new Point(798, 438);
        txtDiscount.Margin = new Padding(7, 22, 7, 7);
        txtDiscount.Name = "txtDiscount";
        txtDiscount.Size = new Size(162, 25);
        txtDiscount.TabIndex = 21;
        txtDiscount.Text = "0";
        // 
        // txtRemarks
        // 
        txtRemarks.BorderStyle = BorderStyle.FixedSingle;
        txtRemarks.Font = new Font("Segoe UI", 10F);
        txtRemarks.Location = new Point(10, 494);
        txtRemarks.Margin = new Padding(7, 22, 7, 7);
        txtRemarks.Multiline = true;
        txtRemarks.Name = "txtRemarks";
        txtRemarks.Size = new Size(950, 70);
        txtRemarks.TabIndex = 22;
        // 
        // lblGSTIN
        // 
        lblGSTIN.AutoSize = true;
        lblGSTIN.BackColor = Color.FromArgb(250, 250, 250);
        lblGSTIN.ForeColor = Color.FromArgb(75, 85, 99);
        lblGSTIN.Location = new Point(493, 71);
        lblGSTIN.Margin = new Padding(10, 4, 3, 3);
        lblGSTIN.Name = "lblGSTIN";
        lblGSTIN.Size = new Size(40, 15);
        lblGSTIN.TabIndex = 29;
        lblGSTIN.Text = "GSTIN";
        // 
        // lblMobile
        // 
        lblMobile.AutoSize = true;
        lblMobile.BackColor = Color.FromArgb(250, 250, 250);
        lblMobile.ForeColor = Color.FromArgb(75, 85, 99);
        lblMobile.Location = new Point(490, 11);
        lblMobile.Margin = new Padding(10, 4, 3, 3);
        lblMobile.Name = "lblMobile";
        lblMobile.Size = new Size(66, 15);
        lblMobile.TabIndex = 34;
        lblMobile.Text = "Mobile No.";
        // 
        // lblPan
        // 
        lblPan.AutoSize = true;
        lblPan.BackColor = Color.FromArgb(250, 250, 250);
        lblPan.ForeColor = Color.FromArgb(75, 85, 99);
        lblPan.Location = new Point(737, 71);
        lblPan.Margin = new Padding(10, 4, 3, 3);
        lblPan.Name = "lblPan";
        lblPan.Size = new Size(30, 15);
        lblPan.TabIndex = 30;
        lblPan.Text = "PAN";
        // 
        // lblBillingAddress
        // 
        lblBillingAddress.AutoSize = true;
        lblBillingAddress.BackColor = Color.FromArgb(250, 250, 250);
        lblBillingAddress.ForeColor = Color.FromArgb(75, 85, 99);
        lblBillingAddress.Location = new Point(10, 172);
        lblBillingAddress.Margin = new Padding(10, 4, 3, 3);
        lblBillingAddress.Name = "lblBillingAddress";
        lblBillingAddress.Size = new Size(85, 15);
        lblBillingAddress.TabIndex = 35;
        lblBillingAddress.Text = "Billing Address";
        // 
        // lblShippingAddress
        // 
        lblShippingAddress.AutoSize = true;
        lblShippingAddress.BackColor = Color.FromArgb(250, 250, 250);
        lblShippingAddress.ForeColor = Color.FromArgb(75, 85, 99);
        lblShippingAddress.Location = new Point(10, 265);
        lblShippingAddress.Margin = new Padding(10, 4, 3, 3);
        lblShippingAddress.Name = "lblShippingAddress";
        lblShippingAddress.Size = new Size(99, 15);
        lblShippingAddress.TabIndex = 36;
        lblShippingAddress.Text = "Shipping Address";
        // 
        // lblPhone
        // 
        lblPhone.AutoSize = true;
        lblPhone.BackColor = Color.FromArgb(250, 250, 250);
        lblPhone.ForeColor = Color.FromArgb(75, 85, 99);
        lblPhone.Location = new Point(13, 71);
        lblPhone.Margin = new Padding(10, 4, 3, 3);
        lblPhone.Name = "lblPhone";
        lblPhone.Size = new Size(63, 15);
        lblPhone.TabIndex = 33;
        lblPhone.Text = "Phone No.";
        // 
        // lblState
        // 
        lblState.AutoSize = true;
        lblState.BackColor = Color.FromArgb(250, 250, 250);
        lblState.ForeColor = Color.FromArgb(75, 85, 99);
        lblState.Location = new Point(10, 367);
        lblState.Margin = new Padding(10, 4, 3, 3);
        lblState.Name = "lblState";
        lblState.Size = new Size(33, 15);
        lblState.TabIndex = 37;
        lblState.Text = "State";
        // 
        // lblCity
        // 
        lblCity.AutoSize = true;
        lblCity.BackColor = Color.FromArgb(250, 250, 250);
        lblCity.ForeColor = Color.FromArgb(75, 85, 99);
        lblCity.Location = new Point(272, 367);
        lblCity.Margin = new Padding(10, 4, 3, 3);
        lblCity.Name = "lblCity";
        lblCity.Size = new Size(36, 15);
        lblCity.TabIndex = 38;
        lblCity.Text = "City *";
        // 
        // lblPinCode
        // 
        lblPinCode.AutoSize = true;
        lblPinCode.BackColor = Color.FromArgb(250, 250, 250);
        lblPinCode.ForeColor = Color.FromArgb(75, 85, 99);
        lblPinCode.Location = new Point(534, 367);
        lblPinCode.Margin = new Padding(10, 4, 3, 3);
        lblPinCode.Name = "lblPinCode";
        lblPinCode.Size = new Size(55, 15);
        lblPinCode.TabIndex = 39;
        lblPinCode.Text = "Pin Code";
        // 
        // lblContactPerson
        // 
        lblContactPerson.AutoSize = true;
        lblContactPerson.BackColor = Color.FromArgb(250, 250, 250);
        lblContactPerson.ForeColor = Color.FromArgb(75, 85, 99);
        lblContactPerson.Location = new Point(796, 367);
        lblContactPerson.Margin = new Padding(10, 4, 3, 3);
        lblContactPerson.Name = "lblContactPerson";
        lblContactPerson.Size = new Size(88, 15);
        lblContactPerson.TabIndex = 40;
        lblContactPerson.Text = "Contact Person";
        // 
        // lblOpeningBalance
        // 
        lblOpeningBalance.AutoSize = true;
        lblOpeningBalance.BackColor = Color.FromArgb(250, 250, 250);
        lblOpeningBalance.ForeColor = Color.FromArgb(75, 85, 99);
        lblOpeningBalance.Location = new Point(10, 420);
        lblOpeningBalance.Margin = new Padding(10, 4, 3, 3);
        lblOpeningBalance.Name = "lblOpeningBalance";
        lblOpeningBalance.Size = new Size(97, 15);
        lblOpeningBalance.TabIndex = 41;
        lblOpeningBalance.Text = "Opening Balance";
        // 
        // lblCreditDays
        // 
        lblCreditDays.AutoSize = true;
        lblCreditDays.BackColor = Color.FromArgb(250, 250, 250);
        lblCreditDays.ForeColor = Color.FromArgb(75, 85, 99);
        lblCreditDays.Location = new Point(272, 420);
        lblCreditDays.Margin = new Padding(10, 4, 3, 3);
        lblCreditDays.Name = "lblCreditDays";
        lblCreditDays.Size = new Size(67, 15);
        lblCreditDays.TabIndex = 42;
        lblCreditDays.Text = "Credit Days";
        // 
        // lblCreditLimit
        // 
        lblCreditLimit.AutoSize = true;
        lblCreditLimit.BackColor = Color.FromArgb(250, 250, 250);
        lblCreditLimit.ForeColor = Color.FromArgb(75, 85, 99);
        lblCreditLimit.Location = new Point(534, 420);
        lblCreditLimit.Margin = new Padding(10, 4, 3, 3);
        lblCreditLimit.Name = "lblCreditLimit";
        lblCreditLimit.Size = new Size(69, 15);
        lblCreditLimit.TabIndex = 43;
        lblCreditLimit.Text = "Credit Limit";
        // 
        // lblDiscount
        // 
        lblDiscount.AutoSize = true;
        lblDiscount.BackColor = Color.FromArgb(250, 250, 250);
        lblDiscount.ForeColor = Color.FromArgb(75, 85, 99);
        lblDiscount.Location = new Point(796, 420);
        lblDiscount.Margin = new Padding(10, 4, 3, 3);
        lblDiscount.Name = "lblDiscount";
        lblDiscount.Size = new Size(54, 15);
        lblDiscount.TabIndex = 44;
        lblDiscount.Text = "Discount";
        // 
        // lblRemarks
        // 
        lblRemarks.AutoSize = true;
        lblRemarks.BackColor = Color.FromArgb(250, 250, 250);
        lblRemarks.ForeColor = Color.FromArgb(75, 85, 99);
        lblRemarks.Location = new Point(10, 473);
        lblRemarks.Margin = new Padding(10, 4, 3, 3);
        lblRemarks.Name = "lblRemarks";
        lblRemarks.Size = new Size(52, 15);
        lblRemarks.TabIndex = 45;
        lblRemarks.Text = "Remarks";
        // 
        // CustomerAddForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(969, 616);
        Controls.Add(pnlContent);
        Controls.Add(pnlHeader);
        Font = new Font("Segoe UI", 9F);
        MinimumSize = new Size(900, 620);
        Name = "CustomerAddForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Customer Information";
        Load += CustomerAddForm_Load;
        pnlHeader.ResumeLayout(false);
        pnlHeader.PerformLayout();
        pnlContent.ResumeLayout(false);
        pnlContent.PerformLayout();
        ResumeLayout(false);
    }

    private Panel pnlHeader = null!, pnlContent = null!;
    private Label lblTitle = null!;
    private ComboBox cmbCustomerType = null!, cmbRegistrationType = null!, cmbState = null!, cmbCity = null!;
    private Label lblCustomerType = null!, lblName = null!, lblPrintName = null!, lblAlias = null!, lblLedgerName = null!, lblGroupName = null!, lblGSTIN = null!, lblPan = null!, lblRegistrationType = null!, lblEmail = null!, lblPhone = null!, lblMobile = null!, lblBillingAddress = null!, lblShippingAddress = null!, lblState = null!, lblCity = null!, lblPinCode = null!, lblContactPerson = null!, lblOpeningBalance = null!, lblCreditDays = null!, lblCreditLimit = null!, lblDiscount = null!, lblRemarks = null!;
    private TextBox txtName = null!;
    private TextBox txtPrintName = null!;
    private TextBox txtAlias = null!;
    private TextBox txtLedgerName = null!;
    private TextBox txtGroupName = null!;
    private TextBox txtGSTIN = null!;
    private TextBox txtPan = null!;
    private TextBox txtEmail = null!;
    private TextBox txtPhone = null!;
    private TextBox txtMobile = null!;
    private TextBox txtBillingAddress = null!;
    private TextBox txtShippingAddress = null!;
    private TextBox txtPinCode = null!;
    private TextBox txtContactPerson = null!;
    private TextBox txtOpeningBalance = null!;
    private TextBox txtCreditDays = null!;
    private TextBox txtCreditLimits = null!;
    private TextBox txtDiscount = null!;
    private TextBox txtRemarks = null!;
    private Win.Shared.Controls.ERPButton btnSave;
    private Win.Shared.Controls.ERPButton btnClose;
    // private Win.Shared.Controls.ERPButton btnSave;
    //  private Win.Shared.Controls.ERPButton btnSave;
    //private Win.Shared.Controls.ERPTextBox txtName;
}
