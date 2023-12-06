// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Swimming swimming = new Swimming("Swimming", "6/12", 30, 12);

double swimmingDistance = swimming.CalculateDistance();
swimming.SetDistance(swimmingDistance);

double swimmingSpeed = swimming.CalculateSpeed();
swimming.SetSpeed(swimmingSpeed);

double swimmingPace = swimming.CalculatePace();
swimming.SetPace(swimmingPace);

swimming.GetSummary();


