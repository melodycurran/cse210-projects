using System;
using System.Collections.Generic;

public class Activity
{
    public string _welcomeMsg;
    public string _description;
    public int _duration;

    public Activity()
    {   
        _welcomeMsg = "";
        _description = "";
        _duration = 0;
    }

    public string WelcomMsg(string activityName)
    {
        Console.WriteLine();
        string _welcomeMsg = $"Welcome to the {activityName}";
        return _welcomeMsg;
    }

    public string Description(string message)
    {   
        Console.WriteLine();
        string _description = $"This activity will help you {message}";
        return _description;
    }

    public int Duration()
    {   
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }

    public void GetReady()
    {
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        Console.WriteLine();
    }

    public void CountDown(int count)
    {
        List<int> countList = new List<int>();

        for (int i = count; i > 0; i--)
        {
            countList.Add(i);
        }
        foreach (int item in countList)
        {
            Console.Write(item);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Spinner(int seconds)
    {
        List<string> spinner = new List<string>(
            new string [] {
                "|",
                "/",
                "-",
                "\\",
                "|",
                "/",
                "-",
                "\\"
            }
        );

        foreach (string spin in spinner)
        {
            Console.Write(spin);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }
    }

    public void EndingMsg(string activityName, int duration)
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        Spinner(500);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {duration} seconds of {activityName}.");
        Console.WriteLine();
    }
}