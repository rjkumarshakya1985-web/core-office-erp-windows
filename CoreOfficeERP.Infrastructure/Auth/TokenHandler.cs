using System.Net.Http.Headers;

namespace CoreOfficeERP.Infrastructure.Auth
{

  
    public class TokenHandler : DelegatingHandler
    {
        private readonly ITokenProvider _tokenProvider;

        public TokenHandler(ITokenProvider tokenProvider)
        {
            _tokenProvider = tokenProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var token = _tokenProvider.GetToken();

            if (!string.IsNullOrWhiteSpace(token))
            {
                request.Headers.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }


}
