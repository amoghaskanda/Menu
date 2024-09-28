namespace Menu.Components.Pages
{
    public partial class Home
    {
        string? Discount { get; set; }
        bool IsValidateClicked { get; set; } = false;
        bool HasCheckedOut { get; set; } = false;
        bool HasPaid { get; set; } = false;
        readonly string[] ValidCodes = { "abc10", "xyz20" };
        List<Item> Items = new()
        {
            new("Italian Coffee", 1.5),
            new("American Coffee", 2.5),
            new("Tea", 3),
            new("Chocolate", 4)
        };

        public void Reset()
        {
            foreach (var item in Items) { item.Count = 0; }
            IsValidateClicked = HasCheckedOut = HasPaid = false;
        }

        public bool IsValidDiscount(string? discount)
        {
            return ValidCodes.Contains(discount);
        }

        public double GetTotal(List<Item> Items)
        {
            if (Items.Any(item => item.Count < 0 || item.Price < 0))
                throw new InvalidOperationException("Price and number of items cannot be negative");
            var sum = Items.Sum(Item => Item.Price * Item.Count);
            if (Discount == ValidCodes[0])
                return Math.Round(sum * 0.9, 1);
            else if (Discount == ValidCodes[1])
                return Math.Round(sum * 0.8, 1);
            else
                return sum;

        }
    }
}