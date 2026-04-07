using CoreOfficeERP.Common.Enums;

namespace CoreOfficeERP.Domain.Responses.Invoices
{
    public class InvoiceResponse
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerId { get; set; }

        public required string InvoiceNumber { get; set; }
        public required string CustomerName { get; set; }
        public string? GstIn { get; set; }

        public int TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }

        public InvoiceStatusEnum Status { get; set; }

        public List<InvoiceItemResponse> Items { get; set; } = new();
    }

    public class InvoiceItemResponse
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }
        public Guid StockId { get; set; }
        public required string ProductCategory { get; set; }
        public required string ProductName { get; set; }

        public int Qty { get; set; }
        public decimal SaleRate { get; set; }

        public decimal Amount { get; set; }
    }
}
