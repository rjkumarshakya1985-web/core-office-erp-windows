using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.DeliveryChallan;

using CoreOfficeERP.Domain.Responses.Invoices;
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

        public async Task<bool> CancelInvoice(int invoiceId)
        {

            var response = await _apiRepository
                .DeleteAsync(ApiEndpoints.CancelInvoice, invoiceId);

            return response;
        }

        public async Task<int> CreateAsync(BillingRequest request)
        {
            var response = await _apiRepository
               .PostAsync<BillingRequest, ApiResponse<int>>(ApiEndpoints.CreateInvoice, request);

            return response!.Data;
        }

        public async Task<InvoiceResponse?> GetInvoice(string number, int finYearId)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Invoice  number is required");

            var url = $"{ApiEndpoints.GetInvoice}/{number}/{finYearId}";
            var response = await _apiRepository
                .GetAsync<ApiResponse<InvoiceResponse>>(url);

            if (response == null)
                throw new Exception("No response from server");

            if (!response.Success)
                throw new Exception(response.Message ?? "Failed to fetch invoice");

            return response.Data;
        }

        public async Task<InvoiceResponse?> GetInvoice(int id)
        {
           
            var url = $"{ApiEndpoints.GetInvoice}/{id}";
            var response = await _apiRepository
                .GetAsync<ApiResponse<InvoiceResponse>>(url);

            if (response == null)
                throw new Exception("No response from server");

            if (!response.Success)
                throw new Exception(response.Message ?? "Failed to fetch invoice");

            return response.Data;
        }
    }
}
