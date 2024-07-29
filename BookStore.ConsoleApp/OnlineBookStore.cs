public class OnlineBookStore : BookStore
{
    public OnlineBookStore(
        string name, 
        string address,
        string webAddress,
        bool hasStationery = false) 
        : base(name, address, hasStationery: hasStationery) 
        {
            WebAddress = webAddress;
        }

    public string WebAddress { get; set; }

    public string LendBook(string book, string customer) =>
        $"Welcome. dear {customer} now the {book} book is yours until 2 week. enjoy";
}