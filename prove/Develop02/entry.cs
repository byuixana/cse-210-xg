
public class Entry
{
    public string _date;
    public string _prompt;
    public string _journalEntry;

    public Entry(string prompt, string entry) 
    {
        _prompt = prompt;
        _journalEntry = entry;
        _date = DateTime.Now.ToString("M/d/yyyy");
    }
    public string entryFormat()
    {
        string entry= $"{_date} \n {_prompt} \n {_journalEntry}";
        return entry;

    }

    public void DisplayEntry()
    {
        Console.WriteLine(entryFormat());
    }


}