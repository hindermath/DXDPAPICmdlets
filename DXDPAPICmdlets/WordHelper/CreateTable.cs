using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit;
using DXDPAPICmdlets.Models;


namespace DXDPAPICmdlets.WordHelper
{
    internal class CreateTable
    {
        SaveDxDpWordCmdlet saveDxDpWordCmdlet = new SaveDxDpWordCmdlet();
        public void CreateTableInDocument(DataTable dataTable, string fileName)
        {
            using (var wordProcessor = new RichEditDocumentServer())
            {
                Document document = wordProcessor.Document;
                Table table = document.Tables.Create(document.Range.Start, dataTable.Data.Count, dataTable.DataColumns.Count, AutoFitBehaviorType.AutoFitToWindow);
                
                if (saveDxDpWordCmdlet.SaveAsPdf)
                    wordProcessor.ExportToPdf(fileName);

                wordProcessor.SaveDocument(fileName, DocumentFormat.OpenXml);
            }
        }
    }
}
