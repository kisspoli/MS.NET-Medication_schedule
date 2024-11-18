using MedicationSchedule.BL.Users.Model;

namespace MedicationSchedule.BL.Users.Manager;

public interface IUsersManager
{
    UserModel CreateUser(CreateUserModel createUserModel);
    UserModel UpdateUser(UpdateUserModel updateUserModel);
    void DeleteUser(int id);
}