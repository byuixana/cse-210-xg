using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.DataAnnotations;

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
        
        int largest_num = 0;
  
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

                    if (number > largest_num)
                        largest_num = number;  
                }

        //Should have added a (float) by sum to get a decimal number instead of integers.
        int average = sum / numbers.Count();

        Console.WriteLine(sum);

        Console.WriteLine(average);

        Console.WriteLine(largest_num);

    }
}