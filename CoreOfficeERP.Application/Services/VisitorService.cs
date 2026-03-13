using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class VisitorService : IVisitorService
    {

        private readonly IApiRepository _apiRepository;

        public VisitorService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<VisitorResponse?> GetVisitor(int id)
        {
            var reuslt= await _apiRepository
                .GetByIdAsync<ApiResponse<VisitorResponse>>(ApiEndpoints.CreatePackingSlip, id);

            return reuslt?.Data;
        }

        public async Task<VisitorResponse?> GetVisitorByMobile(string mobile)
        {
         var result = await _apiRepository
                .GetByIdAsync<ApiResponse<VisitorResponse>>(
                    $"{ApiEndpoints.CreatePackingSlip}/mobile",
                    mobile);

            return result?.Data;
        }
    }
}
