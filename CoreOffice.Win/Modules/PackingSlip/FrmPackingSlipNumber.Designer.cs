namespace CoreOffice.Win.Modules.PackingSlip
{
    partial class FrmPackingSlipNumber
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
            groupBox1 = new GroupBox();
            txtScanner = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtScanner);
            groupBox1.Location = new Point(9, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 114);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search By PackingSlip Number";
            // 
            // txtScanner
            // 
            txtScanner.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScanner.Location = new Point(34, 43);
            txtScanner.Name = "txtScanner";
            txtScanner.Size = new Size(340, 33);
            txtScanner.TabIndex = 0;
            txtScanner.KeyDown += txtScanner_KeyDown;
            // 
            // FrmPackingSlipNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 121);
            Controls.Add(groupBox1);
            Name = "FrmPackingSlipNumber";
            Text = "PackingSlip Number";
            Load += FrmPackingSlipNumber_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtScanner;
    }
}