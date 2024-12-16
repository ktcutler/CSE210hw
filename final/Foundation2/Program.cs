using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create customers with their addresses
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        
        Address address2 = new Address("456 Maple Ave", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", 101, 999.99m, 1);
        Product product2 = new Product("Smartphone", 102, 499.99m, 2);
        
        Product product3 = new Product("Tablet", 103, 399.99m, 1);
        Product product4 = new Product("Headphones", 104, 79.99m, 3);
        
        // Create orders
        List<Product> products1 = new List<Product> { product1, product2 };
        Order order1 = new Order(products1, customer1);

        List<Product> products2 = new List<Product> { product3, product4 };
        Order order2 = new Order(products2, customer2);

        // Print order details for order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost for order 1: {order1.CalculateTotalCost():C}\n");

        // Print order details for order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost for order 2: {order2.CalculateTotalCost():C}");
    }
}
