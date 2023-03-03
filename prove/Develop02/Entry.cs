using System;
using System.Collections.Generic;

public class Entry
{   
    PromptGenerators prompts = new PromptGenerators();

    public string _getPrompts = prompts.GeneratePrompt();
    DateTime _timeStamp = DateTime.Now;
    public string _getDate = _timeStamp.ToShortDateString();

    //Methods
    public void DisplayPrompt()
    {
        Console.WriteLine(_getPrompts);
    }

    public string AskEntry()
    {   
        string entry = Console.ReadLine();
        return entry;
    }

    // public static List<string> AddEntries()
    // {
    //     public List<string> _entriesList = new List<string>();

    //     _entriesList.Add(_getDate);
    //     _entriesList.Add(_getPrompts);
    //     _entriesList.Add(entry);
    // }
}