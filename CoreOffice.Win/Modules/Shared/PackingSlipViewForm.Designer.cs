namespace CoreOffice.Win.Modules.Shared
{
    partial class PackingSlipViewForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtPackingSlip = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            btnPrint = new Button();
            panel2 = new Panel();
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
            panel4 = new Panel();
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
            btnClose = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPackingSlip).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPackingSlip);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 46);
            panel1.TabIndex = 0;
            // 
            // txtPackingSlip
            // 
            txtPackingSlip.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtPackingSlip.Location = new Point(224, 10);
            txtPackingSlip.Name = "txtPackingSlip";
            txtPackingSlip.Size = new Size(270, 25);
            txtPackingSlip.TabIndex = 1;
            txtPackingSlip.KeyDown += txtPackingSlip_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(197, 17);
            label1.TabIndex = 0;
            label1.Text = "Search By Packing Slip Number";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnPrint);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 444);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 46);
            panel3.TabIndex = 2;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(12, 7);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(109, 31);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 303);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 141);
            panel2.TabIndex = 3;
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
            groupBox1.Location = new Point(477, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 141);
            groupBox1.TabIndex = 6;
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
            groupBox2.Size = new Size(394, 141);
            groupBox2.TabIndex = 4;
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
            // panel4
            // 
            panel4.Controls.Add(dataGridPackingSlip);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(842, 257);
            panel4.TabIndex = 4;
            // 
            // dataGridPackingSlip
            // 
            dataGridPackingSlip.AllowUserToAddRows = false;
            dataGridPackingSlip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPackingSlip.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridPackingSlip.BackgroundColor = Color.White;
            dataGridPackingSlip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPackingSlip.Columns.AddRange(new DataGridViewColumn[] { Id, Barcode, ProductCategory, Product, Quantity, Amount, Total, AvailableQty, GstValue });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridPackingSlip.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridPackingSlip.Dock = DockStyle.Fill;
            dataGridPackingSlip.Location = new Point(0, 0);
            dataGridPackingSlip.Name = "dataGridPackingSlip";
            dataGridPackingSlip.Size = new Size(842, 257);
            dataGridPackingSlip.TabIndex = 1;
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
            GstValue.Visible = false;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.Location = new Point(127, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 31);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // PackingSlipViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 490);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "PackingSlipViewForm";
            Text = "Packing Slip View";
            Load += PackingSlipViewForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridPackingSlip).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
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
        private GroupBox groupBox2;
        private Label lblVisitorType;
        private Label lblPhone;
        private Label lblCompanyName;
        private Label lblVisitorControl;
        private Label lblPhoneControl;
        private Label lblName;
        private GroupBox groupBox1;
        private Label lblGrandTotal;
        private Label lblTotalPcs;
        private Label lblGrandTotalControl;
        private Label lblTotalPcsControl;
        private Button btnPrint;
        private TextBox txtPackingSlip;
        private Label label1;
        private Button btnClose;
    }
}