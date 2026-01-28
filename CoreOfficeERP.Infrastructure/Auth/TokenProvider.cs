namespace CoreOfficeERP.Infrastructure.Auth
{
    public class TokenProvider : ITokenProvider
    {
        private string? _token;

        public void SetToken(string token)
        {
            _token = token;
        }

        public string? GetToken()
        {
            return _token;
        }
    }

}
