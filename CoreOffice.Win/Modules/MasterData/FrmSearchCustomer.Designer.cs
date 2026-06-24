namespace CoreOffice.Win.Modules.MasterData
{
    partial class FrmSearchCustomer
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
            pnlTop = new Panel();
            label1 = new Label();
            pnlLeft = new Panel();
            pnlBody = new Panel();
            panel1 = new Panel();
            btnAction = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            chkName = new CheckBox();
            chkMobile = new CheckBox();
            chkGSTIN = new CheckBox();
            txtSearch = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            label4 = new Label();
            lblName = new Label();
            lblMobile = new Label();
            label6 = new Label();
            lblEmail = new Label();
            label8 = new Label();
            lblPan = new Label();
            label10 = new Label();
            lblGSTIN = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            pnlTop.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlBody.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(18, 45, 90);
            pnlTop.Controls.Add(label1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1042, 45);
            pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "CUSTOMER LIST";
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(panel2);
            pnlLeft.Controls.Add(button1);
            pnlLeft.Controls.Add(btnDelete);
            pnlLeft.Controls.Add(btnUpdate);
            pnlLeft.Controls.Add(btnAdd);
            pnlLeft.Controls.Add(btnAction);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 45);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(200, 461);
            pnlLeft.TabIndex = 1;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(panel3);
            pnlBody.Controls.Add(dataGridView1);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(200, 45);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new Size(842, 461);
            pnlBody.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label17);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lblGSTIN);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(lblPan);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblMobile);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(200, 354);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 152);
            panel1.TabIndex = 3;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.FromArgb(18, 45, 90);
            btnAction.Font = new Font("Segoe UI", 12F);
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(0, 0);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(200, 38);
            btnAction.TabIndex = 0;
            btnAction.Text = "Actions";
            btnAction.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.RoyalBlue;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(0, 38);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 38);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add (F9)";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(245, 158, 11);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(0, 77);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(200, 38);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update (F3)";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(239, 68, 68);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(0, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(200, 38);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete (DEL)";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(55, 65, 81);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 155);
            button1.Name = "button1";
            button1.Size = new Size(200, 38);
            button1.TabIndex = 4;
            button1.Text = "Close (ESC)";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(chkGSTIN);
            panel2.Controls.Add(chkMobile);
            panel2.Controls.Add(chkName);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 265);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Search By";
            // 
            // chkName
            // 
            chkName.AutoSize = true;
            chkName.BackColor = Color.FromArgb(18, 45, 90);
            chkName.ForeColor = Color.White;
            chkName.Location = new Point(3, 30);
            chkName.Name = "chkName";
            chkName.Size = new Size(58, 19);
            chkName.TabIndex = 1;
            chkName.Text = "Name";
            chkName.UseVisualStyleBackColor = false;
            // 
            // chkMobile
            // 
            chkMobile.AutoSize = true;
            chkMobile.BackColor = Color.FromArgb(18, 45, 90);
            chkMobile.ForeColor = Color.White;
            chkMobile.Location = new Point(67, 30);
            chkMobile.Name = "chkMobile";
            chkMobile.Size = new Size(63, 19);
            chkMobile.TabIndex = 2;
            chkMobile.Text = "Mobile";
            chkMobile.UseVisualStyleBackColor = false;
            // 
            // chkGSTIN
            // 
            chkGSTIN.AutoSize = true;
            chkGSTIN.BackColor = Color.FromArgb(18, 45, 90);
            chkGSTIN.ForeColor = Color.White;
            chkGSTIN.Location = new Point(134, 30);
            chkGSTIN.Name = "chkGSTIN";
            chkGSTIN.Size = new Size(59, 19);
            chkGSTIN.TabIndex = 3;
            chkGSTIN.Text = "GSTIN";
            chkGSTIN.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15.75F);
            txtSearch.Location = new Point(138, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(701, 35);
            txtSearch.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(6, 10);
            label3.Name = "label3";
            label3.Size = new Size(132, 28);
            label3.TabIndex = 4;
            label3.Text = "Search Here....";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(842, 461);
            dataGridView1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 48);
            panel3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(6, 11);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 5;
            label4.Text = "Name";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.Location = new Point(51, 11);
            lblName.Name = "lblName";
            lblName.Size = new Size(24, 15);
            lblName.TabIndex = 6;
            lblName.Text = "NA";
            // 
            // lblMobile
            // 
            lblMobile.AutoSize = true;
            lblMobile.Font = new Font("Segoe UI", 9F);
            lblMobile.Location = new Point(51, 26);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(24, 15);
            lblMobile.TabIndex = 8;
            lblMobile.Text = "NA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 7;
            label6.Text = "Mobile";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F);
            lblEmail.Location = new Point(51, 41);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(24, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "NA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(6, 41);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 9;
            label8.Text = "Email";
            // 
            // lblPan
            // 
            lblPan.AutoSize = true;
            lblPan.Font = new Font("Segoe UI", 9F);
            lblPan.Location = new Point(51, 56);
            lblPan.Name = "lblPan";
            lblPan.Size = new Size(24, 15);
            lblPan.TabIndex = 12;
            lblPan.Text = "NA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.Location = new Point(6, 56);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 11;
            label10.Text = "PAN";
            // 
            // lblGSTIN
            // 
            lblGSTIN.AutoSize = true;
            lblGSTIN.Font = new Font("Segoe UI", 9F);
            lblGSTIN.Location = new Point(51, 71);
            lblGSTIN.Name = "lblGSTIN";
            lblGSTIN.Size = new Size(24, 15);
            lblGSTIN.TabIndex = 14;
            lblGSTIN.Text = "NA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(6, 71);
            label12.Name = "label12";
            label12.Size = new Size(40, 15);
            label12.TabIndex = 13;
            label12.Text = "GSTIN";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F);
            label13.Location = new Point(51, 86);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 16;
            label13.Text = "NA";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F);
            label14.Location = new Point(6, 86);
            label14.Name = "label14";
            label14.Size = new Size(39, 15);
            label14.TabIndex = 15;
            label14.Text = "Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F);
            label15.Location = new Point(51, 101);
            label15.Name = "label15";
            label15.Size = new Size(24, 15);
            label15.TabIndex = 18;
            label15.Text = "NA";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F);
            label16.Location = new Point(6, 101);
            label16.Name = "label16";
            label16.Size = new Size(39, 15);
            label16.TabIndex = 17;
            label16.Text = "Name";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F);
            label17.Location = new Point(51, 116);
            label17.Name = "label17";
            label17.Size = new Size(24, 15);
            label17.TabIndex = 20;
            label17.Text = "NA";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F);
            label18.Location = new Point(6, 116);
            label18.Name = "label18";
            label18.Size = new Size(39, 15);
            label18.TabIndex = 19;
            label18.Text = "Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F);
            label19.Location = new Point(51, 131);
            label19.Name = "label19";
            label19.Size = new Size(24, 15);
            label19.TabIndex = 22;
            label19.Text = "NA";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F);
            label20.Location = new Point(6, 131);
            label20.Name = "label20";
            label20.Size = new Size(39, 15);
            label20.TabIndex = 21;
            label20.Text = "Name";
            // 
            // FrmSearchCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 506);
            Controls.Add(panel1);
            Controls.Add(pnlBody);
            Controls.Add(pnlLeft);
            Controls.Add(pnlTop);
            Name = "FrmSearchCustomer";
            Text = "FrmSearchCustomer";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Label label1;
        private Panel pnlLeft;
        private Panel pnlBody;
        private Panel panel1;
        private Button btnAction;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button button1;
        private Panel panel2;
        private Label label2;
        private CheckBox chkName;
        private CheckBox chkMobile;
        private CheckBox chkGSTIN;
        private TextBox txtSearch;
        private Label label3;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Label label4;
        private Label lblName;
        private Label label19;
        private Label label20;
        private Label label17;
        private Label label18;
        private Label label15;
        private Label label16;
        private Label label13;
        private Label label14;
        private Label lblGSTIN;
        private Label label12;
        private Label lblPan;
        private Label label10;
        private Label lblEmail;
        private Label label8;
        private Label lblMobile;
        private Label label6;
    }
}