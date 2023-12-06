public class Biking : Activity
{
    private double _laps;
    private double _distance;
    private double _speed;
    private double _pace;
    public Biking(string actvityName, string date, int minutes, double laps) : base(actvityName, date, minutes)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        _distance = _laps * 50 / 1000 * 0.62;
        return _distance; 
    }

    public override double CalculateSpeed()
    {
        _speed = (_distance / _minutes) * 60.00;
        return _speed;
    }

    public override double CalculatePace()
    {
        _pace = _minutes / _distance;
        return _pace;
    }
}