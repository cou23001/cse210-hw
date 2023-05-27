using System;

class Program
{
    static void Main(string[] args)
    {
        RandomScripture v = new RandomScripture();
        Scripture scripture = v.GetRandomScripture();

        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }
        
        
        Console.Clear();
        Console.WriteLine(scripture.GetScripture());
        
        Console.WriteLine("\nHopefully you memorized the scripture!");
    }
}