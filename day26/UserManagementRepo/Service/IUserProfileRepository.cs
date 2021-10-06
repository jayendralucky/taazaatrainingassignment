using UserManagementRepo.Domain;
namespace UserManagementRepo.Service
{
    public interface IUserProfileRepository
    {
        UserProfile GetUserProfile(long id);
         
    }
}