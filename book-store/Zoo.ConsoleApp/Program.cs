// See https://aka.ms/new-console-template for more information

using Zoo.ConsoleApp;

Console.WriteLine("Hello, World!");

var cat = new Cat();
var dog = new Dog();

var zoo = new Zoo.ConsoleApp.Zoo();
zoo.AddAnimal(cat);
zoo.AddAnimal(dog);

zoo.OpenZoo().ForEach(sound => Console.WriteLine(sound));

/* 

Defining a Contract
Dependency injection
Polymorphism
multiple implementation

*/