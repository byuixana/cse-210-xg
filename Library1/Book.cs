public class LibraryBook : Loanable
{
    private string _isbn;
    private int _upc;
    public LibraryBook(string isbn, int upc) : base(string title)
    {
        _isbn = isbn;
        _upc = upc;
    }

    public override void Display()
    {
        ShowBookDetails();
    }

    public void ShowBookDetails()
    {
        Console.WriteLine($"{_title}: {_isbn} :: {_upc} {_isCheckedIn}")
    }
}