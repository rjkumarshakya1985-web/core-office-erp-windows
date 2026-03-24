using CoreOfficeERP.Application.Interfaces;
using CoreOfficeERP.Application.Services;
using CoreOfficeERP.Infrastructure.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace CoreOfficeERP.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(
      this IServiceCollection services)
        {
            services.AddSingleton<ITokenProvider, TokenProvider>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IMasterService, MasterService>();
            services.AddScoped<IPackingSlipService, PackingSlipService>();
            services.AddScoped<IVisitorService, VisitorService>();
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<IFinanceYearService, FinanceYearService>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<IDeliveryChallanService, DeliveryChallanService>();
            services.AddScoped<ISalesPersonService, SalesPersonService>();
            return services;
        }
    }
}
