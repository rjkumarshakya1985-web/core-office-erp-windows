using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class MasterService : IMasterService
    {
        private readonly IApiRepository<DepartmentResponseDto> _apiRepository;

        // 🔹 Constructor injection
        public MasterService(IApiRepository<DepartmentResponseDto> apiRepository)
        {
            _apiRepository = apiRepository;
        }

        public async Task<IEnumerable<DepartmentResponseDto>> GetAllDepartmentsAsync()
        {
            // 🔹 "departments" is API endpoint
            return await _apiRepository.GetAllAsync("master/departments");
        }

    }
}
