using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercise Tracking\n");

        List<Activity> activities = new List<Activity>();

        Running r1 = new Running("23 May 2023",30,3);
        activities.Add(r1);

        Cycling c1 = new Cycling("13 Jan 2023",30,4);
        activities.Add(c1);

        Swimming s1 = new Swimming("10 Feb 2023",30,5);
        activities.Add(s1);

        foreach (Activity ac in activities) 
        {
            Console.WriteLine($"{ac.GetSummary()}");
        }
    }
}