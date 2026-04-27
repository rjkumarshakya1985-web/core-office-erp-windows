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
            dataGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            ChallanNo = new DataGridViewTextBoxColumn();
            Customer = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            ReturnQty = new DataGridViewTextBoxColumn();
            BalanceQty = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            cmbPageSize = new ComboBox();
            btnNext = new Button();
            btnPageDetail = new Button();
            btnPre = new Button();
            btnTotalRecord = new Button();
            txtSearch = new TextBox();
            panel3 = new Panel();
            btnClose = new Button();
            btnShow = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Date, ChallanNo, Customer, Quantity, ReturnQty, BalanceQty, TotalAmount, Status });
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(0, 0);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(800, 357);
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
            // ChallanNo
            // 
            ChallanNo.HeaderText = "Number";
            ChallanNo.Name = "ChallanNo";
            ChallanNo.ReadOnly = true;
            // 
            // Customer
            // 
            Customer.FillWeight = 121.827477F;
            Customer.HeaderText = "Customer";
            Customer.Name = "Customer";
            Customer.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.FillWeight = 121.827477F;
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
            // TotalAmount
            // 
            TotalAmount.FillWeight = 121.827477F;
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 357);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 44);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(cmbPageSize);
            panel4.Controls.Add(btnNext);
            panel4.Controls.Add(btnPageDetail);
            panel4.Controls.Add(btnPre);
            panel4.Controls.Add(btnTotalRecord);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(367, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(433, 44);
            panel4.TabIndex = 1;
            // 
            // cmbPageSize
            // 
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPageSize.FormattingEnabled = true;
            cmbPageSize.Items.AddRange(new object[] { "2", "10", "50", "100", "200" });
            cmbPageSize.Location = new Point(77, 10);
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(63, 25);
            cmbPageSize.TabIndex = 5;
            cmbPageSize.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Black;
            btnNext.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(371, 8);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(43, 28);
            btnNext.TabIndex = 4;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPageDetail
            // 
            btnPageDetail.BackColor = Color.White;
            btnPageDetail.FlatStyle = FlatStyle.System;
            btnPageDetail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPageDetail.Location = new Point(270, 8);
            btnPageDetail.Name = "btnPageDetail";
            btnPageDetail.Size = new Size(102, 28);
            btnPageDetail.TabIndex = 3;
            btnPageDetail.Text = "1/900";
            btnPageDetail.UseVisualStyleBackColor = false;
            // 
            // btnPre
            // 
            btnPre.BackColor = Color.Black;
            btnPre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnPre.ForeColor = Color.White;
            btnPre.Location = new Point(228, 8);
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(43, 28);
            btnPre.TabIndex = 2;
            btnPre.Text = "<";
            btnPre.UseVisualStyleBackColor = false;
            btnPre.Click += btnPre_Click;
            // 
            // btnTotalRecord
            // 
            btnTotalRecord.BackColor = Color.FromArgb(224, 224, 224);
            btnTotalRecord.FlatStyle = FlatStyle.System;
            btnTotalRecord.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnTotalRecord.Location = new Point(139, 8);
            btnTotalRecord.Name = "btnTotalRecord";
            btnTotalRecord.Size = new Size(90, 28);
            btnTotalRecord.TabIndex = 0;
            btnTotalRecord.Text = "Total (3000)";
            btnTotalRecord.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(43, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(235, 23);
            txtSearch.TabIndex = 0;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(btnShow);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnPrint);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 401);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 49);
            panel3.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(137, 7);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(117, 36);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(261, 7);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(117, 36);
            btnShow.TabIndex = 3;
            btnShow.Text = "Show Detail";
            btnShow.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(507, 7);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 36);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(384, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 36);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(16, 7);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(117, 36);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // DeliveryChallanListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "DeliveryChallanListForm";
            Text = "Delivery Challan List";
            WindowState = FormWindowState.Maximized;
            Load += DeliveryChallanListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrid;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Button btnClose;
        private Button btnShow;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnPrint;
        private Panel panel4;
        private Button btnTotalRecord;
        private TextBox txtSearch;
        private Button btnNext;
        private Button btnPageDetail;
        private Button btnPre;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn ChallanNo;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn ReturnQty;
        private DataGridViewTextBoxColumn BalanceQty;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn Status;
        private ComboBox cmbPageSize;
    }
}