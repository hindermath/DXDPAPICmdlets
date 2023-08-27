using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit;
using DXDPAPICmdlets.Models;
using DXDPAPICmdlets.Helper;


namespace DXDPAPICmdlets.WordHelper
{
    internal class CreateTable
    {
        Common common = new Common();
        public void CreateTableInDocument(DataTable dataTable, string fileName)
        {
            using (var wordProcessor = new RichEditDocumentServer())
            {
                Document document = wordProcessor.Document;
                Table table = document.Tables.Create(document.Range.Start, dataTable.Data.Count, dataTable.DataColumns.Count, AutoFitBehaviorType.AutoFitToWindow);
                
                table.BeginUpdate();
                try
                {
                    for (int i = 0; i < dataTable.DataColumns.Count; i++)
                    {
                        document.InsertText(table.Rows[0].Cells[i].Range.Start, dataTable.DataColumns[i].Label);
                    }                    
                }
                finally
                {
                    table.EndUpdate();
                }                
                wordProcessor.ExportToPdf(fileName+common.PdfExtension);
                wordProcessor.SaveDocument(fileName, DocumentFormat.OpenXml);
            }
        }
    }
}
