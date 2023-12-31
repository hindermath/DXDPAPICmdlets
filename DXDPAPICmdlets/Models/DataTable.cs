// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace DXDPAPICmdlets.Models
{
    public class DataTable
    {
        public List<DataTableRow> Data { get; set; }
        public List<DataTableColumn> DataColumns { get; set; }
        public DataTable(List<DataTableColumn> columns, List<DataTableRow> data)
        {
            DataColumns = columns;

            Data = data;
        }
    }
}
