using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction sample1 = new Fraction();
        sample1.GetFractionString();
        sample1.GetDecimalValue();

        Fraction sample2 = new Fraction(5);
        sample2.GetFractionString();
        sample2.GetDecimalValue();

        Fraction sample3 = new Fraction(3,4);
        sample3.GetFractionString();
        sample3.GetDecimalValue();

    }
}