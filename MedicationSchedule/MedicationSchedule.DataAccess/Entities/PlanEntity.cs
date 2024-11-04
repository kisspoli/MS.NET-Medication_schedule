using System.ComponentModel.DataAnnotations.Schema;

namespace MedicationSchedule.DataAccess.Entities;

[Table("Plan")]
public class PlanEntity: BaseEntity
{
    public string MedicationName { get; set; }
    public Double DosageMg { get; set; }
    public List<TimeOnly> TakingTime { get; set; }
    public int DurationDays { get; set; }
    
    public int PatientId { get; set; }
    public UserEntity Patient { get; set; }
    
    public int DoctorId { get; set; }
    public UserEntity Doctor { get; set; }
}