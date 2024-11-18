namespace MedicationSchedule.BL.Plans.Model;

public class CreatePlanModel
{
    public string MedicationName { get; set; }
    public Double DosageMg { get; set; }
    public List<TimeOnly> TakingTime { get; set; }
    public int DurationDays { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
}