namespace CoreOfficeERP.Infrastructure.Api
{
    public interface IApiRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync(string endpoint);
        Task<T?> GetByIdAsync(string endpoint, object id);
        Task<T?> PostAsync(string endpoint, T data);
        Task<T?> PutAsync(string endpoint, object id, T data);
        Task<bool> DeleteAsync(string endpoint, object id);
    }
}
