public class Video{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments;
    private int _commentNumber = 0;
    public Video(string title, string author, int videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}, Created By: {_author}, Length: {_videoLength}, Number of Comments: {_commentNumber}");
    }

    public int CalculateNumOfComments()
    { 
        foreach (Comment comment in _comments)
        {   
            _commentNumber++;
        }
        return _commentNumber;
    }
}