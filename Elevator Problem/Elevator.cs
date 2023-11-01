public class Elevator{
    protected bool _doorsOpen = true;
    protected int _floor;
    protected int _elevatorNumber;
    public Elevator(int floor, int elevatorNumber)
    {
        
        _floor = floor;
        _elevatorNumber = elevatorNumber;
    }

    public void doorAction()
    {
        if (_doorsOpen == true)
        {
            Console.WriteLine("Doors open.");
        } else{
            Console.WriteLine("Doors closed");
        }
    }

    public void doorsClose()
    {
        _doorsOpen = false;
        Console.WriteLine("Doors are closed.");
    }

    public void moveFloor(int userFloor)
    {
        _floor = userFloor;
        Console.WriteLine($"Reached {userFloor}.");
    }
    public void callElevator()
    {
        Console.WriteLine($"Calling Elevator {_elevatorNumber} to Floor {_floor}.");
    }
}