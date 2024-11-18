using AutoMapper;
using MedicationSchedule.BL.Users.Exceptions;
using MedicationSchedule.BL.Users.Model;
using MedicationSchedule.DataAccess.Entities;
using MedicationSchedule.DataAccess.Repository;

namespace MedicationSchedule.BL.Users.Manager;

public class UsersManager : IUsersManager
{
    private readonly IRepository<UserEntity> _usersRepository;
    private readonly IMapper _mapper;

    public UsersManager(IRepository<UserEntity> usersRepository, IMapper mapper)
    {
        _usersRepository = usersRepository;
        _mapper = mapper;
    }
    
    public UserModel CreateUser(CreateUserModel createUserModel)
    {
        var user = _mapper.Map<UserEntity>(createUserModel);
        user = _usersRepository.Save(user);
        return _mapper.Map<UserModel>(user);
    }

    public UserModel UpdateUser(UpdateUserModel updateUserModel)
    {
        var user = _mapper.Map<UserEntity>(updateUserModel);
        user = _usersRepository.Save(user);
        return _mapper.Map<UserModel>(user);
    }

    public void DeleteUser(int id)
    {
        var user = _usersRepository.GetById(id);
        if (user == null)
        {
            throw new UserNotPresentException("User does not exist.");
        }
            
        _usersRepository.Delete(user);
    }
}