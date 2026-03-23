namespace LibraryManagement.Transactions;

public class Transaction
{

    public Transaction(string bookTitle, string memberName, DateTime creationTime, TransactionType type)
    {
        Id = Guid.NewGuid();
        BookTitle = bookTitle;
        MemberName = memberName;
        CreationTime = creationTime;
        Type = type;
    }

    public Guid Id { get; set; }
    public string BookTitle { get; set; }
    public string MemberName { get; set; }
    public DateTime CreationTime { get; set; }
    public TransactionType Type { get; set; }

    public override string ToString()
    {
        return $"\nTransaction {Id}: \nTitle: {BookTitle} \nMember: {MemberName} \nCreatedAt: {CreationTime}\nType: {Type.ToString()}";
    }
}