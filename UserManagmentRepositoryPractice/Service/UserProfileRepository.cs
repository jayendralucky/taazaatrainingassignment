using UserManagmentRepositoryPractice.Domain;
using UserManagmentRepositoryPractice.DataAcessLayer;

namespace UserManagmentRepositoryPractice.Service
{
    public class UserProfileRepository : IUserProfileRepository
    {
        IRepository<UserProfile> userprofilerepository;
        public UserProfileRepository(IRepository<UserProfile> _userprofileRepository)
        {
            userprofilerepository = _userprofileRepository;
        }
        UserProfile IUserProfileRepository.GetUserProfile(long id)
        {
               return userprofilerepository.GetT(id);
        }
    }
}