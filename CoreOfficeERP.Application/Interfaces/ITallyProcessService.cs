using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using CoreOfficeERP.Domain.Responses.Tally;
namespace CoreOfficeERP.Application.Interfaces
{
    public interface ITallyProcessService
    {
        Task<int> CreateAsync(TallyProcessBatchRequest request);
        Task<TallyProcessResponse> GetTallyProcess(int id);
    }

}
