using System;
using System.Collections.Generic;

public class Journal 

{   
    public List<Entry> _entriesList;

    public Journal()
    {   
        _entriesList = new List<Entry>();
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entriesList)
        {   
            Console.WriteLine("=======================================================");
            Console.WriteLine($"{entry._getDate}");
            Console.WriteLine($"{entry._prompts}");
            Console.WriteLine($"---> {entry._entry}");
            Console.WriteLine("=======================================================");
        }
    }
}