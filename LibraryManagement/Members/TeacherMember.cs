namespace LibraryManagement.Members;

public class TeacherMember: Member
{
    public TeacherMember(int id, string name, string phoneNumber)
    {
        BorrowedBooks = new Book[GetMaxBorrowLimit()];
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
    }

    public override int GetMaxBorrowLimit() => 5;
}