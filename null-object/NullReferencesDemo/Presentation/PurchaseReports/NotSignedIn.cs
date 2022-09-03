using NullReferencesDemo.Presentation.Interfaces;

namespace NullReferencesDemo.Presentation.PurchaseReports;

public class NotSignedIn : IPurchaseReport
{
    public string GetResultMessage()
    {
        return "User not signed in!";
    }
}