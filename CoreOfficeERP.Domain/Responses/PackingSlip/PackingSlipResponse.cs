namespace CoreOfficeERP.Domain.Responses.PackingSlip
{
    public class PackingSlipResponse
    {
        public int Id { get; set; }

        public required string SlipNumber { get; set; }

        public DateTime Date { get; set; }

        public int? VisitorId { get; set; }
        public string? VisitorName { get; set; }
        public int VisitorType { get; set; }
        public string VisitorMobile { get; set; }

        public int FinanceYearId { get; set; }

        public Guid PackingSlipPersionId { get; set; }

        public int TotalQuantity { get; set; }

        public decimal TotalAmount { get; set; }

        public VisitorResponse? Visitor { get; set; }
        public List<PackingSlipItemResponse> Items { get; set; } = new();
    }
}
