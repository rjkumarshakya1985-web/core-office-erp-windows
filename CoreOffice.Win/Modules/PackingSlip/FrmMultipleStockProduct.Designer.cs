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
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Id, Barcode, WholeSaleRate, RetailRate, MrpRate, Quantity });
            dataGrid.Location = new Point(23, 25);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(765, 237);
            dataGrid.TabIndex = 0;
            dataGrid.CellClick += dataGrid_CellClick;
            dataGrid.CellDoubleClick += dataGrid_CellDoubleClick;
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
            btnClick.Location = new Point(339, 277);
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
            label1.Location = new Point(25, 4);
            label1.Name = "label1";
            label1.Size = new Size(431, 15);
            label1.TabIndex = 2;
            label1.Text = "इस प्रोडक्ट की अलग-अलग कीमतों पर कई एंट्री हैं। कृपया पैकिंग स्लिप बनाने के लिए एक चुनें।";
            // 
            // FrmMultipleStockProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 313);
            Controls.Add(label1);
            Controls.Add(btnClick);
            Controls.Add(dataGrid);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmMultipleStockProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Multiple Stock Product";
            Load += FrmMultipleStockProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
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
    }
}