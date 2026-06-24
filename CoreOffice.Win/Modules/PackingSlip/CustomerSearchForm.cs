using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain.Responses.Customers;
using Microsoft.Extensions.DependencyInjection;

namespace CoreOffice.Win.Modules.PackingSlip
{
    public class CustomerSearchForm : Form
    {
        private readonly FrmPackingSlip _frmPackingSlip;
        private readonly IServiceProvider _serviceProvider;
        private readonly ICustomerService _customerService;       
        private Panel pnlTop;
        private Label label1;
        private Panel panel3;
        private TextBox txtSearch;
        private Label label3;
        private DataGridView gridCustomers;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn GSTIN;
        private List<CustomerResponse> _customers = new();

        public CustomerSearchForm(
            FrmPackingSlip frmPackingSlip,
            IServiceProvider serviceProvider,
            ICustomerService customerService)
        {
            _frmPackingSlip = frmPackingSlip;
            _serviceProvider = serviceProvider;
            _customerService = customerService;

            // InitializeForm();
            InitializeComponent();   // IMPORTANT
        }       

        private async void CustomerSearchForm_Load(object? sender, EventArgs e)
        {
            if (AppCache.BillingCustomers == null || AppCache.BillingCustomers.Count == 0)
            {
                AppCache.BillingCustomers = await _customerService.GetBillingCustomersAsync();
            }
            _customers = AppCache.BillingCustomers ?? new List<CustomerResponse>();         
            BindCustomers(_customers);

            txtSearch.Focus();
        }
        private void BindCustomers(List<CustomerResponse>? customers = null)
        {
            gridCustomers.AutoGenerateColumns = false;            
            gridCustomers.DataSource = null;
            gridCustomers.DataSource = customers ?? _customers;
           
        }  
        private void InitializeComponent()
        {
            pnlTop = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            txtSearch = new TextBox();
            label3 = new Label();
            gridCustomers = new DataGridView();
            CustomerName = new DataGridViewTextBoxColumn();
            Mobile = new DataGridViewTextBoxColumn();
            GSTIN = new DataGridViewTextBoxColumn();
            pnlTop.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridCustomers).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(18, 45, 90);
            pnlTop.Controls.Add(label1);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(842, 45);
            pnlTop.TabIndex = 1;
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
            // panel3
            // 
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 48);
            panel3.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15.75F);
            txtSearch.Location = new Point(138, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(701, 35);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
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
            // gridCustomers
            // 
            gridCustomers.AllowUserToAddRows = false;
            gridCustomers.AllowUserToDeleteRows = false;
            gridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerName, Mobile, GSTIN });
            gridCustomers.Dock = DockStyle.Fill;
            gridCustomers.Location = new Point(0, 93);
            gridCustomers.MultiSelect = false;
            gridCustomers.Name = "gridCustomers";
            gridCustomers.ReadOnly = true;
            gridCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCustomers.Size = new Size(842, 415);
            gridCustomers.TabIndex = 8;
            gridCustomers.KeyDown += gridCustomers_KeyDown;
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "Name";
            CustomerName.HeaderText = "Name";
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 250;
            // 
            // Mobile
            // 
            Mobile.DataPropertyName = "Mobile";
            Mobile.HeaderText = "Mobile";
            Mobile.Name = "Mobile";
            Mobile.ReadOnly = true;
            Mobile.Width = 150;
            // 
            // GSTIN
            // 
            GSTIN.DataPropertyName = "GSTIN";
            GSTIN.HeaderText = "GSTIN";
            GSTIN.Name = "GSTIN";
            GSTIN.ReadOnly = true;
            GSTIN.Width = 300;
            // 
            // CustomerSearchForm
            // 
            ClientSize = new Size(842, 508);
            Controls.Add(gridCustomers);
            Controls.Add(panel3);
            Controls.Add(pnlTop);
            Name = "CustomerSearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += CustomerSearchForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridCustomers).EndInit();
            ResumeLayout(false);

        }


        private void SelectCurrentCustomer()
        {
            if (gridCustomers.SelectedRows.Count == 0)
                return;

            var customer = gridCustomers.SelectedRows[0].DataBoundItem as CustomerResponse;

            if (customer == null)
                return;

            _frmPackingSlip.SetCustomerInfo(customer);
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(search))
            {
                // Show all customers when textbox is empty
                BindCustomers(_customers);
                return;
            }
            var filteredCustomers = _customers
             .Where(x =>
            (!string.IsNullOrWhiteSpace(x.Name) &&
             x.Name.Contains(search, StringComparison.OrdinalIgnoreCase))
            ||
            (!string.IsNullOrWhiteSpace(x.Mobile) &&
             x.Mobile.Contains(search, StringComparison.OrdinalIgnoreCase))
            ||
            (!string.IsNullOrWhiteSpace(x.GSTIN) &&
             x.GSTIN.Contains(search, StringComparison.OrdinalIgnoreCase))
        )
        .ToList();

            BindCustomers(filteredCustomers);
        }

        private void gridCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevents beep sound
                SelectCurrentCustomer();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (gridCustomers.Rows.Count > 0)
                {
                    gridCustomers.Focus();
                    gridCustomers.ClearSelection();
                    gridCustomers.Rows[0].Selected = true;
                    gridCustomers.CurrentCell = gridCustomers.Rows[0].Cells[0];
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (gridCustomers.Rows.Count > 0)
                {
                    gridCustomers.ClearSelection();
                    gridCustomers.Rows[0].Selected = true;
                    gridCustomers.CurrentCell = gridCustomers.Rows[0].Cells[0];

                    SelectCurrentCustomer();
                }
            }
        }
    }
}
