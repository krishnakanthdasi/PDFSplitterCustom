using System;
using System.Collections.Generic;
using System.IO;
using iText.Kernel.Pdf;
using iText.Kernel.Utils;
using PDFSplitterCustom;

namespace PDFOperations
{
    public class PDFOperations
    {
        public static readonly String DEST = "../../../Result/Result_{0}.pdf";

        public static readonly String RESOURCE = "../../../10840.pdf";

        public static void Main(String[] args)
        {
            FileInfo file = new FileInfo(DEST);
            file.Directory.Create();

            new PDFOperations().ManipulatePdf(DEST);
        }

        public void ManipulatePdf(String dest)
        {
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(RESOURCE));

            IList<PdfDocument> splitDocuments = new CustomPdfSplitter(pdfDoc, dest).SplitByPageNumbers(new List<int> { 1 ,4, 7, 10 ,40});

            foreach (PdfDocument doc in splitDocuments)
            {
                doc.Close();
            }

            pdfDoc.Close();
        }

        
    }
}


