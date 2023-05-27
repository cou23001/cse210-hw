using System;

public class ReflectingActivity : Activity {

    private HashSet<int> _usedIndices = new HashSet<int>();

    private List<string> _questions = new List<string>(){
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    private List<string> _prompts = new List<string>() {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    
    public ReflectingActivity() {
        SetActivityName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        SetDuration(30);
    }

    public void GetReflecting() {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowingCountdownTimer();
        Console.WriteLine();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
        while (DateTime.Now < endTime) {
            Random r = new Random();
            int nonRepeatingIndex = GetNonRepeatingIndex(CountQuestions(), r);
            if (nonRepeatingIndex != -1) {
                Console.Write($"> {GetQuestions(nonRepeatingIndex)} ");
                ShowingSpinner("", 5);
                Console.WriteLine();
            }
            else {
                Console.WriteLine($"> Sorry! No more questions available");
                ShowingSpinner("", 5);
                break;
            }
        }
            
    }

    public string GetRandomPrompt() {
        Random random = new Random();
        int randomIndex = random.Next(CountPrompts());
        return _prompts[randomIndex];
    }

    public string GetQuestions(int i) {
        return _questions[i];
    }

    public int CountQuestions() {
        return _questions.Count;
    }

    public int CountPrompts() {
        return _prompts.Count;
    }

    public int GetRandomQuestionNumber() {
        Random random = new Random();
        int randomIndex = random.Next(CountQuestions());
        return randomIndex;
    }

    public int GetNonRepeatingIndex(int count, Random random)
    {
        int index;
        do
        {
            index = random.Next(count);
            if (_usedIndices.Count == CountQuestions())
                return -1;
        } while (_usedIndices.Contains(index));
        
        _usedIndices.Add(index);
        return index;
    }
}