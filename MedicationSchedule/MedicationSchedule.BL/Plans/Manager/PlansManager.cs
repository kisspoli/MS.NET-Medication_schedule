using AutoMapper;
using MedicationSchedule.BL.Plans.Exceptions;
using MedicationSchedule.BL.Plans.Model;
using MedicationSchedule.DataAccess.Entities;
using MedicationSchedule.DataAccess.Repository;

namespace MedicationSchedule.BL.Plans.Manager;

public class PlansManager : IPlansManager
{
    private readonly IRepository<PlanEntity> _plansRepository;
    private readonly IMapper _mapper;

    public PlansManager(IRepository<PlanEntity> plansRepository, IMapper mapper)
    {
        _plansRepository = plansRepository;
        _mapper = mapper;
    }

    public PlanModel CreatePlan(CreatePlanModel createPlanModel)
    {
        var plan = _mapper.Map<PlanEntity>(createPlanModel);
        plan = _plansRepository.Save(plan);
        return _mapper.Map<PlanModel>(plan);
    }

    public PlanModel UpdatePlan(UpdatePlanModel updatePlanModel)
    {
        var plan = _mapper.Map<PlanEntity>(updatePlanModel);
        plan = _plansRepository.Save(plan);
        return _mapper.Map<PlanModel>(plan);
    }

    public void DeletePlan(int id)
    {
        var plan = _plansRepository.GetById(id);
        if (plan == null)
        {
            throw new PlanNotPresentException("Plan does not exist.");
        }
            
        _plansRepository.Delete(plan);
    }
}