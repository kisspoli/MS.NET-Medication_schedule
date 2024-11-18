using MedicationSchedule.BL.Plans.Model;

namespace MedicationSchedule.BL.Plans.Manager;

public interface IPlansManager
{
    PlanModel CreatePlan(CreatePlanModel createPlanModel);
    PlanModel UpdatePlan(UpdatePlanModel updatePlanModel);
    void DeletePlan(int id);
}