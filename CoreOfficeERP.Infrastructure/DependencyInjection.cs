using CoreOfficeERP.Infrastructure.Api;
using CoreOfficeERP.Infrastructure.Auth;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace CoreOfficeERP.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            string baseApiUrl)
        {
            // 🔹 TokenHandler for HttpClient authentication
            services.AddTransient<TokenHandler>();

            // 🔹 Generic API Repository for all DTOs
            services.AddScoped(typeof(IApiRepository), typeof(ApiRepository));

            // 🔹 HttpClient for ApiRepository (used by generic repository)
            services.AddHttpClient("ApiClient", client =>
            {
                client.BaseAddress = new Uri(baseApiUrl);
                client.Timeout = TimeSpan.FromSeconds(60);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            })
            .AddHttpMessageHandler<TokenHandler>();

            // 🔹 Auth API client (login)
            services.AddHttpClient<IAuthApiRepository, AuthApiRepository>(client =>
            {
                client.BaseAddress = new Uri(baseApiUrl);
                client.Timeout = TimeSpan.FromSeconds(30);
            });

            return services;
        }
    }
}
