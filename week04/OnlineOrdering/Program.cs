using System;

using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Elm St", "New York", "NY", "USA");
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Alice Johnson", address1);
        Customer customer2 = new Customer("Bob Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LPT123", 800, 1));
        order1.AddProduct(new Product("Mouse", "MSE456", 20, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "PHN789", 600, 1));
        order2.AddProduct(new Product("Charger", "CHR101", 25, 3));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
