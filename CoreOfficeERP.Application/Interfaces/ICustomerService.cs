using CoreOfficeERP.Domain.Requests.Customers;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Domain.Responses.Customers;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface ICustomerService
    {
        Task<VisitorResponse> CreateAsync(CustomerRequest request, int visitorId);
        Task<VisitorResponse?> GetCustomerByMobile(string mobile);
        Task<List<CustomerResponse>> GetBillingCustomersAsync();
        Task<CustomerResponse?> CreateCustomerAsync(CustomerRequest request);
    }
}
