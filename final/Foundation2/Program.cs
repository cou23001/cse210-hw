using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering");
        Address a1 = new Address("3484 N Paseo de San Agustin","Tucson","AZ","MX","85712");
        Customer c1 = new Customer("Peter Parker",a1);
        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Hat","H001",23.49,1));
        o1.AddProduct(new Product("Shirt","H002",33.25,1));
        o1.AddProduct(new Product("T-Shirt","H003",13.99,1));
        o1.AddProduct(new Product("Backpack","H004",33.99,1));
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"\nTotal cost order: ${o1.GetTotalCostOrder()}");

        Address a2 = new Address("2030 S Speedway","Tucson","AZ","USA","85700");
        Customer c2 = new Customer("Tom Smith",a2);
        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Pop corn","G001",3.49,3));
        o2.AddProduct(new Product("Soda","G002",4.99,2));
        o2.AddProduct(new Product("Hot dog","G003",3.99,2));
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"\nTotal cost order: ${o2.GetTotalCostOrder()}");
    }
}