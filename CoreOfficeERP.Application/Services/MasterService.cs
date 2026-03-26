using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Domain.Responses.MasterData;
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

        public async Task<IEnumerable<CityResponse>?> GetCityByState(int stateId)
        {
            return await _apiRepository
                 .GetAsync<List<CityResponse>>($"master/cities/{stateId}");
        }

        public async Task<IEnumerable<StateResponse>?> GetStates()
        {
            return await _apiRepository
                      .GetAsync<List<StateResponse>>("master/states");
        }
    }
}
