using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        int total = 0;
        List<int> numbers;
        numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        do 
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }   
        } while (num != 0);

        foreach (int number in numbers)
        {
            total = total + number;
        }

        float average = ((float)total)/numbers.Count;
        Console.WriteLine($"The sum is:  {total}");
        Console.WriteLine($"The average is:  {average}");
        Console.WriteLine($"The largest number is:  {numbers.Max()}");
    }
}