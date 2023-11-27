public class ChecklistGoal : Goal{
    private int _timesDone = 0;
    private int _userGoalTime;
    public ChecklistGoal(string goalDescription, string goalName, int points, bool isDone, int userGoalTime, string type="C") : base(goalDescription, goalName, points, isDone, type)
    {
        _goalDescription = goalDescription;
        _goalName = goalName;
        _points = points;
        _isDone = isDone;
        _userGoalTime = userGoalTime;
        _type = type;
    }

    public int AddVisits()
    {
        _timesDone++;
        return _timesDone;
    }

    public override bool GetGoalStatus()
    {
        // Will using the constructor versions of these cause problems later?
        if (_timesDone < _userGoalTime)
        {
            _isDone = true;
        }
        else
        {
            _isDone = false;
        }
        return _isDone;
    }

    public int GetTimesDone()
    {
        return _timesDone;
    }
    public override string formatGoals()
        {
            if (_isDone == true)
            {
                string goalFormat = $"[X] {_goalName} ({_goalDescription}) Points: {_points}, Goal Completed {_timesDone}/{_userGoalTime}";
                return goalFormat;
            }
            else{
                string goalFormat = $"[] {_goalName} ({_goalDescription}) Points: {_points} Goal Completed {_timesDone}/{_userGoalTime}";
                return goalFormat;
            }
            
        }
    public override string FormatSave()
    {
        string goalFormat = $"{_isDone},{_goalName},{_goalDescription},{_points},{_type},{_timesDone}";
        return goalFormat;
    }
    public override void AddPoints(GoalList goalList)
        {
            int totalPoints = goalList.GetTotalPoints();
            totalPoints += _points;
            goalList.SetTotalPoints(totalPoints);
        }

    public override void UpdateStatus()
        {
            if (_timesDone == _userGoalTime)
            {
                _isDone = true;
            }  
        }
        
    }