public class Activity
{
    protected string _date;
    protected string _actvityName;
    protected int _minutes;
    protected double _distance;
    protected double _speed;
    protected double _pace;

    public Activity(string actvityName, string date, int minutes)
    {
        _actvityName = actvityName;
        _date = date;
        _minutes = minutes;
    }

    public virtual void GetSummary()
    {
        string summary = $"{_date} {_actvityName} ({_minutes} min) Distance {_distance} miles, Speed {_speed} mph, Pace: {_pace} minutes per mile";
        Console.WriteLine(summary);
    }

    public virtual double CalculateDistance()
    {
        return _distance;
    }

    public virtual double CalculateSpeed()
    {
        return _speed;
    }

    public virtual double CalculatePace()
    {
        return _pace;
    }

        public void SetDistance(double distance)
    {
        _distance = distance;
    }

    public void SetSpeed(double speed)
    {
        _speed = speed;
    }

    public void SetPace(double pace)
    {
        _pace = pace;
    }
}