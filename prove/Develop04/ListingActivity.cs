using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{   
    public string _actName;
    public string _descName;

    public ListingActivity() : base()
    {
        _actName = "Listing Activity";
        _descName = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Prompts()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        List<string> promptList = new List<string>(
            new string [] {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            }
        );

        Random rand = new Random();
        int random = rand.Next(0, promptList.Count());

        Console.WriteLine();
        Console.WriteLine($"----- {promptList[random]} -----");
        Console.WriteLine();

        Console.WriteLine("You may begin in...");
        Console.WriteLine();
    }

    public void GetList()
    {   
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        List<string> responseList = new List<string>();

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            responseList.Add(response);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {responseList.Count()} items!");
    }
}