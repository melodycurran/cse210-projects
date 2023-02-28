using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromtUserNumber();

        DisplayResult(userName, userNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {   
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }
    
    static int PromtUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string userNumber = Console.ReadLine();
        int convertedUserNumber = int.Parse(userNumber);

        return convertedUserNumber;
    }

    static void DisplayResult(string name, int number)
    {
        int squaredNumber = number * number;

        Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");
    }

}