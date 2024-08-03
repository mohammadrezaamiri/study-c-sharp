namespace GameClubs.ConsoleApp;

public abstract class Game
{
    public abstract string Name { get; }
    public virtual string Description => string.Empty;
    public abstract void Play();
}