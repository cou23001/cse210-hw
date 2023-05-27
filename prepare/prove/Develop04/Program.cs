using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("\nWelcome to the Mindfulness App!");
            Console.WriteLine("Menu options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Please select a choice from the menu: ");

            choice = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice) {
                case 1:
                    BreathingActivity ba = new BreathingActivity();
                    ba.DisplayStartingMessage();
                    ba.DisplayDescription();
                    ba.GetDurationSession();
                    ba.ShowingSpinner("Get ready...");
                    ba.GetBreathing();
                    ba.DisplayEndingMessage();
                    ba.ShowingSpinner();
                    break;
                case 2:
                    ReflectingActivity ra = new ReflectingActivity();
                    ra.DisplayStartingMessage();
                    ra.DisplayDescription();
                    ra.GetDurationSession();
                    ra.ShowingSpinner("Get ready...");
                    ra.GetReflecting();
                    ra.DisplayEndingMessage();
                    ra.ShowingSpinner();
                    break;
                case 3:
                    ListingActivity la = new ListingActivity();
                    la.DisplayStartingMessage();
                    la.DisplayDescription();
                    la.GetDurationSession();
                    la.ShowingSpinner("Get ready...");
                    la.GetListing();
                    la.DisplayEndingMessage();
                    la.ShowingSpinner();
                    break;
                case 4:
                    Console.WriteLine("\nYou selected 'Quit'");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice");
                    break;
                }
        }
        while (choice != 4);

    }
}