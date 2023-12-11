public class Biking : Activity
{
    private double _miles;
    private double _distance;
    private double _speed;
    private double _pace;
    public Biking(string actvityName, string date, double minutes, double miles) : base(actvityName, date, minutes)
    {
        _miles = miles;
        _minutes = minutes;
    }

    public override double CalculateDistance()
    {
        _distance = _miles;
        return _distance; 
    }

    public override double CalculateSpeed()
    {
        _speed = (_distance / _minutes)* 60.00;
        return _speed;
    }

    public override double CalculatePace()
    {
        _pace = _minutes / _distance;
        return _pace;
    }
}