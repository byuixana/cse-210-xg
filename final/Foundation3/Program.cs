using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        // See https://aka.ms/new-console-template for more information

        Address address = new Address("4615 East 100 North", "Rigby", "Idaho");
        Reception recpetion = new Reception("event@gmail.com", "Smith Reception", "The wedding reception of Heather Anderson and Conner Smith", "12/5/23", address);
        recpetion.GenerateStandardMessage();
        recpetion.GenerateShortMessage();
        recpetion.GenerateFullMessage();

        Outdoor outdoor = new Outdoor("Sunny", "Ririe Carnival", "Raise money for Ririe school districts by playing games", "6/5/24", address);
        outdoor.GenerateStandardMessage();
        outdoor.GenerateFullMessage();
        outdoor.GenerateShortMessage();

        Lecture lecture = new Lecture("Carl Watkins", "Studying the Atom In-Depth", "Talk about atoms", "7/1/24", address, 15);
        lecture.GenerateStandardMessage();
        lecture.GenerateFullMessage();
        lecture.GenerateShortMessage();
    }
}