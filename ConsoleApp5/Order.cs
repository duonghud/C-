public class Order
{
    public string OrderId { get; private set; }
    public Customer Customer { get; private set; }
    public DateTime CreatedTime { get; private set; }

    private List<MenuItem> items;
    public Order(string orderId, Customer customer)
    {
        OrderId = orderId;
        Customer = customer;
        CreatedTime = DateTime.Now;
        items = new List<MenuItem>();
    }

    public void AddItem(MenuItem item)
    {
        items.Add(item);
    }

    public void RemoveItem(string itemId)
    {
        items.RemoveAll(i => i.Id == itemId);
    }

    public double CalculateSubtotal()
    {
        double total = 0;
        foreach (var item in items)
        {
            total += item.CalculatePrice();
        }
        return total;
    }

    public void PrintInvoice()
    {
        Console.WriteLine("======= HÓA ĐƠN =======");
        Console.WriteLine($"Mã đơn: {OrderId}");
        Console.WriteLine($"Khach hang: {Customer.Name}");
        Console.WriteLine($"Thoi gian: {CreatedTime}");
        Console.WriteLine("------------------------");

        foreach (var item in items)
        {
            item.PrintDetail();
        }

        double subtotal = CalculateSubtotal();
        double discount = subtotal * Customer.GetDiscountRate();
        double finalTotal = subtotal - discount;

        Console.WriteLine("------------------------");
        Console.WriteLine($"Tong tien ban dau: {subtotal:N0} VND");
        Console.WriteLine($"Giam gia: {discount:N0} VND");
        Console.WriteLine($"Thanh toan: {finalTotal:N0} VND");
    }
}