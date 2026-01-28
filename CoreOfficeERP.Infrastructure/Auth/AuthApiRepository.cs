using CoreOfficeERP.Domain;
using System.Text;
using System.Text.Json;

namespace CoreOfficeERP.Infrastructure.Auth
{
    public class AuthApiRepository : IAuthApiRepository
    {
        private readonly HttpClient _httpClient;

        public AuthApiRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<LoginResponseDto?> LoginAsync(LoginRequestDto request)
        {
            var content = new StringContent(
                JsonSerializer.Serialize(request),
                Encoding.UTF8,
                "application/json");

            var response = await _httpClient.PostAsync("auth/login", content);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<LoginResponseDto>(
                json,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }


}
