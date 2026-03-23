namespace LibraryManagement.FineManagement
{
    public class FineCalculator: IFineCalculator
    {
        public float CalculateFine(int daysLate) 
        {
            return daysLate * IFineCalculator.FinePerDay;
        }
    }
}
