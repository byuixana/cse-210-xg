// Here is the base class

public class Activity{
    // protected DateTime _startTime = DateTime.Now;
    // protected string _startMessage;
    // protected string _endMessage;
    protected List<string> _animationStrings;
    protected int _userTime;
    protected bool _userTimeUp = false;
    protected List<string> _promptList;
    protected string _activityName;
    protected string _activityDescription;

    public Activity(string activityName, string activityDescription, int userTime)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _userTime = userTime;
    } 
public void DisplayAnimation(){
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        
        foreach (string s in animationStrings){
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayStartMessage()
    {
            Console.WriteLine($"Welcome to the {_activityName} activity.");
            Console.WriteLine(_activityDescription);
            Console.WriteLine("Get ready...");
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine($"You have completed this {_activityName}.");
        Console.WriteLine("Good job!");
    }

    public void Countdown(){
        for(int i = 1; i<=5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
    }

}