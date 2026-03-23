namespace LibraryManagement;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    public bool IsBorrowed { get; set; }

    public Book(int id, string title, string author, decimal price)
    {
        Id = id;
        Title = title;
        Author = author;
        Price = price;
        IsBorrowed = false;
    }

    public override string ToString()
    {
        return $"Book: \nId: {Id}\nTitle: {Title}\nAuthor: {Author}\nPrice: {Price}\nIsBorrowed: {IsBorrowed}\n";
    }
}