using AutoMapper;
using MedicationSchedule.BL.Plans.Manager;
using MedicationSchedule.BL.Plans.Model;
using MedicationSchedule.BL.Plans.Provider;
using MedicationSchedule.Service.Validators.Plan;
using Microsoft.AspNetCore.Mvc;

namespace MedicationSchedule.Service.Controllers;

[ApiController]
[Route("[controller]")]
public class PlanController : ControllerBase
{
    private readonly IPlansManager _plansManager;

    private readonly IPlansProvider _plansProvider;

    private readonly IMapper _mapper;

    public PlanController(IPlansManager plansManager, IPlansProvider plansProvider, IMapper mapper)
    {
        _plansManager = plansManager;
        _plansProvider = plansProvider;
        _mapper = mapper;
    }
    
    [HttpPost]
    [Route("/plan")]
    public IActionResult CreatePlan([FromBody] CreatePlanModel request)
    {
        try
        {
            var validationResult = new CreatePlanValidator().Validate(request);
            if (!validationResult.IsValid) return BadRequest(validationResult.Errors);
            var planModel = _plansManager.CreatePlan(request);
            return Ok(planModel);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet]
    [Route("/plan/all")]
    public IActionResult GetAllPlans()
    {
        try
        {
            var plans = _plansProvider.GetPlans();
            return Ok(plans.Select(u => _mapper.Map<PlanModel>(u)).ToList());
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet]
    [Route("/plan/doctor/{id:int}")]
    public IActionResult GetDoctorPlansById(int id)
    {
        try
        {
            var plans = _plansProvider.GetPlansForDoctor(id);
            return Ok(plans.Select(u => _mapper.Map<PlanModel>(u)).ToList());
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet]
    [Route("/plan/patient/{id:int}")]
    public IActionResult GetPatientPlansById(int id)
    {
        try
        {
            var plans = _plansProvider.GetPlansForPatient(id);
            return Ok(plans.Select(u => _mapper.Map<PlanModel>(u)).ToList());
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpGet]
    [Route("/plan/{id:int}")]
    public IActionResult GetPlanById(int id)
    {
        try
        {
            var plan = _plansProvider.GetPlanInfo(id);
            return Ok(plan);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpPut]
    [Route("/plan")]
    public IActionResult UpdatePlan([FromBody] UpdatePlanModel request)
    {
        try
        {
            var validationResult = new UpdatePlanValidator().Validate(request);
            if (!validationResult.IsValid) return BadRequest(validationResult.Errors);
            var planModel = _plansManager.UpdatePlan(request);
            return Ok(planModel);
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
    
    [HttpDelete]
    [Route("/plan/{id:int}")]
    public IActionResult DeletePlan(int id)
    {
        try
        {
            _plansManager.DeletePlan(id);
            return Ok();
        }
        catch (Exception e)
        {
            return StatusCode(500, e.Message);
        }
    }
}