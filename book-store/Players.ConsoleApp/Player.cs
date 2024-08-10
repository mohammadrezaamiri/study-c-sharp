namespace Players.ConsoleApp;

public class Player
{
    public Player(DateTime birthDate)
    {
        Code = Guid.NewGuid().ToString();
        BirthDate = birthDate;
    }

    // Auto-Implemented properties
    public string Name { get; set; }

    public List<string> InterestedGames { get; } = [];

    // simple properties
    private string bestFavoriteGame; // backing field
    public string BestFavoriteGame { get => bestFavoriteGame; set => bestFavoriteGame = value; }



    // Read-Only properties
    public string Code { get; }
    
    // readonly for backing fields
    
    
    // Write-Only properties
    private int playCount;
    public int PlayCount { set => playCount += value; }
    
    
    
    // Properties with logic
    private DateTime birthDate;
    public DateTime BirthDate { 
        get => birthDate; 
        set { if(value < DateTime.Now) birthDate = value; } 
    }
    
    
    
    // Calculated properties
    public int Age { get => (int)((DateTime.Now - birthDate).TotalDays / 365); }


    
    // public , private , internal , protected , private protected, protected internal
    private protected int TestPrivateProtected() => 1;
    protected internal int TestProtectedInternal() => 1;
}