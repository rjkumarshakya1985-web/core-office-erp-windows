namespace CoreOffice.Win.Modules.MasterData
{
    partial class VistiorCustomerForm
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
            panel10 = new Panel();
            label4 = new Label();
            groupBox1 = new GroupBox();
            cmbCustomerType = new ComboBox();
            Type = new Label();
            cmbRegistrationType = new ComboBox();
            cmbCity = new ComboBox();
            cmbState = new ComboBox();
            txtContactPerson = new TextBox();
            label18 = new Label();
            txtPinCode = new TextBox();
            label15 = new Label();
            label17 = new Label();
            label16 = new Label();
            txtShippingAddress = new TextBox();
            label14 = new Label();
            txtBillingAddress = new TextBox();
            label13 = new Label();
            txtMobile = new TextBox();
            label12 = new Label();
            txtPhoneno = new TextBox();
            label11 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtPanNo = new TextBox();
            label8 = new Label();
            txtGSTIN = new TextBox();
            label7 = new Label();
            txtGroupName = new TextBox();
            label6 = new Label();
            txtLedgerName = new TextBox();
            label5 = new Label();
            txtAlias = new TextBox();
            label3 = new Label();
            txtPrintName = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnCreate = new Button();
            btnClose = new Button();
            txtCreditLimits = new TextBox();
            label19 = new Label();
            txtCreditDays = new TextBox();
            label20 = new Label();
            panel10.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ActiveCaption;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label4);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(924, 43);
            panel10.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 11);
            label4.Name = "label4";
            label4.Size = new Size(148, 20);
            label4.TabIndex = 0;
            label4.Text = "Visitor To Customer";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCreditLimits);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(txtCreditDays);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(cmbCustomerType);
            groupBox1.Controls.Add(Type);
            groupBox1.Controls.Add(cmbRegistrationType);
            groupBox1.Controls.Add(cmbCity);
            groupBox1.Controls.Add(cmbState);
            groupBox1.Controls.Add(txtContactPerson);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(txtPinCode);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(txtShippingAddress);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(txtBillingAddress);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtMobile);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtPhoneno);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPanNo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtGSTIN);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtGroupName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtLedgerName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtAlias);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPrintName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(924, 419);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Information";
            // 
            // cmbCustomerType
            // 
            cmbCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomerType.FormattingEnabled = true;
            cmbCustomerType.Location = new Point(95, 23);
            cmbCustomerType.Name = "cmbCustomerType";
            cmbCustomerType.Size = new Size(212, 23);
            cmbCustomerType.TabIndex = 40;
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Location = new Point(7, 26);
            Type.Name = "Type";
            Type.Size = new Size(86, 15);
            Type.TabIndex = 39;
            Type.Text = "Customer Type";
            // 
            // cmbRegistrationType
            // 
            cmbRegistrationType.FormattingEnabled = true;
            cmbRegistrationType.Location = new Point(424, 126);
            cmbRegistrationType.Name = "cmbRegistrationType";
            cmbRegistrationType.Size = new Size(217, 23);
            cmbRegistrationType.TabIndex = 38;
            // 
            // cmbCity
            // 
            cmbCity.FormattingEnabled = true;
            cmbCity.Location = new Point(423, 184);
            cmbCity.Name = "cmbCity";
            cmbCity.Size = new Size(217, 23);
            cmbCity.TabIndex = 37;
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(90, 184);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(217, 23);
            cmbState.TabIndex = 36;
            // 
            // txtContactPerson
            // 
            txtContactPerson.Location = new Point(122, 370);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.Size = new Size(216, 23);
            txtContactPerson.TabIndex = 35;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(28, 373);
            label18.Name = "label18";
            label18.Size = new Size(88, 15);
            label18.TabIndex = 34;
            label18.Text = "Contact Person";
            // 
            // txtPinCode
            // 
            txtPinCode.Location = new Point(702, 184);
            txtPinCode.Name = "txtPinCode";
            txtPinCode.Size = new Size(216, 23);
            txtPinCode.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(642, 188);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 32;
            label15.Text = "Pin Code";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(351, 188);
            label17.Name = "label17";
            label17.Size = new Size(62, 15);
            label17.TabIndex = 30;
            label17.Text = "Select City";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 184);
            label16.Name = "label16";
            label16.Size = new Size(67, 15);
            label16.TabIndex = 28;
            label16.Text = "Select State";
            // 
            // txtShippingAddress
            // 
            txtShippingAddress.Location = new Point(122, 310);
            txtShippingAddress.Multiline = true;
            txtShippingAddress.Name = "txtShippingAddress";
            txtShippingAddress.Size = new Size(796, 54);
            txtShippingAddress.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 313);
            label14.Name = "label14";
            label14.Size = new Size(99, 15);
            label14.TabIndex = 24;
            label14.Text = "Shipping Address";
            // 
            // txtBillingAddress
            // 
            txtBillingAddress.Location = new Point(122, 246);
            txtBillingAddress.Multiline = true;
            txtBillingAddress.Name = "txtBillingAddress";
            txtBillingAddress.Size = new Size(796, 54);
            txtBillingAddress.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(29, 249);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 22;
            label13.Text = "Billing Address";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(422, 155);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(219, 23);
            txtMobile.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(351, 159);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 20;
            label12.Text = "Mobile No";
            // 
            // txtPhoneno
            // 
            txtPhoneno.Location = new Point(91, 152);
            txtPhoneno.Name = "txtPhoneno";
            txtPhoneno.Size = new Size(216, 23);
            txtPhoneno.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 155);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 18;
            label11.Text = "Phone no";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(702, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 23);
            txtEmail.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(659, 133);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 16;
            label10.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(315, 129);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 14;
            label9.Text = "Registration Type";
            // 
            // txtPanNo
            // 
            txtPanNo.Location = new Point(91, 123);
            txtPanNo.Name = "txtPanNo";
            txtPanNo.Size = new Size(216, 23);
            txtPanNo.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 126);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 12;
            label8.Text = "PAN No";
            // 
            // txtGSTIN
            // 
            txtGSTIN.Location = new Point(702, 97);
            txtGSTIN.Name = "txtGSTIN";
            txtGSTIN.Size = new Size(216, 23);
            txtGSTIN.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(656, 102);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 10;
            label7.Text = "GSTIN";
            // 
            // txtGroupName
            // 
            txtGroupName.Location = new Point(423, 96);
            txtGroupName.Name = "txtGroupName";
            txtGroupName.Size = new Size(216, 23);
            txtGroupName.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(336, 101);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 8;
            label6.Text = "Group Name";
            // 
            // txtLedgerName
            // 
            txtLedgerName.Location = new Point(91, 94);
            txtLedgerName.Name = "txtLedgerName";
            txtLedgerName.Size = new Size(216, 23);
            txtLedgerName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 97);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 6;
            label5.Text = "Ledger Name";
            // 
            // txtAlias
            // 
            txtAlias.Location = new Point(702, 68);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(216, 23);
            txtAlias.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(660, 72);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Alias";
            // 
            // txtPrintName
            // 
            txtPrintName.Location = new Point(422, 66);
            txtPrintName.Name = "txtPrintName";
            txtPrintName.Size = new Size(216, 23);
            txtPrintName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 72);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Print Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 65);
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 69);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 50);
            panel1.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(155, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(137, 40);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "&Create Supplier";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(12, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // txtCreditLimits
            // 
            txtCreditLimits.Location = new Point(421, 214);
            txtCreditLimits.Name = "txtCreditLimits";
            txtCreditLimits.Size = new Size(216, 23);
            txtCreditLimits.TabIndex = 44;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(342, 218);
            label19.Name = "label19";
            label19.Size = new Size(74, 15);
            label19.TabIndex = 43;
            label19.Text = "Credit Limits";
            // 
            // txtCreditDays
            // 
            txtCreditDays.Location = new Point(90, 213);
            txtCreditDays.Name = "txtCreditDays";
            txtCreditDays.Size = new Size(216, 23);
            txtCreditDays.TabIndex = 42;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(18, 217);
            label20.Name = "label20";
            label20.Size = new Size(67, 15);
            label20.TabIndex = 41;
            label20.Text = "Credit Days";
            // 
            // VistiorCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 531);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "VistiorCustomerForm";
            Text = "Vistior Customer";
            Load += VistiorCustomerForm_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel10;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtName;
        private Label label1;
        private TextBox txtPrintName;
        private Label label2;
        private TextBox txtMobile;
        private Label label12;
        private TextBox txtPhoneno;
        private Label label11;
        private TextBox txtEmail;
        private Label label10;
        private Label label9;
        private TextBox txtPanNo;
        private Label label8;
        private TextBox txtGSTIN;
        private Label label7;
        private TextBox txtGroupName;
        private Label label6;
        private TextBox txtLedgerName;
        private Label label5;
        private TextBox txtAlias;
        private Label label3;
        private TextBox txtShippingAddress;
        private Label label14;
        private TextBox txtBillingAddress;
        private Label label13;
        private TextBox txtPinCode;
        private Label label15;
        private Label label17;
        private Label label16;
        private TextBox txtContactPerson;
        private Label label18;
        private Panel panel1;
        private ComboBox cmbCity;
        private ComboBox cmbState;
        private ComboBox cmbRegistrationType;
        private Button btnCreate;
        private Button btnClose;
        private ComboBox cmbCustomerType;
        private Label Type;
        private TextBox txtCreditLimits;
        private Label label19;
        private TextBox txtCreditDays;
        private Label label20;
    }
}