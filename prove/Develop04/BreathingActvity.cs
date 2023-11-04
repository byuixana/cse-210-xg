public class BreathingActivity : Activity{

    public BreathingActivity(string activityName, string activityDescription, int userTime) : base(activityName, activityDescription, userTime)
    {
        _userTime = userTime;
        _activityName = activityName;
        _activityDescription = activityDescription;
    }
    
    public void BreathInandOut()
    {
        DateTime startTime = DateTime.Now;
        DateTime activityTime = startTime.AddSeconds(_userTime);
       
        while (startTime < activityTime)
        {
            Console.WriteLine("Breath in...");
            for(int i = 1; i<=4; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }

            Console.WriteLine("Breath out...");
            for(int i = 1; i<=7; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
                startTime = DateTime.Now;
            }
        }

    }
}