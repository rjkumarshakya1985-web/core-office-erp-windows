namespace CoreOffice.Win.Modules.Shared
{
    partial class PendingPackingSlipForm
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
            panel2 = new Panel();
            dataGrid = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Visitor = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            btnShow = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnPrint = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(845, 49);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGrid);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 401);
            panel2.TabIndex = 1;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Date, Visitor, dataGridViewTextBoxColumn1, Quantity, TotalAmount });
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(0, 0);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(845, 401);
            dataGrid.TabIndex = 0;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
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
            Date.FillWeight = 12.6903543F;
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // Visitor
            // 
            Visitor.FillWeight = 121.827477F;
            Visitor.HeaderText = "Visitor";
            Visitor.Name = "Visitor";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 121.827477F;
            dataGridViewTextBoxColumn1.HeaderText = "Slip No";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.FillWeight = 121.827477F;
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.FillWeight = 121.827477F;
            TotalAmount.HeaderText = "TotalAmount";
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnShow);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnPrint);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 401);
            panel3.Name = "panel3";
            panel3.Size = new Size(845, 49);
            panel3.TabIndex = 2;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(137, 7);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(117, 36);
            btnShow.TabIndex = 3;
            btnShow.Text = "Show Detail";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(383, 7);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 36);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(260, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 36);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(16, 7);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(117, 36);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // PendingPackingSlipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PendingPackingSlipForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pending Packing Slips";
            Load += PendingPackingSlipForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Visitor;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn TotalAmount;
        private Button btnShow;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnPrint;
    }
}