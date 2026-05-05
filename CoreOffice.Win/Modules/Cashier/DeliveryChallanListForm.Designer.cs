namespace CoreOffice.Win.Modules.Cashier
{
    partial class DeliveryChallanListForm
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
            panel4 = new Panel();
            label1 = new Label();
            lblTotalInvoice = new Label();
            panel5 = new Panel();
            label4 = new Label();
            lblTotalTallySynced = new Label();
            panel6 = new Panel();
            label6 = new Label();
            lblTotalCancel = new Label();
            panel9 = new Panel();
            label3 = new Label();
            lblTotalPendinginvoice = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            txtCustomerName = new TextBox();
            label5 = new Label();
            txtChallanNo = new TextBox();
            label7 = new Label();
            btnNext = new Button();
            btnPageDetail = new Button();
            btnPre = new Button();
            btnTotalRecord = new Button();
            cmbPageSize = new ComboBox();
            dataGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            InvoiceNumber = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ReturnQty = new DataGridViewTextBoxColumn();
            BalanceQty = new DataGridViewTextBoxColumn();
            BillAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "TOTAL INVOICES";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 5);
            label4.Name = "label4";
            label4.Size = new Size(139, 15);
            label4.TabIndex = 2;
            label4.Text = "TALLY SYNCED INVOICES";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 2;
            label6.Text = "CANCEL INVOICES";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 4);
            label3.Name = "label3";
            label3.Size = new Size(192, 15);
            label3.TabIndex = 2;
            label3.Text = "PENDING TALLY SYNCED INVOICES";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 79);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnNext);
            panel2.Controls.Add(btnPageDetail);
            panel2.Controls.Add(btnPre);
            panel2.Controls.Add(btnTotalRecord);
            panel2.Controls.Add(cmbPageSize);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1020, 73);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtCustomerName);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtChallanNo);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1020, 36);
            panel3.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(909, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 27);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(800, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 27);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(581, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(536, 10);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Status";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(358, 6);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(168, 23);
            txtCustomerName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(259, 9);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 2;
            label5.Text = "Customer Name";
            // 
            // txtChallanNo
            // 
            txtChallanNo.Location = new Point(116, 5);
            txtChallanNo.Name = "txtChallanNo";
            txtChallanNo.Size = new Size(130, 23);
            txtChallanNo.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 9);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 0;
            label7.Text = "Challan Number";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft Tai Le", 9.75F);
            btnNext.Location = new Point(331, 42);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(30, 28);
            btnNext.TabIndex = 4;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPageDetail
            // 
            btnPageDetail.BackColor = Color.White;
            btnPageDetail.Font = new Font("Microsoft Tai Le", 9.75F);
            btnPageDetail.Location = new Point(214, 42);
            btnPageDetail.Name = "btnPageDetail";
            btnPageDetail.Size = new Size(114, 28);
            btnPageDetail.TabIndex = 3;
            btnPageDetail.Text = "1/1";
            btnPageDetail.UseVisualStyleBackColor = false;
            // 
            // btnPre
            // 
            btnPre.Font = new Font("Microsoft Tai Le", 9.75F);
            btnPre.Location = new Point(182, 42);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(31, 28);
            btnPre.TabIndex = 2;
            btnPre.Text = "<";
            btnPre.UseVisualStyleBackColor = true;
            // 
            // btnTotalRecord
            // 
            btnTotalRecord.BackColor = Color.White;
            btnTotalRecord.Font = new Font("Microsoft Tai Le", 9.75F);
            btnTotalRecord.Location = new Point(68, 42);
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
            cmbPageSize.Size = new Size(57, 24);
            cmbPageSize.TabIndex = 0;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Date, InvoiceNumber, Customer, Quantity, ReturnQty, BalanceQty, BillAmount, Status });
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(0, 152);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(1020, 356);
            dataGrid.TabIndex = 8;
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
            // ReturnQty
            // 
            ReturnQty.HeaderText = "Return Qty";
            ReturnQty.Name = "ReturnQty";
            ReturnQty.ReadOnly = true;
            // 
            // BalanceQty
            // 
            BalanceQty.HeaderText = "Balance Qty";
            BalanceQty.Name = "BalanceQty";
            BalanceQty.ReadOnly = true;
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
            // DeliveryChallanListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 508);
            Controls.Add(dataGrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DeliveryChallanListForm";
            Text = "DeliveryChallanListForm";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label lblTotalInvoice;
        private Label label1;
        private Panel panel5;
        private Label lblTotalTallySynced;
        private Label label4;
        private Panel panel6;
        private Label lblTotalCancel;
        private Label label6;
        private Panel panel9;
        private Label lblTotalPendinginvoice;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnClear;
        private Button btnSearch;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox txtCustomerName;
        private Label label5;
        private TextBox txtChallanNo;
        private Label label7;
        private Button btnNext;
        private Button btnPageDetail;
        private Button btnPre;
        private Button btnTotalRecord;
        private ComboBox cmbPageSize;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn InvoiceNumber;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn BillAmount;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn ReturnQty;
        private DataGridViewTextBoxColumn BalanceQty;
    }
}