// See https://aka.ms/new-console-template for more information

using Games.ConsoleApp;
using GuessNumberGames.ConsoleApp;

Console.WriteLine("Hello, World!");

Game guessNumberGame = new GuessNumberGame("mmd");
guessNumberGame.Start();