using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(); // Default constructor (1/1)
        Fraction fraction2 = new Fraction(5); // Constructor with numerator only (5/1)
        Fraction fraction3 = new Fraction(3, 4); // Constructor with numerator and denominator (3/4)

        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        fraction3.SetNumerator(1);
        fraction3.SetDenominator(3);
        Console.WriteLine($"Updated Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

    }
}