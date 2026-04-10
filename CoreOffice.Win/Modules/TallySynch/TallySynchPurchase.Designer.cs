namespace CoreOffice.Win.Modules.TallySynch
{
    partial class TallySynchPurchase
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
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnClear = new Button();
            btnSynch = new Button();
            label3 = new Label();
            txtVoucher = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label16 = new Label();
            groupBox2 = new GroupBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label21 = new Label();
            label22 = new Label();
            dataGridInvoice = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Group = new DataGridViewTextBoxColumn();
            GST = new DataGridViewTextBoxColumn();
            HSN = new DataGridViewTextBoxColumn();
            Purchase = new DataGridViewTextBoxColumn();
            Qty = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridInvoice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 221);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(7, 34);
            label2.Name = "label2";
            label2.Size = new Size(53, 13);
            label2.TabIndex = 1;
            label2.Text = "Supplier:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(408, 2);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 0;
            label1.Text = "Purchase Synch";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnSynch);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtVoucher);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 526);
            panel2.Name = "panel2";
            panel2.Size = new Size(1028, 83);
            panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Location = new Point(654, 28);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(193, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClose_Click;
            // 
            // btnSynch
            // 
            btnSynch.BackColor = Color.Maroon;
            btnSynch.FlatAppearance.BorderColor = Color.White;
            btnSynch.FlatStyle = FlatStyle.Popup;
            btnSynch.Font = new Font("Segoe UI", 10F);
            btnSynch.ForeColor = Color.White;
            btnSynch.Location = new Point(455, 28);
            btnSynch.Name = "btnSynch";
            btnSynch.Size = new Size(193, 34);
            btnSynch.TabIndex = 3;
            btnSynch.Text = "Synch";
            btnSynch.UseVisualStyleBackColor = false;
            btnSynch.Click += btnSynch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 37);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 2;
            label3.Text = "Voucher No.";
            // 
            // txtVoucher
            // 
            txtVoucher.Font = new Font("Segoe UI", 15F);
            txtVoucher.Location = new Point(114, 28);
            txtVoucher.Name = "txtVoucher";
            txtVoucher.Size = new Size(323, 34);
            txtVoucher.TabIndex = 0;
            txtVoucher.KeyDown += txtVoucher_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(7, 50);
            label4.Name = "label4";
            label4.Size = new Size(109, 13);
            label4.TabIndex = 2;
            label4.Text = "Supplier Tally Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.Location = new Point(7, 66);
            label5.Name = "label5";
            label5.Size = new Size(40, 13);
            label5.TabIndex = 3;
            label5.Text = "GSTIN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F);
            label6.Location = new Point(7, 82);
            label6.Name = "label6";
            label6.Size = new Size(30, 13);
            label6.TabIndex = 4;
            label6.Text = "PAN:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(3, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 178);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Supplier information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F);
            label7.Location = new Point(7, 98);
            label7.Name = "label7";
            label7.Size = new Size(51, 13);
            label7.TabIndex = 5;
            label7.Text = "Address:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F);
            label8.Location = new Point(7, 130);
            label8.Name = "label8";
            label8.Size = new Size(57, 13);
            label8.TabIndex = 6;
            label8.Text = "PIN Code:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F);
            label9.Location = new Point(7, 114);
            label9.Name = "label9";
            label9.Size = new Size(36, 13);
            label9.TabIndex = 7;
            label9.Text = "State:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F);
            label10.Location = new Point(7, 146);
            label10.Name = "label10";
            label10.Size = new Size(46, 13);
            label10.TabIndex = 8;
            label10.Text = "Mobile:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8F);
            label11.Location = new Point(7, 162);
            label11.Name = "label11";
            label11.Size = new Size(37, 13);
            label11.TabIndex = 9;
            label11.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8F);
            label12.Location = new Point(6, 153);
            label12.Name = "label12";
            label12.Size = new Size(56, 13);
            label12.TabIndex = 10;
            label12.Text = "Discount:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 8F);
            label16.Location = new Point(7, 18);
            label16.Name = "label16";
            label16.Size = new Size(37, 13);
            label16.TabIndex = 14;
            label16.Text = "Code:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label20);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(420, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 178);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Business information";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 8F);
            label18.Location = new Point(6, 138);
            label18.Name = "label18";
            label18.Size = new Size(85, 13);
            label18.TabIndex = 13;
            label18.Text = "GST Treatment :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 8F);
            label19.Location = new Point(6, 123);
            label19.Name = "label19";
            label19.Size = new Size(68, 13);
            label19.TabIndex = 12;
            label19.Text = "Credit Limit:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 8F);
            label20.Location = new Point(6, 108);
            label20.Name = "label20";
            label20.Size = new Size(67, 13);
            label20.TabIndex = 11;
            label20.Text = "Credit days:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F);
            label13.Location = new Point(6, 18);
            label13.Name = "label13";
            label13.Size = new Size(41, 13);
            label13.TabIndex = 19;
            label13.Text = "Agent:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8F);
            label14.Location = new Point(6, 48);
            label14.Name = "label14";
            label14.Size = new Size(88, 13);
            label14.TabIndex = 15;
            label14.Text = "Contact Person:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 8F);
            label15.Location = new Point(6, 93);
            label15.Name = "label15";
            label15.Size = new Size(30, 13);
            label15.TabIndex = 18;
            label15.Text = "PAN:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 8F);
            label17.Location = new Point(6, 63);
            label17.Name = "label17";
            label17.Size = new Size(46, 13);
            label17.TabIndex = 16;
            label17.Text = "Mobile:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 8F);
            label21.Location = new Point(6, 78);
            label21.Name = "label21";
            label21.Size = new Size(40, 13);
            label21.TabIndex = 17;
            label21.Text = "GSTIN:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 8F);
            label22.Location = new Point(6, 33);
            label22.Name = "label22";
            label22.Size = new Size(97, 13);
            label22.TabIndex = 15;
            label22.Text = "Agent Tally Name:";
            // 
            // dataGridInvoice
            // 
            dataGridInvoice.AllowUserToAddRows = false;
            dataGridInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInvoice.Columns.AddRange(new DataGridViewColumn[] { Product, Category, Group, GST, HSN, Purchase, Qty, Total });
            dataGridInvoice.Dock = DockStyle.Top;
            dataGridInvoice.Location = new Point(0, 221);
            dataGridInvoice.Name = "dataGridInvoice";
            dataGridInvoice.Size = new Size(1028, 333);
            dataGridInvoice.TabIndex = 6;
            // 
            // Product
            // 
            Product.HeaderText = "PackingSlip No";
            Product.Name = "Product";
            Product.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.Name = "Category";
            // 
            // Group
            // 
            Group.HeaderText = "Group";
            Group.Name = "Group";
            // 
            // GST
            // 
            GST.HeaderText = "GST";
            GST.Name = "GST";
            // 
            // HSN
            // 
            HSN.HeaderText = "HSN";
            HSN.Name = "HSN";
            // 
            // Purchase
            // 
            Purchase.HeaderText = "Purchase";
            Purchase.Name = "Purchase";
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
            // TallySynchPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 609);
            Controls.Add(dataGridInvoice);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TallySynchPurchase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TallySynchPurchase";
            WindowState = FormWindowState.Maximized;
            Load += TallySynchPurchase_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridInvoice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private TextBox txtVoucher;
        private Label label3;
        private Button btnSynch;
        private Button btnClear;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label16;
        private GroupBox groupBox2;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label21;
        private Label label22;
        private DataGridView dataGridInvoice;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Group;
        private DataGridViewTextBoxColumn GST;
        private DataGridViewTextBoxColumn HSN;
        private DataGridViewTextBoxColumn Purchase;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Total;
    }
}