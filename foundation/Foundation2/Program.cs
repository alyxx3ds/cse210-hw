using System;
using Foundation2;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", "P001", 1200.00m, 1);
        Product product2 = new Product("Mouse", "P002", 25.00m, 2);

        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");

        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
    }
}