using System.ComponentModel;

public class BookCase{

    private List<Book> _bookCase;
      
 
    public void AddBook(Book book)
    {
       _bookCase.Add(book);
    }
    public void ShowBooks()
    {
        foreach (Book book in _bookCase)
        {
            Console.WriteLine(book);
        }
    }

}