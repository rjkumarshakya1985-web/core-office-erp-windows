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
            panel7 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel6 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel8 = new Panel();
            btnSearch = new Button();
            comboBox1 = new ComboBox();
            label11 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            btnNext = new Button();
            button3 = new Button();
            btnPre = new Button();
            btnTotalRecord = new Button();
            cmbPageSize = new ComboBox();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            InvoiceNumber = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            BillAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 79);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(192, 192, 0);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label8);
            panel7.ForeColor = Color.White;
            panel7.Location = new Point(654, 9);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 62);
            panel7.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(78, 25);
            label7.Name = "label7";
            label7.Size = new Size(25, 30);
            label7.TabIndex = 3;
            label7.Text = "0";
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
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label6);
            panel6.ForeColor = Color.White;
            panel6.Location = new Point(446, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 62);
            panel6.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(78, 25);
            label5.Name = "label5";
            label5.Size = new Size(25, 30);
            label5.TabIndex = 3;
            label5.Text = "0";
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
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.ForeColor = Color.White;
            panel5.Location = new Point(236, 9);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 62);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 24);
            label3.Name = "label3";
            label3.Size = new Size(25, 30);
            label3.TabIndex = 3;
            label3.Text = "0";
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
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(23, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 62);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 23);
            label2.Name = "label2";
            label2.Size = new Size(25, 30);
            label2.TabIndex = 1;
            label2.Text = "0";
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
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnPre);
            panel2.Controls.Add(btnTotalRecord);
            panel2.Controls.Add(cmbPageSize);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(976, 73);
            panel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(btnClear);
            panel8.Controls.Add(btnSearch);
            panel8.Controls.Add(comboBox1);
            panel8.Controls.Add(label11);
            panel8.Controls.Add(textBox2);
            panel8.Controls.Add(label10);
            panel8.Controls.Add(textBox1);
            panel8.Controls.Add(label9);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(976, 36);
            panel8.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(753, 4);
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
            comboBox1.Location = new Point(623, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
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
            // textBox2
            // 
            textBox2.Location = new Point(358, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 23);
            textBox2.TabIndex = 3;
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
            // textBox1
            // 
            textBox1.Location = new Point(116, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 1;
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
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Microsoft Tai Le", 9.75F);
            button3.Location = new Point(236, 42);
            button3.Name = "button3";
            button3.Size = new Size(114, 28);
            button3.TabIndex = 3;
            button3.Text = "1/1";
            button3.UseVisualStyleBackColor = false;
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
            cmbPageSize.Location = new Point(5, 44);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(84, 24);
            cmbPageSize.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 152);
            panel3.Name = "panel3";
            panel3.Size = new Size(976, 307);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, InvoiceNumber, Customer, Quantity, BillAmount, Status });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(976, 307);
            dataGridView1.TabIndex = 0;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // InvoiceNumber
            // 
            InvoiceNumber.HeaderText = "Invoice Number";
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
            Quantity.HeaderText = "Quanity";
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
            // btnClear
            // 
            btnClear.Location = new Point(862, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 27);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // InvoiceListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 459);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "InvoiceListForm";
            Text = "Invoice List";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Panel panel7;
        private Label label7;
        private Label label8;
        private Button btnTotalRecord;
        private ComboBox cmbPageSize;
        private DataGridView dataGridView1;
        private Button btnNext;
        private Button button3;
        private Button btnPre;
        private Panel panel8;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox1;
        private Label label9;
        private Label label11;
        private ComboBox comboBox1;
        private Button btnSearch;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn InvoiceNumber;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn BillAmount;
        private DataGridViewTextBoxColumn Status;
        private Button btnClear;
    }
}