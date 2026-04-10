using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses.Tally;
using CoreOfficeERP.Infrastructure.Api;
using CoreOfficeERP.Tally.Interfaces;

namespace CoreOfficeERP.Tally.Services
{
    public class LogService:ILogService
    {
        private readonly IApiRepository _apiRepository;

        public LogService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<int> CreateAsync(TallyProcessRequest request)
        {
            var response = await _apiRepository
                .PostAsync<TallyProcessRequest, ApiResponse<int>>(ApiEndpoints.CreateTallyProcessLog, request);

            return response!.Data;
        }
        public async Task<TallyProcessResponse> GetTallyProcess(int companyId)
        {
            var reuslt = await _apiRepository
             .GetAsync<ApiResponse<TallyProcessResponse>>($"{ApiEndpoints.GetTallyProcessLogByCompanyId}/{companyId}");

            return reuslt?.Data;
        }
    
        public async Task<TallyProcessResponse?> GetTallyProcessSteps(int companyId, int financialYearId, int processType, string referenceNo)
        {
            var reuslt = await _apiRepository
             .GetAsync<ApiResponse<TallyProcessResponse>>($"{ApiEndpoints.GetTallyProcessLogByPurchaseRef}/{companyId}/{financialYearId}/{processType}/{referenceNo}");

            return reuslt?.Data;
        }
    }
}
