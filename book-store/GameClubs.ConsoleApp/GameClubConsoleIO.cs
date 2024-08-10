using static System.Console;

namespace GameClubs.ConsoleApp;

public class GameClubConsoleIO : IGameClubIO
{
    public void Write(string message, bool withNewLine = true)
    {
        if (withNewLine) WriteLine(message);
        else Write(message);
    }

    public void Clear()
    {
        Console.Clear();
    }

    public string? ReadLine()
    {
        return Console.ReadLine();
    }
}