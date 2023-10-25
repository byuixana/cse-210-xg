class Elevator{
    protected bool _doorsOpen;
    protected int _floor;
    protected int _elevatorNumber;
    public Elevator(bool doorsOpen, int floor, int elevatorNumber)
    {
        _doorsOpen = doorsOpen;
        _floor = floor;
        _elevatorNumber = elevatorNumber;
    }

    public void doorsOpen()
    {
        _doorsOpen = true;
        Console.WriteLine("Doors are open.");
    }

    public void doorsClose()
    {
        _doorsOpen = false;
        Console.WriteLine("Doors are closed.");
    }

    public void moveFloor(int userFloor)
    {
        _floor = userFloor;
        Console.Writeline($"Reached {userFloor}.")
    }
    public void callElevator(int userElevatorNumber, int userFloor)
    {
        _elevatorNumber = userElevatorNumber;
        Console.WriteLine($"Calling {userElevatorNumber}.")
    }
}