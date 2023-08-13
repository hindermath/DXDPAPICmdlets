using System.Management.Automation;
using System.Management.Automation.Internal;

namespace DevExpress.DP.PDF.Cmdlets
{
    [Cmdlet(VerbsData.Save, "DxDpPdfFile")]
    public class SaveDxDpPdfCmdlet : PSCmdlet
    {
        #region Properties
        private List<PSObject> _psObjects = new List<PSObject>();
        #endregion Properties
        #region Input Parameters
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
