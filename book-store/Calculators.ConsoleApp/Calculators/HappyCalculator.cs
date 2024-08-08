namespace Gamenets.ConsoleApp.Calculators;

public class HappyCalculator : Calculator
{
    public HappyCalculator() => WelcomeToUser();
    private void WelcomeToUser() => Console.WriteLine("Welcome to happy :) calculator");

    public override string CalculatorOwnerName { get; set; } = "Ahmad";

    public override int Mode(int a, int b)
    {
        throw new NotImplementedException();
    }
}