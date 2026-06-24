using CoreOffice.Win.Shared.Mappers;
using CoreOffice.Win.Shared.RDLCModels;
using CoreOfficeERP.Application.Interfaces;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;

namespace CoreOffice.Win.Shared.Prints
{
    public class PrintService
    {
        private readonly IPrintDataService _printDataService;
        private readonly PrinterConfiguration _printerConfig;
        public PrintService(IPrintDataService printDataService)
        {
            _printDataService = printDataService;
            _printerConfig = LoadPrinterConfig(); 
        }
        private PrinterConfiguration LoadPrinterConfig()
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "PrinterSettings.json");

            if (!File.Exists(filePath))
            {
                throw new Exception("PrinterSettings.json not found.");
            }

            string json = File.ReadAllText(filePath);
            var config = JsonConvert.DeserializeObject<PrinterConfiguration>(json);

            if (config == null)
                throw new Exception("Invalid PrinterSettings.json.");
            return config;
           
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
                foreach (var item in items)
                {
                    item.BarcodeImage = GenerateBarcode(item.SlipNumber);
                }
                LocalReport report = new LocalReport();
                report.ReportPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Shared/Prints/PackingSlip/RDLCPackingSlip.rdlc"
                );

                
                var companyData = new List<PackingSlipCompanyModel>
                  {
                      new PackingSlipCompanyModel
            {

                Address = "6/20,Yamuna Kinara Road, Belanganj, Agra",
                Phone = "7817803383",
                Name = "Shiv Sahai Bhagwan Das Sarees Pvt Ltd",
                GstIn = "09AARCS1924P1ZJ",
                Email = "ssbd432@gmail.com",
                State = "Uttar Pradesh",
                StateCode = "07",
                PINCode = "282002",
                SalesPhone = "7817803384",
                Mobile = "9997644193",
                CIN = "U51101UP2012PTC049504",
                MSMECode = "UP-01-0072013"
            }
                   }; 
                report.DataSources.Clear();
                report.DataSources.Add(new ReportDataSource("DataSetPackingSlip", items));
                report.DataSources.Add(new ReportDataSource("DataSetCompany", companyData));

                report.Refresh();               
               
              report.PrintToPrinter(
              printerName: _printerConfig.ReceiptPrinter.PrinterName,
              pageWidth: _printerConfig.ReceiptPrinter.PageWidth,
              pageHeight: _printerConfig.ReceiptPrinter.PageHeight,
              copies: _printerConfig.ReceiptPrinter.Copies
              );

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Print failed: {ex.Message}");
                return false;
            }
        }

        public static byte[] GenerateBarcode(string barcodeText)
        {
            BarcodeLib.Barcode barcode = new BarcodeLib.Barcode();

            using (Image img = barcode.Encode(
                BarcodeLib.TYPE.CODE128,
                barcodeText,
                Color.Black,
                Color.White,
                250,
                40))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
        }     
    }
}
