namespace CoreOffice.Packingslip
{
    partial class MDIParent
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
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            newPackingSlipToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            updatePackingSlipToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            dailyPackingSlipToolStripMenuItem = new ToolStripMenuItem();
            dailyVisitorSlipToolStripMenuItem = new ToolStripMenuItem();
            statusStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 431);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(975, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, transactionToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(975, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            // 
            // transactionToolStripMenuItem
            // 
            transactionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator2, newPackingSlipToolStripMenuItem, toolStripSeparator1, updatePackingSlipToolStripMenuItem, toolStripSeparator3 });
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(80, 20);
            transactionToolStripMenuItem.Text = "Transaction";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(176, 6);
            // 
            // newPackingSlipToolStripMenuItem
            // 
            newPackingSlipToolStripMenuItem.Name = "newPackingSlipToolStripMenuItem";
            newPackingSlipToolStripMenuItem.Size = new Size(179, 22);
            newPackingSlipToolStripMenuItem.Text = "New Packing Slip";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(176, 6);
            // 
            // updatePackingSlipToolStripMenuItem
            // 
            updatePackingSlipToolStripMenuItem.Name = "updatePackingSlipToolStripMenuItem";
            updatePackingSlipToolStripMenuItem.Size = new Size(179, 22);
            updatePackingSlipToolStripMenuItem.Text = "Update Packing Slip";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(176, 6);
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dailyPackingSlipToolStripMenuItem, dailyVisitorSlipToolStripMenuItem });
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // dailyPackingSlipToolStripMenuItem
            // 
            dailyPackingSlipToolStripMenuItem.Name = "dailyPackingSlipToolStripMenuItem";
            dailyPackingSlipToolStripMenuItem.Size = new Size(167, 22);
            dailyPackingSlipToolStripMenuItem.Text = "Daily Packing Slip";
            // 
            // dailyVisitorSlipToolStripMenuItem
            // 
            dailyVisitorSlipToolStripMenuItem.Name = "dailyVisitorSlipToolStripMenuItem";
            dailyVisitorSlipToolStripMenuItem.Size = new Size(167, 22);
            dailyVisitorSlipToolStripMenuItem.Text = "Daily Visitor Slip";
            // 
            // MDIParent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(975, 453);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDIParent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MDIParent";
            WindowState = FormWindowState.Maximized;
            Load += MDIParent_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem newPackingSlipToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem updatePackingSlipToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem dailyPackingSlipToolStripMenuItem;
        private ToolStripMenuItem dailyVisitorSlipToolStripMenuItem;
    }
}



