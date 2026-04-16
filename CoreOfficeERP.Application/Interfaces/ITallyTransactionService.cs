using CoreOfficeERP.Domain.Responses.Tally;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface ITallyTransactionService
    {
        Task<TallyPurchaseResponse> GetTallyPurchase(int id);
    }
}
