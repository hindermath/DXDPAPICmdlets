using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;
using DXDPAPICmdlets.Models;
using DXDPAPICmdlets.Helper;

namespace DXDPAPICmdlets.ExcelHelper
{
    internal class CreateTable
    {
        Common common = new Common();
        public void CreateTableInSpreadsheet(DataTable dataTable, string fileName)
        {
            using (Workbook workbook = new Workbook())
            {
                Worksheet worksheet = workbook.Worksheets[0];
                workbook.BeginUpdate();
                try
                {
                    CellRange cellRange = worksheet.Range.FromLTRB(0, 0, dataTable.DataColumns.Count, dataTable.Data.Count);
                    Table table = worksheet.Tables.Add(cellRange, true);
                    table.ShowTableStyleRowStripes = true;
                    table.Style = workbook.TableStyles[BuiltInTableStyleId.TableStyleMedium2];
                    for (int i = 0; i < dataTable.DataColumns.Count; i++)
                    {
                        TableColumn tableColumn = table.Columns[i];
                        tableColumn.Name = dataTable.DataColumns[i].Label;
                    }
                }
                finally
                {
                    workbook.EndUpdate();
                }

                workbook.Calculate();
                workbook.ExportToPdf(fileName+common.PdfExtension);
                workbook.SaveDocument(fileName, DocumentFormat.Xlsx);
            }

        }
    }
}
