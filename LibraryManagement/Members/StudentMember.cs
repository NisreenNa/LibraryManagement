namespace LibraryManagement.Members;

public class StudentMember: Member
{
    public StudentMember(int id, string name, string phoneNumber)
    {
        BorrowedBooks = new Book[GetMaxBorrowLimit()];
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
    }
    

    public override int GetMaxBorrowLimit() => 3;
}