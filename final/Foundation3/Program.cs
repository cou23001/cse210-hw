using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nEvent Planning");

        Address a1 = new Address("456 Imaginary Lane", "Dreamville", "IM", "USA", "54321");
        Lecture l1 = new Lecture("Introduction to Quantum Physics", "Exploring the mysterious world of quantum mechanics", "October 10, 2023", "14:00", a1, "Dr. Stephen Strange", 150);
        Console.WriteLine("\nStandard Details");
        Console.WriteLine(l1.GetStandardDetails());
        
        Console.WriteLine("\nShort Description");
        Console.WriteLine(l1.GetShortDescription());

        Console.WriteLine("\nFull Details");
        Console.WriteLine(l1.GetFullDetails());

        Address a2 = new Address("789 Fantasy Avenue", "Wonderland", "WL", "USA", "98765");
        Reception r1 = new Reception("Rocket Science in Everyday Life", "Understanding the impact of rocket science on society", "November 15, 2023", "17:30", a2, "alice@wonderland.com");
        Console.WriteLine("\nStandard Details");
        Console.WriteLine(r1.GetStandardDetails());
        
        Console.WriteLine("\nShort Description");
        Console.WriteLine(r1.GetShortDescription());

        Console.WriteLine("\nFull Details");
        Console.WriteLine(r1.GetFullDetails());

        Address a3 = new Address("987 Dream Street", "Dreamland", "DL", "USA", "54321");
        Outdoor o1 = new Outdoor("Gardening Workshop", "Learn the basics of gardening and plant care", "June 5, 2023", "10:00", a3, "Partly cloudy, with a temperature of 25°C and a gentle breeze");
        Console.WriteLine("\nStandard Details");
        Console.WriteLine(o1.GetStandardDetails());
        
        Console.WriteLine("\nShort Description");
        Console.WriteLine(o1.GetShortDescription());

        Console.WriteLine("\nFull Details");
        Console.WriteLine(o1.GetFullDetails());
    }
}