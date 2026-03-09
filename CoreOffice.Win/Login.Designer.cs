namespace CoreOffice.Win
{
    partial class Login
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
            label1 = new Label();
            txtUser = new TextBox();
            txtPwd = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnLogin = new Button();
            btnHelp = new Button();
            btnMinimise = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 39);
            label1.TabIndex = 0;
            label1.Text = "Welcome User!";
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 20F);
            txtUser.Location = new Point(217, 109);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(318, 43);
            txtUser.TabIndex = 1;
            // 
            // txtPwd
            // 
            txtPwd.Font = new Font("Segoe UI", 20F);
            txtPwd.Location = new Point(217, 168);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(318, 43);
            txtPwd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 120);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(115, 183);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(224, 224, 224);
            btnLogin.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(217, 221);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(153, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.FromArgb(224, 224, 224);
            btnHelp.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelp.Location = new Point(376, 221);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(159, 36);
            btnHelp.TabIndex = 6;
            btnHelp.Text = "Help?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnMinimise
            // 
            btnMinimise.BackColor = Color.Transparent;
            btnMinimise.Font = new Font("Segoe UI", 25F);
            btnMinimise.Location = new Point(483, 2);
            btnMinimise.Name = "btnMinimise";
            btnMinimise.Size = new Size(75, 68);
            btnMinimise.TabIndex = 7;
            btnMinimise.Text = "-";
            btnMinimise.UseVisualStyleBackColor = false;
            btnMinimise.Click += btnMinimise_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 25F);
            btnClose.Location = new Point(564, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 68);
            btnClose.TabIndex = 8;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(215, 238, 216);
            ClientSize = new Size(639, 305);
            Controls.Add(btnClose);
            Controls.Add(btnMinimise);
            Controls.Add(btnHelp);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPwd);
            Controls.Add(txtUser);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUser;
        private TextBox txtPwd;
        private Label label2;
        private Label label3;
        private Button btnLogin;
        private Button btnHelp;
        private Button btnMinimise;
        private Button btnClose;
    }
}