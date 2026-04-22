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

        public async Task<bool> CreateAsync(List<TallyProcessRequest> logs)
        {
            var response = await _apiRepository
                .PostAsync<List<TallyProcessRequest>, bool>(
                    ApiEndpoints.CreateTallyProcessLog,
                    logs);

            return response;
        }
        public async Task<TallyProcessResponse?> GetTallyProcess(int companyId)
        {
            var reuslt = await _apiRepository
             .GetAsync<ApiResponse<TallyProcessResponse>>($"{ApiEndpoints.GetTallyProcessLogByCompanyId}/{companyId}");

            return reuslt?.Data;
        }
    }
   

    }
