using System.Collections;
using System.Management.Automation;
using System.Management.Automation.Internal;

namespace DevExpress.DP.Word.Cmdlets
{
    [Cmdlet(VerbsData.Save, "DxDpWordFile")]
    [Alias("SavAsWordFile")]
    public class SaveDxDpWordCmdlet : PSCmdlet
    {
        #region Properties
        private List<PSObject> _psObjects = new List<PSObject>();
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
                {
                    ProcessObject(PSObject.AsPSObject(entry));
                }
            }
            else
            {
                ProcessObject(InputObject);
            }
        }

        private void ProcessObject(PSObject inputPsObject)
        {
            object baseObject = inputPsObject.BaseObject;

            if (baseObject is ScriptBlock ||
                baseObject is SwitchParameter ||
                baseObject is PSReference ||
                baseObject is PSObject)
            {
                ErrorRecord errorRecord = new ErrorRecord(
                    new FormatException("Invalid data type for document processing"),
             "InputNotSupported",
                    ErrorCategory.InvalidOperation,
          null);
                ThrowTerminatingError(errorRecord);
            }

            _psObjects.Add(inputPsObject);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();

            // Rückkehr, wenn keine Objekte vorhanden sind
            if (_psObjects.Count.Equals(0))
                return;
        }
    }
}