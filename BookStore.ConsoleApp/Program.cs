using static System.Console;

var blueBookStore = new BookStore(name: "Blue", address: "shiraz, ghoddousi gharbi");

WriteLine($"bookstore {blueBookStore.Name} opened!");

WriteLine(blueBookStore.Consult(customer: "mohammad"));

var redBookStore = new OnlineBookStore("Red", "shiraz", "www.redbook.ir");

WriteLine(redBookStore.LendBook("unsherli", "ali"));