using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        // Creating lists
        List<int> numbers = new List<int>();

        // Instructions:
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Asks users for a number.
        Console.Write("Enter a number:");
        string number_string = Console.ReadLine();
        int int_number = int.Parse(number_string);
        int sum = 0;
        while (int_number != 0)
            {
                // Adds numbers to list.
                numbers.Add(int_number);
                Console.Write("Enter a number:");
                number_string = Console.ReadLine();
                int_number = int.Parse(number_string);
                
                
            }
        foreach (int number in numbers)
                {
                    sum += number;      
                }
        Console.WriteLine(sum);
    }
}