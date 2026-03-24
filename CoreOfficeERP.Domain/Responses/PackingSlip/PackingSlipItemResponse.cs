namespace CoreOfficeERP.Domain.Responses.PackingSlip
{
    public class PackingSlipItemResponse
    {
        public int Id { get; set; }
        public Guid StockId { get; set; }
        public required string StockGroup { get; set; }
        public required string ProductName { get; set; }
        public required string BarCode { get; set; }
        public required int Qty { get; set; }
        public int AvailableQty { get; set; }

        public decimal GstValue { get; set; }
        public decimal SaleRate { get; set; }

        public decimal Amount => Qty * SaleRate;
    }
}
