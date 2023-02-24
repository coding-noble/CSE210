using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac0 = new Fraction();
        Console.WriteLine(frac0.GetFractionString());
        Console.WriteLine(frac0.GetDecimalValue());

        Fraction frac1 = new Fraction(1);
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        Fraction frac2 = new Fraction(6);
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        Fraction frac3 = new Fraction(6, 7);
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        Fraction frac4 = new Fraction(11, 543);
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());
    }
}