using System.Collections;
using System.Diagnostics;
using System.Management.Automation;
using System.Management.Automation.Internal;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DXDPAPICmdlets.DataHelper;
using DXDPAPICmdlets.Models;
using DXDPAPICmdlets.WordHelper;

namespace DXDPAPICmdlets
{
    [Cmdlet(VerbsData.Save, "DxDpWordFile")]
    [Alias("SavAsWordFile")]
    public class SaveDxDpWordCmdlet : PSCmdlet
    {
        #region Properties
        private List<PSObject> _psObjects = new List<PSObject>();
        private ProcessObject _processObject = new ProcessObject();
        private ErrorRecord? _errorRecord;
        private DataTable _dataTable;
        private CreateTable _createTable = new WordHelper.CreateTable();
        #endregion Properties
        #region Input Parameters
        /// <summary>
        /// This parameter specifies the current pipeline object.
        /// Dieser Parameter gibt das aktuelle Pipeline-Objekt an.
        /// </summary>
        [Parameter(ValueFromPipeline = true, HelpMessage = "Specifies the input pipeline object")]
        public PSObject InputObject { get; set; } = AutomationNull.Value;
        [Parameter(HelpMessage = "Open the file in the associated word processor")]
        public SwitchParameter OpenFileInWordProcessor { get; set; } = false;
        [Parameter(HelpMessage = "Export the file to PDF")]
        public SwitchParameter ExportToPdf { get; set; } = false;
        [Parameter(Mandatory = true, HelpMessage = "Specifies the file name")]
        public string FileName { get; set; } = "a.docx";
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

            _createTable.CreateTableInDocument(_dataTable, FileName, DocumentFormat.OpenXml, ExportToPdf);

            if (OpenFileInWordProcessor)
                Process.Start(new ProcessStartInfo(FileName) {UseShellExecute = true});

        }
    }
}