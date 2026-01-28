using CoreOfficeERP.Domain;

namespace CoreOfficeERP.Infrastructure.Auth
{
    public interface IAuthApiRepository
    {
        Task<LoginResponseDto?> LoginAsync(LoginRequestDto request);
    }
}
