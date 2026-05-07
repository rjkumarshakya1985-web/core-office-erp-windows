namespace CoreOffice.Win.Modules.PackingSlip
{
    partial class FrmPackingSlip
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            label6 = new Label();
            label1 = new Label();
            cmbSalesPerson = new ComboBox();
            panel4 = new Panel();
            panel9 = new Panel();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblTotalPcs = new Label();
            label3 = new Label();
            lblTotalAmount = new Label();
            lblTaxableAmount = new Label();
            lbl = new Label();
            lblTotalPcsControl = new Label();
            groupBox2 = new GroupBox();
            lblDiscount = new Label();
            label7 = new Label();
            lblVisitorType = new Label();
            lblPhone = new Label();
            lblCompanyName = new Label();
            lblVisitorControl = new Label();
            lblPhoneControl = new Label();
            lblName = new Label();
            panel2 = new Panel();
            dataGridPackingSlip = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Barcode = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Rate = new DataGridViewTextBoxColumn();
            Taxable = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            NetTaxable = new DataGridViewTextBoxColumn();
            GstValue = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            AvailableQty = new DataGridViewTextBoxColumn();
            panel10 = new Panel();
            btnPendingPackingSlips = new Button();
            btnClear = new Button();
            btnClose = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnVisitor = new Button();
            btnUpdate = new Button();
            btnRemoved = new Button();
            pnlBarcode = new Panel();
            btnEnter = new Button();
            txtBarcodeScanner = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            pnlHeader.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPackingSlip).BeginInit();
            panel10.SuspendLayout();
            pnlBarcode.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(18, 45, 90);
            pnlHeader.BorderStyle = BorderStyle.Fixed3D;
            pnlHeader.Controls.Add(label6);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(cmbSalesPerson);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1174, 53);
            pnlHeader.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(749, 12);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 1;
            label6.Text = "Select Sales Person";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 11);
            label1.Name = "label1";
            label1.Size = new Size(437, 25);
            label1.TabIndex = 0;
            label1.Text = "SHIV SAHAI BHAGWAN  DAS SAREES PVT. LTD. ";
            // 
            // cmbSalesPerson
            // 
            cmbSalesPerson.Font = new Font("Segoe UI", 11.25F);
            cmbSalesPerson.FormattingEnabled = true;
            cmbSalesPerson.Location = new Point(903, 8);
            cmbSalesPerson.Name = "cmbSalesPerson";
            cmbSalesPerson.Size = new Size(240, 28);
            cmbSalesPerson.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 330);
            panel4.Name = "panel4";
            panel4.Size = new Size(1174, 125);
            panel4.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.Controls.Add(groupBox3);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(394, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(418, 125);
            panel9.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(textBox1);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.FlatStyle = FlatStyle.Popup;
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(30, 70, 150);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(10, 5, 5, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 5, 5, 5);
            groupBox3.Size = new Size(412, 125);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Notes";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(8, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter notes (optional)....";
            textBox1.Size = new Size(380, 95);
            textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblTotalPcs);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblTotalAmount);
            groupBox1.Controls.Add(lblTaxableAmount);
            groupBox1.Controls.Add(lbl);
            groupBox1.Controls.Add(lblTotalPcsControl);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(40, 90, 200);
            groupBox1.Location = new Point(812, 0);
            groupBox1.Margin = new Padding(10, 5, 5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 5, 5, 5);
            groupBox1.Size = new Size(362, 125);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Packing Slip Summary";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(164, 32);
            label8.Name = "label8";
            label8.Size = new Size(17, 19);
            label8.TabIndex = 10;
            label8.Text = "₹";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(164, 91);
            label4.Name = "label4";
            label4.Size = new Size(17, 19);
            label4.TabIndex = 9;
            label4.Text = "₹";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(19, 70);
            label2.Name = "label2";
            label2.Size = new Size(327, 19);
            label2.TabIndex = 8;
            label2.Text = "-----------------------------------------------------";
            // 
            // lblTotalPcs
            // 
            lblTotalPcs.AutoSize = true;
            lblTotalPcs.Font = new Font("Segoe UI", 10F);
            lblTotalPcs.ForeColor = Color.Black;
            lblTotalPcs.Location = new Point(178, 50);
            lblTotalPcs.Name = "lblTotalPcs";
            lblTotalPcs.Size = new Size(30, 19);
            lblTotalPcs.TabIndex = 7;
            lblTotalPcs.Text = ".......";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(19, 51);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 6;
            label3.Text = "Total Pcs :";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(178, 91);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(37, 19);
            lblTotalAmount.TabIndex = 5;
            lblTotalAmount.Text = ".......";
            // 
            // lblTaxableAmount
            // 
            lblTaxableAmount.AutoSize = true;
            lblTaxableAmount.Font = new Font("Segoe UI", 10F);
            lblTaxableAmount.ForeColor = Color.Black;
            lblTaxableAmount.Location = new Point(178, 32);
            lblTaxableAmount.Name = "lblTaxableAmount";
            lblTaxableAmount.Size = new Size(30, 19);
            lblTaxableAmount.TabIndex = 4;
            lblTaxableAmount.Text = ".......";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl.Location = new Point(23, 91);
            lbl.Name = "lbl";
            lbl.Size = new Size(95, 19);
            lbl.TabIndex = 1;
            lbl.Text = "Grand Total :";
            // 
            // lblTotalPcsControl
            // 
            lblTotalPcsControl.AutoSize = true;
            lblTotalPcsControl.Font = new Font("Segoe UI", 10F);
            lblTotalPcsControl.ForeColor = Color.Black;
            lblTotalPcsControl.Location = new Point(19, 31);
            lblTotalPcsControl.Name = "lblTotalPcsControl";
            lblTotalPcsControl.Size = new Size(139, 19);
            lblTotalPcsControl.TabIndex = 0;
            lblTotalPcsControl.Text = "Taxable Net Amount :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(lblDiscount);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblVisitorType);
            groupBox2.Controls.Add(lblPhone);
            groupBox2.Controls.Add(lblCompanyName);
            groupBox2.Controls.Add(lblVisitorControl);
            groupBox2.Controls.Add(lblPhoneControl);
            groupBox2.Controls.Add(lblName);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(30, 70, 150);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(10, 5, 5, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 5, 5, 5);
            groupBox2.Size = new Size(394, 125);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Visitor Information";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lblDiscount.Location = new Point(133, 101);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(30, 19);
            lblDiscount.TabIndex = 7;
            lblDiscount.Text = ".......";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(58, 101);
            label7.Name = "label7";
            label7.Size = new Size(70, 19);
            label7.TabIndex = 6;
            label7.Text = "Discount :";
            // 
            // lblVisitorType
            // 
            lblVisitorType.AutoSize = true;
            lblVisitorType.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lblVisitorType.Location = new Point(133, 75);
            lblVisitorType.Name = "lblVisitorType";
            lblVisitorType.Size = new Size(30, 19);
            lblVisitorType.TabIndex = 5;
            lblVisitorType.Text = ".......";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lblPhone.Location = new Point(133, 48);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(30, 19);
            lblPhone.TabIndex = 4;
            lblPhone.Text = ".......";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            lblCompanyName.Location = new Point(133, 24);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(30, 19);
            lblCompanyName.TabIndex = 3;
            lblCompanyName.Text = ".......";
            // 
            // lblVisitorControl
            // 
            lblVisitorControl.AutoSize = true;
            lblVisitorControl.Font = new Font("Segoe UI", 10F);
            lblVisitorControl.Location = new Point(34, 75);
            lblVisitorControl.Name = "lblVisitorControl";
            lblVisitorControl.Size = new Size(94, 19);
            lblVisitorControl.TabIndex = 2;
            lblVisitorControl.Text = "Visitory Type :";
            // 
            // lblPhoneControl
            // 
            lblPhoneControl.AutoSize = true;
            lblPhoneControl.Font = new Font("Segoe UI", 10F);
            lblPhoneControl.Location = new Point(73, 50);
            lblPhoneControl.Name = "lblPhoneControl";
            lblPhoneControl.Size = new Size(55, 19);
            lblPhoneControl.TabIndex = 1;
            lblPhoneControl.Text = "Phone :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(4, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(124, 19);
            lblName.TabIndex = 0;
            lblName.Text = "Name / Company :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 45, 90);
            panel2.Controls.Add(dataGridPackingSlip);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(1174, 537);
            panel2.TabIndex = 3;
            // 
            // dataGridPackingSlip
            // 
            dataGridPackingSlip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPackingSlip.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridPackingSlip.BackgroundColor = Color.White;
            dataGridPackingSlip.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(25, 55, 109);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridPackingSlip.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridPackingSlip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPackingSlip.Columns.AddRange(new DataGridViewColumn[] { Id, Barcode, Product, Quantity, Rate, Taxable, Discount, NetTaxable, GstValue, Amount, AvailableQty });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.Window;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(220, 230, 250);
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridPackingSlip.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridPackingSlip.Dock = DockStyle.Top;
            dataGridPackingSlip.EnableHeadersVisualStyles = false;
            dataGridPackingSlip.GridColor = Color.Gainsboro;
            dataGridPackingSlip.Location = new Point(0, 0);
            dataGridPackingSlip.Name = "dataGridPackingSlip";
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridPackingSlip.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridPackingSlip.RowTemplate.Height = 40;
            dataGridPackingSlip.Size = new Size(1174, 269);
            dataGridPackingSlip.TabIndex = 2;
            dataGridPackingSlip.CellDoubleClick += dataGridPackingSlip_CellDoubleClick;
            dataGridPackingSlip.RowEnter += dataGridPackingSlip_RowEnter;
            dataGridPackingSlip.KeyDown += dataGridPackingSlip_KeyDown;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // Barcode
            // 
            Barcode.HeaderText = "Barcode";
            Barcode.Name = "Barcode";
            Barcode.ReadOnly = true;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Qty";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Rate
            // 
            Rate.HeaderText = "Rate";
            Rate.Name = "Rate";
            // 
            // Taxable
            // 
            Taxable.HeaderText = "Taxable";
            Taxable.Name = "Taxable";
            Taxable.ReadOnly = true;
            // 
            // Discount
            // 
            Discount.HeaderText = "Discount";
            Discount.Name = "Discount";
            // 
            // NetTaxable
            // 
            NetTaxable.HeaderText = "Net Taxable";
            NetTaxable.Name = "NetTaxable";
            // 
            // GstValue
            // 
            GstValue.HeaderText = "Gst %";
            GstValue.Name = "GstValue";
            GstValue.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // AvailableQty
            // 
            AvailableQty.HeaderText = "AvailableQty";
            AvailableQty.Name = "AvailableQty";
            AvailableQty.Visible = false;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(btnPendingPackingSlips);
            panel10.Controls.Add(btnClear);
            panel10.Controls.Add(btnClose);
            panel10.Controls.Add(btnSave);
            panel10.Controls.Add(btnDelete);
            panel10.Controls.Add(btnVisitor);
            panel10.Controls.Add(btnUpdate);
            panel10.Controls.Add(btnRemoved);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 63);
            panel10.Name = "panel10";
            panel10.Size = new Size(1174, 72);
            panel10.TabIndex = 10;
            // 
            // btnPendingPackingSlips
            // 
            btnPendingPackingSlips.BackColor = Color.FromArgb(124, 58, 237);
            btnPendingPackingSlips.FlatAppearance.BorderSize = 0;
            btnPendingPackingSlips.FlatStyle = FlatStyle.Flat;
            btnPendingPackingSlips.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPendingPackingSlips.ForeColor = Color.White;
            btnPendingPackingSlips.Location = new Point(867, 9);
            btnPendingPackingSlips.Name = "btnPendingPackingSlips";
            btnPendingPackingSlips.Size = new Size(179, 50);
            btnPendingPackingSlips.TabIndex = 12;
            btnPendingPackingSlips.Text = "Pending Packing Slip List";
            btnPendingPackingSlips.UseVisualStyleBackColor = false;
            btnPendingPackingSlips.Click += btnPendingPackingSlips_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(107, 114, 128);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(236, 9);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 50);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(55, 65, 81);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(351, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 50);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RoyalBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(121, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 50);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(581, 9);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 50);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnVisitor
            // 
            btnVisitor.FlatStyle = FlatStyle.Flat;
            btnVisitor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVisitor.ImageAlign = ContentAlignment.MiddleLeft;
            btnVisitor.Location = new Point(6, 10);
            btnVisitor.Name = "btnVisitor";
            btnVisitor.Size = new Size(109, 50);
            btnVisitor.TabIndex = 4;
            btnVisitor.Text = "Visitor";
            btnVisitor.UseVisualStyleBackColor = true;
            btnVisitor.Click += btnVisitor_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(245, 158, 11);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(466, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 50);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Edit Bill";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemoved
            // 
            btnRemoved.BackColor = Color.FromArgb(220, 38, 38);
            btnRemoved.FlatAppearance.BorderSize = 0;
            btnRemoved.FlatStyle = FlatStyle.Flat;
            btnRemoved.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoved.ForeColor = Color.White;
            btnRemoved.Location = new Point(696, 10);
            btnRemoved.Name = "btnRemoved";
            btnRemoved.Size = new Size(165, 50);
            btnRemoved.TabIndex = 7;
            btnRemoved.Text = "Removed Product";
            btnRemoved.UseVisualStyleBackColor = false;
            btnRemoved.Click += btnRemoved_Click;
            // 
            // pnlBarcode
            // 
            pnlBarcode.BackColor = Color.FromArgb(18, 45, 90);
            pnlBarcode.BorderStyle = BorderStyle.Fixed3D;
            pnlBarcode.Controls.Add(btnEnter);
            pnlBarcode.Controls.Add(txtBarcodeScanner);
            pnlBarcode.Controls.Add(label5);
            pnlBarcode.Dock = DockStyle.Top;
            pnlBarcode.Location = new Point(0, 0);
            pnlBarcode.Name = "pnlBarcode";
            pnlBarcode.Size = new Size(1174, 66);
            pnlBarcode.TabIndex = 3;
            // 
            // btnEnter
            // 
            btnEnter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEnter.Location = new Point(721, 15);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(109, 32);
            btnEnter.TabIndex = 13;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtBarcodeScanner
            // 
            txtBarcodeScanner.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBarcodeScanner.Location = new Point(169, 15);
            txtBarcodeScanner.Name = "txtBarcodeScanner";
            txtBarcodeScanner.Size = new Size(546, 32);
            txtBarcodeScanner.TabIndex = 4;
            txtBarcodeScanner.KeyDown += txtBarcodeScanner_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(4, 18);
            label5.Name = "label5";
            label5.Size = new Size(169, 25);
            label5.TabIndex = 3;
            label5.Text = "Barcode Scanner :";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(pnlBarcode);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 455);
            panel3.Name = "panel3";
            panel3.Size = new Size(1174, 135);
            panel3.TabIndex = 4;
            // 
            // FrmPackingSlip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 590);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmPackingSlip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPackingSlip";
            WindowState = FormWindowState.Maximized;
            Load += FrmPackingSlip_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPackingSlip).EndInit();
            panel10.ResumeLayout(false);
            pnlBarcode.ResumeLayout(false);
            pnlBarcode.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlHeader;
        private Panel panel4;
        private Label label1;
        private Label label4;
        private Panel panel7;
        private Panel panel2;
        private Panel panel9;
        private GroupBox groupBox1;
        private Label lblTotalPcs;
        private Label label3;
        private Label lblTotalAmount;
        private Label lblTaxableAmount;
        private Label lbl;
        private Label lblTotalPcsControl;
        private GroupBox groupBox2;
        private Label lblVisitorType;
        private Label lblPhone;
        private Label lblCompanyName;
        private Label lblVisitorControl;
        private Label lblPhoneControl;
        private Label lblName;
        private DataGridView dataGridPackingSlip;
        private Label lblDiscount;
        private Label label7;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Rate;
        private DataGridViewTextBoxColumn Taxable;
        private DataGridViewTextBoxColumn Discount;
        private DataGridViewTextBoxColumn NetTaxable;
        private DataGridViewTextBoxColumn GstValue;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn AvailableQty;
        private Label label2;
        private Label label8;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private Panel panel10;
        private Button btnPendingPackingSlips;
        private Button btnClear;
        private Button btnClose;
        private Button btnSave;
        private Button btnDelete;
        private Button btnVisitor;
        private Button btnUpdate;
        private Button btnRemoved;
        private Panel pnlBarcode;
        private Label label6;
        private ComboBox cmbSalesPerson;
        private TextBox txtBarcodeScanner;
        private Label label5;
        private Panel panel3;
        private Button btnEnter;
    }
}