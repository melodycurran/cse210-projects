using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        Scriptures scripturesText = new Scriptures();
        string userInput = "";
        scripturesText.Display();
        Console.WriteLine();
        Console.WriteLine("Please Enter to continue or type quit");
        
        do
        {
            userInput = Console.ReadLine();

            if (userInput == "")
            {
                string[] getWords = _text.Split(' ');

                    Random randomNumber = new Random();
                    for (int i = randomNumber(0,ScripturesText._text.Length); i < ScripturesText._text.Length; i++)
                    {
                        var chosenWord = getWords[rand];
                        foreach (char chars in chosenWord)
                        {
                            for (int j = 0; j < chosenWord.Length; j++)
                            {
                                // Console.Clear();
                                // Console.WriteLine("_");
                                chosenWord[j] = "_";
                            }
                        }

                        Console.WriteLine(word);
                    }
            }
        } while (userInput != "quit" || scriptures._text == "");
    }
}