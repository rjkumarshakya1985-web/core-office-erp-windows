using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.Customers;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Domain.Responses.Customers;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface ICustomerService
    {
        Task<VisitorResponse> CreateAsync(CustomerRequest request,int visitorId);
        Task<IEnumerable<BillingCustomerResponse>> GetBillingCustomerResponsesAsync();
        Task<List<BillingCustomerResponse>> GetCachedCustomersAsync();
    }
}
