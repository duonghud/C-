namespace ConsoleApp1;

public class VIPCustomer : Customer
{
    public VIPCustomer(string id, string name)
        : base(id, name)
    {
    }

    public override double GetDiscountRate()
    {
        return 0.1;
    }
}