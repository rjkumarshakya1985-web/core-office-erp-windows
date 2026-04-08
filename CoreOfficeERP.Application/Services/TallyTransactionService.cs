using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using CoreOfficeERP.Domain.Responses.Tally;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class TallyTransactionService : ITallyTransactionService
    {

        private readonly IApiRepository _apiRepository;
        public TallyTransactionService(IApiRepository apiRepository)
        {

            _apiRepository = apiRepository;
        }        
        public async Task<IEnumerable<TallyPurchaseResponse?>> GetTallyPurchase(int id)
        {
            var reuslt = await _apiRepository
             .GetAsync<ApiResponse<IEnumerable<TallyPurchaseResponse>>>($"{ApiEndpoints.GetTallyPurchase}/{id}");
            var apiend = $"{ApiEndpoints.GetTallyPurchase}/{id}";    
            return reuslt?.Data;
        }


    }
}
