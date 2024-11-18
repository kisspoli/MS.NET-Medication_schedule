namespace MedicationSchedule.BL.Users.Exceptions;

public class UserNotPresentException : ApplicationException
{
    public UserNotPresentException() { }
    public UserNotPresentException(string message) : base(message) { }
}