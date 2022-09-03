namespace NullReferencesDemo.Presentation.Interfaces;

public interface IPurchaseReportFactory
{
    IPurchaseReport CreateFailedPurchase();
    IPurchaseReport CreateNotSignedIn();
    IPurchaseReport CreateNotRegistered(string userName);
    IPurchaseReport CreateProductNotFound(string userName, string productName);
    IPurchaseReport CreateNotEnoughMoney(string userName, string productName, decimal price);
    IPurchaseReport CreateReport(string userName, string productName, decimal price);
}