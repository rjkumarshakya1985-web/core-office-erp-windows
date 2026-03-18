using CoreOfficeERP.Domain.Requests.PackingSlip;
using CoreOfficeERP.Domain.Responses.PackingSlip;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IPackingSlipService
    {
        Task<int> CreateAsync(PackingSlipRequest request);
        Task<PackingSlipResponse> GetByIdAsync(int id);
        Task<PackingSlipResponse> GetByPackingSlipNumberAsync(string number);
        Task<int> UpdateAsync(object id, PackingSlipRequest request);
        Task<bool> DeleteAsync(int Id);
    }
}
