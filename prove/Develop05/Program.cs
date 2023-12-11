using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        // Boolean to end program.
        bool end = false;

        // Filehandler
        FileHandler fileHandler = new FileHandler();
        // Creates temporary goal list for session.
        GoalList goalList = new GoalList();
        List<Goal> realList = goalList.GetList();

        // While loop for menu
        while (!end)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. End");

            // User input.
            Console.Write("Select a choice from the menu:");
            string userInput = Console.ReadLine();
            
            

            if (userInput == "1")
            {
                Console.Write("What type of goal would you like to make?");
                string goalType = Console.ReadLine();

                // if-else checking what kind of goal a user wants to make.
                // Goal questions eventually, but for now a dummy goal.
                if (goalType == "1")
                {
                    Goal goal = new Goal("Attend the temple", "Attend the temple this week", 3, false);
                    goalList.AddtoList(goal);
                }
                else if (goalType == "2")
                {
                    EternalGoal eternalGoal = new EternalGoal("Study scriptures", "Study for ten minutes each day", 10, false);
                    goalList.AddtoList(eternalGoal);
                }
                else if (goalType == "3")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal("Journal for ten minutes after scripture study", "Study for ten minutes each day", 10, false, 10,  5);
                    goalList.AddtoList(checklistGoal);
                }

            }
            else if(userInput == "2")
            {
                goalList.DisplayGoals();
                foreach (Goal goal in goalList.GetList())
                {
                    goal.AddPoints(goalList);
                }
                goalList.DisplayTotalPoints();
            }
            else if(userInput == "3")
            {
                // This will take all the user's previous goals and write them from the document back into the goalList object.
                Console.Write("Filename:");
                string fileName = Console.ReadLine();
               
                fileHandler.CreateFile(fileName, goalList);
            }
            else if(userInput == "4")
            {
                // This will take all the user's previous goals and write them from the document back into the goalList object.
                Console.Write("Filename:");
                string fileName = Console.ReadLine();
                realList = fileHandler.LoadFile(fileName, goalList);
                foreach (Goal goal in realList)
                {
                    Console.WriteLine(goal.GetName());
                }
            }
            else if(userInput == "5")
            { 
                int goalNumber = 1;
                foreach (Goal goal in goalList.GetList())
                {
                    Console.WriteLine($"{goalNumber}) {goal.GetName()}");
                    goalNumber++;
                }
                Console.Write("Select a goal to enter:");
                string user_goal_number = Console.ReadLine();
                int user_number = int.Parse(user_goal_number) - 1;
                List<Goal> realGoalList = new List<Goal>();
                realGoalList = goalList.GetList();
                Goal selectedGoal = realGoalList[user_number];
                if (selectedGoal.GetGoalType() == "E")
                {
                    selectedGoal.AddPoints(goalList);
                }
                else if (selectedGoal.GetGoalType() == "C")
                {
                    selectedGoal.AddPoints(goalList);
                    selectedGoal.UpdateStatus();
                }
                else if (selectedGoal.GetGoalType() == "S")
                {
                    selectedGoal.AddPoints(goalList);
                    selectedGoal.UpdateStatus();
                }
                int goalPoints = selectedGoal.GetPoints();
                Console.WriteLine($"Congrats! You have earned {goalPoints} points!");
                goalList.DisplayTotalPoints();
            }
            else if (userInput == "6")
            {
                end = true;
            }

            
        }
        Console.WriteLine("The Lord loves effort. Good work!");

        // Place Menu here in while loop and a points variable to display at the start of each round.

    }
    
}