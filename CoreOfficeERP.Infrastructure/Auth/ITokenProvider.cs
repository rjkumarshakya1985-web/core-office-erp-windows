namespace CoreOfficeERP.Infrastructure.Auth
{
    public interface ITokenProvider
    {
        void SetToken(string token);
        string? GetToken();
    }
}
