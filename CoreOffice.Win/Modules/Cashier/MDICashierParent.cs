

using CoreOffice.Win.Modules.Cashier.Invoices;
using CoreOffice.Win.Modules.PackingSlip;
using CoreOffice.Win.Modules.Shared;
using CoreOffice.Win.Modules.TallySynch;
using CoreOffice.Win.Session;
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;


namespace CoreOffice.Win.Modules.Cashier
{
    public partial class MDICashierParent : Form
    {
        private int childFormNumber = 0;
        private Panel topPanel;
        private Label lblCompanyInfo;
        private Button btnChangeCompany;

        private readonly IServiceProvider _serviceProvider;
        private readonly IFinanceYearService _financeYearService;


        public MDICashierParent(IServiceProvider serviceProvider, IFinanceYearService financeYearService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _financeYearService = financeYearService;
            InitializeHeader();
        }

        public T GetService<T>()
        {
            return _serviceProvider.GetRequiredService<T>();
        }   

        //public void OpenFormInPanel(Form form)
        //{
        //    // Close existing form
        //    if (activeForm != null)
        //    {
        //        activeForm.Close();
        //        activeForm.Dispose();
        //    }

        //    panelContainer.Controls.Clear();

        //    activeForm = form;

        //    form.TopLevel = false;
        //    form.FormBorderStyle = FormBorderStyle.None;
        //    form.Dock = DockStyle.Fill;

        //    panelContainer.Controls.Add(form);

        //    form.FormClosed += Form_FormClosed;

        //    form.Show();
        //}
       
        private void InitializeHeader()
        {
            topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 40,
                BackColor = Color.FromArgb(45, 45, 48)
            };

            // ✅ Table Layout (Center alignment ke liye best)
            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3
            };

            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // left space
            table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));    // content
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // right space

            // ✅ Inner panel (label + button together)
            var innerPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false
            };

            lblCompanyInfo = new Label
            {
                ForeColor = Color.White,
                AutoSize = true,
                Margin = new Padding(0, 10, 10, 0) // spacing
            };

            btnChangeCompany = new Button
            {
                Text = "Change",
                AutoSize = true,
                Height = 25,
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(0, 5, 0, 0)
            };

            btnChangeCompany.Click += BtnChangeCompany_Click;

            // Add to inner panel
            innerPanel.Controls.Add(lblCompanyInfo);
            innerPanel.Controls.Add(btnChangeCompany);

            // Add to center column
            table.Controls.Add(innerPanel, 1, 0);

            topPanel.Controls.Add(table);
            this.Controls.Add(topPanel);
        }
        private void UpdateCompanyHeader()
        {
            if (lblCompanyInfo == null) return;

            lblCompanyInfo.Text = $"Company: {UserSession.FinanceYearName}";
            lblCompanyInfo.Refresh();

        }
        private DashboardForm dashboard;
        private async void MDICashierParent_Load(object sender, EventArgs e)
        {
            try
            {


                var result = await _financeYearService.GetActiveFinanceYears();

                if (result != null && result.Any())
                {

                    AppCache.Companies = result.ToList();

                    var activeFY = result.FirstOrDefault();

                    if (activeFY != null)
                    {
                        lblCompanyInfo.Text = $"Company: {activeFY.Name}";
                        UserSession.FinanceYearId = activeFY.Id;
                    }
                    else
                    {
                        lblCompanyInfo.Text = "No Active Financial Year";
                    }
                }
                else
                {
                    lblCompanyInfo.Text = "No Active Financial Year";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading financial year: " + ex.Message);
            }
            BindPanelsidebar(); 
            dashboard = new DashboardForm();
            OpenChild(dashboard);
        }
        private Form activeForm = null;      
        public void OpenChild(Form child)
        {
            // Remove current form
            if (activeForm != null)
            {
                panelContainer.Controls.Remove(activeForm);
                // Don't dispose dashboard
                if (!(activeForm is DashboardForm))
                {
                    activeForm.FormClosed -= Child_FormClosed;
                    activeForm.Close();
                    activeForm.Dispose();
                }
                else
                {
                    activeForm.Hide();
                }
            }

            activeForm = child;

            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            if (!panelContainer.Controls.Contains(child))
            {
                panelContainer.Controls.Add(child);

                child.FormClosed -= Child_FormClosed;
                child.FormClosed += Child_FormClosed;
            }
            child.Show();
            child.BringToFront();
        }
        private void Logout()
        {
            DialogResult result = MessageBox.Show(
                "Do you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear session data             
                UserSession.FinanceYearId = 0;

                // Open login form
                Login login = new Login(null,null,null,null);
                login.Show();

                // Hide or close current form
                this.Hide();
            }
        }
        private void Child_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(sender is DashboardForm))
            {
                OpenChild(dashboard);
            }
        }
        public void BindPanelsidebar()
        {
            panelSidebar.Controls.Add(CreateSidebarButton("Dashboard", Properties.Resources.home, 120, (s, e) =>{OpenChild(dashboard);}));
            panelSidebar.Controls.Add(CreateSidebarButton("Packing Slip", Properties.Resources.packingslip, 170, (s, e) =>{var frm = GetService<FrmPackingSlip>();OpenChild(frm);}));
            panelSidebar.Controls.Add(CreateSidebarButton("Delivery Challan", Properties.Resources.delivery, 180,(s, e) =>{ OpenChild(dashboard); }));
            panelSidebar.Controls.Add(CreateSidebarButton("Invoice", Properties.Resources.bill, 220, (s, e) => { OpenChild(dashboard); }));
            panelSidebar.Controls.Add(CreateSidebarButton("Tally", Properties.Resources.calculator, 280, (s, e) => { var frm = GetService<TallySynchPurchase>(); OpenChild(frm); }));
            panelSidebar.Controls.Add(CreateSidebarButton("Reports", Properties.Resources.combo_chart, 330, (s, e) => { OpenChild(dashboard); }));
            panelSidebar.Controls.Add(CreateSidebarButton("Settings", Properties.Resources.settings, 380, (s, e) => { OpenChild(dashboard); }));
            panelSidebar.Controls.Add(CreateSidebarButton("Logout", Properties.Resources.turn_off, 420, (s, e) => { Logout(); }));
        }
        private Panel CreateSidebarButton(string text, Image icon, int top,  EventHandler clickEvent)
        {
            Panel panel = new Panel();
            panel.Width = 220;
            panel.Height = 50;
            panel.Top = top;
            panel.BackColor = Color.FromArgb(27, 79, 156);
            panel.Cursor = Cursors.Hand;

            PictureBox pic = new PictureBox();
            pic.Image = icon;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Size = new Size(24, 24);
            pic.Location = new Point(15, 13);
            pic.Cursor = Cursors.Hand;


            Label lbl = new Label();
            lbl.Text = text;
            lbl.ForeColor = Color.White;
            lbl.Font = new Font("Segoe UI", 10);
            lbl.AutoSize = true;
            lbl.Location = new Point(50, 15);
            lbl.Cursor = Cursors.Hand;

            panel.Controls.Add(pic);
            panel.Controls.Add(lbl);           

            panel.MouseEnter += (s, e) =>
                panel.BackColor = Color.FromArgb(47, 128, 237);

            panel.MouseLeave += (s, e) =>
                panel.BackColor = Color.FromArgb(27, 79, 156);

            // Clicks
            panel.Click += clickEvent;
            pic.Click += clickEvent;
            lbl.Click += clickEvent;

            return panel;
        }
        private void BtnChangeCompany_Click(object sender, EventArgs e)
        {

            var form = new CompanySelectionForm(this);
            form.Show();
        }

        public void UpdateFinanceYear()
        {
            //  Header update
            UpdateCompanyHeader();

            //  Close all child forms
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
        private void createInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<PendingPackingSlipForm>();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void invoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<InvoiceForm>();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void createDeliveryChallanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<DeliveryNoteForm>();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void returnDeliverChallanItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<DeliveryChallanReturnDetailForm>();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void deliveryChallanToInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<DeliveryChallanToInvoiceForm>();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void createInvoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<InvoiceForm>();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void searchPackingSlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<PackingSlipViewForm>();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void invoiceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<InvoiceListForm>();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<DeliveryChallanEditViewForm>();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }


        private void searchInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var childForm = _serviceProvider.GetRequiredService<InvoiceSearchForm>();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void createPackingSlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<FrmPackingSlip>();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<DeliveryChallanListForm>();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void purchaseTallySnyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var childForm = _serviceProvider.GetRequiredService<TallySynchPurchase>();
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void menuicon_Click(object sender, EventArgs e)
        {
            if (panelSidebar.Width == 220)
                    panelSidebar.Width = 60;
                else
                    panelSidebar.Width = 220;
            
        }
    }
}
