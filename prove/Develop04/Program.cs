using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;

        while (userChoice != 4)
        {
            Console.WriteLine("Menu Options:");
            List<string> menuList = new List<string>(
                new string [] {
                    "1. Start breathing activity",
                    "2. Start reflecting activity",
                    "3. Start listing activity",
                    "4. Quit"
                    }
                );

                foreach (string menu in menuList)
                {
                    Console.WriteLine(menu);
                }
                
                Console.Write("Select a choice from the menu: ");
                userChoice = int.Parse(Console.ReadLine());
        
////////////////////////////////////////////// If user chose 1 /////////////////////////////////////////////////////

            if (userChoice == 1)
            {
                BreathingActivity act = new BreathingActivity();

                Console.WriteLine(act.WelcomMsg(act._actName));
                Console.WriteLine(act.Description(act._descName));

                act.GetReady();
                act.Spinner(500);

                int count = 0;
                act.Duration();

                if (act._duration < 15)
                {
                    count = act._duration / 2;
                }
                else if (act._duration < 45)
                {
                    count = act._duration / 4;
                }
                else if (act._duration < 70)
                {
                    count = act._duration / 10;
                }
                else
                {
                    count = act._duration / 15;
                }

                DateTime start = DateTime.Now;
                DateTime end = start.AddSeconds(act._duration);
                Console.WriteLine();

                while (DateTime.Now < end)
                {
                    act.BreatheIn();
                    act.CountDown(count);
                    Console.WriteLine();
                    act.BreatheOut();
                    act.CountDown(count);
                    Console.WriteLine();
                }
                act.EndingMsg(act._actName, act._duration);
            }

/////////////////////////////////////////////// If user chose 2 /////////////////////////////////////////////

            else if (userChoice == 2)
            {
                ReflectionActivity reflect = new ReflectionActivity();

                Console.WriteLine(reflect.WelcomMsg(reflect._actName));
                Console.WriteLine(reflect.Description(reflect._descName));

                reflect.Duration();

                reflect.GetReady();
                reflect.Spinner(500);

                reflect.Prompt();

                reflect.GetAnswer();
                Console.WriteLine();
                reflect.CountDown(5);
                reflect.Questions();
                reflect.EndingMsg(reflect._actName, reflect._duration); 
            }

/////////////////////////////////////////////// If user chose 3 /////////////////////////////////////////////

            else if (userChoice == 3)
            {
                ListingActivity list = new ListingActivity();
                Console.WriteLine();
                Console.WriteLine(list.WelcomMsg(list._actName));
                Console.WriteLine(list.Description(list._descName));
                Console.WriteLine();

                list.Duration();
                list.GetReady();
                list.Spinner(500);
                list.Prompts();
                list.CountDown(5);
                list.GetList();

                Console.WriteLine();
                list.EndingMsg(list._actName, list._duration);
                Console.WriteLine();
            }
        }
    }
}