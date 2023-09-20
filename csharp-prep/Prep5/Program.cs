using System;
 // Examples of C# functions:
        // returnType FunctionName(dataType parameter1, dataType parameter2)
            // {
            //     // function_body
            // }
            
        // int AddNumbers(int first, int second)
        // {
        //     int sum = first + second;
        //     return sum;
        // }
        // void DisplayPersonalMessage(string user_name):
        //     Console.WriteLine($"Hello {user_name}")
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static string Main();
            {
            }
                //Welcomes user with their name
                static void DisplayWelcome();
                    {
                        Console.WriteLine("Welcome to the program!");
                    }

                 // Asks for and converts username into a string
                static string PromptUserName();
                    {
                        Console.Write("Please enter your name:");
                        string user_name = Console.ReadLine();
                        return user_name;
                    }

                static int PromptUserNumber();
                    {
                        Console.Write("Please enter your number:");
                        string user_number_str = Console.ReadLine();
                        int user_number = int.Parse(user_number_string);
                        return user_number;
                    }
                    
                static int SquareNumber(int user_number);
                    {
                        int square_number = user_number**2;
                        return squared_number;
                    }
                static string DisplayResult(string user_name, int squared_number);
                    {
                        string result = Console.WriteLine($"{user_name}, the square of your favorite number is {squared_number}.")
                    }
        Main();

    }
}