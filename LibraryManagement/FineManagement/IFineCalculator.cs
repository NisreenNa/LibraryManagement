namespace LibraryManagement.FineManagement;

public interface IFineCalculator
{
    public static float FinePerDay { get; set; } = 0.5F;
    float CalculateFine(int daysLate);
}