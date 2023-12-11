public class GoalList{
   protected List<Goal> _goalList = new List<Goal>();
   protected int _totalPoints = 0;
    public List<Goal> GetList()
    {
        return _goalList;
    } 

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public void SetList(List<Goal> goalList){
        _goalList = goalList;
    }
    public List<Goal> AddtoList(Goal goal)
    {
        _goalList.Add(goal);
        return _goalList;
    }

    public void DisplayTotalPoints()
    {
        
        Console.WriteLine(_totalPoints);
    }

    // public void AddTotalPoints()
    // {
    //     foreach(Goal goal in _goalList)
    //     {
    //         string type = goal.GetGoalType();
    //         if (goal.GetGoalStatus() == true)
    //         {
    //             _totalPoints += goal.GetPoints();
    //         }
    //         else if (type == "C")
    //         {
    //             int timesDone = eternalGoal.GetTimesDone();
    //             _totalPoints += (goal.GetPoints() * timesDone); 
    //         }
    //     }
    // }


    public void DisplayGoals()
    {
        foreach(Goal goal in _goalList)
        {
            Console.WriteLine(goal.formatGoals());
            // Adds up points at the end of the DisplayGoals.
        }
        
    }


}