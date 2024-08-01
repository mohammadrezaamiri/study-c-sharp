namespace Vehicle.ConsoleApp;

public class Bicycle : Vehicle
{
    public Bicycle(string name, string brand, DateTime buildDate)
        : base(name, brand, buildDate)
    {
    }

    public string Color { get; set; }
    
    public override string Move()
    {
        return $"bicycle {Name} ride";
    }
}