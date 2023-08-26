using System.Management.Automation;
using System.Management.Automation.Internal;


namespace DXDPAPICmdlets.Helper;

public class ProcessObject
{
    public bool TryProcessObject(PSObject inputPsObject, ref List<PSObject> psObjects, out ErrorRecord? errorRecord)
    {
        object baseObject = inputPsObject.BaseObject;

        if (baseObject is ScriptBlock ||
            baseObject is SwitchParameter ||
            baseObject is PSReference ||
            baseObject is PSObject)
        {
            errorRecord = new ErrorRecord(
                new FormatException("Invalid data type for document processing"),
                "InputNotSupported",
                ErrorCategory.InvalidOperation,
                null);

            return true;
        }

        psObjects.Add(inputPsObject);
        errorRecord = null;
        return false;
    }
}