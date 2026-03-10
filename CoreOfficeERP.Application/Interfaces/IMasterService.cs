using CoreOfficeERP.Domain;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IMasterService
    {
        Task<IEnumerable<DepartmentResponseDto>> GetAllDepartmentsAsync();
 
    }
}
