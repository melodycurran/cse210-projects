using System;
using System.Collections.Generic;


public class ReflectionActivity : Activity
{
    public string _actName;
    public string _descName;

    public ReflectionActivity() : base()
    {
        _actName = "Reflection Activity";
        _descName = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."; 
    }

    public void Prompt()
    {
        Console.WriteLine("Consider the following prompt:");

        List<string> promptList = new List<string>(
            new string [] {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            }
        );

        Random rand = new Random();
        int random = rand.Next(0, promptList.Count());

        Console.WriteLine();
        Console.WriteLine($"---- {promptList[random]} -----");
        Console.WriteLine();
    }

    public void GetAnswer()
    {
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string userAnswer = Console.ReadLine();

        if (userAnswer == "")
        {
            Console.WriteLine("Now ponder each of these questions as they relate to your experience.");
            Console.WriteLine();
            Console.Write("You may begin in... ");
            Console.WriteLine();
        }
    }

    public void Questions()
    {
        List<string> questions = new List<string>(
            new string [] {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            }
        );

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            foreach (string question in questions)
            {
                if (DateTime.Now < end)
                {
                    Console.Write($"> {question} ");
                    Spinner(1000);
                    Console.WriteLine();
                }
                
            }
        }
    }
}