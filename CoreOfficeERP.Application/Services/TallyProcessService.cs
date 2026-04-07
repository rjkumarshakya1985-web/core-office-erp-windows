using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.PackingSlip;
using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using CoreOfficeERP.Domain.Responses.Tally;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
   
    public class TallyProcessService : ITallyProcessService
    {
        private readonly IApiRepository _apiRepository;

        public TallyProcessService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<int> CreateAsync(TallyProcessBatchRequest request)
        {
            var response = await _apiRepository
                .PostAsync<TallyProcessBatchRequest, ApiResponse<int>>(ApiEndpoints.CreateTallyProcessLog, request);

            return response!.Data;
        }
        public async Task<TallyProcessResponse?> GetTallyProcess(int companyId)
        {
            var reuslt = await _apiRepository
             .GetAsync<ApiResponse<TallyProcessResponse>>($"{ApiEndpoints.GetTallyProcessLogByCompanyId}/{companyId}");

            return reuslt?.Data;
        }
    }
   

    }
