using AutoMapper;
using MedicationSchedule.BL.Roles.Exceptions;
using MedicationSchedule.BL.Roles.Model;
using MedicationSchedule.DataAccess.Entities;
using MedicationSchedule.DataAccess.Repository;

namespace MedicationSchedule.BL.Roles.Provider;

public class RolesProvider : IRolesProvider
{
    private readonly IRepository<RoleEntity> _rolesRepository;
    private readonly IMapper _mapper;

    public RolesProvider(IRepository<RoleEntity> rolesRepository, IMapper mapper)
    {
        _rolesRepository = rolesRepository;
        _mapper = mapper;
    }

    public IEnumerable<RoleModel> GetRoles()
    {
        var roles = _rolesRepository.GetAll().ToList();

        return _mapper.Map<IEnumerable<RoleModel>>(roles);
    }

    public RoleModel GetRoleInfo(int id)
    {
        var role = _rolesRepository.GetById(id);
        if (role == null)
        {
            throw new RoleNotPresentException("Role does not exist.");
        }

        return _mapper.Map<RoleModel>(role);
    }
}