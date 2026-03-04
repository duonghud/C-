namespace ConsoleApp1;

public class Drink : MenuItem
{
    public string Size { get; private set; }
    public bool IsIced { get; private set; }

    public Drink(string id, string name, double basePrice, string size, bool isIced)
        : base(id, name, basePrice)
    {
        Size = size;
        IsIced = isIced;
    }

    public override double CalculatePrice()
    {
        double price = BasePrice;
        switch (Size)
        {
            case "S":
                price += BasePrice;
                break;
            case "M":
                price += BasePrice * 0.2;
                break;
            case "L":
                price += BasePrice * 0.3;
                break;
            case "XL":
                price += BasePrice * 0.7;
                break;
            case "XXL":
                price += BasePrice * 0.9;
                break;
        }
        return price;
    }

    public override void PrintDetail()
    {
        Console.WriteLine(
            $"- {Name} (Size {Size}, {(IsIced ? "Đá" : "Nóng")}): {CalculatePrice():N0} VND");
    }
}