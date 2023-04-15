using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magic = int.Parse(Console.ReadLine());
        
        // Generate the random number
        Random randomGenerator = new Random();
        

        int guesses = 0;

        int guess;
        string repeat = "Y";
        
        do
        {
            int magic = randomGenerator.Next(1, 5);

            do 
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;
                
                if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic)
                {
                    Console.WriteLine("Lower");
                }
                else{
                    Console.WriteLine($"You guessed it! in {guesses} times");
                    Console.Write("Keep playing (Y/N)? ");
                    repeat = Console.ReadLine();
                    guesses = 0;
                }
            } while (guess != magic);
        } while (repeat != "N");
    }
}