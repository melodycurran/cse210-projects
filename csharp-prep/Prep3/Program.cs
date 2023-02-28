using System;

class Program
{
    static void Main(string[] args)
    {   
        //Console.Write("What is the magic number? ");
        //string userMagicNumber = Console.ReadLine();
        Random randomNumber = new Random();
        int guessThisNumber = randomNumber.Next(1, 101);
        
        Console.WriteLine("The computer generated a randome number, try to guess it! ");

        int convertedUserGuess;

        do 
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();

            convertedUserGuess = int.Parse(userGuess);

            if (convertedUserGuess > guessThisNumber)
            {
                Console.WriteLine("Lower!");
            }
            else if (convertedUserGuess < guessThisNumber)
            {
                Console.WriteLine("Higher!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        } while (convertedUserGuess != guessThisNumber);
    }
}