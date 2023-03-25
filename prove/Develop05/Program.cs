using System;

class Program
{
    static void Main(string[] args)
    {
        int userOption = 0;
        Actions actions = new Actions();

        while (userOption != 6)
        {
            Console.WriteLine($"You have {actions._score} points");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            List<string> menuOptions = new List<string>(
                new string [] {
                    "1. Create New Goal",
                    "2. List Goals",
                    "3. Save Goals",
                    "4. Load Goals",
                    "5. Record Events",
                    "6. Quit"
                }
            );
            foreach (string menu in menuOptions)
            {
                Console.WriteLine(menu);
            }

            Console.Write("Select choice from the menu: ");
            userOption = int.Parse(Console.ReadLine());   

            if (userOption == 1)
            {
                actions.CreateNewGoals();
            }
            else if (userOption == 2)
            {
                actions.ListGoals();
            } 
            else if (userOption == 3)
            {
                actions.SaveGoals();
            }   
            else if (userOption == 4)
            {
                actions.LoadGoals();
            }
            else if (userOption == 5)
            {
                actions.RecordEvent();
            }
        }
    }
}