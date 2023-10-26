public class VIP_Elevator : Elevator
{
    int _code;
    bool _codeCorrect = false;

    class VIP_Elevator(int code, bool codeCorrect)
    {
        _code = code;
        _codeCorrect = codeCorrect;

    }
    public void DisplayMessage(){
        if (_codeCorrect == true)
        {
            Console.WriteLine("Verified. Moving to ")
        }else{
            Console.WriteLine("Incorrect code.");
        }
    }
}