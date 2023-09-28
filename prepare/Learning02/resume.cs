using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

public class Resume 
{
    public string _applicantName;
    
    public List<Job> _jobs = new List<Job>();
    
    public void Display()
    {
        Console.WriteLine($"Name:{_applicantName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.ShowDetails();
        }

    }

    
}