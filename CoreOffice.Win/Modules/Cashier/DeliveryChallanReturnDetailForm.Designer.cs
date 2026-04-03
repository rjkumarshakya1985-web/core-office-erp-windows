namespace CoreOffice.Win.Modules.Cashier
{
    partial class DeliveryChallanReturnDetailForm
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
            dataGridReturn = new DataGridView();
            panel3 = new Panel();
            btnClose = new Button();
            btnClear = new Button();
            btnGenerateDeliveryChallan = new Button();
            panel4 = new Panel();
            lblCustomer = new Label();
            label6 = new Label();
            lblDate = new Label();
            Date = new Label();
            panel5 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            lblTotalReturnQty = new Label();
            label4 = new Label();
            Id = new DataGridViewTextBoxColumn();
            StockId = new DataGridViewTextBoxColumn();
            Product = new DataGridViewTextBoxColumn();
            SaleRate = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Returned = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            ReturnQty = new DataGridViewTextBoxColumn();
            CurrentQty = new DataGridViewTextBoxColumn();
            TaxableAmount = new DataGridViewTextBoxColumn();
            GstPer = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReturn).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
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
            panel1.Size = new Size(971, 88);
            panel1.TabIndex = 3;
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
            panel2.Size = new Size(971, 43);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 11);
            label1.Name = "label1";
            label1.Size = new Size(216, 20);
            label1.TabIndex = 0;
            label1.Text = "DELIVERY CHALLAN RETURN";
            // 
            // dataGridReturn
            // 
            dataGridReturn.AllowUserToAddRows = false;
            dataGridReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridReturn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridReturn.Columns.AddRange(new DataGridViewColumn[] { Id, StockId, Product, SaleRate, Qty, Returned, Balance, ReturnQty, CurrentQty, TaxableAmount, GstPer, Amount });
            dataGridReturn.Dock = DockStyle.Top;
            dataGridReturn.Location = new Point(0, 88);
            dataGridReturn.Name = "dataGridReturn";
            dataGridReturn.Size = new Size(971, 333);
            dataGridReturn.TabIndex = 5;
            dataGridReturn.CellEndEdit += dataGridReturn_CellEndEdit;
            dataGridReturn.CellValidating += dataGridReturn_CellValidating;
            dataGridReturn.CellValueChanged += dataGridReturn_CellValueChanged;
            dataGridReturn.KeyDown += dataGridReturn_KeyDown;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnGenerateDeliveryChallan);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 570);
            panel3.Name = "panel3";
            panel3.Size = new Size(971, 45);
            panel3.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(465, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(159, 37);
            btnClose.TabIndex = 3;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(300, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(159, 37);
            btnClear.TabIndex = 1;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnGenerateDeliveryChallan
            // 
            btnGenerateDeliveryChallan.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateDeliveryChallan.Location = new Point(11, 3);
            btnGenerateDeliveryChallan.Name = "btnGenerateDeliveryChallan";
            btnGenerateDeliveryChallan.Size = new Size(283, 37);
            btnGenerateDeliveryChallan.TabIndex = 0;
            btnGenerateDeliveryChallan.Text = "Generate &Delivery Challan Return";
            btnGenerateDeliveryChallan.UseVisualStyleBackColor = true;
            btnGenerateDeliveryChallan.Click += btnGenerateDeliveryChallan_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblCustomer);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(lblDate);
            panel4.Controls.Add(Date);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 421);
            panel4.Name = "panel4";
            panel4.Size = new Size(426, 149);
            panel4.TabIndex = 7;
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
            label6.Location = new Point(30, 73);
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
            panel5.Size = new Size(426, 38);
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
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(545, 421);
            panel6.Name = "panel6";
            panel6.Size = new Size(426, 149);
            panel6.TabIndex = 8;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(426, 38);
            panel7.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.Controls.Add(lblTotalReturnQty);
            panel8.Controls.Add(label4);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(147, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(279, 38);
            panel8.TabIndex = 1;
            // 
            // lblTotalReturnQty
            // 
            lblTotalReturnQty.AutoSize = true;
            lblTotalReturnQty.Font = new Font("Segoe UI", 12F);
            lblTotalReturnQty.Location = new Point(235, 10);
            lblTotalReturnQty.Name = "lblTotalReturnQty";
            lblTotalReturnQty.Size = new Size(19, 21);
            lblTotalReturnQty.TabIndex = 6;
            lblTotalReturnQty.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(108, 9);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 5;
            label4.Text = "Total Return Qty :";
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
            StockId.Visible = false;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.Name = "Product";
            // 
            // SaleRate
            // 
            SaleRate.HeaderText = "SaleRate";
            SaleRate.Name = "SaleRate";
            // 
            // Qty
            // 
            Qty.HeaderText = "Qty";
            Qty.Name = "Qty";
            // 
            // Returned
            // 
            Returned.HeaderText = "Returned";
            Returned.Name = "Returned";
            // 
            // Balance
            // 
            Balance.HeaderText = "Balance";
            Balance.Name = "Balance";
            // 
            // ReturnQty
            // 
            ReturnQty.HeaderText = "ReturnQty";
            ReturnQty.Name = "ReturnQty";
            // 
            // CurrentQty
            // 
            CurrentQty.HeaderText = "Current Qty";
            CurrentQty.Name = "CurrentQty";
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
            GstPer.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            // 
            // DeliveryChallanReturnDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 615);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(dataGridReturn);
            Controls.Add(panel1);
            Name = "DeliveryChallanReturnDetailForm";
            Text = "Delivery Challan Return Detail";
            WindowState = FormWindowState.Maximized;
            Load += DeliveryChallanReturnDetailForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridReturn).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtNumber;
        private Label label5;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridReturn;
        private Panel panel3;
        private Button btnClear;
        private Button btnGenerateDeliveryChallan;
        private Button btnClose;
        private Panel panel4;
        private Label Date;
        private Panel panel5;
        private Label label2;
        private Label lblCustomer;
        private Label label6;
        private Label lblDate;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label lblTotalReturnQty;
        private Label label4;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StockId;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn SaleRate;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Returned;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn ReturnQty;
        private DataGridViewTextBoxColumn CurrentQty;
        private DataGridViewTextBoxColumn TaxableAmount;
        private DataGridViewTextBoxColumn GstPer;
        private DataGridViewTextBoxColumn Amount;
    }
}