
using CoreOffice.Win.Shared;
using CoreOfficeERP.Application.Interfaces;

using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Domain;


namespace CoreOffice.Win.Modules.Cashier.Invoices
{
    public partial class InvoiceListForm : Form
    {
        private IInvoiceService _invoiceService;
        private int pageSize = 10;
        private int pageIndex = 0;
        private int totalPages = 0;
        public InvoiceListForm(IInvoiceService invoiceService)
        {
            InitializeComponent();
            _invoiceService = invoiceService;
            var list = new List<KeyValuePair<int, string>>();

            // 👉 Add "All" at top
            list.Add(new KeyValuePair<int, string>(-1, "All"));

            // 👉 Add enum values
            list.AddRange(Enum.GetValues(typeof(InvoiceStatusEnum))
                .Cast<InvoiceStatusEnum>()
                .Select(e => new KeyValuePair<int, string>((int)e, e.ToString())));

            cmbInvoiceStatus.DataSource = list;
            cmbInvoiceStatus.DisplayMember = "Value";
            cmbInvoiceStatus.ValueMember = "Key";

            // 👉 Default select "All"
            cmbInvoiceStatus.SelectedIndex = 0;
        }

        private TableDataRequest TableDataRequest()
        {
            this.pageSize = int.TryParse(this.cmbPageSize.Text, out var pageSize) ? pageSize : 10;

            var rq = new TableDataRequest
            {
                PageIndex = this.pageIndex,
                PageSize = this.pageSize,
                SortField = "Id",
                SortOrder = 1
            };

            if (rq.Filters == null)
            {
                rq.Filters = new Dictionary<string, string>();
            }
            rq.Filters.Clear();
            if (txtInvoiceNumber.Text.Trim() != "")
                rq.Filters.Add("InvoiceNumber", txtInvoiceNumber.Text);

            if (txtCustomerName.Text.Trim() != "")
                rq.Filters.Add("CustomerName", txtCustomerName.Text);

            if (cmbInvoiceStatus.SelectedValue != null && (int)cmbInvoiceStatus.SelectedValue != -1)
                rq.Filters.Add("Status", cmbInvoiceStatus.SelectedValue.ToString());

            return rq;
        }

        private void UpdatePaginationButtons()
        {
            btnPre.Enabled = pageIndex > 0;
            btnNext.Enabled = pageIndex < totalPages - 1;
        }
        public void PageNumberOf(int totalRows)
        {
            totalPages = (int)Math.Ceiling((double)totalRows / this.pageSize);
            totalPages = totalPages == 0 ? 1 : totalPages;

            btnPageDetail.Text = $"{this.pageIndex + 1}/{totalPages}";
        }

        public async Task LoadData()
        {
            AppLoader.Show();
            dataGrid.Rows.Clear();
            var result = await _invoiceService.GetTableData(TableDataRequest(), Session.UserSession.FinanceYearId
                  );

            btnTotalRecord.Text = $"Total ({result.TotalRows.ToString()})";
            PageNumberOf(result.TotalRows);
            foreach (var item in result.Result)
            {
                dataGrid.Rows.Add(
                   item.Id,
                   item.Date.ToString("dd-MM-yyyy hh:mm tt"),
                   item.InvoiceNumber ?? "",
                   item.CustomerName ?? "",
                   item.Quantity,
                   item.TotalAmount.ToString("0.00"),
                   ((InvoiceStatusEnum)item.Status).ToString()
              );
            }
            UpdatePaginationButtons();
            AppLoader.Hide();
        }
        private async Task TotalStatusCount()
        {
            var statusCounts = await _invoiceService.GetInvoiceStatusCountsAsync(Session.UserSession.FinanceYearId);
            
            if (statusCounts == null || !statusCounts.Any())
            {
               
                return;
            }

            var totalCount = statusCounts.Sum(s => s.Count);
            lblTotalPendinginvoice.Text = $"{statusCounts.FirstOrDefault(s => s.Status == (int)InvoiceStatusEnum.Created)?.Count ?? 0}";
            lblTotalInvoice.Text = $"{totalCount}";
            lblTotalCancel.Text = $"{statusCounts.FirstOrDefault(s => s.Status == (int)InvoiceStatusEnum.Cancelled)?.Count ?? 0}";
            lblTotalTallySynced.Text = $"{statusCounts.FirstOrDefault(s => s.Status == (int)InvoiceStatusEnum.TallySynced)?.Count ?? 0}";
            lblDeliveryChallan.Text = $"{statusCounts.FirstOrDefault(s => s.Status == (int)InvoiceStatusEnum.DeliveryChallanInvoice)?.Count ?? 0}";

        }
        private async void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pageIndex = 0;
            await LoadData();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (pageIndex > 0)
            {
                pageIndex--;
                _ = LoadData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageIndex < totalPages - 1)
            {
                pageIndex++;
                _ = LoadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            pageIndex = 0;
            _ = LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtInvoiceNumber.Clear();
            pageIndex = 0;
            _ = LoadData();
        }

        private async void InvoiceListForm_Load(object sender, EventArgs e)
        {
            this.pageIndex = 0;
            await LoadData();
            await TotalStatusCount();
        }
    }
}
