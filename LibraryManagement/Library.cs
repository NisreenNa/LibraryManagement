using System.Text;
using LibraryManagement.FineManagement;
using LibraryManagement.Members;
using LibraryManagement.Transactions;

namespace LibraryManagement;

public class Library
{
    public Library(int bookLength, int memberLength, int transactionLength)
    {
        Books = new Book[bookLength];
        Members = new Member[memberLength];
        Transactions = new Transaction[transactionLength];
    }
    public Book [] Books { get; set; }
    public Member [] Members { get; set; }
    public Transaction [] Transactions { get; set; }
    public static int TotalBorrowedBooks;

    public void AddBook(Book book)
    {
        Books[book.Id] = book;
    }

    public void AddMember(Member member)
    {
        Members[member.Id] = member;
    }

    public void BorrowBook(int memberId, int bookId)
    {
        var book = Books[bookId];
        if (book == null)
        {
            Console.WriteLine($"No book with Id: {bookId}");
            return;
        }
        var member = Members[memberId];
        if (member == null)
        {
            Console.WriteLine($"No member with Id: {memberId}");
            return;
        }
        member.BorrowBook(book);
        Transactions.AddToArray(new Transaction(book.Title, member.Name, DateTime.UtcNow, TransactionType.Borrow));
        ++TotalBorrowedBooks;
    }

    public void ReturnBook(int  memberId, int bookId, int days)
    {
        IFineCalculator fineCalc = new FineCalculator();
        var member = Members[memberId];
        if (member == null)
        {
            Console.WriteLine($"No member found with Id:{memberId}");
            return;
        }
        var book = Books[bookId];
        if (book == null) 
        {
            Console.WriteLine($"No book found with Id {bookId}");
            return;
        }
        member.ReturnBook(bookId);
        member.FineValue = fineCalc.CalculateFine(days);
        Transactions.AddToArray(new Transaction(book.Title, member.Name, DateTime.UtcNow, TransactionType.Return));
        --TotalBorrowedBooks;
    }

    public void PrintTransactions()
    {
        if (!Transactions.Any() || Transactions.FirstOrDefault() == null)
        {
            Console.WriteLine("No transactions found");
            return;
        }
        StringBuilder stringBuilder = new StringBuilder();
        foreach (var transaction in Transactions.Where(e=>e!=null))
        {
            stringBuilder.AppendLine(transaction.ToString());
        }
        Console.Write(stringBuilder.ToString());
    }
}
