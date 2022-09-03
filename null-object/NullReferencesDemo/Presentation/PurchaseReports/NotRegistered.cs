using NullReferencesDemo.Presentation.Interfaces;

namespace NullReferencesDemo.Presentation.PurchaseReports;

public class NotRegistered : IPurchaseReport
{
    private readonly string userName;

    public NotRegistered(string userName)
    {
        this.userName = userName;
    }
    public string GetResultMessage()
    {
        return $"User {this.userName} is not registered!";
    }
}