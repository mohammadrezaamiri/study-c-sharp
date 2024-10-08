﻿namespace GameClubs.ConsoleApp;

public class GameClub
{
    private readonly IGameClubIO _io;

    public GameClub(IGameClubIO io, params Game[] games)
    {
        _io = io;
        AddGames(games);
    }

    public void ComeIn(string player) => ChooseMenu(player);
    public void AddGames(params Game[] games) => _games.AddRange(games);
 
    private readonly List<Game> _games = new ();
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
            default : _io.Write("Wrong Choice. Try again !");
                break;
        }

        return playAgain;
    }

    private void ShowGameDescription(int gameId)
        => _io.Write($"the {_games[gameId-1].Name} description :" +
                             $" \n {_games[gameId-1].Description} \n");

    private void PlayGame(string player, int gameId)
    {
        if (GameNotFound(gameId)) return;

        var game = _games[gameId-1];

        _io.Write($"Welcome dear {player}. Enjoy the {game.Name}.");

        game.Play();
    }

    private void ShowGames(string player)
    {
        if (GamesAreEmpty()) return;

        string result = "Which Game you mean : \n";
        for (int i = 1; i <= _games.Count; i++)
            result += $"[{i}]. {_games[i-1].Name} \n";
        
        _io.Write($"{result} \n dear {player} Choice : ", false);
    }

    private bool GamesAreEmpty()
    {
        if (_games.Count != 0) return false;

        _io.Write("game club not have any game!");
        return true;
    }

    private bool GameNotFound(int gameId)
    {
        if (gameId >= 1 && gameId <= _games.Count) return false;
        
        _io.Write("game not found");
        return true;
    }

    private int GetChoice()
    {
        int choice = 0;
        bool isChoiceValid = false;
        while (isChoiceValid == false)
        {
            isChoiceValid = int.TryParse(_io.ReadLine()!, out int userInput);
            choice = userInput;
        }
        _io.Clear();
        return choice;
    }
    
    
    private void ShowMenu(string player)
    {
        _io.Write(@$"
Welcome {player}. What can i do for you ?
[1]. Play game
[2]. Show game description
[3]. Exit

{player} choice : ");
    }

}