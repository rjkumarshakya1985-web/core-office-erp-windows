namespace CoreOffice.Win.Modules.Cashier
{
    partial class CompanySelectionForm
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
            cmbFiananceYear = new ComboBox();
            btnChange = new Button();
            SuspendLayout();
            // 
            // cmbFiananceYear
            // 
            cmbFiananceYear.FormattingEnabled = true;
            cmbFiananceYear.Location = new Point(12, 18);
            cmbFiananceYear.Name = "cmbFiananceYear";
            cmbFiananceYear.Size = new Size(212, 23);
            cmbFiananceYear.TabIndex = 0;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(243, 17);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(111, 23);
            btnChange.TabIndex = 1;
            btnChange.Text = "&Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // CompanySelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 62);
            Controls.Add(btnChange);
            Controls.Add(cmbFiananceYear);
            Name = "CompanySelectionForm";
            Text = "Change Company Financial Year";
            Load += CompanySelectionForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbFiananceYear;
        private Button btnChange;
    }
}