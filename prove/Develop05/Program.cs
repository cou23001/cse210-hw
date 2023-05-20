// Week 05 Develop: Eternal Quest Program
// Cesar Coutino

// Exceeding Requirements
// The program can add negative goals
// If a negative goal is added. The programs deducts the total of points.
// It checks if it is a positive or negative goal to display the appropiate message.

using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        Objectives goals = new Objectives();

        do
        {
            //Console.Clear();
            Console.WriteLine($"\nYou have {goals.TotalPoints()} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            //Console.Clear();
            switch (choice) {
                case 1:
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.WriteLine("  4. Negative Goal");
                    Console.Write("What type of goal would you like to create? ");
                    int type_goal = int.Parse(Console.ReadLine());
                    Console.Write("What is the name of your goal? ");
                    string name_goal = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string desc_goal = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int amount_goal = int.Parse(Console.ReadLine());
                    
                    if (type_goal == 1) {
                        SimpleGoal sg = new SimpleGoal(name_goal, desc_goal, amount_goal);
                        goals.Add(sg);
                    } else if (type_goal == 2) {
                        EternalGoal eg = new EternalGoal(name_goal, desc_goal, amount_goal);
                        goals.Add(eg);
                    } else if (type_goal == 3) {
                        Console.Write("What is the amount of bonus points? ");
                        int bonus = int.Parse(Console.ReadLine());
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        int times = int.Parse(Console.ReadLine());
                        CheckListGoal cg = new CheckListGoal(name_goal, desc_goal, amount_goal, bonus, times);
                        goals.Add(cg);
                    } else if (type_goal == 4) {
                        NegativeGoal ng = new NegativeGoal(name_goal, desc_goal, -amount_goal);
                        goals.Add(ng);
                    } else {
                        Console.WriteLine ("Wrong type of goal!");
                        break;
                    }
                    break;
                case 2:
                    Console.WriteLine ("The goals are:");            
                    Console.WriteLine(goals.DisplayGoals());
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Name of the file: ");
                    string file = Console.ReadLine();
                    goals.SaveGoals(file);
                    break;
                case 4:
                    Console.Write("Name of the file: ");
                    string filecsv = Console.ReadLine();
                    Console.WriteLine(goals.LoadGoals(filecsv));
                    break;
                case 5:
                    Console.WriteLine("The goals are:");
                    Console.Write(goals.ShowGoals());
                    Console.Write("Which goal did you accomplish? ");
                    int goal = int.Parse(Console.ReadLine());
                    if (goals.NegativeGoalType(goal)){
                        Console.WriteLine($"You have lost {goals.RecordEvent(goal)} points!!");
                    } else
                        Console.WriteLine($"Congratulations you have earned {goals.RecordEvent(goal)} points!!");
                    Console.WriteLine($"You now have {goals.TotalPoints()} points");
                    break;
                case 6:
                    Console.WriteLine("\nYou selected 'Quit'");
                    break;
                default:
                    Console.WriteLine("\nInvalid choice");
                    break;
                }
        }
        while (choice != 6);
    }
}