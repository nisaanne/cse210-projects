using System;

public class Program
{
    public static void Main(string[] args)
    {
        Address address1 = new Address("123 Bravo Way", "Sacramento", "CA", "USA");
        Address address2 = new Address("2395 Oak Drive", "Colorado Springs", "CO", "USA");

        Customer customer1 = new Customer("Mary Smith", address1);
        Customer customer2 = new Customer("Joe McDonald", address2);

        Product product1 = new Product("Skylight", "S123", 10.0, 2);
        Product product2 = new Product("Puzzle", "P123", 10.0, 2);
        Product product3 = new Product("Binoculars", "B123", 10.0, 2);
        
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");


    }
}