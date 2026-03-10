using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Infrastructure.Api;

namespace CoreOfficeERP.Application.Services
{
    public class MasterService : IMasterService
    {
        private readonly IApiRepository _apiRepository;

        // 🔹 Constructor injection
        public MasterService(IApiRepository apiRepository)
        {
            _apiRepository = apiRepository;
        }

        public async Task<IEnumerable<DepartmentResponseDto>?> GetAllDepartmentsAsync()
        {
            return await _apiRepository
                .GetAsync<List<DepartmentResponseDto>>("master/departments");
        }

    }
}
