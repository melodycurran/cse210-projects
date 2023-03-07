using System;
using System.Collections.Generic;

public class Entry
{   
    public PromptGenerators prompts = new PromptGenerators();
    public DateTime timeStamp = DateTime.Now;

    //Methods
    public string DisplayPrompt()
    {   
        string _getPrompts = prompts.GeneratePrompt();

        Console.WriteLine(_getPrompts);
        return _getPrompts;
    }

    public string GetDate()
    {
        string _getDate = timeStamp.ToShortDateString();
        return _getDate;

    }

    public string AskEntry()
    {   
        string _entry = Console.ReadLine();
        return _entry;
    } 
}