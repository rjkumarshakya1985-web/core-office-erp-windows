using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.Customers;
using CoreOfficeERP.Domain.Requests.PackingSlip;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Domain.Responses.Customers;
using CoreOfficeERP.Infrastructure.Api;
using CoreOfficeERP.Application.Cache;

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
        public async Task<IEnumerable<BillingCustomerResponse>?> GetBillingCustomerResponsesAsync()
        {
            return await _apiRepository
                .GetAsync<List<BillingCustomerResponse>>("customer/billing-customers");
        }
        public async Task<List<BillingCustomerResponse>> GetCachedCustomersAsync()
        {
            if (!CustomerCache.IsLoaded)
            {
                var customers = await GetBillingCustomerResponsesAsync();

                if (customers != null)
                    CustomerCache.Load(customers);
            }

            return CustomerCache.Customers;
        }
    }
}
