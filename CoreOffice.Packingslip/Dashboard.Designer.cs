namespace CoreOffice.Packingslip
{
    partial class Dashboard
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
            panel1 = new Panel();
            lblWelcome = new Label();
            grpLeft = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            grpLeft.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 214);
            label1.Name = "label1";
            label1.Size = new Size(282, 39);
            label1.TabIndex = 1;
            label1.Text = "PackingSlip Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 84, 68);
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 71);
            panel1.TabIndex = 2;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(3, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(174, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome User!";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // grpLeft
            // 
            grpLeft.BackColor = Color.FromArgb(254, 253, 221);
            grpLeft.Controls.Add(button2);
            grpLeft.Controls.Add(button1);
            grpLeft.Dock = DockStyle.Left;
            grpLeft.Location = new Point(0, 71);
            grpLeft.Name = "grpLeft";
            grpLeft.Size = new Size(197, 379);
            grpLeft.TabIndex = 3;
            grpLeft.TabStop = false;
            grpLeft.Text = "Packing Slip";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(254, 253, 221);
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(6, 63);
            button2.Name = "button2";
            button2.Size = new Size(185, 35);
            button2.TabIndex = 5;
            button2.Text = "Update Packing Slip(Ctrl+U)";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(18, 84, 68);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(185, 35);
            button1.TabIndex = 4;
            button1.Text = "New Packing Slip(Ctrl+N)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpLeft);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpLeft.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label lblWelcome;
        private GroupBox grpLeft;
        private Button button1;
        private Button button2;
    }
}