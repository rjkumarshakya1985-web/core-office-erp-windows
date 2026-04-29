using CoreOfficeERP.Domain.Requests.Tally;
using CoreOfficeERP.Domain.Responses.PackingSlip;
using CoreOfficeERP.Domain.Responses.Tally;
namespace CoreOfficeERP.Application.Interfaces
{
    public interface ITallyProcessService
    {
        Task<bool> CreateAsync(List<TallyProcessRequest> logs);   
        Task<TallyProcessResponse> GetTallyProcess(int id);
    }

}
