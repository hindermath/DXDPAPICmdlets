using System.Management.Automation;
using System.Management.Automation.Internal;
using DevExpress.XtraSpreadsheet.Model.CopyOperation;

namespace DevExpress.DP.Word.Cmdlets
{
    [Cmdlet(VerbsData.Save, "DxDpWordFile")]
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
                    new PSInvalidOperationException("Input is not supported from the pipeline."),
            "InputNotSupported",
                    ErrorCategory.InvalidOperation,
        null);
                ThrowTerminatingError(errorRecord);
            }
        }

        protected override void ProcessRecord()
        {
            if (InputObject == null || InputObject == AutomationNull.Value)
                return;
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();

            // Rückkehr, wenn keine Objekte vorhanden sind
            if (_psObjects.Count == 0)
                return;
        }
    }
}