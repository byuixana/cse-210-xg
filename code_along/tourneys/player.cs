public class Player
{
    private string _playerName;
    private int _jerseyNumber;

    public Player(string name, int jersey)
    {
        _playerName = name;
        _jerseyNumber = jersey;
    }
    public void Display()
    {
        Console.WriteLine($"{_playerName} {_jerseyNumber}");
    }
}