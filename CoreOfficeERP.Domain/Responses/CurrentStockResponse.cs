namespace CoreOfficeERP.Domain.Responses
{
    public class CurrentStockResponse
    {
        public Guid Id { get; set; }
        public  string StockGroup { get; set; }
        public  string ProductName { get; set; }
        public  string BarCode { get; set; }
        public int AvailableQty { get; set; }

        public decimal PurchaseRate { get; set; }
        public decimal WholeSaleRate { get; set; }

        public decimal RetailRate { get; set; }
        public decimal MrpRate { get; set; }

        public int GstPPercent { get; set; }
        public int GstWPercent { get; set; }
        public int GstRPercent { get; set; }
    }
}
