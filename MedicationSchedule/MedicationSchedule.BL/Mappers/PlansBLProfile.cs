using AutoMapper;
using MedicationSchedule.BL.Plans.Model;
using MedicationSchedule.DataAccess.Entities;

namespace MedicationSchedule.BL.Mappers;

public class PlansBLProfile : Profile
{
    public PlansBLProfile()
    {
        CreateMap<PlanEntity, PlanModel>()
            .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(x => x.ExternalId, opt => opt.MapFrom(src => src.ExternalId))
            .ForMember(x => x.CreationTime, opt => opt.MapFrom(src => src.CreationTime))
            .ForMember(x => x.ModificationTime, opt => opt.MapFrom(src => src.ModificationTime))
            .ForMember(x => x.MedicationName, opt => opt.MapFrom(src => src.MedicationName))
            .ForMember(x => x.DosageMg, opt => opt.MapFrom(src => src.DosageMg))
            .ForMember(x => x.TakingTime, opt => opt.MapFrom(src => src.TakingTime))
            .ForMember(x => x.DurationDays, opt => opt.MapFrom(src => src.DurationDays))
            .ForMember(x => x.PatientId, opt => opt.MapFrom(src => src.PatientId))
            .ForMember(x => x.DoctorId, opt => opt.MapFrom(src => src.DoctorId));
        
        CreateMap<CreatePlanModel, PlanEntity>()
            .ForMember(x => x.MedicationName, opt => opt.MapFrom(src => src.MedicationName))
            .ForMember(x => x.DosageMg, opt => opt.MapFrom(src => src.DosageMg))
            .ForMember(x => x.TakingTime, opt => opt.MapFrom(src => src.TakingTime))
            .ForMember(x => x.DurationDays, opt => opt.MapFrom(src => src.DurationDays))
            .ForMember(x => x.PatientId, opt => opt.MapFrom(src => src.PatientId))
            .ForMember(x => x.DoctorId, opt => opt.MapFrom(src => src.DoctorId));

        CreateMap<UpdatePlanModel, PlanEntity>()
            .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(x => x.MedicationName, opt => opt.MapFrom(src => src.MedicationName))
            .ForMember(x => x.DosageMg, opt => opt.MapFrom(src => src.DosageMg))
            .ForMember(x => x.TakingTime, opt => opt.MapFrom(src => src.TakingTime))
            .ForMember(x => x.DurationDays, opt => opt.MapFrom(src => src.DurationDays))
            .ForMember(x => x.PatientId, opt => opt.MapFrom(src => src.PatientId))
            .ForMember(x => x.DoctorId, opt => opt.MapFrom(src => src.DoctorId));

    }
}