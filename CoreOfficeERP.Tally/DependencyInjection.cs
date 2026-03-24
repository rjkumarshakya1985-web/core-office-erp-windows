using Microsoft.Extensions.DependencyInjection;

namespace CoreOfficeERP.Tally
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationTally(
         this IServiceCollection services)
        {

            return services;
        }
    }
}
