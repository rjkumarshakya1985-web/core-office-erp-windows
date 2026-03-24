namespace CoreOffice.Win.Modules.Admin
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 161);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(86, 13);
            label2.TabIndex = 1;
            label2.Text = "Purchase Synch";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(408, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 41);
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
            // 
            // TallySynchPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 609);
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
    }
}