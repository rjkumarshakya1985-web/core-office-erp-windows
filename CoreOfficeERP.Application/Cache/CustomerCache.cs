using CoreOfficeERP.Domain.Responses.Customers;
namespace CoreOfficeERP.Application.Cache
{
    public static class CustomerCache
    {
        public static List<BillingCustomerResponse> Customers { get; private set; }
            = new List<BillingCustomerResponse>();

        public static bool IsLoaded => Customers.Any();

        public static void Load(IEnumerable<BillingCustomerResponse> customers)
        {
            Customers = customers.ToList();
        }

        public static void Clear()
        {
            Customers.Clear();
        }
    }
}
