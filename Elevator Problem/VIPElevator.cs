public class VIPElevator : Elevator
{
    int _code;
    bool _codeCorrect = false;

    public VIPElevator(int code, bool codeCorrect, int floor, int elevatorNumber) : base(floor,elevatorNumber)
    {
        _code = code;
        _codeCorrect = codeCorrect;

    }
    public void DisplayMessage(){
        if (_codeCorrect == true)
        {
            Console.WriteLine("Verified. Moving to ");
        }else{
            Console.WriteLine("Incorrect code.");
        }
    }
}