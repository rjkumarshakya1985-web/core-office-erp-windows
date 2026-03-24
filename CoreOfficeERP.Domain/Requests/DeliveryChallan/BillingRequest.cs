
namespace CoreOfficeERP.Domain.Requests.DeliveryChallan
{
    public class BillingRequest
    {
        public Guid Id { get; set; }

        public int FinanceYearId { get; set; }

        public int VisitorId { get; set; }

        public Guid? CustomerId { get; set; }

        public List<int> PackingSlipIds { get; set; } = new List<int>();
        public string? Remarks { get; set; }
    }
}
