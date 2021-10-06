using UserManagmentRepositoryPractice.Domain;
namespace UserManagmentRepositoryPractice.Service
{
    public interface IUserProfileRepository
    {
         UserProfile GetUserProfile(long id);
    }
}