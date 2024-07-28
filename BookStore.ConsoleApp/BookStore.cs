public class BookStore 
{
    public BookStore(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public void Consult(string customerName)
    {
        Console.WriteLine($"welcome to blue book store {customerName}");
    }
}