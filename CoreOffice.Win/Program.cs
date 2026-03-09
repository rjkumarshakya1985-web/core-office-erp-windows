using CoreOfficeERP.Application;
using CoreOfficeERP.Infrastructure;
using CoreOfficeERP.Infrastructure.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace CoreOffice.Win
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

           
            services.AddInfrastructure("https://api.ssbdagra.in/api/");

           
            services.AddApplication();


            //  Register TokenProvider as Singleton
            services.AddSingleton<ITokenProvider, TokenProvider>();

            services.AddTransient<Login>();

            using var serviceProvider = services.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<Login>();
            Application.Run(mainForm);
        }
    }
}