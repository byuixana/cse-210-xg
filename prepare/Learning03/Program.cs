using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        // Top number.
        Console.Write("Type a number:");
        string string_top_number = Console.ReadLine();
        int top_number = int.Parse(string_top_number);

        // Bottom number.
        Console.Write("Type a number:");
        string string_bottom_number = Console.ReadLine();
        int bottom_number = int.Parse(string_bottom_number);

        // Create fractions. 
        Fraction fraction = new Fraction();
        
        Console.WriteLine(fraction.GetFractionString());
        // Whole number.
        Fraction fraction2 = new Fraction(top_number);
        Console.WriteLine(fraction2.GetFractionString());

        // Regular fraction.
        Fraction fraction3 = new Fraction(top_number, bottom_number);
        Console.WriteLine(fraction3.GetFractionString());
        
        // Convert fraction to decimals.
        
        Console.WriteLine(fraction3.GetDecimalValue(top_number, bottom_number));


    }
}