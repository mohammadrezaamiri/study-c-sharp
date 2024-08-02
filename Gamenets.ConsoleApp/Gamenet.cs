public class Gamenet
{
    private Game _game;
    
    public void PlayGame()
    {
        _game.Start();
    }

    public void BuyGame(Game game)
    {
        _game = game;
    }
}