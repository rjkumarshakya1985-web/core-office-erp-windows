namespace CoreOfficeERP.Domain.Responses
{
    public class CurrentStockResponse
    {
        public Guid Id { get; set; }
        public required string  StockGroup { get; set; }
        public required string ProductName { get; set; }
        public required string BarCode { get; set; }
        public int AvailableQty { get; set; }
        public decimal WholeSaleRate { get; set; }
        public decimal RetailRate { get; set; }
        public decimal MrpRate { get; set; }
    }
}
