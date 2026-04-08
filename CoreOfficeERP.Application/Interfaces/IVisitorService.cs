

using CoreOfficeERP.Domain.Responses;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IVisitorService
    {
        Task<VisitorResponse?> GetVisitor(int id);

        Task<VisitorResponse?> GetVisitorByMobile(string value);
    }
}
