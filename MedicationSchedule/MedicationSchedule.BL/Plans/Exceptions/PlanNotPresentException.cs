namespace MedicationSchedule.BL.Plans.Exceptions;

public class PlanNotPresentException : ApplicationException
{
    public PlanNotPresentException() { }
    public PlanNotPresentException(string message) : base(message) { }
}