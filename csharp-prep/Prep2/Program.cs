using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user about the grade
        Console.Write("What is you grade percentage? ");
        string grade = Console.ReadLine();

        bool isPass;
        string message;

        // Convert the user input
        int convertedGrade = int.Parse(grade);

        // Conditional statements to get the letter grade
        if (convertedGrade >= 90)
        {
            Console.WriteLine("A. ");
            isPass = true;
        }
        else if (convertedGrade >= 80)
        {
            Console.WriteLine("B. ");
            isPass = true;
        }
        else if (convertedGrade >= 70)
        {
            Console.WriteLine("C. ");
            isPass = true;
        }
        else if (convertedGrade >= 60)
        {
            Console.WriteLine("D. ");
            isPass = false;
        }
        else
        {
            Console.WriteLine("F. ");
            isPass = false;
        }

        // Conditions to figure if student passed or not
        if (isPass == true)
        {
            message = "Congratulations, you passed this semester!";
        }
        else
        {
            message = "Failed. Sorry, you need to retake this course.";
        }

    // Print message
        Console.WriteLine(message);
    }
}