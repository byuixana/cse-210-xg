
public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _journalEntry = "";
    

    public string _name = "";

    public Entry(string prompt, string entry, string user_name) 
    {
        _prompt = prompt;
        _journalEntry = entry;
        _name = user_name;
        _date = DateTime.Now.ToString("M/d/yyyy");
    }
    public string entryFormat()
    {
        string entry= $"{_date} \n {_prompt} \n {_journalEntry} \n Signed {_name}";
        return entry;

    }

    public void DisplayEntry()
    {
        Console.WriteLine("|||");
        Console.WriteLine(entryFormat());
    }


}