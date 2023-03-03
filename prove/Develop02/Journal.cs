using System;
using System.Collections.Generic;

public class Journal 
/// This class is for saving the journal entries with the prompts and the date.
{   
    List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>(_entriesList);
    }


    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
}