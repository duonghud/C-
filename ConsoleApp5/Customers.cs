public abstract class Customer
{
    public string CustomerId { get; protected set; }
    public string Name { get; protected set; }

    private int points;

    public int Points
    {
        get { return points; }
        private set
        {
            if (value >= 0)
                points = value;
        }
    }

    public Customer(string id, string name)
    {
        CustomerId = id;
        Name = name;
        Points = 0;
    }

    public void AddPoints(int value)
    {
        if (value > 0)
            Points += value;
    }

    public abstract double GetDiscountRate();
}