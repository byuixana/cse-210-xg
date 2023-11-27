public class Goal{
    protected string _goalDescription;
    protected string _goalName;
    protected int _points;
    protected bool _isDone;
    protected string _type;
    public Goal(string goalDescription, string goalName, int points, bool isDone, string type="S")
    {
        _goalDescription = goalDescription;
        _goalName = goalName;
        _points = points;
        _isDone = isDone;
        _type =type;
    }

        public virtual string formatGoals()
        {
            if (_isDone == false)
            {
                string goalFormat = $"[] {_goalName} ({_goalDescription}) Points: {_points}";
                return goalFormat;
            }
            else{
                string goalFormat = $"[X] {_goalName} ({_goalDescription}) Points: {_points}";
                return goalFormat;
            }
            
        }

        public virtual void UpdateStatus()
        {
            _isDone = true;
        }

        public virtual string FormatSave(){

                string goalFormat = $"{_isDone},{_goalName},{_goalDescription},{_points}, {_type}";
                return goalFormat;
        }

        public virtual void AddPoints(GoalList goalList)
        {
            int totalPoints = goalList.GetTotalPoints();
            totalPoints += _points;
            goalList.SetTotalPoints(totalPoints);
        }

         public int GetPoints()
        {
            return _points;
        }
        public void SetPoints(int points){
            _points = points;
        }

        public virtual bool GetGoalStatus()
        {
            return _isDone;
        }
        public virtual string GetGoalType()
        {
            return _type;
        }

        public string GetName()
        {
            return _goalName;
        }
    }

