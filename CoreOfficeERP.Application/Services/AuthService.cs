using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Domain;
using CoreOfficeERP.Infrastructure.Auth;

namespace CoreOfficeERP.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthApiRepository _authRepo;

        public AuthService(IAuthApiRepository authRepo)
        {
            _authRepo = authRepo;
        }

        public async Task<LoginResponseDto?> LoginAsync(LoginRequestDto request)
        {
            return await _authRepo.LoginAsync(request);
        }
    }
}
