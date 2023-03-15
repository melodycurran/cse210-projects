using System;

class Program
{
    static void Main(string[] args)
    {
        // MathAssignment ass1 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment ass2 = new WritingAssignment();
        ass2.SetStudentName("Mary Waters");
        ass2.SetTopic("Europian History");
        ass2.SetTitle("The Causes of World War II");


        // ass1.GetSummary();
        // ass1.GetHomeWorkList();
        Console.WriteLine(ass2.GetSummary());
        Console.WriteLine(ass2.GetWritingInformation());
        
    }
}