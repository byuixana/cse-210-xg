using System.Diagnostics.Contracts;

public class Job{
    public string _companyName;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    

    public Job(string companyName, string jobTitle, int startYear, int endYear) 
    {
    _companyName = companyName;
    _jobTitle = jobTitle;
    _startYear = startYear;
    _endYear = endYear;
    }


    public void ShowDetails()
    {
        Console.WriteLine($"{_companyName} {_jobTitle} {_startYear} {_endYear}.");
        
    }
}


