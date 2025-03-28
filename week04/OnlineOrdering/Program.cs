using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create addresses
        Address address1 = new Address("2816/1 Mkoba 16", "Gweru", "Midlands", "Zimbabwe");
        Address address2 = new Address("368 Jules Street Malvern", "Johannesburg", "Gauteng", "South Africa");

        // Create customers
        Customer customer1 = new Customer("Blessing Mpofu", address1);
        Customer customer2 = new Customer("Bellinda Mpofu", address2);

        // Create products
        Product product1 = new Product("Smartphone", "gxh1", 100.00m, 1);
        Product product2 = new Product("Laptop", "G001", 1000.00m, 1);
        Product product3 = new Product("Ear pods", "T001", 20.00m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        // Display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        
        Console.WriteLine($"Total Price: ${order.CalculateTotal():0.00}");
        Console.WriteLine();
    }
}