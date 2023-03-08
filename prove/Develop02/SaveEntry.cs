using System;
using System.Collections.Generic;

public class SaveJournalEntry 

{   
    public string _journalName = "";
    public List<Journal> _journalList;

    public SaveJournalEntry()
    {   
        _journalList = new List<Journal>();
    }

    public void SaveJournal()
    {    
        Console.Write("What is the name of your file? ");
        _journalName = Console.ReadLine();
    }



}