using GameClubs.ConsoleApp;

var maxGuessNumberGame = new GuessNumberGame("Max Guess Number");
var simpleGuessNumberGame = new GuessNumberGame("Simple Guess Number");

var gameClub = new GameClub(
    maxGuessNumberGame, 
    simpleGuessNumberGame);
gameClub.AddGames(new GuessNumberGame("Kermani Guess Number"));

gameClub.ComeIn("Ahmad");