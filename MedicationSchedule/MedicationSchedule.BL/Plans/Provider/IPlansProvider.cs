using MedicationSchedule.BL.Plans.Model;

namespace MedicationSchedule.BL.Plans.Provider;

public interface IPlansProvider
{
    IEnumerable<PlanModel> GetPlans();
    IEnumerable<PlanModel> GetPlansForDoctor(int id);
    IEnumerable<PlanModel> GetPlansForPatient(int id);
    PlanModel GetPlanInfo(int id);
}