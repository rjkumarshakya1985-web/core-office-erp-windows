namespace CoreOfficeERP.Domain.Requests.DeliveryChallanToInvoice
{
    public class DeliveryChallanToInvoiceRequest
    {
        public int FinYearId { get; set; }
        public decimal Discount { get; set; }
        public required List<int> DeliveryChallanIds { get; set; }
    }
}
