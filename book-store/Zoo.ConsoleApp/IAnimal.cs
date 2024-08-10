namespace Zoo.ConsoleApp;

// contract that some class should implement
// for dependency injection
// for multi inheritance

public interface IAnimal
{
    string Name { get; set; }
    string MakeSound();
}