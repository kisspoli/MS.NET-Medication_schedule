using AutoMapper;
using MedicationSchedule.BL.Plans.Exceptions;
using MedicationSchedule.BL.Plans.Model;
using MedicationSchedule.DataAccess.Entities;
using MedicationSchedule.DataAccess.Repository;

namespace MedicationSchedule.BL.Plans.Provider;

public class PlansProvider : IPlansProvider
{
    private readonly IRepository<PlanEntity> _plansRepository;
    private readonly IMapper _mapper;

    public PlansProvider(IRepository<PlanEntity> plansRepository, IMapper mapper)
    {
        _plansRepository = plansRepository;
        _mapper = mapper;
    }

    public IEnumerable<PlanModel> GetPlans()
    {
        var plans = _plansRepository.GetAll().ToList();

        return _mapper.Map<IEnumerable<PlanModel>>(plans);
    }

    public IEnumerable<PlanModel> GetPlansForDoctor(int id)
    {
        var plans = _plansRepository.GetAll(x => x.DoctorId == id).ToList();

        return _mapper.Map<IEnumerable<PlanModel>>(plans);
    }

    public IEnumerable<PlanModel> GetPlansForPatient(int id)
    {
        var plans = _plansRepository.GetAll(x => x.PatientId == id).ToList();

        return _mapper.Map<IEnumerable<PlanModel>>(plans);
    }

    public PlanModel GetPlanInfo(int id)
    {
        var plan = _plansRepository.GetById(id);
        if (plan == null)
        {
            throw new PlanNotPresentException("Plan does not exist.");
        }

        return _mapper.Map<PlanModel>(plan);
    }
}