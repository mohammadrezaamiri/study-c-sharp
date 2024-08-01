namespace Vehicle.ConsoleApp;

public abstract class Vehicle
{
    private DateTime _startTime;
    
    public Vehicle(string name, string brand, DateTime buildDate)
    {
        Name = name;
        Brand = brand;
        BuildDate = buildDate;
    }

    private DateTime _buildDate;
    
    public string Name { get; set; }
    public string Brand { get; set; }
    public int LifeTime { get; private set; }
    public DateTime BuildDate
    {
        get => _buildDate;
        set => SetBuildDate(value);
    }

    private void SetBuildDate(DateTime value)
    {
        if (value < DateTime.Now) _buildDate = value;
        else throw new Exception("build date should be in past");
    }
    
    public virtual string Move()
    {
        _startTime = DateTime.Now;
        return $"vehicle {Name} moved";
    }

    public string Stop()
    {
        CalculateLifeTime();
        return $"vehicle {Name} stopped and life time is {LifeTime}";
    }

    private void CalculateLifeTime()
    {
        var now = DateTime.Now;
        LifeTime = (now - _startTime).Milliseconds;
    }
}