using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Online Ordering System");
        Customer custoemr1 = new Customer("Ivan Suararez", new Address("Timoleague", "Cork", "Ireland"));
        Product product1 = new Product("Laptop", 021, 6, 600.50);
        Product product2 = new Product("Table", 502, 3, 200.20);
        Product product3 = new Product("UPS", 773, 1, 450.00);
        Product product4 = new Product("Headphones", 234, 4, 50.00);
        Product product5 = new Product("Keyboard", 115, 3, 20.00);

        Order order1 = new Order(new List<Product> { product1, product2, product3, product4, product5 }, new List<Customer> { custoemr1 });
        Console.WriteLine($"{order1.PackingLabel()}");
        Console.WriteLine("");
        Console.WriteLine($"{order1.ShippingLabel()}");
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Total Cost of Order:   {order1.TotalCostOrder()}");


        Customer custoemr2 = new Customer("Camila Bermudez", new Address("Fresno", "California", "USA"));
        Product product6 = new Product("Laptop", 021, 10, 600.50);
        Product product7 = new Product("Table", 502, 5, 200.20);
        Product product8 = new Product("UPS", 773, 2, 450.00);
        Product product9 = new Product("Headphones", 234, 10, 50.00);
        Product product10 = new Product("Keyboard", 115, 5, 20.00);
        Product product11 = new Product("Mouse", 206, 5, 11.50);

        Order order2 = new Order(new List<Product> { product6, product7, product8, product9, product10, product11 }, new List<Customer> { custoemr2 });

        Console.WriteLine($"{order2.PackingLabel()}");
        Console.WriteLine("");
        Console.WriteLine($"{order2.ShippingLabel()}");
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Total Cost of Order:   {order2.TotalCostOrder()}"); 
    }
}