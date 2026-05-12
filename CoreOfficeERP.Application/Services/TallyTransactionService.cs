using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.Tally;
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
        public async Task<TallyPurchaseResponse> GetTallyPurchase(int id)
        {
            var result = await _apiRepository
             .GetAsync<ApiResponse<TallyPurchaseResponse>>($"{ApiEndpoints.GetTallyPurchase}/{id}");
            return result?.Data;

        }
        public async Task<bool> TallyDataUpdate(object id,List<TallyNameRequest> request)
        {
            var result = await _apiRepository
             .PutAsync<List<TallyNameRequest>, ApiResponse<bool>>(ApiEndpoints.TallyDataUpdate, id,request);
            return result!.Data;

        }

    }
}
