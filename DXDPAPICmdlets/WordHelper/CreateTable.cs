using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit;
using DXDPAPICmdlets.Models;


namespace DXDPAPICmdlets.WordHelper
{
    internal class CreateTable
    {
        public void CreateTableInDocument(DataTable dataTable, string fileName)
        {
            using (var wordProcessor = new RichEditDocumentServer())
            {
                Document document = wordProcessor.Document;
                Table table = document.Tables.Create(document.Range.Start, dataTable.Data.Count, dataTable.DataColumns.Count, AutoFitBehaviorType.AutoFitToWindow);
                
                wordProcessor.ExportToPdf(fileName+".pdf");
                wordProcessor.SaveDocument(fileName, DocumentFormat.OpenXml);
            }
        }
    }
}
