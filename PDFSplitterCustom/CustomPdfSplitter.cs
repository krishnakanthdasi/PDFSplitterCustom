using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFSplitterCustom
{
    public class CustomPdfSplitter : PdfSplitter
    {

        private String dest;
        private int partNumber = 1;

        public CustomPdfSplitter(PdfDocument pdfDocument, String dest) : base(pdfDocument)
        {
            this.dest = dest;
        }

        protected override PdfWriter GetNextPdfWriter(PageRange documentPageRange)
        {
            return new PdfWriter(String.Format(dest, partNumber++));
        }
    }
}
