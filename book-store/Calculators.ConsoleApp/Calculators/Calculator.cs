namespace Gamenets.ConsoleApp.Calculators;

public abstract class Calculator
{
    // overloading  // overriding
    public virtual int Add(params int[] numbers)
    {
        Console.WriteLine("this is calculator");
        Console.WriteLine($"owner is {CalculatorOwnerName}");
        return numbers.Sum();
    }

    public virtual string CalculatorOwnerName { get; set; } = "Ali";

    public virtual decimal Add(params decimal[] numbers)
    {
        var result = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
            result += numbers[i];

        return result;
    }
    
    public virtual int Minus(params int[] numbers)
    {
        var result = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
            result -= numbers[i];

        return result;
    }
    public virtual decimal Minus(params decimal[] numbers)
    {
        var result = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
            result -= numbers[i];

        return result;
    }

    public abstract int Mode(int a, int b);
}