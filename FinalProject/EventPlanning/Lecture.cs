public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker, string title, string description, string date, string address, string eventType="Lecture") : base(title, description, date, address, eventType)
    {
        _speaker = speaker;
        // _title = title;
        // _description = description;
        // _date = date;
        // _address = address;
        // _eventType = eventType;
    }


    public virtual string GenerateStandardMessage()
    {
        string standardMessage = $"{_title}, {_description}, {_date}, {_address}";
        return standardMessage;
    }

    public virtual string GenerateFullMessage()
    {
        string fullMessage = $"{_eventType} {_title}: {_speaker}, {_description}, {_date}, {_capacity}";
        return fullMessage;
    }

    public virtual string GenerateShortMessage()
    {
        string shortMessage = $"{_title}: {_eventType}, {_date}";
        return shortMessage;
    }
}