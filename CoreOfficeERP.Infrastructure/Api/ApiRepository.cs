
using CoreOfficeERP.Domain;
using System.Text;
using System.Text.Json;

namespace CoreOfficeERP.Infrastructure.Api
{
    public class ApiRepository : IApiRepository
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

        public async Task<TResponse?> GetAsync<TResponse>(string endpoint)
        {
            var response = await _httpClient.GetAsync(endpoint);

            var json = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                string message = "Something went wrong";

                try
                {
                    var error = JsonSerializer.Deserialize<ApiErrorResponse>(
                        json,
                        _jsonOptions);

                    if (!string.IsNullOrWhiteSpace(error?.Message))
                        message = error.Message;
                }
                catch
                {
                }

                throw new Exception(message);
            }

            return JsonSerializer.Deserialize<TResponse>(json, _jsonOptions);
        }

        public async Task<TResponse?> GetByIdAsync<TResponse>(string endpoint, object id)
        {
            var response = await _httpClient.GetAsync($"{endpoint}/{id}");
            response.EnsureSuccessStatusCode();

            return await DeserializeResponse<TResponse>(response);
        }

        public async Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest data)
        {
            var content = CreateJsonContent(data);

            var response = await _httpClient.PostAsync(endpoint, content);
            response.EnsureSuccessStatusCode();

            return await DeserializeResponse<TResponse>(response);
        }

        public async Task<TResponse?> PutAsync<TRequest, TResponse>(string endpoint, object id,TRequest data)
        {
            var content = CreateJsonContent(data);

            var response = await _httpClient.PutAsync($"{endpoint}/{id}", content);
            response.EnsureSuccessStatusCode();

            return await DeserializeResponse<TResponse>(response);
        }
        public async Task<TResponse?> PutAsync<TRequest, TResponse>(string endpoint, TRequest data)
        {
            var content = CreateJsonContent(data);

            var response = await _httpClient.PutAsync($"{endpoint}", content);
            response.EnsureSuccessStatusCode();

            return await DeserializeResponse<TResponse>(response);
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





