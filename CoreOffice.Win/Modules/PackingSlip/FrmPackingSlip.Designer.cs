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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            btnPendingPackingSlips = new Button();
            btnClear = new Button();
            btnClose = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            btnVisitor = new Button();
            btnUpdate = new Button();
            btnRemoved = new Button();
            panel5 = new Panel();
            panel8 = new Panel();
            label6 = new Label();
            cmbSalesPerson = new ComboBox();
            txtBarcodeScanner = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            panel9 = new Panel();
            groupBox1 = new GroupBox();
            lblGrandTotal = new Label();
            lblTotalPcs = new Label();
            lblGrandTotalControl = new Label();
            lblTotalPcsControl = new Label();
            groupBox2 = new GroupBox();
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
            ProductCategory = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            AvailableQty = new DataGridViewTextBoxColumn();
            GstValue = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPackingSlip).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 53);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 10);
            label1.Name = "label1";
            label1.Size = new Size(437, 25);
            label1.TabIndex = 0;
            label1.Text = "SHIV SAHAI BHAGWAN  DAS SAREES PVT. LTD. ";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 387);
            panel3.Name = "panel3";
            panel3.Size = new Size(1174, 203);
            panel3.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 0, 0);
            panel6.Controls.Add(panel11);
            panel6.Controls.Add(panel10);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 50);
            panel6.Name = "panel6";
            panel6.Size = new Size(1174, 153);
            panel6.TabIndex = 4;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(64, 64, 64);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 61);
            panel11.Name = "panel11";
            panel11.Size = new Size(1174, 92);
            panel11.TabIndex = 11;
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
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1174, 61);
            panel10.TabIndex = 10;
            // 
            // btnPendingPackingSlips
            // 
            btnPendingPackingSlips.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPendingPackingSlips.Location = new Point(733, 6);
            btnPendingPackingSlips.Name = "btnPendingPackingSlips";
            btnPendingPackingSlips.Size = new Size(179, 48);
            btnPendingPackingSlips.TabIndex = 12;
            btnPendingPackingSlips.Text = "Pending Packing Slip List";
            btnPendingPackingSlips.UseVisualStyleBackColor = true;
            btnPendingPackingSlips.Click += btnPendingPackingSlips_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.Location = new Point(122, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(106, 50);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.Location = new Point(405, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 50);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 192, 255);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(513, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 48);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(919, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(159, 48);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnVisitor
            // 
            btnVisitor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVisitor.Location = new Point(6, 6);
            btnVisitor.Name = "btnVisitor";
            btnVisitor.Size = new Size(109, 50);
            btnVisitor.TabIndex = 4;
            btnVisitor.Text = "Visitor";
            btnVisitor.UseVisualStyleBackColor = true;
            btnVisitor.Click += btnVisitor_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(607, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 48);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Edit Bill";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemoved
            // 
            btnRemoved.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRemoved.Location = new Point(234, 5);
            btnRemoved.Name = "btnRemoved";
            btnRemoved.Size = new Size(165, 50);
            btnRemoved.TabIndex = 7;
            btnRemoved.Text = "Removed Product";
            btnRemoved.UseVisualStyleBackColor = true;
            btnRemoved.Click += btnRemoved_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(txtBarcodeScanner);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1174, 50);
            panel5.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Controls.Add(label6);
            panel8.Controls.Add(cmbSalesPerson);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(731, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(439, 46);
            panel8.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(30, 11);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 1;
            label6.Text = "Select Sales Person";
            // 
            // cmbSalesPerson
            // 
            cmbSalesPerson.Font = new Font("Segoe UI", 11.25F);
            cmbSalesPerson.FormattingEnabled = true;
            cmbSalesPerson.Location = new Point(184, 7);
            cmbSalesPerson.Name = "cmbSalesPerson";
            cmbSalesPerson.Size = new Size(240, 28);
            cmbSalesPerson.TabIndex = 0;
            // 
            // txtBarcodeScanner
            // 
            txtBarcodeScanner.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBarcodeScanner.Location = new Point(179, 6);
            txtBarcodeScanner.Name = "txtBarcodeScanner";
            txtBarcodeScanner.Size = new Size(546, 35);
            txtBarcodeScanner.TabIndex = 4;
            txtBarcodeScanner.KeyDown += txtBarcodeScanner_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(8, 9);
            label5.Name = "label5";
            label5.Size = new Size(169, 25);
            label5.TabIndex = 3;
            label5.Text = "Barcode Scanner :";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 262);
            panel4.Name = "panel4";
            panel4.Size = new Size(1174, 125);
            panel4.TabIndex = 5;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(394, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(415, 125);
            panel9.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(lblGrandTotal);
            groupBox1.Controls.Add(lblTotalPcs);
            groupBox1.Controls.Add(lblGrandTotalControl);
            groupBox1.Controls.Add(lblTotalPcsControl);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(809, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 125);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Packing Slip Information";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI", 14.25F);
            lblGrandTotal.Location = new Point(144, 57);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(40, 25);
            lblGrandTotal.TabIndex = 5;
            lblGrandTotal.Text = ".......";
            // 
            // lblTotalPcs
            // 
            lblTotalPcs.AutoSize = true;
            lblTotalPcs.Font = new Font("Segoe UI", 14.25F);
            lblTotalPcs.Location = new Point(143, 29);
            lblTotalPcs.Name = "lblTotalPcs";
            lblTotalPcs.Size = new Size(40, 25);
            lblTotalPcs.TabIndex = 4;
            lblTotalPcs.Text = ".......";
            // 
            // lblGrandTotalControl
            // 
            lblGrandTotalControl.AutoSize = true;
            lblGrandTotalControl.Font = new Font("Segoe UI", 14.25F);
            lblGrandTotalControl.Location = new Point(22, 57);
            lblGrandTotalControl.Name = "lblGrandTotalControl";
            lblGrandTotalControl.Size = new Size(118, 25);
            lblGrandTotalControl.TabIndex = 1;
            lblGrandTotalControl.Text = "Grand Total :";
            // 
            // lblTotalPcsControl
            // 
            lblTotalPcsControl.AutoSize = true;
            lblTotalPcsControl.Font = new Font("Segoe UI", 14.25F);
            lblTotalPcsControl.Location = new Point(46, 29);
            lblTotalPcsControl.Name = "lblTotalPcsControl";
            lblTotalPcsControl.Size = new Size(93, 25);
            lblTotalPcsControl.TabIndex = 0;
            lblTotalPcsControl.Text = "Total Pcs :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonHighlight;
            groupBox2.Controls.Add(lblVisitorType);
            groupBox2.Controls.Add(lblPhone);
            groupBox2.Controls.Add(lblCompanyName);
            groupBox2.Controls.Add(lblVisitorControl);
            groupBox2.Controls.Add(lblPhoneControl);
            groupBox2.Controls.Add(lblName);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(394, 125);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Visitor Information";
            // 
            // lblVisitorType
            // 
            lblVisitorType.AutoSize = true;
            lblVisitorType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVisitorType.Location = new Point(196, 85);
            lblVisitorType.Name = "lblVisitorType";
            lblVisitorType.Size = new Size(40, 25);
            lblVisitorType.TabIndex = 5;
            lblVisitorType.Text = ".......";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(194, 52);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(40, 25);
            lblPhone.TabIndex = 4;
            lblPhone.Text = ".......";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompanyName.Location = new Point(193, 23);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(40, 25);
            lblCompanyName.TabIndex = 3;
            lblCompanyName.Text = ".......";
            // 
            // lblVisitorControl
            // 
            lblVisitorControl.AutoSize = true;
            lblVisitorControl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVisitorControl.Location = new Point(62, 85);
            lblVisitorControl.Name = "lblVisitorControl";
            lblVisitorControl.Size = new Size(128, 25);
            lblVisitorControl.TabIndex = 2;
            lblVisitorControl.Text = "Visitory Type :";
            // 
            // lblPhoneControl
            // 
            lblPhoneControl.AutoSize = true;
            lblPhoneControl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneControl.Location = new Point(115, 53);
            lblPhoneControl.Name = "lblPhoneControl";
            lblPhoneControl.Size = new Size(75, 25);
            lblPhoneControl.TabIndex = 1;
            lblPhoneControl.Text = "Phone :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(22, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(168, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name / Company :";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridPackingSlip);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(1174, 209);
            panel2.TabIndex = 3;
            // 
            // dataGridPackingSlip
            // 
            dataGridPackingSlip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPackingSlip.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridPackingSlip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPackingSlip.Columns.AddRange(new DataGridViewColumn[] { Id, Barcode, ProductCategory, Product, Quantity, Amount, Total, AvailableQty, GstValue });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridPackingSlip.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridPackingSlip.Dock = DockStyle.Fill;
            dataGridPackingSlip.Location = new Point(0, 0);
            dataGridPackingSlip.Name = "dataGridPackingSlip";
            dataGridPackingSlip.Size = new Size(1174, 209);
            dataGridPackingSlip.TabIndex = 0;
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
            // ProductCategory
            // 
            ProductCategory.HeaderText = "Category";
            ProductCategory.Name = "ProductCategory";
            ProductCategory.ReadOnly = true;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // AvailableQty
            // 
            AvailableQty.HeaderText = "AvailableQty";
            AvailableQty.Name = "AvailableQty";
            AvailableQty.Visible = false;
            // 
            // GstValue
            // 
            GstValue.HeaderText = "GstValue";
            GstValue.Name = "GstValue";
            GstValue.ReadOnly = true;
            // 
            // FrmPackingSlip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 590);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmPackingSlip";
            Text = "FrmPackingSlip";
            WindowState = FormWindowState.Maximized;
            Load += FrmPackingSlip_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPackingSlip).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBox2;
        private Label label1;
        private Label lblName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel7;
        private Panel panel6;
        private Button btnVisitor;
        private Panel panel5;
        private TextBox txtBarcodeScanner;
        private Label label5;
        private Label lblVisitorType;
        private Label lblPhone;
        private Label lblCompanyName;
        private Button btnRemoved;
        private Label lblVisitorControl;
        private Label lblPhoneControl;
        private Button btnUpdate;
        private Button btnSave;
        private Button btnDelete;
        private Panel panel9;
        private GroupBox groupBox1;
        private Label lblGrandTotal;
        private Label lblTotalPcs;
        private Label lblGrandTotalControl;
        private Label lblTotalPcsControl;
        private Panel panel11;
        private Panel panel10;
        private Button btnClose;
        private Button btnClear;
        private Panel panel2;
        private DataGridView dataGridPackingSlip;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn ProductCategory;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn AvailableQty;
        private DataGridViewTextBoxColumn GstValue;
        private Panel panel8;
        private Label label6;
        private ComboBox cmbSalesPerson;
        private Button btnPendingPackingSlips;
    }
}