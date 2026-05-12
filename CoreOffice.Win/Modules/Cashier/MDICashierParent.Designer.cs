using CoreOffice.Win.Session;

namespace CoreOffice.Win.Modules.Cashier
{
    partial class MDICashierParent
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDICashierParent));
            menuStrip = new MenuStrip();
            invoiceToolStripMenuItem = new ToolStripMenuItem();
            createInvoiceToolStripMenuItem = new ToolStripMenuItem();
            searchPackingSlipToolStripMenuItem = new ToolStripMenuItem();
            createPackingSlipToolStripMenuItem = new ToolStripMenuItem();
            deliveryChallanToolStripMenuItem = new ToolStripMenuItem();
            createDeliveryChallanToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            returnDeliverChallanItemToolStripMenuItem = new ToolStripMenuItem();
            searchChallanReturnToolStripMenuItem = new ToolStripMenuItem();
            deliveryChallanReturnListToolStripMenuItem = new ToolStripMenuItem();
            invoiceToolStripMenuItem1 = new ToolStripMenuItem();
            deliveryChallanToInvoiceToolStripMenuItem = new ToolStripMenuItem();
            createInvoiceToolStripMenuItem1 = new ToolStripMenuItem();
            invoiceListToolStripMenuItem = new ToolStripMenuItem();
            searchInvoiceToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            createCreditNoteToolStripMenuItem = new ToolStripMenuItem();
            creditNoteListToolStripMenuItem = new ToolStripMenuItem();
            searchCreditNoteToolStripMenuItem = new ToolStripMenuItem();
            tallyToolStripMenuItem = new ToolStripMenuItem();
            purchaseTallySnyncToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            lblCompany = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            panelTop = new Panel();
            menuicon = new PictureBox();
            button4 = new Button();
            label4 = new Label();
            label3 = new Label();
            panelSidebar = new Panel();
            pictureBox1 = new PictureBox();
            panelContainer = new Panel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuicon).BeginInit();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { invoiceToolStripMenuItem, deliveryChallanToolStripMenuItem, invoiceToolStripMenuItem1, tallyToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(737, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // invoiceToolStripMenuItem
            // 
            invoiceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createInvoiceToolStripMenuItem, searchPackingSlipToolStripMenuItem, createPackingSlipToolStripMenuItem });
            invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            invoiceToolStripMenuItem.Size = new Size(83, 20);
            invoiceToolStripMenuItem.Text = "Packing Slip";
            // 
            // createInvoiceToolStripMenuItem
            // 
            createInvoiceToolStripMenuItem.Name = "createInvoiceToolStripMenuItem";
            createInvoiceToolStripMenuItem.Size = new Size(176, 22);
            createInvoiceToolStripMenuItem.Text = "Packing Slip List";
            createInvoiceToolStripMenuItem.Click += createInvoiceToolStripMenuItem_Click;
            // 
            // searchPackingSlipToolStripMenuItem
            // 
            searchPackingSlipToolStripMenuItem.Name = "searchPackingSlipToolStripMenuItem";
            searchPackingSlipToolStripMenuItem.Size = new Size(176, 22);
            searchPackingSlipToolStripMenuItem.Text = "Search Packing Slip";
            searchPackingSlipToolStripMenuItem.Click += searchPackingSlipToolStripMenuItem_Click;
            // 
            // createPackingSlipToolStripMenuItem
            // 
            createPackingSlipToolStripMenuItem.Name = "createPackingSlipToolStripMenuItem";
            createPackingSlipToolStripMenuItem.Size = new Size(176, 22);
            createPackingSlipToolStripMenuItem.Text = "Create Packing Slip";
            createPackingSlipToolStripMenuItem.Click += createPackingSlipToolStripMenuItem_Click;
            // 
            // deliveryChallanToolStripMenuItem
            // 
            deliveryChallanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createDeliveryChallanToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripSeparator1, returnDeliverChallanItemToolStripMenuItem, searchChallanReturnToolStripMenuItem, deliveryChallanReturnListToolStripMenuItem });
            deliveryChallanToolStripMenuItem.Enabled = false;
            deliveryChallanToolStripMenuItem.Name = "deliveryChallanToolStripMenuItem";
            deliveryChallanToolStripMenuItem.Size = new Size(104, 20);
            deliveryChallanToolStripMenuItem.Text = "Delivery Challan";
            // 
            // createDeliveryChallanToolStripMenuItem
            // 
            createDeliveryChallanToolStripMenuItem.Name = "createDeliveryChallanToolStripMenuItem";
            createDeliveryChallanToolStripMenuItem.Size = new Size(218, 22);
            createDeliveryChallanToolStripMenuItem.Text = "Create Delivery Challan";
            createDeliveryChallanToolStripMenuItem.Click += createDeliveryChallanToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(218, 22);
            toolStripMenuItem1.Text = "Search Delivery Challan";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(218, 22);
            toolStripMenuItem2.Text = "Delivery Challan List";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(215, 6);
            // 
            // returnDeliverChallanItemToolStripMenuItem
            // 
            returnDeliverChallanItemToolStripMenuItem.Name = "returnDeliverChallanItemToolStripMenuItem";
            returnDeliverChallanItemToolStripMenuItem.Size = new Size(218, 22);
            returnDeliverChallanItemToolStripMenuItem.Text = "Delivery Challan Return";
            returnDeliverChallanItemToolStripMenuItem.Click += returnDeliverChallanItemToolStripMenuItem_Click;
            // 
            // searchChallanReturnToolStripMenuItem
            // 
            searchChallanReturnToolStripMenuItem.Name = "searchChallanReturnToolStripMenuItem";
            searchChallanReturnToolStripMenuItem.Size = new Size(218, 22);
            searchChallanReturnToolStripMenuItem.Text = "Search Challan Return";
            // 
            // deliveryChallanReturnListToolStripMenuItem
            // 
            deliveryChallanReturnListToolStripMenuItem.Name = "deliveryChallanReturnListToolStripMenuItem";
            deliveryChallanReturnListToolStripMenuItem.Size = new Size(218, 22);
            deliveryChallanReturnListToolStripMenuItem.Text = "Delivery Challan Return List";
            // 
            // invoiceToolStripMenuItem1
            // 
            invoiceToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { deliveryChallanToInvoiceToolStripMenuItem, createInvoiceToolStripMenuItem1, invoiceListToolStripMenuItem, searchInvoiceToolStripMenuItem, toolStripSeparator2, createCreditNoteToolStripMenuItem, creditNoteListToolStripMenuItem, searchCreditNoteToolStripMenuItem });
            invoiceToolStripMenuItem1.Enabled = false;
            invoiceToolStripMenuItem1.Name = "invoiceToolStripMenuItem1";
            invoiceToolStripMenuItem1.Size = new Size(57, 20);
            invoiceToolStripMenuItem1.Text = "Invoice";
            // 
            // deliveryChallanToInvoiceToolStripMenuItem
            // 
            deliveryChallanToInvoiceToolStripMenuItem.Name = "deliveryChallanToInvoiceToolStripMenuItem";
            deliveryChallanToInvoiceToolStripMenuItem.Size = new Size(215, 22);
            deliveryChallanToInvoiceToolStripMenuItem.Text = "&Delivery Challan To Invoice";
            deliveryChallanToInvoiceToolStripMenuItem.Click += deliveryChallanToInvoiceToolStripMenuItem_Click;
            // 
            // createInvoiceToolStripMenuItem1
            // 
            createInvoiceToolStripMenuItem1.Name = "createInvoiceToolStripMenuItem1";
            createInvoiceToolStripMenuItem1.Size = new Size(215, 22);
            createInvoiceToolStripMenuItem1.Text = "Create &Invoice";
            createInvoiceToolStripMenuItem1.Click += createInvoiceToolStripMenuItem1_Click;
            // 
            // invoiceListToolStripMenuItem
            // 
            invoiceListToolStripMenuItem.Name = "invoiceListToolStripMenuItem";
            invoiceListToolStripMenuItem.Size = new Size(215, 22);
            invoiceListToolStripMenuItem.Text = "Invoice List";
            invoiceListToolStripMenuItem.Click += invoiceListToolStripMenuItem_Click;
            // 
            // searchInvoiceToolStripMenuItem
            // 
            searchInvoiceToolStripMenuItem.Name = "searchInvoiceToolStripMenuItem";
            searchInvoiceToolStripMenuItem.Size = new Size(215, 22);
            searchInvoiceToolStripMenuItem.Text = "Search Invoice ";
            searchInvoiceToolStripMenuItem.Click += searchInvoiceToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(212, 6);
            // 
            // createCreditNoteToolStripMenuItem
            // 
            createCreditNoteToolStripMenuItem.Name = "createCreditNoteToolStripMenuItem";
            createCreditNoteToolStripMenuItem.Size = new Size(215, 22);
            createCreditNoteToolStripMenuItem.Text = "Create Credit Note";
            // 
            // creditNoteListToolStripMenuItem
            // 
            creditNoteListToolStripMenuItem.Name = "creditNoteListToolStripMenuItem";
            creditNoteListToolStripMenuItem.Size = new Size(215, 22);
            creditNoteListToolStripMenuItem.Text = "Credit Note List";
            // 
            // searchCreditNoteToolStripMenuItem
            // 
            searchCreditNoteToolStripMenuItem.Name = "searchCreditNoteToolStripMenuItem";
            searchCreditNoteToolStripMenuItem.Size = new Size(215, 22);
            searchCreditNoteToolStripMenuItem.Text = "Search Credit Note";
            // 
            // tallyToolStripMenuItem
            // 
            tallyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { purchaseTallySnyncToolStripMenuItem });
            tallyToolStripMenuItem.Name = "tallyToolStripMenuItem";
            tallyToolStripMenuItem.Size = new Size(42, 20);
            tallyToolStripMenuItem.Text = "Tally";
            // 
            // purchaseTallySnyncToolStripMenuItem
            // 
            purchaseTallySnyncToolStripMenuItem.Name = "purchaseTallySnyncToolStripMenuItem";
            purchaseTallySnyncToolStripMenuItem.Size = new Size(176, 22);
            purchaseTallySnyncToolStripMenuItem.Text = "Purchase Tally Sync";
            purchaseTallySnyncToolStripMenuItem.Click += purchaseTallySnyncToolStripMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { lblCompany });
            statusStrip.Location = new Point(0, 501);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(737, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // lblCompany
            // 
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(39, 17);
            lblCompany.Text = "Status";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(menuicon);
            panelTop.Controls.Add(button4);
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(label3);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 24);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10, 5, 10, 5);
            panelTop.Size = new Size(737, 55);
            panelTop.TabIndex = 6;
            // 
            // menuicon
            // 
            menuicon.Cursor = Cursors.Hand;
            menuicon.Image = Properties.Resources.menu;
            menuicon.Location = new Point(7, 8);
            menuicon.Name = "menuicon";
            menuicon.Size = new Size(47, 39);
            menuicon.SizeMode = PictureBoxSizeMode.StretchImage;
            menuicon.TabIndex = 3;
            menuicon.TabStop = false;
            menuicon.Click += menuicon_Click;
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Location = new Point(628, 5);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 1;
            label4.Text = $"Welcome, {UserSession.RoleEnum}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(27, 79, 156);
            label3.Location = new Point(60, 15);
            label3.Name = "label3";
            label3.Size = new Size(336, 21);
            label3.TabIndex = 0;
            label3.Text = "SHIV SAHAY BHAGWAN DAS SAREES PVT. LTD.";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(27, 79, 156);
            panelSidebar.Controls.Add(pictureBox1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 79);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 422);
            panelSidebar.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ssbd_sidebar_logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(220, 79);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(517, 422);
            panelContainer.TabIndex = 9;
            // 
            // MDICashierParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(737, 523);
            Controls.Add(panelContainer);
            Controls.Add(panelSidebar);
            Controls.Add(panelTop);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDICashierParent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shiv Sahay Bhagwan das Sarees Pvt Ltd. -MDI";
            WindowState = FormWindowState.Maximized;
            Load += MDICashierParent_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuicon).EndInit();
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblCompany;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem invoiceToolStripMenuItem;
        private ToolStripMenuItem createInvoiceToolStripMenuItem;
        private ToolStripMenuItem deliveryChallanToolStripMenuItem;
        private ToolStripMenuItem createDeliveryChallanToolStripMenuItem;
        private ToolStripMenuItem returnDeliverChallanItemToolStripMenuItem;
        private ToolStripMenuItem invoiceToolStripMenuItem1;
        private ToolStripMenuItem deliveryChallanToInvoiceToolStripMenuItem;
        private ToolStripMenuItem createInvoiceToolStripMenuItem1;
        private ToolStripMenuItem searchPackingSlipToolStripMenuItem;
        private ToolStripMenuItem invoiceListToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem searchChallanReturnToolStripMenuItem;
        private ToolStripMenuItem deliveryChallanReturnListToolStripMenuItem;
        private ToolStripMenuItem searchInvoiceToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem createCreditNoteToolStripMenuItem;
        private ToolStripMenuItem creditNoteListToolStripMenuItem;
        private ToolStripMenuItem searchCreditNoteToolStripMenuItem;
        private ToolStripMenuItem createPackingSlipToolStripMenuItem;
        private ToolStripMenuItem tallyToolStripMenuItem;
        private ToolStripMenuItem purchaseTallySnyncToolStripMenuItem;
        private Panel panelTop;
        private Label label3;
        private Label label4;
        private Button button4;
        private Panel panelSidebar;
        private Panel panelContainer;
        private PictureBox menuicon;
        private PictureBox pictureBox1;
    }
}



