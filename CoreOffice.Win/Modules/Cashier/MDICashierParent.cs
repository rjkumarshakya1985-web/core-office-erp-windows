

using CoreOffice.Win.Modules.Cashier.Invoices;
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
            var childForm = _serviceProvider.GetRequiredService<DeliveryNoteForm>();
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
    }
}
