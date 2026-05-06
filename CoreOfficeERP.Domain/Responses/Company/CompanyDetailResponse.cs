namespace CoreOfficeERP.Domain.Responses.Company
{
    public class CompanyDetailResponse
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Description { get; set; }
        public string? GstIn { get; set; }
    }
}
