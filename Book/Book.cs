using System.Net;

public class Book{

    private string _author;
    private string _name;
    private int _timesRead;
    private bool _available;

    public Book(string author, string name)
    {
        _author = author;
        _name = name;
        _timesRead = 0;
        _available = true;
    }

    public void Display(string author, string name)
    {
       Console.WriteLine($"{_author} \n {_name} \n {_timesRead} \n {_available}");
        if (!_available)
        {
            Console.WriteLine("Checked out.");
        }
    }
    public bool HasAuthor(string author)
    {
        return _author.Contains(author);
    }

}