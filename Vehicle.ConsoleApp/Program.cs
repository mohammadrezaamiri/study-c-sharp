// See https://aka.ms/new-console-template for more information

using Vehicle.ConsoleApp;

Console.WriteLine("Hello, Inheritance!");



Vehicle.ConsoleApp.Vehicle ul12 = 
    new Airplane("ul12", "airbus", DateTime.Now.AddYears(-10));
Vehicle.ConsoleApp.Vehicle bmx = 
    new Bicycle("bmx", "hymalia", DateTime.Now.AddYears(5));

Vehicle.ConsoleApp.Vehicle[] vehicles = [ ul12, bmx ];
foreach (var vehicle in vehicles)
    Console.WriteLine(vehicle.Move());

Console.ReadKey();
foreach (var vehicle in vehicles)
    Console.WriteLine(vehicle.Stop());
    