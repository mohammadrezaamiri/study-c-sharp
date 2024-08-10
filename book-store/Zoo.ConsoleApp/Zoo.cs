namespace Zoo.ConsoleApp;

public class Zoo
{
    private readonly List<IAnimal> _animals = [];

    public void AddAnimal(IAnimal animal) => _animals.Add(animal);

    public List<string> OpenZoo()
    {
        var animalsSound = new List<string>();
        _animals.ForEach(_ => animalsSound.Add(_.MakeSound()));
        return animalsSound;
    }
}