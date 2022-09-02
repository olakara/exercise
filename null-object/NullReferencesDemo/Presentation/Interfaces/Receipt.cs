namespace NullReferencesDemo.Presentation.Interfaces
{
    public class Receipt : IPurchaseReport
    {
        public string ItemName { get; private set; }
        public decimal Price { get; private set; }

        public Receipt(string itemName, decimal price)
        {
            this.ItemName = itemName;
            this.Price = price;
        }

        public string GetResultMessage()
        {
            return $"Thank you for buying {this.ItemName} for {this.Price:C}";
        }
    }
}
