using static System.Console;

namespace GameClubs.ConsoleApp;

public class GameClub(params Game[] games)
{
    public void ComeIn(string player) => ChooseMenu(player);

    private void ChooseMenu(string player)
    {
        bool playAgain = true;
        while (playAgain)
        {
            ShowMenu(player);
            var choice = GetChoice();
            playAgain = DoOrder(player, choice, playAgain);   
        }
    }

    private bool DoOrder(string player, int choice, bool playAgain)
    {
        switch (choice)
        {
            case 1 :
            {
                ShowGames(player);
                var gameId = GetChoice();
                PlayGame(player, gameId);
            } break;
            case 2:
            {
                ShowGames(player);
                var gameId = GetChoice();
                ShowGameDescription(gameId);
            } break;
            case 3 : playAgain = false; break;
            default : WriteLine("Wrong Choice. Try again !");
                break;
        }

        return playAgain;
    }

    private void ShowGameDescription(int gameId)
        => WriteLine($"the {games[gameId-1].Name} description :" +
                             $" \n {games[gameId-1].Description} \n");

    private void PlayGame(string player, int gameId)
    {
        if (GameNotFound(gameId)) return;

        var game = games[gameId-1];

        WriteLine($"Welcome dear {player}. Enjoy the {game.Name}.");

        game.Play();
    }

    private void ShowGames(string player)
    {
        if (GamesAreEmpty()) return;

        string result = "Which Game you mean : \n";
        for (int i = 1; i <= games.Length; i++)
            result += $"[{i}]. {games[i-1].Name} \n";
        
        Write($"{result} \n dear {player} Choice : ");
    }

    private bool GamesAreEmpty()
    {
        if (games.Length != 0) return false;

        WriteLine("game club not have any game!");
        return true;
    }

    private bool GameNotFound(int gameId)
    {
        if (gameId >= 1 && gameId <= games.Length) return false;
        
        WriteLine("game not found");
        return true;
    }

    private static int GetChoice()
    {
        int choice = 0;
        bool isChoiceValid = false;
        while (isChoiceValid == false)
        {
            isChoiceValid = int.TryParse(ReadLine()!, out int userInput);
            choice = userInput;
        }
        Clear();
        return choice;
    }
    
    
    private void ShowMenu(string player)
    {
        Write(@$"
Welcome {player}. What can i do for you ?
[1]. Play game
[2]. Show game description
[3]. Exit

{player} choice : ");
    }

}