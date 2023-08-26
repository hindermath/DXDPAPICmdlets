using System.Collections;
using System.Management.Automation;
using System.Management.Automation.Internal;
using DXDPAPICmdlets.Helper;

namespace DevExpress.DP.Word.Cmdlets
{
    [Cmdlet(VerbsData.Save, "DxDpWordFile")]
    [Alias("SavAsWordFile")]
    public class SaveDxDpWordCmdlet : PSCmdlet, IDisposable
    {
        #region Properties
        private List<PSObject> _psObjects = new List<PSObject>();
        private ProcessObject _processObject = new ProcessObject();
        private ErrorRecord? _errorRecord;
        #endregion Properties
        #region Input Parameters
        /// <summary>
        /// This parameter specifies the current pipeline object.
        /// Dieser Parameter gibt das aktuelle Pipeline-Objekt an.
        /// </summary>
        [Parameter(ValueFromPipeline = true, HelpMessage = "Specifies the input pipeline object")]
        public PSObject InputObject { get; set; } = AutomationNull.Value;
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

            var TG = new TypeGetter(this);

            var dataTable = TG.CastObjectsToTableView(_psObjects);

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}