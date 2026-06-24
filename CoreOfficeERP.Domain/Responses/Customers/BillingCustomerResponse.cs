using CoreOfficeERP.Common.Enums;

namespace CoreOfficeERP.Domain.Responses.Customers
{
    public class BillingCustomerResponse
    {
        public Guid id { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? gstIn { get; set; }
        public decimal? Discount { get; set; }
        public CustomerTypeEnum RegType { get; set; }
    }
}
