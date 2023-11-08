public class SmartDevice{
    protected bool _deviceOn = false;
    protected DateTime _startTime;
    protected DateTime _totalTime;
    private string _name;
    public SmartDevice(bool deviceOn, string name)
    {
        _deviceOn = deviceOn;
        _name = name;
    }

    public void TurnOn()
    {
        _deviceOn = true;
        _startTime = DateTime.Now;
        Console.WriteLine(_deviceOn);
    }

    public void TurnOff()
    {
        _deviceOn = false;
        CheckTimeOn();
        Console.WriteLine(_deviceOn);
    }

    public void CheckTimeOn()
    {
        TimeSpan currentTime = _totalTime - _startTime;
        Console.WriteLine($"{_name} has been on since {currentTime}.");
    }   

}