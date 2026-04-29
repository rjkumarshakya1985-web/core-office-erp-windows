using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Common;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Requests.PackingSlip;
using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using CoreOfficeERP.Domain.Responses.Tally;
using CoreOfficeERP.Infrastructure.Api;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var reuslt = await _apiRepository          
             .GetAsync<ApiResponse<TallyPurchaseResponse>>($"{ApiEndpoints.GetTallyPurchase}/{id}");           
            return reuslt?.Data;

        }
        public async Task<int> TallyDataUpdate(List<TallyNameRequest> request)
        {
            var reuslt = await _apiRepository
             .PutAsync<List<TallyNameRequest>, ApiResponse<int>>(ApiEndpoints.TallyDataUpdate, request);
            return reuslt!.Data;
           
        }  

    }
}
