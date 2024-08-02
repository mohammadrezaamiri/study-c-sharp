using Players.ConsoleApp;

var player = new Player(DateTime.Now.AddYears(-10));

player.TestProtectedInternal();
// player.TestPrivateProtected();