using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        int grade = int.Parse(Console.ReadLine());
        int remainder = grade % 10;
        string letter = "";
        string sign = "";
         
        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder < 3)
        {
            sign = "-";
        }

        if (grade >= 90)
        {
            if (remainder >= 7)
            {
                sign = "";
            }
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
            sign = "";
        }

        
        Console.WriteLine ($"Your grade is {letter}{sign}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Good luck for the next time");
        }
    }
}