using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Event Planning");

        Address a1 = new Address("2030 S Speedway","Tucson","AZ","USA","85700");
        Lecture l1 = new Lecture("Welcome","More details goes here","May 24, 2023","10:30",a1,"Peter Parker",2000);
        Console.WriteLine("\nStandard Details");
        Console.WriteLine(l1.GetStandardDetails());
        
        Console.WriteLine("\nShort Description");
        Console.WriteLine(l1.GetShortDescription());

        Console.WriteLine("\nFull Details");
        Console.WriteLine(l1.GetFullDetails());
    }
}