using CoreOfficeERP.Tally.Interfaces;
using CoreOfficeERP.Tally.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CoreOfficeERP.Tally
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationTally(
         this IServiceCollection services)
        {
            services.AddScoped<ITallyPurchaseService, TallyPurchaseService>();
            return services;

        }
    }
}
