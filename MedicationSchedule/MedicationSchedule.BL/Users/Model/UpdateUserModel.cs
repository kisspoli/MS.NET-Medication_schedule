namespace MedicationSchedule.BL.Users.Model;

public class UpdateUserModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Patronymic { get; set; }
    public DateOnly Birthday { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public int RoleId { get; set; }
}