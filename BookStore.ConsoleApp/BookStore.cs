public class BookStore
{
    public BookStore(
        string name,
        string address,
        bool hasCaffee = false,
        bool hasCozyReadingNook = false,
        bool hasStationery = false)
    {
        Name = name;
        Address = address;
        HasCaffee = hasCaffee;
        HasCozyReadingNook = hasCozyReadingNook;
        HasStationery = hasStationery;
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public bool HasCaffee { get; set; }
    public bool HasCozyReadingNook { get; set; }
    public bool HasStationery { get; set; }


    public string Consult(string customer) =>
        $"Welcome to blue book store {customer}. please start reading. just do it.";

    public string SellBook(string book, string customer) => 
        $"Welcome dear {customer}. it's your book {book}. enjoy that";

    public string SetAppointmentForReadingBookEvent(string eventName, string customer) =>
        $"Welcome, we will see you in event {eventName} dear {customer}";
}