

namespace CoreOfficeERP.Domain.Responses.Customers
{
    public class CustomerResponse
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Mobile { get; set; }
        public decimal? Discount { get; set; }
        public int? CustomerType { get; set; }
        public string? GSTIN { get; set; }
    }
}
