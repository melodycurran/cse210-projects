using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   Journal journal = new Journal();
        int userOption = 0;
        List<string> optionsList = new List<string>(
            new string[] {
            "Please select one of the follorwing options",
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit",
            "What would you like to do? "
            }
        );
        while (userOption != 5)
        {
            foreach (string option in optionsList)
            {
                Console.WriteLine(option);
            }
        };
        userOption = int.Parse(Console.ReadLine());

    }
}