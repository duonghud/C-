namespace ConsoleApp1;

public class RegularCustomer : Customer
{
    public RegularCustomer(string id, string name)
        : base(id, name)
    {
    }

    public override double GetDiscountRate()
    {
        return 0.0;
    }
}