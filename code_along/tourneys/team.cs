public class Team
{

    private string _name;
    private List<Player> _roster = new List<Player>();
    private int _wins = 0;
    private int _losses = 0;

    public Team(string name)
    {
        _name = name;

    }
    public string GetTeamName()
        {
            return _name;
        }

    public void AddPlayer(Player p)
    {
        _roster.Add(p);
    }

    public void AddWin()
    {
        _wins += 1;
    }

    public void AddLosses()
    {
        _losses += 1;
    }

   
    public void DisplayRoster()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_wins}");
        Console.WriteLine($"{_losses}");
        Console.WriteLine("------------");
        foreach (Player p in _roster) 
        {
           p.Display();
        }
        Console.WriteLine();

     
    }
   
}