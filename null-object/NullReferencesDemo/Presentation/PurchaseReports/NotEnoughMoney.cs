using NullReferencesDemo.Presentation.Interfaces;

namespace NullReferencesDemo.Presentation.PurchaseReports;

public class NotEnoughMoney : IPurchaseReport
{
    private readonly string userName;
    private readonly decimal price;
    private readonly string productName;
    
    public NotEnoughMoney(string userName, string productName, decimal price)
    {
        this.userName = userName;
        this.productName = productName;
        this.price = price;
    }

    public string GetResultMessage()
    {
        return $"Dear {this.userName},\n You do not have {this.price:C} to pay for the {this.productName}";
    }
}