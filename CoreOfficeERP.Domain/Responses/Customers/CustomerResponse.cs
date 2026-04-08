

namespace CoreOfficeERP.Domain.Responses.Customers
{
    public class CustomerResponse
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Mobile { get; set; }
    }
}
