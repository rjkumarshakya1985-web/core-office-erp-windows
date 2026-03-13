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
            panel1 = new Panel();
            panel8 = new Panel();
            label1 = new Label();
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
            panel3 = new Panel();
            panel6 = new Panel();
            btnRemoved = new Button();
            btnClear = new Button();
            btnClose = new Button();
            btnVisitor = new Button();
            btnSave = new Button();
            panel5 = new Panel();
            txtBarcodeScanner = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
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
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPackingSlip).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel8);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 53);
            panel1.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Maroon;
            panel8.Controls.Add(label1);
            panel8.Location = new Point(10, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(299, 41);
            panel8.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 6);
            label1.Name = "label1";
            label1.Size = new Size(225, 25);
            label1.TabIndex = 0;
            label1.Text = "Shiv Sahai Bhagwan Das";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridPackingSlip);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 209);
            panel2.TabIndex = 3;
            // 
            // dataGridPackingSlip
            // 
            dataGridPackingSlip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPackingSlip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPackingSlip.Columns.AddRange(new DataGridViewColumn[] { Id, Barcode, ProductCategory, Product, Quantity, Amount, Total, AvailableQty });
            dataGridPackingSlip.Dock = DockStyle.Fill;
            dataGridPackingSlip.Location = new Point(0, 0);
            dataGridPackingSlip.Name = "dataGridPackingSlip";
            dataGridPackingSlip.Size = new Size(895, 209);
            dataGridPackingSlip.TabIndex = 0;
            dataGridPackingSlip.CellValueChanged += dataGridPackingSlip_CellValueChanged;
            dataGridPackingSlip.CurrentCellDirtyStateChanged += dataGridPackingSlip_CurrentCellDirtyStateChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
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
            Product.HeaderText = "Product Name";
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
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
            AvailableQty.ReadOnly = true;
            AvailableQty.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 387);
            panel3.Name = "panel3";
            panel3.Size = new Size(895, 203);
            panel3.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 0, 0);
            panel6.Controls.Add(btnRemoved);
            panel6.Controls.Add(btnClear);
            panel6.Controls.Add(btnClose);
            panel6.Controls.Add(btnVisitor);
            panel6.Controls.Add(btnSave);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 50);
            panel6.Name = "panel6";
            panel6.Size = new Size(895, 153);
            panel6.TabIndex = 4;
            // 
            // btnRemoved
            // 
            btnRemoved.Location = new Point(333, 7);
            btnRemoved.Name = "btnRemoved";
            btnRemoved.Size = new Size(165, 50);
            btnRemoved.TabIndex = 7;
            btnRemoved.Text = "Removed Product";
            btnRemoved.UseVisualStyleBackColor = true;
            btnRemoved.Click += btnRemoved_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(509, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(151, 50);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(162, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(165, 50);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close (X)";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnVisitor
            // 
            btnVisitor.Location = new Point(5, 6);
            btnVisitor.Name = "btnVisitor";
            btnVisitor.Size = new Size(151, 50);
            btnVisitor.TabIndex = 4;
            btnVisitor.Text = "Visitor";
            btnVisitor.UseVisualStyleBackColor = true;
            btnVisitor.Click += btnVisitor_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(666, 7);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 48);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 0, 0);
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(txtBarcodeScanner);
            panel5.Controls.Add(label5);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(895, 50);
            panel5.TabIndex = 3;
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
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 262);
            panel4.Name = "panel4";
            panel4.Size = new Size(895, 125);
            panel4.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 0, 0);
            groupBox1.Controls.Add(lblGrandTotal);
            groupBox1.Controls.Add(lblTotalPcs);
            groupBox1.Controls.Add(lblGrandTotalControl);
            groupBox1.Controls.Add(lblTotalPcsControl);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(508, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 125);
            groupBox1.TabIndex = 4;
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
            groupBox2.BackColor = Color.FromArgb(192, 0, 0);
            groupBox2.Controls.Add(lblVisitorType);
            groupBox2.Controls.Add(lblPhone);
            groupBox2.Controls.Add(lblCompanyName);
            groupBox2.Controls.Add(lblVisitorControl);
            groupBox2.Controls.Add(lblPhoneControl);
            groupBox2.Controls.Add(lblName);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(508, 125);
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
            // FrmPackingSlip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 590);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmPackingSlip";
            Text = "FrmPackingSlip";
            WindowState = FormWindowState.Maximized;
            Load += FrmPackingSlip_Load;
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPackingSlip).EndInit();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridPackingSlip;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBox2;
        private Label label1;
        private Label lblName;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel7;
        private Panel panel6;
        private Button btnClose;
        private Button btnVisitor;
        private Button btnSave;
        private Panel panel5;
        private TextBox txtBarcodeScanner;
        private Label label5;
        private Label lblVisitorType;
        private Label lblPhone;
        private Label lblCompanyName;
        private Label lblGrandTotal;
        private Label lblTotalPcs;
        private Button btnClear;
        private Button btnRemoved;
        private Label lblGrandTotalControl;
        private Label lblTotalPcsControl;
        private Label lblVisitorControl;
        private Label lblPhoneControl;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn ProductCategory;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn AvailableQty;
        private Panel panel8;
    }
}