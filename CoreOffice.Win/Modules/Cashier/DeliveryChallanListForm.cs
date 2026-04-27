using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Domain;



namespace CoreOffice.Win.Modules.Cashier
{
    public partial class DeliveryChallanListForm : Form
    {
        private IDeliveryChallanService _deliveryChallanService;
        private int pageSize = 10;
        private int pageIndex = 0;
        private int totalPages = 0;
        public DeliveryChallanListForm(IDeliveryChallanService deliveryChallanService)
        {
            InitializeComponent();
            _deliveryChallanService = deliveryChallanService;
            cmbPageSize.SelectedIndex = 0;
        }

        private TableDataRequest TableDataRequest()
        {
            this.pageSize = int.TryParse(this.cmbPageSize.Text, out var pageSize) ? pageSize : 10;
            return new TableDataRequest
            {
                PageIndex = this.pageIndex,
                PageSize = this.pageSize,
                Search = txtSearch.Text,
                SortField = "Id",
                SortOrder = 1
            };
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
            dataGrid.Rows.Clear();
            var result = await _deliveryChallanService.GetTableData(TableDataRequest(), Session.UserSession.FinanceYearId
                  );

            btnTotalRecord.Text = $"Total ({result.TotalRows.ToString()})";
            PageNumberOf(result.TotalRows);
            foreach (var item in result.Result)
            {
                dataGrid.Rows.Add(
                   item.Id,
                   item.Date.ToString("dd-MM-yyyy hh:mm tt"),
                   item.ChallanNumber ?? "",
                   item.CustomerName ?? "",
                   item.Quantity,
                   item.ReturnQuantity,
                   item.BalanceQuantity,
                   item.TotalAmount.ToString("0.00"),
                   ((DeliveryChallanStatusEnum)item.Status).ToString()   
              );
            }
            UpdatePaginationButtons();
        }

        private async void DeliveryChallanListForm_Load(object sender, EventArgs e)
        {


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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.pageIndex = 0;
                _ = LoadData();
            }
        }
    }
}
