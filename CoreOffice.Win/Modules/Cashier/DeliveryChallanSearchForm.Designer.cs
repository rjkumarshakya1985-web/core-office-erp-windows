namespace CoreOffice.Win.Modules.Cashier
{
    partial class DeliveryChallanSearchForm
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 9.75F);
            btnSearch.Location = new Point(408, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(111, 26);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.75F);
            txtSearch.Location = new Point(155, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(238, 25);
            txtSearch.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(7, 18);
            label1.Name = "label1";
            label1.Size = new Size(146, 17);
            label1.TabIndex = 3;
            label1.Text = "DELIVERY CHALLAN NO";
            // 
            // DeliveryChallanSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 53);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeliveryChallanSearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delivery Challan Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
    }
}