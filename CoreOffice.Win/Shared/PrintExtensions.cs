using Microsoft.Reporting.WinForms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;

namespace CoreOffice.Win.Shared
{
    public static class PrintExtensions
    {

        private static IList<Stream> m_streams;
        private static int m_currentPageIndex;

        /// <summary>
        /// Main Extension Method → Call this from anywhere
        /// </summary>
        public static void PrintToPrinter(this LocalReport report,
                                         string printerName = "",
                                         string pageWidth = "3.15in",
                                         string pageHeight = "11in",
                                         short copies = 1)
        {
            Export(report, pageWidth, pageHeight);
            Print(printerName, copies);
        }

        /// <summary>
        /// Export RDLC → EMF Streams (Dynamic Size)
        /// </summary>
        private static void Export(LocalReport report, string pageWidth, string pageHeight)
        {
            string deviceInfo = $@"
            <DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>{pageWidth}</PageWidth>
                <PageHeight>{pageHeight}</PageHeight>
                <MarginTop>0.2in</MarginTop>
                <MarginLeft>0.2in</MarginLeft>
                <MarginRight>0.2in</MarginRight>
                <MarginBottom>0.2in</MarginBottom>
            </DeviceInfo>";

            Warning[] warnings;
            m_streams = new List<Stream>();

            report.Render("Image", deviceInfo, CreateStream, out warnings);

            foreach (var stream in m_streams)
                stream.Position = 0;
        }

        /// <summary>
        /// Create Memory Stream
        /// </summary>
        private static Stream CreateStream(string name, string ext, Encoding encoding, string mimeType, bool willSeek)
        {
            var stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        /// <summary>
        /// Send to Printer
        /// </summary>
        private static void Print(string printerName, short copies)
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("No pages to print.");

            PrintDocument printDoc = new PrintDocument();

            if (!string.IsNullOrEmpty(printerName))
                printDoc.PrinterSettings.PrinterName = printerName;

            printDoc.PrinterSettings.Copies = copies;
            printDoc.PrintPage += PrintPage;

            m_currentPageIndex = 0;
            printDoc.Print();
        }

        /// <summary>
        /// Print Each Page
        /// </summary>
        private static void PrintPage(object sender, PrintPageEventArgs e)
        {
            using (var pageImage = new Metafile(m_streams[m_currentPageIndex]))
            {
                e.Graphics.DrawImage(pageImage, e.PageBounds);
            }

            m_currentPageIndex++;
            e.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }
    }
}

