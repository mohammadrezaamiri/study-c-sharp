// See https://aka.ms/new-console-template for more information

using GuessNumberGames.ConsoleApp;

var gamenet = new Gamenet.ConsoleApp.Gamenet();
var guessNumberGame = new GuessNumberGame("mmd"); 
gamenet.BuyGame(guessNumberGame);
gamenet.PlayGame();

Console.WriteLine("Hello, World!");