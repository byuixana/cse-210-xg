public class Video{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments;
    private int _commentNumber;
    public Video(string title, string author, int videoLength, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
        _comments = comments;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public void SetComments(List<Comment> comments)
    {
        _comments = comments;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}, Created By: {_author}, Length: {_videoLength} seconds, Number of Comments: {_commentNumber}");
    }

    public void UpdateCommentNumber()
    {
        _commentNumber++;
    }

    // public int CalculateNumOfComments()
    // { 
    //     foreach (Comment comment in _comments)
    //     {   
    //         _commentNumber++;
    //     }
    //     return _commentNumber;
    // }
}