using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses.Tally;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface ITallyTransactionService
    {
        Task<TallyPurchaseResponse> GetTallyPurchase(int id);
        Task<int> TallyDataUpdate(List<TallyNameRequest> request);
    }
}
