using AutoMapper;
using MedicationSchedule.BL.Users.Model;
using MedicationSchedule.DataAccess.Entities;

namespace MedicationSchedule.BL.Mappers;

public class UsersBLProfile : Profile
{
    public UsersBLProfile()
    {
        CreateMap<UserEntity, UserModel>()
            .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(x => x.ExternalId, opt => opt.MapFrom(src => src.ExternalId))
            .ForMember(x => x.CreationTime, opt => opt.MapFrom(src => src.CreationTime))
            .ForMember(x => x.ModificationTime, opt => opt.MapFrom(src => src.ModificationTime))
            .ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(x => x.Surname, opt => opt.MapFrom(src => src.Surname))
            .ForMember(x => x.Patronymic, opt => opt.MapFrom(src => src.Patronymic))
            .ForMember(x => x.Birthday, opt => opt.MapFrom(src => src.Birthday))
            .ForMember(x => x.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(x => x.PasswordHash, opt => opt.MapFrom(src => src.PasswordHash))
            .ForMember(x => x.RoleId, opt => opt.MapFrom(src => src.RoleId));
        
        CreateMap<CreateUserModel, UserEntity>()
            .ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(x => x.Surname, opt => opt.MapFrom(src => src.Surname))
            .ForMember(x => x.Patronymic, opt => opt.MapFrom(src => src.Patronymic))
            .ForMember(x => x.Birthday, opt => opt.MapFrom(src => src.Birthday))
            .ForMember(x => x.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(x => x.PasswordHash, opt => opt.MapFrom(src => src.PasswordHash))
            .ForMember(x => x.RoleId, opt => opt.MapFrom(src => src.RoleId));
        
        CreateMap<UpdateUserModel, UserEntity>()
            .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(x => x.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(x => x.Surname, opt => opt.MapFrom(src => src.Surname))
            .ForMember(x => x.Patronymic, opt => opt.MapFrom(src => src.Patronymic))
            .ForMember(x => x.Birthday, opt => opt.MapFrom(src => src.Birthday))
            .ForMember(x => x.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(x => x.PasswordHash, opt => opt.MapFrom(src => src.PasswordHash))
            .ForMember(x => x.RoleId, opt => opt.MapFrom(src => src.RoleId));
    }
}