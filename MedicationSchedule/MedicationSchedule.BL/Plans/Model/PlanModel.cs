namespace MedicationSchedule.BL.Plans.Model;

public class PlanModel
{
    public int Id { get; set; }   
    public Guid ExternalId { get; set; }
    public DateTime CreationTime { get; set; }
    public DateTime ModificationTime { get; set; }
    public string MedicationName { get; set; }
    public Double DosageMg { get; set; }
    public List<TimeOnly> TakingTime { get; set; }
    public int DurationDays { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
}