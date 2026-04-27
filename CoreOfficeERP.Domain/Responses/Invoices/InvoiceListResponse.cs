using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOfficeERP.Domain.Responses.Invoices
{
    public class InvoiceListResponse
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime Date { get; set; }
        public string CustomerName { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public int Status { get; set; }
    }
}
