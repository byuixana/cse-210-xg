using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.Write("What is the magic number?");
        string magic_number_str = Console.ReadLine();
        int magic_number = int.Parse(magic_number_str);
        Console.Write("What is your guess?");
        string guess_string = Console.ReadLine();
        int guess_number = int.Parse(guess_string);
        
        while (guess_number != magic_number)
            // An if statement that checks if the guess number is high or lower
            {
            if (guess_number < magic_number)
                Console.WriteLine("Higher!");
            if (guess_number > magic_number)
                Console.WriteLine("Lower!");
            Console.Write("What's your new guess?");
            guess_string = Console.ReadLine();
            guess_number = int.Parse(guess_string);
            }
        Console.WriteLine("You guessed correctly! Good work!");
    }
}