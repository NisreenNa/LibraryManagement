namespace LibraryManagement.Members;

public abstract class Member
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public Book[] BorrowedBooks { get; set; }
    public float FineValue { get; set; } // To store the fine for a member
    public int BorrowedBooksCount => BorrowedBooks.Count(e=>e!=null && e.IsBorrowed);
    public void BorrowBook(Book book)
    {
        if (BorrowedBooksCount>=GetMaxBorrowLimit())
        {
            Console.Write("You exceeded the maximum borrow limit.");
            return;
        }
        book.IsBorrowed = true;
        BorrowedBooks[book.Id]=book; // array[^1] give us the last element of array.
    }

    public void ReturnBook(int bookId)
    {
        BorrowedBooks[bookId].IsBorrowed = false;
    }

    public abstract int GetMaxBorrowLimit();
}