using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;
using DXDPAPICmdlets.Models;

namespace DXDPAPICmdlets.ExcelHelper
{
    internal class CreateTable
    {
        SaveDxDpExcelCmdlet saveDxDpExcelCmdlet = new SaveDxDpExcelCmdlet();

        public void CreateTableInSpreadsheet(DataTable dataTable, string fileName)
        {
            using (Workbook workbook = new Workbook())
            {
                Worksheet worksheet = workbook.Worksheets[0];
                workbook.BeginUpdate();
                try
                {
                    worksheet.Import(dataTable.Data, 0, 0);
                }
                finally
                {
                    workbook.EndUpdate();
                }

                if (saveDxDpExcelCmdlet.CalcuateSpreadsheets)
                    workbook.Calculate();
                if (saveDxDpExcelCmdlet.SaveAsPdf)
                    workbook.ExportToPdf(fileName);
                workbook.SaveDocument(fileName, DocumentFormat.Xlsx);
            }

        }
    }
}
