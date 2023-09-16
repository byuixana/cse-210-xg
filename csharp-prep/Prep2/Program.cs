using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage?");
        string grade = Console.ReadLine();
        int grade_percent = int.Parse(grade);
        string letter = "";
        // This if/else statement determines the letter grade from ther user percentage
        if (grade_percent >= 90)
        {
            letter = "A";
        }
        else if (grade_percent >= 80)
        {
           letter = "B";
        }
        else if (grade_percent >= 70)
        {
            letter = "C";
        }
        else if (grade_percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        // Instead of doing Console.WriteLine everywhere, you should have put it at the very bottom
    Console.WriteLine(letter);
        // Tells the user if they passed of failed
        if (grade_percent >= 70) {
            Console.WriteLine("Congrats! You passed!");
        }
        else 
        {
            Console.WriteLine("You did not pass. Try again!");
        }
      
    }
}