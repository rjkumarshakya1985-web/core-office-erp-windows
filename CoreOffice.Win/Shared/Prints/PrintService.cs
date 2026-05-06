using CoreOffice.Win.Shared.Mappers;
using CoreOffice.Win.Shared.RDLCModels;
using CoreOfficeERP.Application.Interfaces;
using Microsoft.Reporting.WinForms;

namespace CoreOffice.Win.Shared.Prints
{
    public class PrintService
    {
        private readonly IPrintDataService _printDataService;
        public PrintService(IPrintDataService printDataService)
        {
            _printDataService = printDataService;
        }

        public async Task<bool> PrintPackingSlipAsync(int packingSlipId)
        {
            try
            {
                var packingSlip = await _printDataService.GetPackingSlipPrint(packingSlipId);

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
            //    var items = new List<PackingSlipItemModel>
            //      {
            //          new PackingSlipItemModel
            //{
            //              SlipNumber="0008",
            //              Date=DateTime.Now,
            //                VisitorName="Shiv Sahay Bhagwan Das Pvt Ltd Agra",
            //                VisitorType="Customer",
            //                VisitorMobile="8299344397",
            //                TotalPcs=10,
            //                GrandTotal=1000,
            //                StockGroup="Group A",
            //                BarCode="1234567890123",
            //                    Qty=10,
            //                    GstValue=5,
            //                    SaleRate=100,
            //                    TaxableAmount=950,
            //                    Amount=1000,
            //                        Salesman="John Doe",
            //                        UserName="admin",
            //                        Department="Sales",
            //                        SubDepartment="Retail",
            //    ProductName = "B-222, Yamuna River, Agra",
               
            //}
            //       };


                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("DataSetPackingSlip", items));
                report.DataSources.Add(new ReportDataSource("DataSetCompany", companyData));

                report.Refresh();

               
                report.PrintToPrinter(
                    printerName: "ESYPOS ETP5311(250N)", 
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
