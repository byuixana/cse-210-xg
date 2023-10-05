using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job("Melalueca", "UX Designer", 2015, 2020);
        Job job2 = new Job("Binary Cocoa", "Programmer", 2020, 2023);

        // List<Job> jobs = new List<Job>();
        Resume resume1 = new Resume();
        resume1.SetAplicantsName("John Doe");
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        resume1.Display();
        


        // resume1.DisplayResume()
        
    }

}