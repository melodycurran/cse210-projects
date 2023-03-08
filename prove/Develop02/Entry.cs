using System;
using System.Collections.Generic;

public class Entry
{   
    public string _prompts = "";
    public string _getDate = "";
    public string _entry = "";
    //Methods
    public void DisplayPrompt()
    {   
        PromptGenerators prompts = new PromptGenerators();
        _prompts = prompts.GeneratePrompt();
        Console.WriteLine(_prompts);
    }

    public void GetDate()
    {   
        DateTime timeStamp = DateTime.Now;
        _getDate = timeStamp.ToShortDateString();
    }

    public void AskEntry()
    {   
        _entry = Console.ReadLine();
    }
}