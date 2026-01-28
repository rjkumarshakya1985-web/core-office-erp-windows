using System.Text;
using System.Text.Json;

namespace CoreOfficeERP.Infrastructure.Api
{
    public class ApiRepository<T> : IApiRepository<T>
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptions;

        public ApiRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
            if (_httpClient.BaseAddress == null)
                _httpClient.BaseAddress = new Uri("https://api.ssbdagra.in/api/");

            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public async Task<IEnumerable<T>> GetAllAsync(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<T>>(json, _jsonOptions)!;
        }

        public async Task<T?> GetByIdAsync(string endpoint, object id)
        {
            var response = await _httpClient.GetAsync($"{endpoint}/{id}");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(json, _jsonOptions);
        }

        public async Task<T?> PostAsync(string endpoint, T data)
        {
            var content = CreateJsonContent(data);

            var response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();

            return await DeserializeResponse<T>(response);
        }

        public async Task<T?> PutAsync(string endpoint, object id, T data)
        {
            var content = CreateJsonContent(data);

            var response = await _httpClient.PutAsync($"{endpoint}/{id}", content);
            response.EnsureSuccessStatusCode();

            return await DeserializeResponse<T>(response);
        }

        public async Task<bool> DeleteAsync(string endpoint, object id)
        {
            var response = await _httpClient.DeleteAsync($"{endpoint}/{id}");
            return response.IsSuccessStatusCode;
        }

        // 🔽 Helpers
        private static StringContent CreateJsonContent<TData>(TData data)
        {
            return new StringContent(
                JsonSerializer.Serialize(data),
                Encoding.UTF8,
                "application/json");
        }

        private async Task<TResult?> DeserializeResponse<TResult>(HttpResponseMessage response)
        {
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<TResult>(json, _jsonOptions);
        }
    }
}





