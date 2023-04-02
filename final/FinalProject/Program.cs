using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        string divider = "===============================================================================";
        
        Console.WriteLine(divider);
        Console.WriteLine("---- Current interest rate is at 4% annually. No minimun deposit required! ----");
        Console.WriteLine(divider);

         while (userInput != 7)
        {  
            List<string> menuList = new List<string>(
                new string [] {
                    "1. Create Account",
                    "2. Log in",
                    "3. Deposit",
                    "4. Withdrawal",
                    "5. View Balance",
                    "6. View Transaction History"
                }
            );

            foreach (string menu in menuList)
            {
                Console.WriteLine(menu);
            }
            
            Console.Write("Enter the number of the corresponding choice: ");
            userInput = int.Parse(Console.ReadLine());   

            Console.WriteLine(divider);

            if (userInput == 1)
            {
                Profile person = new Profile();
                person.Questions();
                
                Console.WriteLine(divider);
            }
            else if (userInput == 3)
            {
                Deposit deposit =  new Deposit();
                deposit.ComputeBalance();
            }
        }
    }
}