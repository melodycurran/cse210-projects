using System;
using System.Collections.Generic;

public class Scriptures
{
    public string _text;
    public string _reference;

    public Scriptures()
    {
        _text = "";
        _reference = "";

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

    public string GetPassage()
    {
        return _reference;
    }

    public void SetPassage(string passage)
    {
        _reference = passage;
    }
}