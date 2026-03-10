using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.PackingSlip;
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
    }
}
