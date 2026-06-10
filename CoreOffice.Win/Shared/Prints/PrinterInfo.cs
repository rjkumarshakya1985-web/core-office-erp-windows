using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOffice.Win.Shared.Prints
{
    public class PrinterInfo
    {
        public string PrinterName { get; set; }
        public string PageWidth { get; set; }
        public string PageHeight { get; set; }
        public short Copies { get; set; }
    }

    public class PrinterConfiguration
    {
        public PrinterInfo ReceiptPrinter { get; set; }
        public PrinterInfo A4Printer { get; set; }
    }
}
