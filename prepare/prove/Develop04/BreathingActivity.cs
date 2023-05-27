using System;

public class BreathingActivity : Activity {

    public BreathingActivity() {
        SetActivityName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetDuration(30);
    }

    public void GetBreathing() {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        Console.WriteLine();
        Console.WriteLine();

        while (DateTime.Now < endTime) {
            Console.Write("Breathe in...");
            ShowingCountdownTimer();
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowingCountdownTimer();
            Console.WriteLine();
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}