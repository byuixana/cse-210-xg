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
        string letter = "A";
        if (grade_percent >= 90)
        {
            Console.WriteLine(letter);
        }
        else if (grade_percent >= 80)
        {
            letter = "B";
            Console.WriteLine(letter);
        }
        else if (grade_percent >= 70)
        {
            letter = "C";
            Console.WriteLine(letter);
        }
        else if (grade_percent >= 60)
        {
            letter = "D";
            Console.WriteLine(letter);
        }
        else if (grade_percent >= 50)
        {
            letter = "F";
            Console.WriteLine(letter);
        }
        if (grade_percent >= 70)
        {
            Console.WriteLine("You passed! Congrats!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}