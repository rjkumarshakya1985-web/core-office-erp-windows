using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CoreOfficeERP.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(
      this IServiceCollection services)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IMasterService, MasterService>();
            //services.AddScoped<IParcelService, ParcelService>();
            //services.AddScoped<IPackingSlipService, PackingSlipService>();

            return services;
        }
    }
}
