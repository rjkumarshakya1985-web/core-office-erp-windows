namespace CoreOffice.Win.Modules.PackingSlip
{
    partial class FrmProductQty
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
            txtProductQty = new TextBox();
            SuspendLayout();
            // 
            // txtProductQty
            // 
            txtProductQty.Location = new Point(23, 10);
            txtProductQty.Name = "txtProductQty";
            txtProductQty.Size = new Size(252, 23);
            txtProductQty.TabIndex = 0;
            txtProductQty.KeyDown += txtProductQty_KeyDown;
            // 
            // FrmProductQty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 49);
            Controls.Add(txtProductQty);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmProductQty";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Qty";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductQty;
    }
}