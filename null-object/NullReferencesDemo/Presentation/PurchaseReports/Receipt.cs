namespace NullReferencesDemo.Presentation.Interfaces
{
    public class Receipt : IPurchaseReport
    {
        public string UserName { get; private set; }
        public string ItemName { get; private set; }
        public decimal Price { get; private set; }

        public Receipt(string userName, string itemName, decimal price)
        {
            this.UserName = userName;
            this.ItemName = itemName;
            this.Price = price;
        }

        public string GetResultMessage()
        {
            return $"Dear {this.UserName}, \n Thank you for buying {this.ItemName} for {this.Price:C}";
        }
    }
}
