namespace CoreOffice.Win.Modules.Cashier
{
    partial class VisitorForm
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
            rdScanner = new RadioButton();
            rdMobile = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdMobile);
            groupBox1.Controls.Add(rdScanner);
            groupBox1.Controls.Add(txtScanner);
            groupBox1.Location = new Point(1, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 114);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fetech All PackingSlips By Visitor";
            // 
            // txtScanner
            // 
            txtScanner.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScanner.Location = new Point(34, 56);
            txtScanner.Name = "txtScanner";
            txtScanner.Size = new Size(340, 33);
            txtScanner.TabIndex = 0;
            txtScanner.KeyDown += txtScanner_KeyDown;
            // 
            // rdScanner
            // 
            rdScanner.AutoSize = true;
            rdScanner.Location = new Point(35, 25);
            rdScanner.Name = "rdScanner";
            rdScanner.Size = new Size(134, 19);
            rdScanner.TabIndex = 1;
            rdScanner.TabStop = true;
            rdScanner.Text = "Search By Visitor Slip";
            rdScanner.UseVisualStyleBackColor = true;
            // 
            // rdMobile
            // 
            rdMobile.AutoSize = true;
            rdMobile.Location = new Point(237, 25);
            rdMobile.Name = "rdMobile";
            rdMobile.Size = new Size(133, 19);
            rdMobile.TabIndex = 2;
            rdMobile.TabStop = true;
            rdMobile.Text = "Search By Mobile no";
            rdMobile.UseVisualStyleBackColor = true;
            // 
            // VisitorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 120);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VisitorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VisitorForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtScanner;
        private RadioButton rdMobile;
        private RadioButton rdScanner;
    }
}