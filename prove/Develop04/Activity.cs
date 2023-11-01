// Here is the base class

public class Activity{
    protected string _startMessage;
    protected string _endMessage;
    // protected List<string> _animationStrings;
    protected int _timer;
    protected bool _userTimeUp = false;
    protected List<string> _promptList;
    protected string _activityName;

    public Activity(string activityName)
    {
        _activityName = activityName;
    } 
public void DisplayAnimation(){
        List<string> _animationStrings = new List<string>();
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        _animationStrings.Add("|");
        _animationStrings.Add("/");
        _animationStrings.Add("-");
        _animationStrings.Add("\\");
        _animationStrings.Add("|");

        foreach (string s in _animationStrings){
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("Done. Good work.")
    }

    public void DisplayMessages(int timer, int userTime)
    {
        // True-false value declaring whether or not the time is up. How do I ensure the Start message displays first?
        // Should I make two separate functions?
        // if (not _userTimeUp) 
        // {
        //     Console.WriteLine($"Welcome to your {activity_name} session.");
        // }

    }

}