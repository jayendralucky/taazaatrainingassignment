using System.Collections.Generic;
using UserManagmentRepositoryPractice.Domain;
namespace UserManagmentRepositoryPractice.Service
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();//get all
        User GetUser(long id);
        int InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);

         
    }
}