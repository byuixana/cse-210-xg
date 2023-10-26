// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Elevator elevator = new Elevator(true, 1, 1);
elevator.doorAction();
elevator.doorsClose();
elevator.callElevator();
Console.Write("Desired floor:");
string userFloorString = Console.ReadLine();
int userFloor = int.Parse(userFloorString);
elevator.moveFloor(userFloor);