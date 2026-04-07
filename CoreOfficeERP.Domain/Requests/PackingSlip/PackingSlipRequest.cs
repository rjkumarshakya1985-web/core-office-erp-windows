namespace CoreOfficeERP.Domain.Requests.PackingSlip
{
    public class PackingSlipRequest
    {
        public int Id { get; set; }
        public  DateTime Date { get; set; }
       
        public Guid? SalesPersonId { get; set; }
        public int? VisitorId { get; set; }
       
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
        public string? Remarks { get; set; }

        public required List<PackingSlipItemRequest> Items { get; set; }
    }
}
