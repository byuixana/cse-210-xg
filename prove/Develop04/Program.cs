using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

// bool end = false;

// Console.WriteLine("---Menu---");
// Console.WriteLine("Choose an activity to calm your mind.")
// Console.WriteLine("1) Breathing");
// Console.WriteLine("2) Reflecting");
// Console.WriteLine("3) Listing");
// Console.WriteLine("4) End");
// Console.Write("Choose an activity:");
// string userActivity = Console.ReadLine();

// while (not end){
//     // If-else statements checking user choice. 
//     if (userActivity == "1"){
//         // Breathing activity
//     }
//     else if(userActivity == "2"){
//         // Reflecting actvity
//     }
//     else if(userActivity == "3") {
//         //Listing activity
//     }

    Activity activity = new Activity("Activity");
    activity.DisplayAnimation();
}


    
}

