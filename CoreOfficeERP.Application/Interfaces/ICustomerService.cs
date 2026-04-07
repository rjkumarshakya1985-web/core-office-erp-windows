using CoreOfficeERP.Domain.Requests.Customers;
using CoreOfficeERP.Domain.Responses;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface ICustomerService
    {
        Task<VisitorResponse> CreateAsync(CustomerRequest request,int visitorId);
    }
}
