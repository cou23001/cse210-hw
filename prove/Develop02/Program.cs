using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        Journal journal = new Journal();
        do
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = int.Parse(Console.ReadLine());
            switch (choice) {
                case 1:
                    Console.WriteLine("Write your journal entry: ");
                    Prompt prompt = new Prompt();
                    string result = prompt.GetRandomPrompt();
                    Console.WriteLine(result);
                    Console.Write("> ");
                    string message = Console.ReadLine();
                    Console.Write("Location: ");
                    string loc = Console.ReadLine();
                    Entry entry = new Entry(result,message,loc,DateTime.Now);
                    journal.WriteJournal(entry);
                    Console.WriteLine(entry.ToDisplay());
                    break;
                case 2:
                    Console.WriteLine(journal.DisplayJournal());
                    break;
                case 3:
                    Console.Write("What is the filename to load: ");
                    string filename = Console.ReadLine();
                    Console.WriteLine(journal.LoadJournal(filename));
                    break;
                case 4:
                    Console.Write("What is the filename to save: ");
                    filename = Console.ReadLine();
                    journal.SaveJournal(filename);
                    Console.WriteLine($"Saved {journal.Count()} entries.");
                    break;
                case 5:
                    Console.WriteLine("\nYou selected 'Quit'");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice");
                    break;
                }
        }
        while (choice != 5);
    }
}