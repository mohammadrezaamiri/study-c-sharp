namespace Players.ConsoleApp;

public class TrainLinq
{
    public void Tain()
    {
        var players = new List<Player>();
        var player = new Player(DateTime.Now);
        players.Add(player);
        players.AddRange(new List<Player>{new Player(DateTime.Now)});
        var listCount = players.Count;
        players.Clear();
        bool isContain = players.Contains(player);
        bool isExist = players.Exists(_ => _.Name == "ali");
        players.Insert(3, player);
        players.Reverse();
        players.Remove(player);
        Player? aliPlayer = players.Find(_ => _.Name == "ali");
        var slicedList = players.Slice(1, 5);
        // list.RemoveAll();
        // list.RemoveRange();
        players.ForEach(player =>
        {
           Console.WriteLine(player.SayHello()); 
        });
        
        var firstPlayer = players.FirstOrDefault();
        var singlePlayer = players.SingleOrDefault(_ => _.Name == "ahmad");
        players.ToList();
        var oldToYoung =  players.OrderByDescending(_ => _.Age).ToList();
        var youngToOld = players.OrderBy(_ => _.Age).ToList();
        
        players.Where(_ => _.Name == "ali").ToList();
        var olderThan40 = players.Any(_ => _.Age > 40);
        var nameOfPlayers = players.Select(_ => _.Name).ToList();
        var allPlayersInterestedGame = players
            .Where(_ => _.Age > 15)
            .SelectMany(_ => _.InterestedGames.Select(game => game))
            .ToList();

        var oldestAliPlayer = players
            .Where(_ => _.Name == "ali")
            .Select(_ => new { _.Name, _.Age })
            .OrderByDescending(_ => _.Age)
            .FirstOrDefault();
        
        var playersWithInterestedGames = 
            players.Select(player => new PlayerWithInterestedGames
            {
                PlayerName = player.Name,
                InterestedGames = player.InterestedGames
            }).ToList();
    }
}

public class PlayerWithInterestedGames
{
    public string PlayerName { get; set; }
    public List<string> InterestedGames { get; set; }
}

public static class PlayerUtils
{
    public static string SayHello(this Player player)
    {
        return $"Hi every body i am {player.Name} with age {player.Age} and age is just a number";
    }
}