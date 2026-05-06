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
            txtUser = new TextBox();
            txtPwd = new TextBox();
            btnLogin = new Button();
            btnHelp = new Button();
            btnMinimise = new Button();
            btnClose = new Button();
            label2 = new Label();
            label1 = new Label();
            gradientClass1 = new GradientClass();
            label5 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            gradientClass1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 12F);
            txtUser.Location = new Point(354, 193);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "User Name";
            txtUser.Size = new Size(252, 29);
            txtUser.TabIndex = 1;
            // 
            // txtPwd
            // 
            txtPwd.Font = new Font("Segoe UI", 12F);
            txtPwd.Location = new Point(354, 228);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.PlaceholderText = "Password";
            txtPwd.Size = new Size(252, 29);
            txtPwd.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(33, 145, 245);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(354, 286);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = Color.FromArgb(224, 224, 224);
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHelp.Location = new Point(486, 286);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(120, 36);
            btnHelp.TabIndex = 6;
            btnHelp.Text = "Help?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnMinimise
            // 
            btnMinimise.BackColor = Color.Transparent;
            btnMinimise.Font = new Font("Segoe UI", 12F);
            btnMinimise.Location = new Point(549, 2);
            btnMinimise.Name = "btnMinimise";
            btnMinimise.Size = new Size(41, 35);
            btnMinimise.TabIndex = 7;
            btnMinimise.Text = "-";
            btnMinimise.UseVisualStyleBackColor = false;
            btnMinimise.Click += btnMinimise_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 12F);
            btnClose.Location = new Point(596, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 35);
            btnClose.TabIndex = 8;
            btnClose.Text = "x";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(297, 150);
            label2.Name = "label2";
            label2.Size = new Size(309, 27);
            label2.TabIndex = 1;
            label2.Text = "SIGN IN TO YOUR ACCOUNT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 54);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO";
            // 
            // gradientClass1
            // 
            gradientClass1.BackColor = Color.Transparent;
            gradientClass1.Controls.Add(label5);
            gradientClass1.Controls.Add(label3);
            gradientClass1.Controls.Add(pictureBox1);
            gradientClass1.Controls.Add(label1);
            gradientClass1.GradientBottom = Color.FromArgb(33, 145, 245);
            gradientClass1.GradientTop = Color.FromArgb(9, 74, 158);
            gradientClass1.Location = new Point(1, 2);
            gradientClass1.Name = "gradientClass1";
            gradientClass1.Size = new Size(320, 420);
            gradientClass1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(2, 358);
            label5.Name = "label5";
            label5.Size = new Size(221, 45);
            label5.TabIndex = 10;
            label5.Text = "For more detail or help please \r\nemail us at info@brainsoftsoftware.com.\r\n or visit www.brainsoftsoftware.com";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 100);
            label3.Name = "label3";
            label3.Size = new Size(230, 38);
            label3.TabIndex = 2;
            label3.Text = "SHIV SAHAY BHAGWAN DAS\r\nAGRA, UTTAR PRADESH";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.shape_01_01;
            pictureBox1.Location = new Point(210, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 420);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ssbd_logo_new;
            pictureBox2.Location = new Point(354, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(449, 407);
            label4.Name = "label4";
            label4.Size = new Size(187, 15);
            label4.TabIndex = 3;
            label4.Text = "© 2026 Brainsoft Software Pvt Ltd.";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(639, 423);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(gradientClass1);
            Controls.Add(btnClose);
            Controls.Add(btnMinimise);
            Controls.Add(btnHelp);
            Controls.Add(btnLogin);
            Controls.Add(txtPwd);
            Controls.Add(txtUser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            gradientClass1.ResumeLayout(false);
            gradientClass1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUser;
        private TextBox txtPwd;
        private Button btnLogin;
        private Button btnHelp;
        private Button btnMinimise;
        private Button btnClose;
        private Label label2;
        private Label label1;
        private GradientClass gradientClass1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}