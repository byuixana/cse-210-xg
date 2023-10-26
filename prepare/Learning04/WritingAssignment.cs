public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string title, string topic) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        string writingSummary = $"{_studentName} - {_title} \n{_topic}";
        return writingSummary;
    }
}