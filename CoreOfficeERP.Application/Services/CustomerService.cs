using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.Customers;
using CoreOfficeERP.Domain.Requests.PackingSlip;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IApiRepository _apiRepository;

        public CustomerService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<VisitorResponse> CreateAsync(CustomerRequest request, int visitorId)
        {
            var url = $"{ApiEndpoints.CreateSupplier}/{visitorId}";
            var response = await _apiRepository
                .PostAsync<CustomerRequest,VisitorResponse>(url, request);

            return response;
        }
    }
}
