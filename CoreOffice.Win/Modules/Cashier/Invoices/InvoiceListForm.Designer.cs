namespace CoreOffice.Win.Modules.Cashier.Invoices
{
    partial class InvoiceListForm
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
            panel9 = new Panel();
            lblTotalPendinginvoice = new Label();
            label3 = new Label();
            panel7 = new Panel();
            lblDeliveryChallan = new Label();
            label8 = new Label();
            panel6 = new Panel();
            lblTotalCancel = new Label();
            label6 = new Label();
            panel5 = new Panel();
            lblTotalTallySynced = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblTotalInvoice = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel8 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            cmbInvoiceStatus = new ComboBox();
            label11 = new Label();
            txtCustomerName = new TextBox();
            label10 = new Label();
            txtInvoiceNumber = new TextBox();
            label9 = new Label();
            btnNext = new Button();
            btnPageDetail = new Button();
            btnPre = new Button();
            btnTotalRecord = new Button();
            cmbPageSize = new ComboBox();
            panel3 = new Panel();
            dataGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            InvoiceNumber = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            BillAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1071, 79);
            panel1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(255, 128, 0);
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(lblTotalPendinginvoice);
            panel9.Controls.Add(label3);
            panel9.ForeColor = Color.White;
            panel9.Location = new Point(229, 9);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 62);
            panel9.TabIndex = 3;
            // 
            // lblTotalPendinginvoice
            // 
            lblTotalPendinginvoice.AutoSize = true;
            lblTotalPendinginvoice.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPendinginvoice.Location = new Point(73, 24);
            lblTotalPendinginvoice.Name = "lblTotalPendinginvoice";
            lblTotalPendinginvoice.Size = new Size(25, 30);
            lblTotalPendinginvoice.TabIndex = 3;
            lblTotalPendinginvoice.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 4);
            label3.Name = "label3";
            label3.Size = new Size(192, 15);
            label3.TabIndex = 2;
            label3.Text = "PENDING TALLY SYNCED INVOICES";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(192, 192, 0);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(lblDeliveryChallan);
            panel7.Controls.Add(label8);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(858, 9);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 62);
            panel7.TabIndex = 3;
            // 
            // lblDeliveryChallan
            // 
            lblDeliveryChallan.AutoSize = true;
            lblDeliveryChallan.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeliveryChallan.Location = new Point(78, 25);
            lblDeliveryChallan.Name = "lblDeliveryChallan";
            lblDeliveryChallan.Size = new Size(25, 30);
            lblDeliveryChallan.TabIndex = 3;
            lblDeliveryChallan.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 6);
            label8.Name = "label8";
            label8.Size = new Size(179, 15);
            label8.TabIndex = 2;
            label8.Text = "DELIVERY CHALLAN TO INVOICE";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 0, 0);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lblTotalCancel);
            panel6.Controls.Add(label6);
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(650, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 62);
            panel6.TabIndex = 2;
            // 
            // lblTotalCancel
            // 
            lblTotalCancel.AutoSize = true;
            lblTotalCancel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCancel.Location = new Point(78, 25);
            lblTotalCancel.Name = "lblTotalCancel";
            lblTotalCancel.Size = new Size(25, 30);
            lblTotalCancel.TabIndex = 3;
            lblTotalCancel.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 2;
            label6.Text = "CANCEL INVOICES";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Blue;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblTotalTallySynced);
            panel5.Controls.Add(label4);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(440, 9);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 62);
            panel5.TabIndex = 1;
            // 
            // lblTotalTallySynced
            // 
            lblTotalTallySynced.AutoSize = true;
            lblTotalTallySynced.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTallySynced.Location = new Point(73, 24);
            lblTotalTallySynced.Name = "lblTotalTallySynced";
            lblTotalTallySynced.Size = new Size(25, 30);
            lblTotalTallySynced.TabIndex = 3;
            lblTotalTallySynced.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 5);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 2;
            label4.Text = "TALLY SYNCED INVOICES";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Green;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblTotalInvoice);
            panel4.Controls.Add(label1);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(23, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 62);
            panel4.TabIndex = 0;
            // 
            // lblTotalInvoice
            // 
            lblTotalInvoice.AutoSize = true;
            lblTotalInvoice.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalInvoice.Location = new Point(59, 23);
            lblTotalInvoice.Name = "lblTotalInvoice";
            lblTotalInvoice.Size = new Size(25, 30);
            lblTotalInvoice.TabIndex = 1;
            lblTotalInvoice.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "TOTAL INVOICES";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(btnPageDetail);
            panel2.Controls.Add(btnPre);
            panel2.Controls.Add(btnTotalRecord);
            panel2.Controls.Add(cmbPageSize);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1071, 73);
            panel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(btnClear);
            panel8.Controls.Add(btnSearch);
            panel8.Controls.Add(cmbInvoiceStatus);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(txtCustomerName);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(txtInvoiceNumber);
            panel8.Controls.Add(label9);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1071, 36);
            panel8.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(909, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 27);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(800, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 27);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbInvoiceStatus
            // 
            cmbInvoiceStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInvoiceStatus.FormattingEnabled = true;
            cmbInvoiceStatus.Location = new Point(623, 6);
            cmbInvoiceStatus.Name = "cmbInvoiceStatus";
            cmbInvoiceStatus.Size = new Size(171, 23);
            cmbInvoiceStatus.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(536, 10);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 4;
            label11.Text = "Invoice Status";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(358, 6);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(168, 23);
            txtCustomerName.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(259, 9);
            label10.Name = "label10";
            label10.Size = new Size(94, 15);
            label10.TabIndex = 2;
            label10.Text = "Customer Name";
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.Location = new Point(116, 5);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.Size = new Size(130, 23);
            txtInvoiceNumber.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 9);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 0;
            label9.Text = "Invoice Number";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft Tai Le", 9.75F);
            btnNext.Location = new Point(353, 42);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(30, 28);
            btnNext.TabIndex = 4;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPageDetail
            // 
            btnPageDetail.BackColor = Color.White;
            btnPageDetail.Font = new Font("Microsoft Tai Le", 9.75F);
            btnPageDetail.Location = new Point(236, 42);
            btnPageDetail.Name = "btnPageDetail";
            btnPageDetail.Size = new Size(114, 28);
            btnPageDetail.TabIndex = 3;
            btnPageDetail.Text = "1/1";
            btnPageDetail.UseVisualStyleBackColor = false;
            // 
            // btnPre
            // 
            btnPre.Font = new Font("Microsoft Tai Le", 9.75F);
            btnPre.Location = new Point(204, 42);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(31, 28);
            btnPre.TabIndex = 2;
            btnPre.Text = "<";
            btnPre.UseVisualStyleBackColor = true;
            btnPre.Click += btnPre_Click;
            // 
            // btnTotalRecord
            // 
            btnTotalRecord.BackColor = Color.White;
            btnTotalRecord.Font = new Font("Microsoft Tai Le", 9.75F);
            btnTotalRecord.Location = new Point(90, 42);
            btnTotalRecord.Name = "btnTotalRecord";
            btnTotalRecord.Size = new Size(114, 28);
            btnTotalRecord.TabIndex = 1;
            btnTotalRecord.Text = "Total (0)";
            btnTotalRecord.UseVisualStyleBackColor = false;
            // 
            // cmbPageSize
            // 
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.Font = new Font("Microsoft Tai Le", 9.75F);
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.Items.AddRange(new object[] { "2", "10", "20", "50", "100", "200" });
            cmbPageSize.Location = new Point(5, 44);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(84, 24);
            cmbPageSize.TabIndex = 0;
            cmbPageSize.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGrid);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(1071, 307);
            panel3.TabIndex = 2;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Date, InvoiceNumber, Customer, Quantity, BillAmount, Status });
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(0, 0);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(1071, 307);
            dataGrid.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // InvoiceNumber
            // 
            InvoiceNumber.HeaderText = "Number";
            InvoiceNumber.Name = "InvoiceNumber";
            InvoiceNumber.ReadOnly = true;
            // 
            // Customer
            // 
            Customer.HeaderText = "Customer";
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // BillAmount
            // 
            BillAmount.HeaderText = "Bill Amount";
            BillAmount.Name = "BillAmount";
            BillAmount.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // InvoiceListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 459);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "InvoiceListForm";
            Text = "Invoice List";
            WindowState = FormWindowState.Maximized;
            Load += InvoiceListForm_Load;
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label lblTotalInvoice;
        private Label label1;
        private Label lblTotalCancel;
        private Label label6;
        private Label lblTotalTallySynced;
        private Label label4;
        private Panel panel7;
        private Label lblDeliveryChallan;
        private Label label8;
        private Button btnTotalRecord;
        private ComboBox cmbPageSize;
        private DataGridView dataGrid;
        private Button btnNext;
        private Button btnPageDetail;
        private Button btnPre;
        private Panel panel8;
        private TextBox txtCustomerName;
        private Label label10;
        private TextBox txtInvoiceNumber;
        private Label label9;
        private Label label11;
        private ComboBox cmbInvoiceStatus;
        private Button btnSearch;
        private Button btnClear;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn InvoiceNumber;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn BillAmount;
        private DataGridViewTextBoxColumn Status;
        private Panel panel9;
        private Label lblTotalPendinginvoice;
        private Label label3;
    }
}