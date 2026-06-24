using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.Customers;
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
                .PostAsync<CustomerRequest, VisitorResponse>(url, request);

            return response;
        }

        public async Task<VisitorResponse?> GetCustomerByMobile(string mobile)
        {
            var result = await _apiRepository
                .GetByIdAsync<ApiResponse<VisitorResponse?>>(
                    ApiEndpoints.GetCustomerByMobile,
                    mobile);

            return result?.Data;
        }

        public async Task<List<CustomerResponse>> GetBillingCustomersAsync()
        {
            var result = await _apiRepository
                .GetAsync<ApiResponse<List<CustomerResponse>>>(ApiEndpoints.GetBillingCustomers);

            return result?.Data ?? new List<CustomerResponse>();
        }

        public async Task<CustomerResponse?> CreateCustomerAsync(CustomerRequest request)
        {
            var result = await _apiRepository
                .PostAsync<CustomerRequest, ApiResponse<CustomerResponse>>(
                    ApiEndpoints.CreateCustomer,
                    request);

            return result?.Data;
        }
    }
}
