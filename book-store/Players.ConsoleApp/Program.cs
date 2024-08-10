using Players.ConsoleApp;

var trainGeneric = new TrainGeneric();
trainGeneric.TrainPrinter();


var cat = new Cat();
var treatment = new Treatment<Cat>();
treatment.Treat(cat);

// var player = new Player(DateTime.Now);
// var treatment2 = new Treatment<Player>(player);