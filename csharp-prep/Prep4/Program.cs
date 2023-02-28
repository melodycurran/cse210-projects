using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>();
        int numbers;
        int sum;

        do
        {
            Console.Write("Give me a number: ");
            string userInput = Console.ReadLine();
            numbers = int.Parse(userInput);

            userNumbers.Add(numbers);


        } while (numbers != 0);
        
        sum = userNumbers.AsQueryable().Sum();
        Console.WriteLine($"The sum is {sum}.");

        userNumbers.Sort();

        float count = userNumbers.Count-1;
        
        float ave = sum / count;
        Console.WriteLine($"The average is {ave}.");
        int max = userNumbers.Max();
        Console.WriteLine($"The max number is {max}.");

        
        Console.WriteLine($"The sorted list is:");
        foreach (int num in userNumbers)
        {
            Console.WriteLine($"{num}");
        }


    }
}