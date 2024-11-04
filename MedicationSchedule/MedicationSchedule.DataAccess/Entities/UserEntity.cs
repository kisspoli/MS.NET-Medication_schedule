using System.ComponentModel.DataAnnotations.Schema;

namespace MedicationSchedule.DataAccess.Entities;

[Table("User")]
public class UserEntity : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string? Patronymic { get; set; }
    public DateOnly Birthday { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }

    public int RoleId { get; set; }
    public RoleEntity Role { get; set; }
    public List<PlanEntity>? PlansAsDoctor { get; set; }
    public List<PlanEntity>? PlansAsPatient { get; set; }
}