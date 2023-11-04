public class ListingActivity : Activity{
    private List<string> _promptsList = new List<string>();
    private List<string> _answerList = new List<string>();
    public ListingActivity(string activityName, string activityDescription, int userTime) : base(activityName, activityDescription, userTime)
    {
        _userTime = userTime;
        _activityName = activityName;
        _activityDescription = activityDescription;
    }
    
     public void DisplayPrompt()
    {
        _promptsList.Add("Who are people that you appreciate?");
        _promptsList.Add("What are personal strengths of yours?");
        _promptsList.Add("Who are people that you have helped this week?");
        _promptsList.Add("When have you felt the Holy Ghost this month?");
        _promptsList.Add("Who are some of your personal heroes?");
        Random rnd = new Random();
        int randomIndex = rnd.Next(_promptsList.Count);
        string randomPrompt = _promptsList[randomIndex];
        Console.WriteLine(randomPrompt);
    }

    public void GratitudeList(){
        Activity dummyActivity = new Activity("Dummy activity", "This is a dummy activity", 0);
        DateTime startTime = DateTime.Now;
        DateTime activityTime = startTime.AddSeconds(_userTime);
       
        while(startTime < activityTime)
        {
            dummyActivity.Countdown();
            Console.Write(">");
            string response = Console.ReadLine();
            _answerList.Add(response);
            startTime = DateTime.Now;
        } 
        Console.WriteLine($"You listed {_answerList.Count} things.");
   
    }
}