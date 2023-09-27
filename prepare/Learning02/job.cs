public class Job{
    private string _jobTitle;
    private int _yearsExperience;
    private string _skillsNeeded;

    public Job(string jobTitle, int yearsExperience, string skills) 
    {
    _jobTitle = jobTitle;
    _yearsExperience = yearsExperience;
    _skillsNeeded = skills;
    }


    public void ShowDetails()
    {
        Console.WriteLine($"""Job: {_jobTitle} {_yearsExperience} {_yearsExperience}.""");

    }
}


