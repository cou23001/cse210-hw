using System;

public class Activity {
    private string _name;
    private string _description;
    private int _duration;

    
    public string GetActivityName() {
        return _name;
    }

    public void SetActivityName(string name) {
        _name = name;
    }

    public string GetDescription() {
        return _description;
    }

    public void SetDescription(string desc) {
        _description = desc;
    }

    public void SetDuration(int secs) {
        _duration = secs;
    }
    public int GetDuration() {
        return _duration;
    } 
    public int GetDurationMilli() {
        return _duration * 1000;
    }

    public void DisplayStartingMessage() {
        Console.WriteLine($"Welcome to the {GetActivityName()} Activity.");
        Console.WriteLine();
    }

    public void DisplayDescription() {
        Console.WriteLine($"{GetDescription()}");
        Console.WriteLine();
    }

    public void DisplayEndingMessage() {
        Console.WriteLine($"Well done!");
        ShowingSpinner("", 3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {GetActivityName()} Activity.");
        ShowingSpinner("", 3);
    }

    public void GetDurationSession() {
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.Clear();
    }

    public void ShowingSpinner(string msg = "", int secs = 3) {
        
        if (!string.IsNullOrEmpty(msg))
        {
            Console.WriteLine($"{msg}");
        }
        
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(secs);

        int i = 0;

        while (DateTime.Now < endTime) {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character

            i++;

            if (i >= animationStrings.Count) {
                i = 0;
            }
        }
    }

    public void ShowingCountdownTimer(int duration = 5) {
        for (int i = duration; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}