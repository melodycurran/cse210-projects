using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string text = File.ReadAllText(@"./scriptures.json");
        Scriptures _scriptures = JsonSerializer.Deserialize<Scriptures>(text);

        Console.WriteLine($"{_scriptures._reference} {_scriptures._text} ");
        
    }
}