namespace CoreOffice.Win.Modules.Cashier
{
    partial class DeliveryChallanEditViewForm
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
            txtNumber = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            dataGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            StockId = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            SalePrice = new DataGridViewTextBoxColumn();
            TotalQty = new DataGridViewTextBoxColumn();
            ReturnQty = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnPrint = new Button();
            btnClose = new Button();
            btnCancel = new Button();
            panel4 = new Panel();
            lblStatus = new Label();
            label7 = new Label();
            lblCustomer = new Label();
            label6 = new Label();
            lblDate = new Label();
            Date = new Label();
            panel5 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            lblGrandTotal = new Label();
            label14 = new Label();
            lblTotalPcs = new Label();
            label16 = new Label();
            panel7 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtNumber);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 88);
            panel1.TabIndex = 4;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(168, 52);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(217, 23);
            txtNumber.TabIndex = 3;
            txtNumber.KeyDown += txtNumber_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 56);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 2;
            label5.Text = "Delivery Challan Number";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 43);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 11);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 0;
            label1.Text = "DELIVERY CHALLAN DETAIL";
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, StockId, Category, Product, SalePrice, TotalQty, ReturnQty, Balance, TotalAmount });
            dataGrid.Dock = DockStyle.Top;
            dataGrid.Location = new Point(0, 88);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(852, 333);
            dataGrid.TabIndex = 6;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // StockId
            // 
            StockId.HeaderText = "StockId";
            StockId.Name = "StockId";
            StockId.ReadOnly = true;
            StockId.Visible = false;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // SalePrice
            // 
            SalePrice.HeaderText = "SalePrice";
            SalePrice.Name = "SalePrice";
            SalePrice.ReadOnly = true;
            // 
            // TotalQty
            // 
            TotalQty.HeaderText = "Total Qty";
            TotalQty.Name = "TotalQty";
            TotalQty.ReadOnly = true;
            // 
            // ReturnQty
            // 
            ReturnQty.HeaderText = "Return Qty";
            ReturnQty.Name = "ReturnQty";
            ReturnQty.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.HeaderText = "Balance";
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.HeaderText = "Amount";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnPrint);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnCancel);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 578);
            panel3.Name = "panel3";
            panel3.Size = new Size(852, 45);
            panel3.TabIndex = 7;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(4, 3);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(159, 37);
            btnPrint.TabIndex = 4;
            btnPrint.Text = "&Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(167, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(159, 37);
            btnClose.TabIndex = 3;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(332, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 37);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblStatus);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lblCustomer);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(lblDate);
            panel4.Controls.Add(Date);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 421);
            panel4.Name = "panel4";
            panel4.Size = new Size(339, 157);
            panel4.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblStatus.Location = new Point(107, 100);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(57, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "............";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(45, 100);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 5;
            label7.Text = "Status :";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 11.25F);
            lblCustomer.Location = new Point(109, 73);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(45, 20);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "............";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(28, 73);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 3;
            label6.Text = "Customer :";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 11.25F);
            lblDate.Location = new Point(109, 48);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(42, 20);
            lblDate.TabIndex = 2;
            lblDate.Text = "...........";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 11.25F);
            Date.Location = new Point(59, 48);
            Date.Name = "Date";
            Date.Size = new Size(48, 20);
            Date.TabIndex = 1;
            Date.Text = "Date :";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(337, 38);
            panel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 8);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 0;
            label2.Text = "Delivery Challan Summary ";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lblGrandTotal);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(lblTotalPcs);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Right;
            panel6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel6.Location = new Point(618, 421);
            panel6.Name = "panel6";
            panel6.Size = new Size(234, 157);
            panel6.TabIndex = 13;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotal.Location = new Point(106, 71);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(29, 20);
            lblGrandTotal.TabIndex = 12;
            lblGrandTotal.Text = "NF";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(8, 71);
            label14.Name = "label14";
            label14.Size = new Size(95, 20);
            label14.TabIndex = 11;
            label14.Text = "Grand Total:";
            // 
            // lblTotalPcs
            // 
            lblTotalPcs.AutoSize = true;
            lblTotalPcs.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPcs.Location = new Point(110, 40);
            lblTotalPcs.Name = "lblTotalPcs";
            lblTotalPcs.Size = new Size(29, 20);
            lblTotalPcs.TabIndex = 10;
            lblTotalPcs.Text = "NF";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(21, 40);
            label16.Name = "label16";
            label16.Size = new Size(79, 20);
            label16.TabIndex = 9;
            label16.Text = "Total Pcs :";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(232, 28);
            panel7.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 5);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 2;
            label3.Text = "Bill Summary";
            // 
            // DeliveryChallanEditViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 623);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(dataGrid);
            Controls.Add(panel1);
            Name = "DeliveryChallanEditViewForm";
            Text = "DeliveryChallanEditViewForm";
            WindowState = FormWindowState.Maximized;
            Load += DeliveryChallanEditViewForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNumber;
        private Label label5;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGrid;
        private Panel panel3;
        private Button btnClose;
        private Button btnCancel;
        private Panel panel4;
        private Label lblCustomer;
        private Label label6;
        private Label lblDate;
        private Label Date;
        private Panel panel5;
        private Label label2;
        private Panel panel6;
        private Label lblGrandTotal;
        private Label label14;
        private Label lblTotalPcs;
        private Label label16;
        private Panel panel7;
        private Label label3;
        private Button btnPrint;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StockId;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn SalePrice;
        private DataGridViewTextBoxColumn TotalQty;
        private DataGridViewTextBoxColumn ReturnQty;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn TotalAmount;
        private Label lblStatus;
        private Label label7;
    }
}