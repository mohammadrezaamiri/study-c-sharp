using static System.Console;

namespace GameClubs.ConsoleApp;

public class GuessNumberGame : Game
{
    public GuessNumberGame(string name, string description = "Guess Number between 1 to 100")
    {
        Name = name;
        Description = description;
        _number = GenerateRandomNumber();
    }

    public override string Name { get; }
    public override string Description { get; }

    private readonly int _number;
    private int _guessCount;
    
    public override void Play()
    {
        var isGuessCorrect = false;

        while (!isGuessCorrect)
        {
            _guessCount++;

            var number = GetNumber();
            if (number == _number)
            {
                WriteLine($"correct!! you could guess number with {_guessCount} time ");
                isGuessCorrect = true;
            }
            else Help(number);
        }
    }

    private void Help(int number)
    {
        if (number > _number)
            WriteLine($"please Enter number smaller than {number}");

        if (number < _number)
            WriteLine($"please enter number grater than {number}");
    }
    
    private int GenerateRandomNumber() => new Random().Next(1, 100);
    
    private int GetNumber()
    {
        bool canParseNumber = false;

        var number = 0;
        while (!canParseNumber)
        {
            Write("Enter your guess : ");
            canParseNumber = int.TryParse(ReadLine(), out number);
        }
        return number;
    }
}