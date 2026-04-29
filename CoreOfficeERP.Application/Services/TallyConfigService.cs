using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Domain.Responses.Tally;
using CoreOfficeERP.Infrastructure.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOfficeERP.Application.Services
{
    public class TallyConfigService:ITallyConfigService
    {
        private readonly IApiRepository _apiRepository;

        public TallyConfigService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }
        public async Task<TallyConfigResponse> GetTallyConfig(int companyId)
        {
            var reuslt = await _apiRepository
             .GetAsync<ApiResponse<TallyConfigResponse>>($"{ApiEndpoints.GetTallyConfig}/{companyId}");
            if (reuslt == null)
                throw new Exception("No response from server");

            if (!reuslt.Success)
                throw new Exception(reuslt.Message ?? "Failed to fetch Tally Configs");
            return reuslt?.Data;
        }
        public async Task<IEnumerable<TallyCompanyResponse>> GetAllCompanies()
        {
            var reuslt = await _apiRepository
              .GetAsync<ApiResponse<IEnumerable<TallyCompanyResponse>>>(ApiEndpoints.GetTallyCompanies);
            if (reuslt == null)
                throw new Exception("No response from server");

            if (!reuslt.Success)
                throw new Exception(reuslt.Message ?? "Failed to fetch Tally Companies");
            return reuslt?.Data;
        }
    }
}
