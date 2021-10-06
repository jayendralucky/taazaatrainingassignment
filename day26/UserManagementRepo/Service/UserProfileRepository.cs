using UserManagementRepo.Domain;
using UserManagementRepo.Repository;

namespace UserManagementRepo.Service
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
            return userprofilerepository.Get(id);
        }
    }
}