public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _address;
    protected string _eventType = "";

    public Event(string title, string description, string date, string address, string eventType) 
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
        _eventType = eventType;
    }


    public virtual string GenerateStandardMessage()
    {
        string standardMessage = $"{_title}, {_description}, {_date}, {_address}";
        return standardMessage;
    }

    public virtual string GenerateFullMessage()
    {
        string fullMessage = "";
        return fullMessage;
    }

    public virtual string GenerateShortMessage()
    {
        string shortMessage = "";
        return shortMessage;
    }
}