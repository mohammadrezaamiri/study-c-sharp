namespace Zoo.ConsoleApp;

public class Cat : IAnimal
{
    public string Name { get; set; }
    
    public string MakeSound()
    {
        return "miou miou";
    }
}