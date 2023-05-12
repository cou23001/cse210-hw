using System;

public class RandomQuestions
{
    private List<string> quest = new List<string>(){
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
    };
    public string GetQuestions(int i) {
        return quest[i];
    }

    public void ShowQuestions() {
        for (int i = 0; i < Count() ; i++)
        {
            Console.Write($"> {GetQuestions(i)} ");
            
            Console.WriteLine();
        }
    }
    public int Count() {
        return quest.Count;
    }
}