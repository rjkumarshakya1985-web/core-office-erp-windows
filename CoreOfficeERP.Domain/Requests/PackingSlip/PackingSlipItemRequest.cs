namespace CoreOfficeERP.Domain.Requests.PackingSlip
{
    public class PackingSlipItemRequest
    {
        public int? Id { get; set; }
        public int PackingSlipId { get; set; }

        public Guid StockId { get; set; }

        public decimal SaleRate { get; set; }
        public int Qty { get; set; }
    }
}
