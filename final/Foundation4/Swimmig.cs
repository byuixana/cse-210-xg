public class Swimming : Activity
{
    private int _laps;
    private double _distance;
    private double _speed;
    private double _pace;
    public Swimming(string actvityName, string date, int minutes, int laps) : base(actvityName, date, minutes)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        _distance = _laps * 50.00 / 1000.00 * 0.62;
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