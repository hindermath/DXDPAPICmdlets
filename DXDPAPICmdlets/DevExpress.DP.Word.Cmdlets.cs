using System.Management.Automation;
using System.Management.Automation.Internal;
using DevExpress.XtraSpreadsheet.Model.CopyOperation;

namespace DevExpress.DP.Word.Cmdlets
{
    [Cmdlet(VerbsData.Save, "DxDpWordFile")]
    public class SaveDxDpWordCmdlet : PSCmdlet
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