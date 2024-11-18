namespace MedicationSchedule.BL.Roles.Exceptions;

public class RoleNotPresentException : ApplicationException
{
    public RoleNotPresentException() { }
    public RoleNotPresentException(string message) : base(message) { }
}