public class GuessNumberGame : Game
{
    public GuessNumberGame() => _number = RandomNumber();
    protected override string Name { get; set; } = "Taav Guess Number";
    
    private readonly int _number;
    private int _guessCount = 0;
    
    protected override void Play()
    {
        bool isGuessCorrect = false;

        while (!isGuessCorrect)
        {
            _guessCount++;

            int number = GetNumber();
            if (number == _number)
            {
                Console.WriteLine
                    ($"correct!! you could guess number with {_guessCount} time ");
                isGuessCorrect = true;
            }
            else Help(number);
        }
    }

    

    private void Help(int number)
    {
        if (number > _number)
            Console.WriteLine($"please Enter number smaller than {number}");

        if (number < _number)
            Console.WriteLine($"please enter number grater than {number}");
    }
    
    private int RandomNumber() => new Random().Next(1, 100);
    
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
}