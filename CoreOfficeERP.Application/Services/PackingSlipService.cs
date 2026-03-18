using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.PackingSlip;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class PackingSlipService : IPackingSlipService
    {

        private readonly IApiRepository _apiRepository;

        public PackingSlipService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<int> CreateAsync(PackingSlipRequest request)
        {
            var response = await _apiRepository
                .PostAsync<PackingSlipRequest, ApiResponse<int>>(ApiEndpoints.CreatePackingSlip, request);

            return response!.Data;
        }

        public async Task<bool> DeleteAsync(int Id)
        {
            var response = await _apiRepository
                 .DeleteAsync(ApiEndpoints.CreatePackingSlip,Id);
            return response;
        }

        public async Task<PackingSlipResponse> GetByIdAsync(int id)
        {
            var reuslt = await _apiRepository
             .GetByIdAsync<ApiResponse<PackingSlipResponse>>(ApiEndpoints.CreatePackingSlip, id);

            return reuslt?.Data;
        }

        public async Task<PackingSlipResponse> GetByPackingSlipNumberAsync(string number)
        {
            var reuslt = await _apiRepository
             .GetByIdAsync<ApiResponse<PackingSlipResponse>>(ApiEndpoints.GetPackingSlipNumber, number);

            return reuslt?.Data;
        }

        public async Task<int> UpdateAsync(object id, PackingSlipRequest request)
        {
            var response = await _apiRepository
                .PutAsync<PackingSlipRequest, ApiResponse<int>>(ApiEndpoints.CreatePackingSlip, id, request);

            return response!.Data;
        }
    }
}
