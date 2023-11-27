public class FileHandler{

    public void CreateFile(string file, GoalList goalList)
        {
            List<Goal> goals = goalList.GetList();
            Console.WriteLine("Saving to file...");
            using (StreamWriter outputFile = new StreamWriter(file))
            {  
                // You can add text to the file with the WriteLine method
                foreach (Goal goal in goals)
                {
                    outputFile.WriteLine(goal.FormatSave());
                }
            }
        }

    public List<Goal> LoadFile(string _filename, GoalList goalList)
        {
            Console.WriteLine(_filename);
            List<Goal> newGoalList = goalList.GetList();
            
            string[] lines = System.IO.File.ReadAllLines(_filename);

            foreach (string line in lines)
                {
                    string [] line_array = line.Split(",");
                    bool isDone = bool.Parse(line_array[0]);
                    string goalName = line_array[1];
                    string goalDescription = line_array[2];
                    int points = int.Parse(line_array[3]);
                    string type = line_array[4];
                    if (type == "S")
                    {
                        Goal goal = new Goal(goalDescription, goalName, points, isDone, type);
                        newGoalList.Add(goal);
                        Console.WriteLine("Added");
                    }
                    else if (type == "E")
                    {
                        EternalGoal eternalGoal = new EternalGoal(goalDescription, goalName, points, isDone, type);
                        newGoalList.Add(eternalGoal);
                        Console.WriteLine("Added");
                    }
                    else if (type == "C")
                    {
                        string timesDone = line_array[5];
                        int integerTimesDone = int.Parse(timesDone);
                        string timesToDo = line_array[6];
                        int integerTimesToDo = int.Parse(timesToDo);
                        ChecklistGoal checklistGoal = new ChecklistGoal(goalDescription, goalName, points, isDone, integerTimesDone, integerTimesToDo, type);
                        newGoalList.Add(checklistGoal);
                        
                        
                        Console.WriteLine("Added");
                    }
                    
                }
            return newGoalList;
        }
}