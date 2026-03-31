using CoreOffice.Win.Modules.Cashier;
using CoreOffice.Win.Modules.Cashier.Invoices;
using CoreOffice.Win.Modules.MasterData;
using CoreOffice.Win.Modules.PackingSlip;
using CoreOffice.Win.Modules.Shared;
using CoreOfficeERP.Application;
using CoreOfficeERP.Infrastructure;
using CoreOfficeERP.Tally;
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


            // services.AddInfrastructure("https://localhost:7121/api/");
            services.AddInfrastructure("https://localhost:7121/api/");

            services.AddApplication();
            services.AddApplicationTally();


            //  Register TokenProvider as Singleton

            services.AddTransient<Login>();
            services.AddTransient<FrmPackingSlip>();
            services.AddTransient<DeliveryNoteForm>();
            services.AddTransient<MDIPackingSlip>();
            services.AddTransient<MDICashierParent>();
            services.AddTransient<CompanySelectionForm>();
            services.AddTransient<InvoiceForm>();
            services.AddTransient<DeliveryChallanReturnDetailForm>();
            services.AddTransient<VistiorCustomerForm>();
            services.AddTransient<DeliveryChallanToInvoiceForm>();
            services.AddTransient<PendingPackingSlipForm>();

            using var serviceProvider = services.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<Login>();
            Application.Run(mainForm);
        }
    }
}