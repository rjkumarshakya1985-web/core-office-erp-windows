using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.DeliveryChallan;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IApiRepository _apiRepository;

        public InvoiceService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }

        public async Task<int> CreateAsync(BillingRequest request)
        {
            var response = await _apiRepository
               .PostAsync<BillingRequest, ApiResponse<int>>(ApiEndpoints.CreateInvoice, request);

            return response!.Data;
        }
    }
}
