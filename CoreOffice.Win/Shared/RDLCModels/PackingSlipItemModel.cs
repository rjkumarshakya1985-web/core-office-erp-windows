using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOffice.Win.Shared.RDLCModels
{
    public class PackingSlipItemModel
    {
        public int Id { get; set; }
        public string SlipNumber { get; set; }
        public DateTime Date { get; set; }
        public string VisitorName { get; set; }
        public string VisitorType { get; set; }
        public string VisitorMobile { get; set; }
        public int TotalPcs { get; set; }
        public decimal GrandTotal { get; set; }
        public string StockGroup { get; set; }
        public string ProductName { get; set; }
        public string BarCode { get; set; }
        public int Qty { get; set; }
        public decimal GstValue { get; set; }
        public decimal SaleRate { get; set; }
        public decimal TaxableAmount { get; set; }
        public decimal Amount { get; set; }
        public string Salesman { get; set; }
        public string UserName { get; set; }
        public string Department { get; set; }
        public string SubDepartment { get; set; }
    }
}
