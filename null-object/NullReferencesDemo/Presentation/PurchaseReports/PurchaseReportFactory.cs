using NullReferencesDemo.Presentation.Interfaces;

namespace NullReferencesDemo.Presentation.PurchaseReports;

public class PurchaseReportFactory : IPurchaseReportFactory
{
    public IPurchaseReport CreateFailedPurchase()
    {
        return FailedPurchase.Instance;
    }

    public IPurchaseReport CreateNotSignedIn()
    {
        return new NotSignedIn();
    }

    public IPurchaseReport CreateNotRegistered(string userName)
    {
        return new NotRegistered(userName);
    }

    public IPurchaseReport CreateProductNotFound(string userName, string productName)
    {
        return new ProductNotFound(userName, productName);
    }

    public IPurchaseReport CreateNotEnoughMoney(string userName, string productName, decimal price)
    {
        return new NotEnoughMoney(userName, productName, price);
    }

    public IPurchaseReport CreateReport(string userName, string productName, decimal price)
    {
        return new Receipt(userName, productName, price);
    }
}