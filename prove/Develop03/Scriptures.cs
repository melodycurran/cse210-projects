using System;
using System.Collections.Generic;

public class Scriptures
{
    public string _text;

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
        string[] getWords = _text.Split(' ');

        foreach (var word in getWords)
        {
            for (int i = 0; i < _text.Length; i++)
            {
                Random randomNumber = new Random();
                int rand = randomNumber(0,);

                var chosenWord = getWords[rand];
                foreach (char chars in chosenWord)
                {
                    for (int j = 0; j < chosenWord.Length; j++)
                    {
                        Console.Clear();
                        Console.WriteLine("_");
                    }
                }
            }
        }
    }
}