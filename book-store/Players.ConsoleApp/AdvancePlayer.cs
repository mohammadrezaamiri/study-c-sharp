using static System.Console;

namespace Players.ConsoleApp;

public class AdvancePlayer : Player
{
    public AdvancePlayer(DateTime dateTime) : base(dateTime)
    {
        base.TestPrivateProtected();
        
        base.TestProtectedInternal();
    }
}