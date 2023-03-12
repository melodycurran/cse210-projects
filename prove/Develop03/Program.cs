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
        Console.WriteLine();
        Console.WriteLine("Please Enter to continue or type quit");
        
        do
        {
            userInput = Console.ReadLine();

            if (userInput == "")
            {
                scripturesText.Display();
            }
        } while (userInput != "quit" || scriptures._text == "");
    }
}