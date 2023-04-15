using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        List<int> list;
        list = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        do 
        {
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            list.Add(num);
        } while (number != 0);
    }
}