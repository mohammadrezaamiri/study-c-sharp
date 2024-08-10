using static System.Console;

namespace Players.ConsoleApp;

public class PlayerAbility<TPlayer>(TPlayer player) where TPlayer : Player
{
    public void Play() => WriteLine($"{player.Name} is playing");

    public void WatchOtherPlayers() => WriteLine($"{player.Name} is watching other players");

    public void EatSomeThing() => WriteLine($"{player.Name} is eat something");
}


public class Treatment<TAnimal> where TAnimal : Animal
{
    public void Treat(TAnimal animal)
    {
        WriteLine($"Your {animal.Name} now is ok");
    }
}

public abstract class Animal
{
    public abstract string Name { get; set; }
}

public class Cat : Animal
{
    public override string Name { get; set; } = "Maloos";
}
