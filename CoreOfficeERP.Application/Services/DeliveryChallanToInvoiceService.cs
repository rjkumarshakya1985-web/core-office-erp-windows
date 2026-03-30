using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.DeliveryChallan;
using CoreOfficeERP.Domain.Requests.DeliveryChallanToInvoice;
using CoreOfficeERP.Domain.Responses.DeliveryChallan;
using CoreOfficeERP.Domain.Responses.DeliveryChallanToInvoice;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class DeliveryChallanToInvoiceService : IDeliveryChallanToInvoiceService
    {

        private readonly IApiRepository _apiRepository;

        public DeliveryChallanToInvoiceService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }

        public async Task<int> CreateDeliveryChallansToInvoice(DeliveryChallanToInvoiceRequest invoiceRequest)
        {
            var response = await _apiRepository
                .PostAsync<DeliveryChallanToInvoiceRequest, ApiResponse<int>>(ApiEndpoints.CreateDeliveryChallanToinvoice, invoiceRequest);

            return response!.Data;
        }

        public async Task<DeliverChallanToInvoiceResponse?> GetDeliveryChallanForInvoiceByNumber(string number, int finYearId)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Delivery Challan number is required");

            var url = $"{ApiEndpoints.GetDeliveryChallanForInvoice}/{number}/{finYearId}";
            var response = await _apiRepository
                .GetAsync<ApiResponse<DeliverChallanToInvoiceResponse?>>(url);

            if (response == null)
                throw new Exception("No response from server");

            if (!response.Success)
                throw new Exception(response.Message ?? "Failed to fetch delivery challan");

            return response.Data;
        }
    }
}
