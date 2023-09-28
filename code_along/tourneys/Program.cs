// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Team injuredTeam = new Team("Injured FC");

Player ronaldo = new Player("Christiano Ronaldo", 7);

Player messi = new Player("Lionel Messi", 87);


injuredTeam.AddPlayer(ronaldo);
injuredTeam.AddPlayer(messi);
injuredTeam.DisplayRoster();

Team dropandrollers = new Team("Drop and Rollers");

Player potter = new Player("Harry Potter", 3);
Player malfoy = new Player("Draco Malfoy", 5);

dropandrollers.AddPlayer(potter);
dropandrollers.AddPlayer(malfoy);
dropandrollers.DisplayRoster();

Match match1 = new Match(injuredTeam, dropandrollers);
match1.DecideWin();

injuredTeam.DisplayRoster();
dropandrollers.DisplayRoster();
