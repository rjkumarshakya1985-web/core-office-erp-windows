using CoreOfficeERP.Domain;

namespace CoreOfficeERP.Application.Interfaces
{
    public interface IAuthService
    {
        Task<LoginResponseDto?> LoginAsync(LoginRequestDto request);
    }
}
