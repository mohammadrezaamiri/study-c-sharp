namespace Games.ConsoleApp;

public abstract class Game
{
    protected abstract string Name { get; set; }

    public void Start()
    {
        Console.WriteLine($"Game {Name} started");
        Play();
    }
    
    protected abstract void Play();
}