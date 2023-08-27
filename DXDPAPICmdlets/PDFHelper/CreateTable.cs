using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DXDPAPICmdlets.Models;

namespace DXDPAPICmdlets.PDFHelper
{
    internal class CreateTable
    {
        public void CreateTableInPdf(DataTable dataTable, string fileName)
        {
            using (DevExpress.Pdf.PdfDocumentProcessor pdfDocumentProcessor = new DevExpress.Pdf.PdfDocumentProcessor())
            {
                pdfDocumentProcessor.CreateEmptyDocument(fileName);
                pdfDocumentProcessor.LoadDocument(fileName);

                pdfDocumentProcessor.CloseDocument();
            }
        }
    }
}
