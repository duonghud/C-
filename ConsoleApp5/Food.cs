namespace ConsoleApp1;

public class Food : MenuItem
{
    public bool IsHeated { get; private set; }

    public Food(string id, string name, double basePrice, bool isHeated)
        : base(id, name, basePrice)
    {
        IsHeated = isHeated;
    }

    public override double CalculatePrice()
    {
        return BasePrice;
    }

    public override void PrintDetail()
    {
        Console.WriteLine(
            $"- {Name} ({(IsHeated ? "Hâm nóng" : "Không hâm")}): {CalculatePrice():N0} VND");
    }
}