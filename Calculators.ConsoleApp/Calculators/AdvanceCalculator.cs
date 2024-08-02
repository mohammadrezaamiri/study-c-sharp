namespace Gamenets.ConsoleApp.Calculators;

public class AdvanceCalculator : Calculator
{
    public override int Add(params int[] numbers)
    {
        Console.WriteLine("this is advance calculator");
        var result = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
            result += numbers[i];

        return result;
    }

    public override int Mode(int a, int b)
    {
        return a % b;
    }
}