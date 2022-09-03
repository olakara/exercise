using NullReferencesDemo.Presentation.Interfaces;

namespace NullReferencesDemo.Presentation.PurchaseReports;

public class FailedPurchase : IPurchaseReport
{
    private static FailedPurchase instance;
    private FailedPurchase()
    {
            
    }

    public static FailedPurchase Instance
    {
        get
        {
            
            if (instance != null) return instance;
            
            instance = new FailedPurchase();
            return instance;
        }
    }
    public string GetResultMessage()
    {
        return "Purchase failed!";
    }
}