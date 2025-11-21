using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Order Management System =====\n");

        // Create Order 1 - USA Customer
        Address address1 = new Address("123 Main Street", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);

        // Add products to Order 1
        Product product1 = new Product("Laptop", "L001", 999.99, 1);
        Product product2 = new Product("Mouse", "M045", 29.99, 2);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Display Order 1 information
        Console.WriteLine("ORDER 1:");
        Console.WriteLine("--------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order1.CalculateTotal():F2}");
        Console.WriteLine("\n==========================================\n");

        // Create Order 2 - International Customer
        Address address2 = new Address("456 Maple Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Maria Garcia", address2);
        Order order2 = new Order(customer2);

        // Add products to Order 2
        Product product3 = new Product("Keyboard", "K202", 79.99, 1);
        Product product4 = new Product("Monitor", "MON88", 299.99, 1);
        Product product5 = new Product("HDMI Cable", "H100", 15.99, 3);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display Order 2 information
        Console.WriteLine("ORDER 2:");
        Console.WriteLine("--------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotal Cost: ${order2.CalculateTotal():F2}");
        Console.WriteLine("\n==========================================\n");
    }
}