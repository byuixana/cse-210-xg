using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        bool end = false;

        while (end == false)
        {
            Console.WriteLine("---Menu---");
            Console.WriteLine("Choose an activity to calm your mind.");
            Console.WriteLine("1) Breathing");
            Console.WriteLine("2) Reflecting");
            Console.WriteLine("3) Listing");
            Console.WriteLine("4) End");
            Console.Write("Choose an activity:");
            string userActivity = Console.ReadLine();
            Console.Write("Activity time(seconds):");
            string userTimeString = Console.ReadLine();
            int userTime = int.Parse(userTimeString);
            if (userTime < 10)
            {
                Console.WriteLine("You may want more time than that. Enter a different number of seconds.");
                Console.Write("Activity time(seconds):");
                userTimeString = Console.ReadLine();
                userTime = int.Parse(userTimeString);
            }
            // If-else statements checking user choice. 
            if (userActivity == "1")
            {
                // Breathing activity
                BreathingActivity breathingActivity = new BreathingActivity("breathing activity", "This activity will help you relax by walking you through breathing", userTime);
                breathingActivity.DisplayAnimation();
                breathingActivity.DisplayStartMessage();
                breathingActivity.BreathInandOut();
                breathingActivity.DisplayEndMessage();
                
            }
            else if(userActivity == "2"){
                ReflectingActivity reflectionActivity = new ReflectingActivity("reflection activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", userTime);
                reflectionActivity.DisplayPrompt();
                reflectionActivity.DisplayQuestions();
            }

            else if(userActivity == "3") {
                ListingActivity listingActivity = new ListingActivity("listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", userTime);
                listingActivity.DisplayPrompt();
                listingActivity.GratitudeList();
                listingActivity.DisplayEndMessage();
            }
            else if (userActivity == "4") {
                end = true;
            }
        }

    }
}


