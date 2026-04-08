using CoreOfficeERP.Common.Enums;
using CoreOfficeERP.Domain.Responses.Customers;

namespace CoreOfficeERP.Domain.Responses.DeliveryChallanToInvoice
{
    public class DeliverChallanToInvoiceResponse
    {
        public int DeliveryChallanId { get; set; }
        public required string DeiliverChallanNo { get; set; }
        public int Quantity { get; set; }
        public int ReturnQty { get; set; }
        public int AvailableInvoiceQty { get; set; }
        public decimal TotalAmount { get; set; }

        public DeliveryChallanStatusEnum DeliveryChallanStatusEnum { get; set; }
        public CustomerResponse Customer { get; set; }
    }
}
