public class Outdoor : Event{
        private string _weather;
    public Outdoor(string weather, string title, string description, string date, string address, string eventType="Reception") : base(title, description, date, address, eventType)
    {
        _weather = weather;
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }


    public override string GenerateStandardMessage()
    {
        string standardMessage = $"{_title}, {_description}, {_date}, {_address}";
        return standardMessage;
    }

    public override string GenerateFullMessage()
    {
        string fullMessage = $"{_eventType} {_title}: {_description}, {_date}, {_weather}";
        return fullMessage;
    }

    public override string GenerateShortMessage()
    {
        string shortMessage = $"{_title}: {_eventType}, {_date}";
        return shortMessage;
    }
}