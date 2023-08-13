using System.Management.Automation;
using System.Management.Automation.Internal;

namespace DexExpress.DP.Excel.Cmdlets
{
    [Cmdlet(VerbsData.Save, "DxDpExcelFile")]
    public class SaveDxDpExcelCmdlet : PSCmdlet
    {
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

    }
}
