namespace CoreOfficeERP.Domain.Requests.DeliveryChallan
{
    public class DeliveryChalanReturnRequest
    {
        public int DeliveryChallanId { get; set; }
        public int FinanceYearId  { get; set; }
        public Guid  CustomerId { get; set; }
     
        public List<DeliveryChallanReturnItem> DeliveryChallanReturnItems { get; set; }
    }

    public class DeliveryChallanReturnItem
    {
        public int DeliveryChallanItemId { get;set; }
        public Guid StockId { get; set; }
        public int ReturnQty { get;set;}
        public decimal SaleRate { get;set; }
        public decimal Amount { get; set; }
      
    }
}
