namespace Vehicle.ConsoleApp;

public class Airplane : Vehicle
{
    public Airplane(string name, string brand, DateTime buildDate)
        : base(name, brand, buildDate)
    {
    }
    
    public override string Move()
    {
        return $"Airplane {Name} flew";
    }
}