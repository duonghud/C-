
public abstract class MenuItem
{
    // Khai báo biến
    public string Id { get; set; }
    public string Name { get; set; }
    public double BasePrice { get; set; }

    public MenuItem(string id, string name, double basePrice)
    {
        Id = id;
        Name = name;
        BasePrice = basePrice;
    }

    public abstract double CalculatePrice();
    public abstract void PrintDetail();
}