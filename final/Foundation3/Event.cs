public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected Address _address;
    protected string _eventType = "";

    public Event(string title, string description, string date, Address address, string eventType) 
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
        _eventType = eventType;
    }


    public virtual void GenerateStandardMessage()
    {
        string standardMessage = $"{_title}, {_description}, {_date}, {_address}";
        Console.WriteLine(standardMessage);
    }

    public virtual void GenerateFullMessage()
    {
        string fullMessage = "";
        Console.WriteLine(fullMessage);
    }

    public virtual void GenerateShortMessage()
    {
        string shortMessage = "";
        Console.WriteLine(shortMessage);
    }
}