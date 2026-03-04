namespace ConsoleApp1;

public class main
{
    static void Main(string[] args)
    {
        // Tạo khách hàng
        Customer vip = new VIPCustomer("C01", "Nguyen Sy Khanh Anh");
        Customer regular = new RegularCustomer("C02", "Tran Duc Hieu");
        // Tạo Order cho khách VIP
        Order order = new Order("ORD001", regular);

        order.AddItem(new Drink("D01", "Ca phe", 30000, "XL", true));
        order.AddItem(new Drink("D02", "Tra chanh", 30000, "XXL", true));
        order.AddItem(new Food("F01", "Banh sung trau", 20000, false));
        order.AddItem(new Food("F01", "Banh Mi Kep Trung Bate", 50000, false));
        // In hóa đơn
        order.PrintInvoice();

        Console.ReadLine();
    }
}