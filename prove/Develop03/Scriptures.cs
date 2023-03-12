using System;
using System.Collections.Generic;

public class Scriptures
{
    private string _text;

    public Scriptures()
    {   
        ScripturesList getList = new ScripturesList();
        _text = getList.GenerateScripture();
        
    }


/// Getters and Setters
    public string GetChaptersAndVerse()
    {
        return _text;
    }

    public void SetChapterAndVerse(string chapterAndVerse)
    {
        _text = chapterAndVerse;
    }


/// Method
    public void Display()
    {   
        Console.WriteLine(_text);
    }
}