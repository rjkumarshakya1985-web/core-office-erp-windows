namespace CoreOffice.Win.Modules.Shared
{
    partial class AddUpdateProductQtyForm
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
            txtProductQty.Location = new Point(37, 14);
            txtProductQty.Name = "txtProductQty";
            txtProductQty.Size = new Size(252, 23);
            txtProductQty.TabIndex = 1;
            txtProductQty.KeyDown += txtProductQty_KeyDown;
            // 
            // AddUpdateProductQtyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 54);
            Controls.Add(txtProductQty);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddUpdateProductQtyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add /Update Product Qty";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductQty;
    }
}