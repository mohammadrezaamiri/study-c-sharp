namespace Zoo.ConsoleApp;

public class Dog : IAnimal 
{
    public string Name { get; set; }
    
    public string MakeSound()
    {
        return "hup hup";
    }
}