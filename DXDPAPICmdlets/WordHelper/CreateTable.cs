using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit;
using DXDPAPICmdlets.Models;
using DXDPAPICmdlets.Helper;


namespace DXDPAPICmdlets.WordHelper
{
    internal class CreateTable
    {
        private readonly Common _common = new();
        public void CreateTableInDocument(DataTable dataTable, string fileName, DocumentFormat documentFormat, bool export2Pdf = false)
        {
            using var wordProcessor = new RichEditDocumentServer();
            Document document = wordProcessor.Document;
            Table table = document.Tables.Create(document.Range.Start, dataTable.Data.Count, dataTable.DataColumns.Count, AutoFitBehaviorType.AutoFitToWindow);
            var cellRowIndex = 0;
            var cellRowIndexValue = 0;

            table.BeginUpdate();
            try
            {
                for (var cellColumnIndex = 0; cellColumnIndex < dataTable.DataColumns.Count; cellColumnIndex++)
                    document.InsertText(table.Rows[cellRowIndex].Cells[cellColumnIndex].Range.Start,
                        dataTable.DataColumns[cellColumnIndex].Label);
                for (cellRowIndex = ++cellRowIndexValue; cellRowIndex < dataTable.Data.Count; cellRowIndex++)
                {
                    var dataTableRow = dataTable.Data[cellRowIndex - 1];
                    var valueList = new List<string>();
                    foreach (var dataTableColumn in dataTable.DataColumns)
                        valueList.Add(dataTableRow.Values[dataTableColumn.ToString()].DisplayValue);
                    for (int cellColumnIndex = 0; cellColumnIndex < valueList.Count; cellColumnIndex++)
                        document.InsertText(table.Rows[cellRowIndex].Cells[cellColumnIndex].Range.Start,
                            valueList[cellColumnIndex]);

                }
            }
            finally
            {
                table.EndUpdate();
            }
            wordProcessor.ExportToPdf(fileName + _common.PdfExtension);
            wordProcessor.SaveDocument(fileName, documentFormat);
        }
    }
}
