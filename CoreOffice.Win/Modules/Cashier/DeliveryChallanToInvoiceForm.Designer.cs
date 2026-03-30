namespace CoreOffice.Win.Modules.Cashier
{
    partial class DeliveryChallanToInvoiceForm
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
            txtDeliveryChallanNo = new TextBox();
            label5 = new Label();
            panel10 = new Panel();
            label4 = new Label();
            dataGridInvoice = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            DeliveryChallanNo = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            ReturnQty = new DataGridViewLinkColumn();
            InvoiceQty = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnDelete = new Button();
            btnClose = new Button();
            btnSave = new Button();
            btnClear = new Button();
            panel8 = new Panel();
            lblGSTIN = new Label();
            label6 = new Label();
            lblCustomerMobile = new Label();
            label10 = new Label();
            lblCustomerName = new Label();
            label12 = new Label();
            panel9 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            lblGrandTotal = new Label();
            label14 = new Label();
            lblTotalPcs = new Label();
            label16 = new Label();
            panel7 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridInvoice).BeginInit();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtDeliveryChallanNo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 88);
            panel1.TabIndex = 1;
            // 
            // txtDeliveryChallanNo
            // 
            txtDeliveryChallanNo.Location = new Point(137, 52);
            txtDeliveryChallanNo.Name = "txtDeliveryChallanNo";
            txtDeliveryChallanNo.Size = new Size(217, 23);
            txtDeliveryChallanNo.TabIndex = 3;
            txtDeliveryChallanNo.KeyDown += txtDeliveryChallanNo_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 56);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 2;
            label5.Text = "Delivery Challan No";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ActiveCaption;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label4);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(840, 43);
            panel10.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 11);
            label4.Name = "label4";
            label4.Size = new Size(239, 20);
            label4.TabIndex = 0;
            label4.Text = "DELIVERY CHALLAN TO INVOICE";
            // 
            // dataGridInvoice
            // 
            dataGridInvoice.AllowUserToAddRows = false;
            dataGridInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInvoice.Columns.AddRange(new DataGridViewColumn[] { Id, DeliveryChallanNo, Qty, ReturnQty, InvoiceQty, Amount });
            dataGridInvoice.Dock = DockStyle.Top;
            dataGridInvoice.Location = new Point(0, 88);
            dataGridInvoice.Name = "dataGridInvoice";
            dataGridInvoice.Size = new Size(840, 333);
            dataGridInvoice.TabIndex = 5;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // DeliveryChallanNo
            // 
            DeliveryChallanNo.HeaderText = "Delivery Challan No";
            DeliveryChallanNo.Name = "DeliveryChallanNo";
            DeliveryChallanNo.ReadOnly = true;
            // 
            // Qty
            // 
            Qty.HeaderText = "Quantity";
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            // 
            // ReturnQty
            // 
            ReturnQty.HeaderText = "Return Qty";
            ReturnQty.Name = "ReturnQty";
            ReturnQty.ReadOnly = true;
            ReturnQty.Resizable = DataGridViewTriState.True;
            ReturnQty.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // InvoiceQty
            // 
            InvoiceQty.HeaderText = "Invoice Qty";
            InvoiceQty.Name = "InvoiceQty";
            InvoiceQty.ReadOnly = true;
            // 
            // Amount
            // 
            Amount.HeaderText = "Total Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnClear);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 565);
            panel3.Name = "panel3";
            panel3.Size = new Size(840, 44);
            panel3.TabIndex = 6;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDelete.Location = new Point(236, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(162, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "&Delete Row Item";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnClose.Location = new Point(121, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 34);
            btnClose.TabIndex = 3;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSave.Location = new Point(404, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(182, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "&Generate Invoice ";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnClear.Location = new Point(7, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 34);
            btnClear.TabIndex = 1;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(lblGSTIN);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(lblCustomerMobile);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(lblCustomerName);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Left;
            panel8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel8.Location = new Point(0, 421);
            panel8.Name = "panel8";
            panel8.Size = new Size(364, 144);
            panel8.TabIndex = 11;
            // 
            // lblGSTIN
            // 
            lblGSTIN.AutoSize = true;
            lblGSTIN.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGSTIN.Location = new Point(76, 102);
            lblGSTIN.Name = "lblGSTIN";
            lblGSTIN.Size = new Size(173, 20);
            lblGSTIN.TabIndex = 10;
            lblGSTIN.Text = ".........................................";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 102);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 9;
            label6.Text = "GSTIN :";
            // 
            // lblCustomerMobile
            // 
            lblCustomerMobile.AutoSize = true;
            lblCustomerMobile.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerMobile.Location = new Point(77, 73);
            lblCustomerMobile.Name = "lblCustomerMobile";
            lblCustomerMobile.Size = new Size(173, 20);
            lblCustomerMobile.TabIndex = 8;
            lblCustomerMobile.Text = ".........................................";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 73);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 7;
            label10.Text = "Mobile :";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(77, 42);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(173, 20);
            lblCustomerName.TabIndex = 6;
            lblCustomerName.Text = ".........................................";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 42);
            label12.Name = "label12";
            label12.Size = new Size(59, 20);
            label12.TabIndex = 5;
            label12.Text = "Name :";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaption;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label2);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(362, 28);
            panel9.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 3);
            label2.Name = "label2";
            label2.Size = new Size(135, 17);
            label2.TabIndex = 1;
            label2.Text = "Customer Information";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblGrandTotal);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(lblTotalPcs);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(panel7);
            panel5.Dock = DockStyle.Right;
            panel5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel5.Location = new Point(606, 421);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 144);
            panel5.TabIndex = 12;
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
            // DeliveryChallanToInvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 609);
            Controls.Add(panel5);
            Controls.Add(panel8);
            Controls.Add(panel3);
            Controls.Add(dataGridInvoice);
            Controls.Add(panel1);
            Name = "DeliveryChallanToInvoiceForm";
            Text = "DeliveryChallan To Invoice ";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridInvoice).EndInit();
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtDeliveryChallanNo;
        private Label label5;
        private Panel panel10;
        private Label label4;
        private DataGridView dataGridInvoice;
        private Panel panel3;
        private Button btnDelete;
        private Button btnClose;
        private Button btnSave;
        private Button btnClear;
        private Panel panel8;
        private Label lblCustomerMobile;
        private Label label10;
        private Label lblCustomerName;
        private Label label12;
        private Panel panel9;
        private Label label2;
        private Panel panel5;
        private Label lblGrandTotal;
        private Label label14;
        private Label lblTotalPcs;
        private Label label16;
        private Panel panel7;
        private Label label3;
        private Label lblGSTIN;
        private Label label6;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn DeliveryChallanNo;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewLinkColumn ReturnQty;
        private DataGridViewTextBoxColumn InvoiceQty;
        private DataGridViewTextBoxColumn Amount;
    }
}