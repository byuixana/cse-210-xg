public class EternalGoal : Goal{

    // For the program's sake in the future, I may have to put this in Goal, so I can use to to check off goals in the future.
    private bool _goalContinues;

    public EternalGoal(string goalDescription, string goalName, int points, bool isDone=false, string type="E") : base(goalDescription, goalName, points, isDone, type)
    {
        _goalDescription = goalDescription;
        _goalName = goalName;
        _points = points;
        _isDone = isDone;
        _type = type;
    }

    public override string formatGoals()
        {
                string goalFormat = $"[E] {_goalName}, ({_goalDescription}), Points: {_points} ";
                return goalFormat;
        }

    public override void AddPoints(GoalList goalList)
        {
            int totalPoints = goalList.GetTotalPoints();
            totalPoints += _points;
        }

    }


    