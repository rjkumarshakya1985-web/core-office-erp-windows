namespace CoreOffice.Win.Modules.PackingSlip
{
    partial class FrmMultipleStockProduct
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
            Barcode = new DataGridViewTextBoxColumn();
            WholeSaleRate = new DataGridViewTextBoxColumn();
            RetailRate = new DataGridViewTextBoxColumn();
            MrpRate = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            btnClick = new Button();
            label1 = new Label();
            erpHeader1 = new CoreOffice.Win.Shared.Controls.ERPHeader();
            erpLabel1 = new CoreOffice.Win.Shared.Controls.ERPLabel();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            erpHeader1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Barcode, WholeSaleRate, RetailRate, MrpRate, Quantity });
            dataGrid.Location = new Point(12, 141);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(765, 237);
            dataGrid.TabIndex = 0;
            dataGrid.CellClick += dataGrid_CellClick;
            dataGrid.CellDoubleClick += dataGrid_CellDoubleClick;
            dataGrid.KeyDown += dataGrid_KeyDown;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Barcode
            // 
            Barcode.HeaderText = "Barcode";
            Barcode.Name = "Barcode";
            // 
            // WholeSaleRate
            // 
            WholeSaleRate.HeaderText = "Whole Sale Rate";
            WholeSaleRate.Name = "WholeSaleRate";
            WholeSaleRate.ReadOnly = true;
            // 
            // RetailRate
            // 
            RetailRate.HeaderText = "Retail Rate";
            RetailRate.Name = "RetailRate";
            RetailRate.ReadOnly = true;
            // 
            // MrpRate
            // 
            MrpRate.HeaderText = "Mrp Rate";
            MrpRate.Name = "MrpRate";
            MrpRate.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // btnClick
            // 
            btnClick.Location = new Point(327, 384);
            btnClick.Name = "btnClick";
            btnClick.Size = new Size(129, 33);
            btnClick.TabIndex = 1;
            btnClick.Text = "Select";
            btnClick.UseVisualStyleBackColor = true;
            btnClick.Click += btnClick_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 101);
            label1.Name = "label1";
            label1.Size = new Size(431, 15);
            label1.TabIndex = 2;
            label1.Text = "इस प्रोडक्ट की अलग-अलग कीमतों पर कई एंट्री हैं। कृपया पैकिंग स्लिप बनाने के लिए एक चुनें।";
            // 
            // erpHeader1
            // 
            erpHeader1.BackColor = Color.FromArgb(18, 45, 90);
            erpHeader1.Controls.Add(erpLabel1);
            erpHeader1.Dock = DockStyle.Top;
            erpHeader1.Location = new Point(0, 0);
            erpHeader1.Name = "erpHeader1";
            erpHeader1.Size = new Size(982, 70);
            erpHeader1.SubTitle = "Select the required product/ rate for this barcode";
            erpHeader1.TabIndex = 3;
            erpHeader1.Title = "MULTIPLE STOCK FOUND";
            // 
            // erpLabel1
            // 
            erpLabel1.AutoSize = true;
            erpLabel1.Font = new Font("Segoe UI", 9F);
            erpLabel1.ForeColor = Color.White;
            erpLabel1.Location = new Point(795, 28);
            erpLabel1.Name = "erpLabel1";
            erpLabel1.Size = new Size(130, 15);
            erpLabel1.TabIndex = 0;
            erpLabel1.Text = "Barcode𝄃𝄃𝄂𝄂𝄀𝄁𝄃𝄂𝄂𝄃";
            // 
            // FrmMultipleStockProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 429);
            Controls.Add(erpHeader1);
            Controls.Add(label1);
            Controls.Add(btnClick);
            Controls.Add(dataGrid);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmMultipleStockProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multiple Stock Product";
            Load += FrmMultipleStockProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            erpHeader1.ResumeLayout(false);
            erpHeader1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private Button btnClick;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn WholeSaleRate;
        private DataGridViewTextBoxColumn RetailRate;
        private DataGridViewTextBoxColumn MrpRate;
        private DataGridViewTextBoxColumn Quantity;
        private Win.Shared.Controls.ERPHeader erpHeader1;
        private Win.Shared.Controls.ERPLabel erpLabel1;
    }
}