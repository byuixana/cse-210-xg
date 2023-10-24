public class Loanable{
    protected bool _isCheckedIn = true;
    protected string _title;

    public Loanable(string title)
    {
        _title = title;
    }
    public void Checkout()
    {
        _isCheckedIn = false;
    }

    public void CheckIn()
    {
        _isCheckedIn = true;
    }
    public virtual void Display()
    {
        Console.WriteLine($"Title: {_title}");
        base.Display();
    }
}