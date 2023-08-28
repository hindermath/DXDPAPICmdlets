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
                    
                    for (int headerCol = 0; headerCol < dataTable.DataColumns.Count; headerCol++)
                    {
                        TableColumn tableColumn = table.Columns[headerCol];
                        tableColumn.Name = dataTable.DataColumns[headerCol].Label;
                    }

                    for (int cellRowIndex = 0; cellRowIndex < dataTable.Data.Count; cellRowIndex++)
                    {
                        var dataTableRow = dataTable.Data[cellRowIndex];
                        var valueList = new List<string>();
                        foreach (var dataTableColumn in dataTable.DataColumns)
                        {
                            string dataValue = dataTableRow.Values[dataTableColumn.ToString()].DisplayValue;
                            valueList.Add(dataValue);
                        }
                        for (int cellColIndex = 0; cellColIndex < valueList.Count; cellColIndex++)
                        {
                            worksheet.Cells[cellRowIndex, cellColIndex].Value = valueList[cellColIndex];
                        }
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
