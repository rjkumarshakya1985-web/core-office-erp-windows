namespace CoreOffice.Win.Modules.Cashier
{
    partial class DeliveryNoteForm
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
            txtPackingSlip = new TextBox();
            label5 = new Label();
            panel10 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            panel8 = new Panel();
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
            panel4 = new Panel();
            lblVisitorMobile = new Label();
            label8 = new Label();
            lblVisitorName = new Label();
            label6 = new Label();
            panel6 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            btnDelete = new Button();
            btnClose = new Button();
            btnSave = new Button();
            btnClear = new Button();
            btnVisitor = new Button();
            dataGridInvoice = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            PackingSlip = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            btnCustomer = new Button();
            panel1.SuspendLayout();
            panel10.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridInvoice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPackingSlip);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 88);
            panel1.TabIndex = 0;
            // 
            // txtPackingSlip
            // 
            txtPackingSlip.Location = new Point(106, 52);
            txtPackingSlip.Name = "txtPackingSlip";
            txtPackingSlip.Size = new Size(217, 23);
            txtPackingSlip.TabIndex = 3;
            txtPackingSlip.KeyDown += txtPackingSlip_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 58);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 2;
            label5.Text = "Packing Slip";
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ActiveCaption;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label4);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(979, 43);
            panel10.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 11);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 0;
            label4.Text = "DELIVERY CHALLAN";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dataGridInvoice);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(979, 564);
            panel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(lblCustomerMobile);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(lblCustomerName);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Left;
            panel8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel8.Location = new Point(304, 333);
            panel8.Name = "panel8";
            panel8.Size = new Size(364, 187);
            panel8.TabIndex = 10;
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
            panel5.Location = new Point(745, 333);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 187);
            panel5.TabIndex = 9;
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
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblVisitorMobile);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(lblVisitorName);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Left;
            panel4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 333);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 187);
            panel4.TabIndex = 8;
            // 
            // lblVisitorMobile
            // 
            lblVisitorMobile.AutoSize = true;
            lblVisitorMobile.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVisitorMobile.Location = new Point(75, 72);
            lblVisitorMobile.Name = "lblVisitorMobile";
            lblVisitorMobile.Size = new Size(173, 20);
            lblVisitorMobile.TabIndex = 4;
            lblVisitorMobile.Text = ".........................................";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 72);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 3;
            label8.Text = "Mobile :";
            // 
            // lblVisitorName
            // 
            lblVisitorName.AutoSize = true;
            lblVisitorName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVisitorName.Location = new Point(75, 41);
            lblVisitorName.Name = "lblVisitorName";
            lblVisitorName.Size = new Size(173, 20);
            lblVisitorName.TabIndex = 2;
            lblVisitorName.Text = ".........................................";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 41);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 1;
            label6.Text = "Name :";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(302, 28);
            panel6.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 4);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 0;
            label1.Text = "Visit Information";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnCustomer);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(btnClear);
            panel3.Controls.Add(btnVisitor);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 520);
            panel3.Name = "panel3";
            panel3.Size = new Size(979, 44);
            panel3.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnDelete.Location = new Point(466, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(162, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "&Delete Packing Slip Row";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnClose.Location = new Point(351, 4);
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
            btnSave.Location = new Point(634, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 34);
            btnSave.TabIndex = 2;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnClear.Location = new Point(237, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 34);
            btnClear.TabIndex = 1;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnVisitor
            // 
            btnVisitor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnVisitor.Location = new Point(9, 3);
            btnVisitor.Name = "btnVisitor";
            btnVisitor.Size = new Size(109, 34);
            btnVisitor.TabIndex = 0;
            btnVisitor.Text = "&Visitor";
            btnVisitor.UseVisualStyleBackColor = true;
            btnVisitor.Click += btnVisitor_Click;
            // 
            // dataGridInvoice
            // 
            dataGridInvoice.AllowUserToAddRows = false;
            dataGridInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInvoice.Columns.AddRange(new DataGridViewColumn[] { Id, PackingSlip, Qty, Total });
            dataGridInvoice.Dock = DockStyle.Top;
            dataGridInvoice.Location = new Point(0, 0);
            dataGridInvoice.Name = "dataGridInvoice";
            dataGridInvoice.Size = new Size(979, 333);
            dataGridInvoice.TabIndex = 4;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // PackingSlip
            // 
            PackingSlip.HeaderText = "PackingSlip No";
            PackingSlip.Name = "PackingSlip";
            PackingSlip.ReadOnly = true;
            // 
            // Qty
            // 
            Qty.HeaderText = "Quantity";
            Qty.Name = "Qty";
            Qty.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCustomer.Location = new Point(124, 3);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(109, 34);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "&Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // DeliveryNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 652);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DeliveryNoteForm";
            Text = "Delivery Note Form";
            WindowState = FormWindowState.Maximized;
            Load += DeliveryNoteForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridInvoice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridInvoice;
        private Panel panel8;
        private Panel panel9;
        private Label label2;
        private Panel panel5;
        private Panel panel7;
        private Label label3;
        private Panel panel4;
        private Panel panel6;
        private Label label1;
        private Panel panel3;
        private Label label4;
        private Panel panel10;
        private TextBox txtPackingSlip;
        private Label label5;
        private Button btnVisitor;
        private Label label6;
        private Label lblCustomerMobile;
        private Label label10;
        private Label lblCustomerName;
        private Label label12;
        private Label lblGrandTotal;
        private Label label14;
        private Label lblTotalPcs;
        private Label label16;
        private Label lblVisitorMobile;
        private Label label8;
        private Label lblVisitorName;
        private Button btnClear;
        private Button btnClose;
        private Button btnSave;
        private Button btnDelete;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn PackingSlip;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Total;
        private Button btnCustomer;
    }
}