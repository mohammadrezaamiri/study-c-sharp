using System.Reflection;
using System.Text;
using static System.Console;

namespace Players.ConsoleApp;

public class TrainGeneric
{
    public void TrainPrinter()
    {
        var player = new Player(DateTime.Now.AddYears(-10))
        {
            Name = "ali",
            PlayCount = 10,
            BestFavoriteGame = "Combat",
            InterestedGames = { "PES", "FIFA" }
        };
        var printer = new Printer<Player>(player);
        printer.PrintObjectInfo();
        
        var printer2 = new Printer<string>("ali");
        printer2.PrintObjectInfo();

        var printer3 = new Printer<int>(1403);
        printer3.PrintObjectInfo();

        var playerAbility = new PlayerAbility<Player>(player);
        playerAbility.WatchOtherPlayers();
        playerAbility.EatSomeThing();
        playerAbility.Play();
    }
}

public class Printer<T>(T obj)
{
    public void PrintObjectInfo()
    {
        var sb = new StringBuilder();

        var type = obj?.GetType();
        if (type is null) return;
        
        if(type.IsValueType || type == typeof(string))
        {
            WriteLine($"value : {obj} , type : {type}");
            return;
        }
        
        
        
        sb.Append("Type: " + type.Name);

        sb.Append("\n Fields:");
        var fi = type.GetFields();
        if (fi.Length > 0)
            foreach (var f in fi)
                sb.Append("\n " + f + " = " + f.GetValue(obj));
        else
            sb.Append("\n None");

        sb.Append("\n Properties:");
        var pi = type.GetProperties();
        if (pi.Length > 0)
            foreach (var p in pi)
            {
                if (p.CanRead)
                    sb.Append($"\n {p} = {p.GetValue(obj, null)}");
            }
        else
            sb.Append("\n None");

        WriteLine(sb.ToString());
    }
}