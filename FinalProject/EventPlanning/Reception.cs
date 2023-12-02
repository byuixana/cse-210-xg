public class Reception : Event{
        private string _email;
    public Reception(string email, string title, string description, string date, string address, string eventType="Reception") : base(title, description, date, address, eventType)
    {
        _email = email;
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
        string fullMessage = $"{_eventType} {_title}: {_description}, {_date}, {_email}";
        return fullMessage;
    }

    public override string GenerateShortMessage()
    {
        string shortMessage = $"{_title}: {_eventType}, {_date}";
        return shortMessage;
    }
}