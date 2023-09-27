using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job("Janitor", 0, "Clean, stay up late, have patience, and sing with a broom as a microphone.");
        job1.ShowDetails();

        Resume resume1 = new Resume("John Doe", "Binary Cocoa", 7);
        resume1.DisplayData();
    }

}