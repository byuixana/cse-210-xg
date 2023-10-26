using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment = new Assignment("Alexandra", "Differential Equations");
        Console.WriteLine(assignment.GetSummary());
        WritingAssignment writingAssignment = new WritingAssignment("Alexandra", "European History", "The Causes of World War Two");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInfo());
        MathAssignment mathAssignment = new MathAssignment("Alexandra", "Fractions", "Section 7.3", "Problems 7-12");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }
}