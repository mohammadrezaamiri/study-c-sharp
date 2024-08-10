namespace GameClubs.ConsoleApp;

public interface IGameClubIO
{
    void Write(string message, bool withNewLine = true);
    void Clear();
    string? ReadLine();
    
}