using Games.ConsoleApp;

namespace GuessNumberGames.ConsoleApp;

public class GuessNumberGame : Game
{
    protected override string Name { get; set; } = "Taav Guess Number";

    protected override void Play()
    {
        StartGame();
    }

    public GuessNumberGame(string playerName)
    {
        PlayerName = playerName;
        _number = RandomNumber();
    }

    public string PlayerName { get; set; }
    private int _number;

    int countGuess = 0;

    private void StartGame()
    {
        bool Guess = false;

        while (!Guess)
        {
            countGuess++;

            int number = GetNumber();

            if (number > _number)

                Console.WriteLine($"please Enter number smaller than {number}");

            if (number < _number)
                Console.WriteLine($"please enter number grater than {number}");
            if (number == _number)
            {
                Console.WriteLine
                    ($"correct {PlayerName}!! you could guess number with {countGuess} time ");
                Guess = true;
            }
        }
    }

    private int GetNumber()
    {
        bool canParseNumber = false;

        var number = 0;
        while (!canParseNumber)
        {
            Console.WriteLine("enter your guess :");
            canParseNumber = int.TryParse(Console.ReadLine(), out number);
        }

        return number;
    }

    private int RandomNumber()
    {
        Random random = new Random();

        return random.Next(1, 100);
    }
}