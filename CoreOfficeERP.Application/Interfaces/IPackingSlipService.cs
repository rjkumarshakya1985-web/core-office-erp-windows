using CoreOfficeERP.Domain.Requests.PackingSlip;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IPackingSlipService
    {
        Task<int> CreateAsync(PackingSlipRequest request);
    }
}
