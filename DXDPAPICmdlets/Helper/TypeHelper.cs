using System.Management.Automation;
using DXDPAPICmdlets.Models;
using DataTable = DevExpress.DataAccess.Native.Data.DataTable;

namespace DXDPAPICmdlets.Helper
{
    public class TypeHelper
    {
        private PSCmdlet _cmdlet;

        public TypeHelper(PSCmdlet cmdlet)
        {
            _cmdlet = cmdlet;
        }
        public DataTable CastObjectsToTableView(List<PSObject> psObjects)
        {
            List<FormatViewDefinition> objectFormats = psObjects.Select(GetFormatViewDefinitionForObject).ToList();

            var dataTableColumns = GetDataColumnsForObject(psObjects);

            foreach (var dataColumn in dataTableColumns)
            {
                _cmdlet.WriteVerbose(dataColumn.ToString());
            }

            List<DataTableRow> dataTableRows = new List<DataTableRow>();
            for (var i = 0; i < objectFormats.Count; i++)
            {
                var dataTableRow = CastObjectToDataTableRow(psObjects[i], dataTableColumns, i);
                dataTableRows.Add(dataTableRow);
            }

            SetTypesOnDataColumns(dataTableRows, dataTableColumns);

            return new DataTable(dataTableColumns, dataTableRows);
        }
    }

}
