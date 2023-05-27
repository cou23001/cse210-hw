using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Bookstore");        
        Address a1 = new Address("456 Elm Street", "Booktown", "NY", "USA", "54321");
        Customer c1 = new Customer("Alice Johnson", a1);
        Order o1 = new Order(c1);

        o1.AddProduct(new Product("The Great Gatsby", "B001", 12.99, 1));
        o1.AddProduct(new Product("To Kill a Mockingbird", "B002", 19.99, 2));
        o1.AddProduct(new Product("Pride and Prejudice", "B003", 27.99, 3));
        o1.AddProduct(new Product("1984", "B004", 11.99, 1));

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"\nTotal cost order: ${o1.GetTotalCostOrder()}");

        Console.WriteLine("Online Electronics Store");
        Address a2 = new Address("789 Oak Avenue", "Techville", "CA", "USA", "98765");
        Customer c2 = new Customer("Bob Smith", a2);
        Order o2 = new Order(c2);

        o2.AddProduct(new Product("Smartphone", "E001", 599.99, 1));
        o2.AddProduct(new Product("Laptop", "E002", 999.99, 1));
        o2.AddProduct(new Product("Headphones", "E003", 149.99, 2));
        o2.AddProduct(new Product("Smartwatch", "E004", 199.99, 1));

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"\nTotal cost order: ${o2.GetTotalCostOrder()}");
    }
}