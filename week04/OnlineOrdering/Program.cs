using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // ---------- ORDER 1 ----------
        Address addr1 = new Address("123 Apple St", "Provo", "UT", "USA");
        Customer cust1 = new Customer("John Smith", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "A100", 799.99, 1));
        order1.AddProduct(new Product("Mouse", "B200", 25.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
        Console.WriteLine("\n-----------------------------\n");

        // ---------- ORDER 2 ----------
        Address addr2 = new Address("45 Maple Road", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Sarah Connor", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Headphones", "H300", 59.99, 1));
        order2.AddProduct(new Product("Microphone", "M400", 120.00, 1));
        order2.AddProduct(new Product("USB Cable", "U500", 8.99, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}