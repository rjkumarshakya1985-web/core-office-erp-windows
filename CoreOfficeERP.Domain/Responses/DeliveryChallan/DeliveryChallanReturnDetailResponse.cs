
using CoreOfficeERP.Common.Enums;

namespace CoreOfficeERP.Domain.Responses.DeliveryChallan
{
    public class DeliveryChallanReturnDetailResponse
    {
        public int DeliveryChallanId { get; set; }
        public DateTime DeliveryChallanDate { get; set; }
        public Guid CustomerId { get; set; }
        public required string CustomerName { get; set; }

        public int TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }

        public DeliveryChallanStatusEnum Status { get; set; }
        public List<DeliveryChallanReturnDetailItem> Items { get; set; } = new();

    }

    public class DeliveryChallanReturnDetailItem
    {
        public Guid StockId { get; set; }

        public int DeliveryChallanItemId { get; set; }
        public required string ProductCategory { get; set; }
        public required string ProductName { get; set; }

        public decimal SaleRate { get; set; }
        public int Qty { get; set; }
        public int Returned { get; set; }

        public int Balance { get; set; }

        public int ReturnQty { get; set; }

        public decimal Amount { get; set; }
    }
}
