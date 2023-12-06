public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string speaker, string title, string description, string date, Address address, int capacity, string eventType="Lecture") : base(title, description, date, address, eventType)
    {
        _speaker = speaker;
        _capacity = capacity;
        // _title = title;
        // _description = description;
        // _date = date;
        // _address = address;
        // _eventType = eventType;
    }


    public override void GenerateStandardMessage()
    {
        string standardMessage = $"{_title}, {_description}, {_date}, {_address.FormatAddress()}";
        Console.WriteLine(standardMessage);
    }

    public override void GenerateFullMessage()
    {
        string fullMessage = $"{_eventType} {_title}: {_speaker}, {_description}, {_date}, {_capacity}";
        Console.WriteLine(fullMessage);
    }

    public override void GenerateShortMessage()
    {
        string shortMessage = $"{_title}: {_eventType}, {_date}";
        Console.WriteLine(shortMessage);
    }
}