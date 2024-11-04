using System.ComponentModel.DataAnnotations.Schema;

namespace MedicationSchedule.DataAccess.Entities;

[Table("Role")]
public class RoleEntity : BaseEntity
{
    public string Name { get; set; }
    
    public List<UserEntity> Users { get; set; }
}