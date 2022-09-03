using NullReferencesDemo.Presentation.Interfaces;

namespace NullReferencesDemo.Presentation.PurchaseReports;

public class ProductNotFound : IPurchaseReport
{
    private readonly string userName;
    private readonly string productName;

    public ProductNotFound(string userName, string productName)
    {
        this.productName = productName;
        this.userName = userName;
    }
    public string GetResultMessage()
    {
        return $"Dear {this.userName}, \n Sorry, we do not have {this.productName} in stock!";
    }
}