public class Running : Activity
{
    private double _miles;
    private double _distance;
    private double _speed;
    private double _pace;
    public Running(string actvityName, string date, double minutes, double miles) : base(actvityName, date, minutes)
    {
        _miles = miles;
    }

    public override double CalculateDistance()
    {
        _distance = _miles;
        return _distance;
    }

    public override double CalculateSpeed()
    {
        _speed = (_minutes / _distance);
        return _speed;
    }

    public override double CalculatePace()
    {
        _pace = _minutes / _distance;
        return _pace;
    }
}