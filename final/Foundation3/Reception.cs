public class Reception : Event{
        private string _email;
    public Reception(string email, string title, string description, string date, Address address, string eventType="Reception") : base(title, description, date, address, eventType)
    {
        _email = email;
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }


    public override void GenerateStandardMessage()
    {
        string standardMessage = $"{_title}, {_description}, {_date}, {_address.FormatAddress()}";
        Console.WriteLine(standardMessage);
    }

    public override void GenerateFullMessage()
    {
        string fullMessage = $"{_eventType} {_title}: {_description}, {_date}, {_email}";
        Console.WriteLine(fullMessage);
    }

    public override void GenerateShortMessage()
    {
        string shortMessage = $"{_title}: {_eventType}, {_date}";
        Console.WriteLine(shortMessage);
    }
}