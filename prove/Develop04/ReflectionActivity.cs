public class ReflectingActivity : Activity{
    private List<string> _promptsList = new List<string>();
    private List<string> _questionsList = new List<string>();
    private Activity _activitySpinner = new Activity("Dummy activity", "This is a dummy activity", 0);

    public ReflectingActivity(string activityName, string activityDescription, int userTime) : base(activityName, activityDescription, userTime)
    {
        _userTime = userTime;
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void DisplayPrompt()
    {
        _promptsList.Add("Think of a time when you stood up for someone else.");
        _promptsList.Add("Think of a time when you did something really difficult.");
        _promptsList.Add("Think of a time when you helped someone in need.");
        _promptsList.Add("Think of a time when you did something truly selfless.");
        Random rnd = new Random();
        int randomIndex = rnd.Next(_promptsList.Count);
        string randomPrompt = _promptsList[randomIndex];
        Console.WriteLine(randomPrompt);
    }

    public void DisplayQuestions(){

        DateTime startTime = DateTime.Now;
        DateTime activityTime = startTime.AddSeconds(_userTime);

        _questionsList.Add("Why was this experience meaningful to you?");
        _questionsList.Add("Have you ever done anything like this before?");
        _questionsList.Add("How did you get started?");
        _questionsList.Add("How did you feel when it was over");
        _questionsList.Add("What made this time different than other times when you were not as successful?");
        _questionsList.Add("What is your favorite thing about this experience?");
        _questionsList.Add("What could you learn from this experience that applies to other situations?");
        _questionsList.Add("What did you learn about yourself through this experience?");
        _questionsList.Add("How can you keep this experience in mind in the future?");
        
        
            foreach (string question in _questionsList)
            {
                Console.WriteLine(question);
                _activitySpinner.DisplayAnimation();
                startTime = DateTime.Now;
                if (startTime >= activityTime)
                {
                    _activitySpinner.DisplayEndMessage();
                    break;
                }
            }
}
}