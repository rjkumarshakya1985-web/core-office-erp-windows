using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Responses.MasterData;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IMasterService
    {
        Task<IEnumerable<DepartmentResponseDto>> GetAllDepartmentsAsync();
        Task<IEnumerable<StateResponse>> GetStates();
        Task<IEnumerable<CityResponse>> GetCityByState(int stateId);
    }
}
