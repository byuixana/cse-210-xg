using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        Swimming swimming = new Swimming("Swimming", "6/12", 12, 12);

        double swimmingDistance = swimming.CalculateDistance();
        swimming.SetDistance(swimmingDistance);

        double swimmingSpeed = swimming.CalculateSpeed();
        swimming.SetSpeed(swimmingSpeed);

        double swimmingPace = swimming.CalculatePace();
        swimming.SetPace(swimmingPace);

        swimming.GetSummary();

        Running running = new Running("Running", "6/12", 30.0, 3.0);
        double runningDistance = running.CalculateDistance();
        running.SetDistance(runningDistance);

        double runningSpeed = running.CalculateSpeed();
        running.SetSpeed(runningSpeed);

        double runningPace = running.CalculatePace();
        running.SetPace(runningPace);

        running.GetSummary();

        Biking biking = new Biking("Biking", "6/14", 30.0, 6.75);
        double bikingDistance = biking.CalculateDistance();
        biking.SetDistance(bikingDistance);

        double bikingSpeed = biking.CalculateSpeed();
        biking.SetSpeed(bikingSpeed);

        double bikingPace = biking.CalculatePace();
        biking.SetPace(bikingPace);

        biking.GetSummary();


    
    }
}