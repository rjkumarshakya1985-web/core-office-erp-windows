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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtPackingSlip = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            btnClose = new Button();
            btnPrint = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
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
            Rate = new DataGridViewTextBoxColumn();
            TaxableAmount = new DataGridViewTextBoxColumn();
            GstPer = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            AvailableQty = new DataGridViewTextBoxColumn();
            GstValue = new DataGridViewTextBoxColumn();
            lblTotalPcs = new Label();
            label3 = new Label();
            lblTotalAmount = new Label();
            lblTaxableAmount = new Label();
            lbl = new Label();
            lblTotalPcsControl = new Label();
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
            panel1.Size = new Size(931, 46);
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
            panel3.Size = new Size(931, 46);
            panel3.TabIndex = 2;
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
            panel2.Size = new Size(931, 141);
            panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(lblTotalPcs);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblTotalAmount);
            groupBox1.Controls.Add(lblTaxableAmount);
            groupBox1.Controls.Add(lbl);
            groupBox1.Controls.Add(lblTotalPcsControl);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(566, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 141);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Packing Slip Information";
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
            lblVisitorType.Location = new Point(196, 90);
            lblVisitorType.Name = "lblVisitorType";
            lblVisitorType.Size = new Size(40, 25);
            lblVisitorType.TabIndex = 5;
            lblVisitorType.Text = ".......";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(194, 57);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(40, 25);
            lblPhone.TabIndex = 4;
            lblPhone.Text = ".......";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompanyName.Location = new Point(193, 28);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(40, 25);
            lblCompanyName.TabIndex = 3;
            lblCompanyName.Text = ".......";
            // 
            // lblVisitorControl
            // 
            lblVisitorControl.AutoSize = true;
            lblVisitorControl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVisitorControl.Location = new Point(62, 90);
            lblVisitorControl.Name = "lblVisitorControl";
            lblVisitorControl.Size = new Size(128, 25);
            lblVisitorControl.TabIndex = 2;
            lblVisitorControl.Text = "Visitory Type :";
            // 
            // lblPhoneControl
            // 
            lblPhoneControl.AutoSize = true;
            lblPhoneControl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneControl.Location = new Point(115, 58);
            lblPhoneControl.Name = "lblPhoneControl";
            lblPhoneControl.Size = new Size(75, 25);
            lblPhoneControl.TabIndex = 1;
            lblPhoneControl.Text = "Phone :";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(22, 28);
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
            panel4.Size = new Size(931, 257);
            panel4.TabIndex = 4;
            // 
            // dataGridPackingSlip
            // 
            dataGridPackingSlip.AllowUserToAddRows = false;
            dataGridPackingSlip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPackingSlip.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridPackingSlip.BackgroundColor = Color.White;
            dataGridPackingSlip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPackingSlip.Columns.AddRange(new DataGridViewColumn[] { Id, Barcode, ProductCategory, Product, Quantity, Rate, TaxableAmount, GstPer, Amount, AvailableQty, GstValue });
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
            dataGridPackingSlip.Size = new Size(931, 257);
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
            // Rate
            // 
            Rate.HeaderText = "Rate";
            Rate.Name = "Rate";
            // 
            // TaxableAmount
            // 
            TaxableAmount.HeaderText = "Taxable Amount";
            TaxableAmount.Name = "TaxableAmount";
            // 
            // GstPer
            // 
            GstPer.HeaderText = "Gst %";
            GstPer.Name = "GstPer";
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
            // GstValue
            // 
            GstValue.HeaderText = "GstValue";
            GstValue.Name = "GstValue";
            GstValue.ReadOnly = true;
            GstValue.Visible = false;
            // 
            // lblTotalPcs
            // 
            lblTotalPcs.AutoSize = true;
            lblTotalPcs.Font = new Font("Segoe UI", 14.25F);
            lblTotalPcs.Location = new Point(234, 66);
            lblTotalPcs.Name = "lblTotalPcs";
            lblTotalPcs.Size = new Size(40, 25);
            lblTotalPcs.TabIndex = 13;
            lblTotalPcs.Text = ".......";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(131, 66);
            label3.Name = "label3";
            label3.Size = new Size(93, 25);
            label3.TabIndex = 12;
            label3.Text = "Total Pcs :";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 14.25F);
            lblTotalAmount.Location = new Point(234, 95);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(40, 25);
            lblTotalAmount.TabIndex = 11;
            lblTotalAmount.Text = ".......";
            // 
            // lblTaxableAmount
            // 
            lblTaxableAmount.AutoSize = true;
            lblTaxableAmount.Font = new Font("Segoe UI", 14.25F);
            lblTaxableAmount.Location = new Point(234, 35);
            lblTaxableAmount.Name = "lblTaxableAmount";
            lblTaxableAmount.Size = new Size(40, 25);
            lblTaxableAmount.TabIndex = 10;
            lblTaxableAmount.Text = ".......";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 14.25F);
            lbl.Location = new Point(107, 95);
            lbl.Name = "lbl";
            lbl.Size = new Size(118, 25);
            lbl.TabIndex = 9;
            lbl.Text = "Grand Total :";
            // 
            // lblTotalPcsControl
            // 
            lblTotalPcsControl.AutoSize = true;
            lblTotalPcsControl.Font = new Font("Segoe UI", 14.25F);
            lblTotalPcsControl.Location = new Point(68, 35);
            lblTotalPcsControl.Name = "lblTotalPcsControl";
            lblTotalPcsControl.Size = new Size(156, 25);
            lblTotalPcsControl.TabIndex = 8;
            lblTotalPcsControl.Text = "Taxable Amount :";
            // 
            // PackingSlipViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 490);
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
        private GroupBox groupBox2;
        private Label lblVisitorType;
        private Label lblPhone;
        private Label lblCompanyName;
        private Label lblVisitorControl;
        private Label lblPhoneControl;
        private Label lblName;
        private GroupBox groupBox1;
        private Button btnPrint;
        private TextBox txtPackingSlip;
        private Label label1;
        private Button btnClose;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn ProductCategory;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Rate;
        private DataGridViewTextBoxColumn TaxableAmount;
        private DataGridViewTextBoxColumn GstPer;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn AvailableQty;
        private DataGridViewTextBoxColumn GstValue;
        private Label lblTotalPcs;
        private Label label3;
        private Label lblTotalAmount;
        private Label lblTaxableAmount;
        private Label lbl;
        private Label lblTotalPcsControl;
    }
}