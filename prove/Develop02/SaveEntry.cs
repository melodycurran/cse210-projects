using System;
using System.Collections.Generic;

public class SaveJournalEntry 

{   
    public string _journalName;
    public List<Journal> _journalList;

    public SaveJournalEntry()
    {   
        _journalList = new List<Journal>();
    }

    public void GiveJournalTitle()
    {    
        Console.Write("What is the name of your file? ");
        _journalName = Console.ReadLine();
    }

    public void DisplayJounal()
    {
        foreach (Journal journalEntry in _journalList)
        {   
            for (int i = 0; i < journalEntry._entriesList.Count; i++)
            {
                Console.WriteLine(journalEntry._entriesList[i]._getDate);
                Console.WriteLine(journalEntry._entriesList[i]._prompts);
                Console.WriteLine(journalEntry._entriesList[i]._entry);
            }
        }
    }



}