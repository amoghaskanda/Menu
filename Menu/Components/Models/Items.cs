public class Item
{
    public string Name { get; set; }
    public int Count { get; set; }
    public double Price { get; set; }
    public Item(string _name, double _price, int _count = 0)
    {
        Name = _name;
        Price = _price;
        Count = _count;
    }
}