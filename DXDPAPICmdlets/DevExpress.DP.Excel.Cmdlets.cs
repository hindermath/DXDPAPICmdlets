using System.Collections;
using System.Diagnostics;
using DXDPAPICmdlets.DataHelper;
using System.Management.Automation;
using System.Management.Automation.Internal;
using DevExpress.Spreadsheet;

namespace DXDPAPICmdlets
{
    [Cmdlet(VerbsData.Save, "DxDpExcelFile")]
    [Alias("SavAsExcelFile")]
    public class SaveDxDpExcelCmdlet : PSCmdlet, IDisposable
    {
        #region Properties
        private List<PSObject> _psObjects = new List<PSObject>();
        private ProcessObject _processObject = new ProcessObject();
        private ErrorRecord? _errorRecord;
        private DXDPAPICmdlets.Models.DataTable _dataTable;
        #endregion Properties
        #region Input Parameters
        /// <summary>
        /// This parameter specifies the current pipeline object.
        /// Dieser Parameter gibt das aktuelle Pipeline-Objekt an.
        /// </summary>
        [Parameter(ValueFromPipeline = true, HelpMessage = "Specifies the input pipeline object")]
        public PSObject InputObject { get; set; } = AutomationNull.Value;
        [Parameter(HelpMessage = "Open th file in the associated word processor")]
        public SwitchParameter OpenFileInSpreadsheet { get; set; }
        [Parameter(Mandatory = true, HelpMessage = "Specifies the file name")]
        public string FileName { get; set; }
        #endregion
        protected override void BeginProcessing()
        {
            if (Console.IsInputRedirected)
            {
                ErrorRecord errorRecord = new ErrorRecord(
                    new PSInvalidOperationException("Not supported in this environment (when input is redirected)."),
                    "InputNotSupported",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(errorRecord);
            }
        }
        protected override void ProcessRecord()
        {
            if (InputObject.Equals(null) || InputObject.Equals(AutomationNull.Value))
                return;

            if (InputObject.BaseObject is IDictionary dictionary)
            {
                foreach (DictionaryEntry entry in dictionary)
                    if (_processObject.TryProcessObject(PSObject.AsPSObject(entry), ref _psObjects, out _errorRecord))
                        ThrowTerminatingError(_errorRecord);
            }
            else if (_processObject.TryProcessObject(InputObject, ref _psObjects, out _errorRecord))
                ThrowTerminatingError(_errorRecord);
        }
        protected override void EndProcessing()
        {
            base.EndProcessing();

            // Rückkehr, wenn keine Objekte vorhanden sind
            if (_psObjects.Count.Equals(0))
                return;

            TypeGetter typeGetter = new TypeGetter(this);

            _dataTable = typeGetter.CastObjectsToTableView(_psObjects);

            using (Workbook workbook = new Workbook())
            {
                Worksheet worksheet = workbook.Worksheets[0];
                workbook.BeginUpdate();
                try
                {
                    worksheet.Import(_dataTable.Data, 0, 0);
                }
                finally
                {
                    workbook.EndUpdate();
                }
                workbook.Calculate();
                workbook.SaveDocument(FileName, DocumentFormat.Xlsx);
            }


            if (OpenFileInSpreadsheet)
                Process.Start(new ProcessStartInfo(FileName) {UseShellExecute = true});
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
