using System.Management.Automation;
using System.Management.Automation.Internal;

namespace DevExpress.DP.PDF.Cmdlets
{
    [Cmdlet(VerbsData.Save, "DxDpPdfFile")]
    [Alias("SavAsPdfFile")]
    public class SaveDxDpPdfCmdlet : PSCmdlet
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
