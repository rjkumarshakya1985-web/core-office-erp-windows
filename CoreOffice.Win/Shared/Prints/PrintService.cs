using CoreOffice.Win.Shared.Mappers;
using CoreOffice.Win.Shared.RDLCModels;
using CoreOfficeERP.Application.Interfaces;
using Microsoft.Reporting.WinForms;

namespace CoreOffice.Win.Shared.Prints
{
    public class PrintService
    {
        private readonly IPackingSlipService _packingSlipService;
        public PrintService(IPackingSlipService packingSlipService) { 
            _packingSlipService = packingSlipService;
        }

        public async Task<bool> PrintPackingSlipAsync(int packingSlipId)
        {
            try
            {
                
                var packingSlip = await _packingSlipService.GetByIdAsync(packingSlipId);

                if (packingSlip == null)
                {
                    MessageBox.Show("Packing slip not found.");
                    return false;
                }
                var items = PackingSlipMapper.ToItems(packingSlip);

               
                LocalReport report = new LocalReport();
                report.ReportPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Shared/Prints/PackingSlip/RDLCPackingSlip.rdlc"
                );

                
                var companyData = new List<PackingSlipCompanyModel>
                  {
                      new PackingSlipCompanyModel
            {
                Address = "B-222, Yamuna River, Agra",
                Phone = "8299344397",
                Name = "Shiv Sahay Bhagwan Das Pvt Ltd Agra",
                GstIn = "07ADFPY6443H1Z1",
                Email = "ssbdagra@gmail.com",
                State = "Uttar Pradesh",
                StateCode = "07"
            }
                   };

               
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("DataSetPackingSlip", items));
                report.DataSources.Add(new ReportDataSource("DataSetCompany", companyData));

                report.Refresh();

               
                report.PrintToPrinter(
                    printerName: "", 
                    pageWidth: "3.15in",
                    pageHeight: "11in",
                    copies: 1
                );

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Print failed: {ex.Message}");
                return false;
            }
        }


    }
}
