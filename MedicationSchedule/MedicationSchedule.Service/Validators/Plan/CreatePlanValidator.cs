using FluentValidation;
using MedicationSchedule.BL.Plans.Model;

namespace MedicationSchedule.Service.Validators.Plan;

public class CreatePlanValidator: AbstractValidator<CreatePlanModel>
{
    public CreatePlanValidator()
    {
        RuleFor(x => x.MedicationName)
            .NotEmpty()
            .WithMessage("Medication name must be valid");
        RuleFor(x => x.DosageMg)
            .NotEmpty()
            .GreaterThan(0)
            .WithMessage("Dosage must be valid");
        RuleFor(x => x.TakingTime)
            .NotEmpty()
            .WithMessage("Taking time must be valid");
        RuleFor(x => x.DurationDays)
            .NotEmpty()
            .WithMessage("Duration must be valid");
        RuleFor(x => x.PatientId)
            .NotEmpty()
            .WithMessage("Patient must be valid");
        RuleFor(x => x.DoctorId)
            .NotEmpty()
            .WithMessage("Doctor must be valid");
    }
}