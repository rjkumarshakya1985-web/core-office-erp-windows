using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOfficeERP.Domain.Responses.Print
{
    public class PackingSlipRDLCResponse
    {
        public int Id { get; set; }
        public string SlipNumber { get; set; }
        public DateTime? Date { get; set; }
        public int? SalesPersonId { get; set; }
        public int? VisitorId { get; set; }
        public string VisitorName { get; set; }
        public string VisitorType { get; set; }
        public string VisitorMobile { get; set; }
        public int? FinanceYearId { get; set; }
        public int? UserId { get; set; }
        public int? TotalPcs { get; set; }
        public decimal? GrandTotal { get; set; }
        public string StockGroup { get; set; }
        public string ProductName { get; set; }
        public string BarCode { get; set; }
        public decimal? Qty { get; set; }
        public decimal? AvailableQty { get; set; }
        public decimal? GstValue { get; set; }
        public decimal? SaleRate { get; set; }
        public decimal? TaxableAmount { get; set; }
        public decimal? Amount { get; set; }
        public string Salesman { get; set; }
        public string UserName { get; set; }

        // 👇 Company fields (if used in same dataset OR separate dataset)
        public string Name { get; set; }
        public string GstIn { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string StateCode { get; set; }
        public string Email { get; set; }
    }
}
