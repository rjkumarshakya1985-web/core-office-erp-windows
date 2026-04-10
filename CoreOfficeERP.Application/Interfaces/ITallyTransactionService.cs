using CoreOfficeERP.Domain.Responses.Tally;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface ITallyTransactionService
    {
        Task<IEnumerable<TallyPurchaseResponse>> GetTallyPurchase(int id);
    }
}
