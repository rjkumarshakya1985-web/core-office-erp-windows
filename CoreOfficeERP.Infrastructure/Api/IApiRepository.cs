namespace CoreOfficeERP.Infrastructure.Api
{
    public interface IApiRepository
    {
        Task<TResponse?> PostAsync<TRequest, TResponse>(string endpoint, TRequest data);
        Task<TResponse?> GetAsync<TResponse>(string endpoint);
        Task<TResponse?> GetByIdAsync<TResponse>(string endpoint, object id);
        Task<TResponse?> PutAsync<TRequest, TResponse>(string endpoint, object id, TRequest data);
        Task<bool> DeleteAsync(string endpoint, object id);
    }
}
