using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.DeliveryChallan;
using CoreOfficeERP.Domain.Responses.DeliveryChallan;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class DeliveryChallanService : IDeliveryChallanService
    {
        private readonly IApiRepository _apiRepository;

        public DeliveryChallanService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }

        public async Task<bool> CancelDeliveryChallan(int delviveryChallanId)
        {

            var response = await _apiRepository
                .DeleteAsync(ApiEndpoints.CancelDeliveryChallan, delviveryChallanId);

            return response;
        }

        public async Task<int> CreateAsync(BillingRequest request)
        {
            var response = await _apiRepository
                .PostAsync<BillingRequest, ApiResponse<int>>(ApiEndpoints.CreateDeliveryChallan, request);

            return response!.Data;
        }

        public async Task<DeliveryChallanReturnDetailResponse?> GetDeliveryChallan(string number, int finYearId)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Delivery Challan number is required");

            var url = $"{ApiEndpoints.GetDeliveryChallanDetail}/{number}/{finYearId}";
            var response = await _apiRepository
                .GetAsync<ApiResponse<DeliveryChallanReturnDetailResponse>>(url);

            if (response == null)
                throw new Exception("No response from server");

            if (!response.Success)
                throw new Exception(response.Message ?? "Failed to fetch delivery challan");

            return response.Data;
        }

        public async Task<DeliveryChallanReturnDetailResponse?> GetDeliveryChallanForReturn(string number, int finYearId)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Delivery Challan number is required");

            var url = $"{ApiEndpoints.GetDeliveryChallReturnDetail}/{number}/{finYearId}";
            var response = await _apiRepository
                .GetAsync<ApiResponse<DeliveryChallanReturnDetailResponse>>(url);

            if (response == null)
                throw new Exception("No response from server");

            if (!response.Success)
                throw new Exception(response.Message ?? "Failed to fetch delivery challan");

            return response.Data;
        }

        public async Task<int> SaveDeliveryChallanReturn(DeliveryChalanReturnRequest request)
        {
            var response = await _apiRepository
               .PostAsync<DeliveryChalanReturnRequest, ApiResponse<int>>(ApiEndpoints.CreateDeliveryChallanReturn, request);

            return response!.Data;
        }


    }
}
