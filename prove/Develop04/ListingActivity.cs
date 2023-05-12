using System;

public class ListingActivity : Activity {

    private List<string> prompts = new List<string>(){
        "When have you felt the Holy Ghost this month?",
        "What is your favorite thing about this experience?",
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    public ListingActivity() {
        SetActivityName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in certain area.");
        SetDuration(30);
    }

    public void GetListing()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowingCountdownTimer();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        int counter = 0;
        while (DateTime.Now < endTime) {
            Console.Write("> ");
            Console.ReadLine();
            counter++;
        }
        Console.WriteLine($"You listed {counter} items!");
        Console.WriteLine();
    }

    public string GetRandomPrompt() {
        Random random = new Random();
        int randomIndex = random.Next(CountPrompts());
        return prompts[randomIndex];
    }

     public int CountPrompts() {
        return prompts.Count;
    }
}