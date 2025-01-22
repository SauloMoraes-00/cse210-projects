using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // Test the default constructor (1/1)
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1 (default): {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");

        // Test the constructor with one parameter (5/1)
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction 2 (one parameter): {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");

        // Test the constructor with two parameters (3/4)
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction 3 (two parameters): {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        // Test the constructor with two parameters (1/3)
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction 4 (two parameters): {fraction4.GetFractionString()} = {fraction4.GetDecimalValue()}");
    }
}
