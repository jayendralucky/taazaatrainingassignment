using UserManagmentSystem.Data;
namespace UserManagmentSystem.Service
{
    public class UserRepository
    {
        UserDbContext userDbContext;
        public UserRepository(UserDbContext _userDbContext)
        {
            userDbContext=_userDbContext;   
        }       
    }
}