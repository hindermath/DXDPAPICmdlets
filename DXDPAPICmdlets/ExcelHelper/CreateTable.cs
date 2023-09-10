using DevExpress.Spreadsheet;
using DXDPAPICmdlets.Models;
using DXDPAPICmdlets.Helper;

namespace DXDPAPICmdlets.ExcelHelper
{
    internal class CreateTable
    {
        private readonly Common _common = new();
        public void CreateTableInSpreadsheet(DataTable dataTable, string fileName)
        {
            using Workbook workbook = new Workbook();
            Worksheet worksheet = workbook.Worksheets[0];
            workbook.BeginUpdate();
            var cellRange = worksheet.Range.FromLTRB(0, 0, dataTable.DataColumns.Count - 1, dataTable.Data.Count);
            var table = worksheet.Tables.Add(cellRange, true);
            var cellDataRange = table.DataRange;
            try
            {
                table.ShowTableStyleRowStripes = true;
                table.Style = workbook.TableStyles[BuiltInTableStyleId.TableStyleMedium2];

                for (var headerCol = 0; headerCol < dataTable.DataColumns.Count; headerCol++)
                {
                    TableColumn tableColumn = table.Columns[headerCol];
                    tableColumn.Name = dataTable.DataColumns[headerCol].Label;
                }

                for (var cellRowIndex = 0; cellRowIndex < dataTable.Data.Count; cellRowIndex++)
                {
                    var dataTableRow = dataTable.Data[cellRowIndex];
                    var valueList = new List<string>();
                    foreach (var dataTableColumn in dataTable.DataColumns)
                        valueList.Add(dataTableRow.Values[dataTableColumn.ToString()].DisplayValue);
                    for (var cellColIndex = 0; cellColIndex < valueList.Count; cellColIndex++)
                        cellDataRange[cellRowIndex, cellColIndex].Value = valueList[cellColIndex];
                }

            }
            finally
            {
                workbook.EndUpdate();
            }

            workbook.Calculate();
            workbook.ExportToPdf(fileName + _common.PdfExtension);
            workbook.SaveDocument(fileName, DocumentFormat.Xlsx);

        }
    }
}
