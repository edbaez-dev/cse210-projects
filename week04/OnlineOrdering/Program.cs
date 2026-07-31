using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple Street", "Salt Lake City, UT", "USA");
        Customer customer1 = new Customer("Diego Fernandez", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "P001", 19.99, 2));
        order1.AddProduct(new Product("Keyboard", "P002", 45.50, 1));
        order1.AddProduct(new Product("USB Cable", "P003", 7.25, 3));

        Address address2 = new Address("456 King Avenue", "Toronto, ON", "Canada");
        Customer customer2 = new Customer("Sofia Martinez", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Desk Lamp", "P004", 22.00, 1));
        order2.AddProduct(new Product("Notebook Set", "P005", 12.75, 4));

        Console.WriteLine("--- Order 1 ---");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine();

        Console.WriteLine("--- Order 2 ---");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}