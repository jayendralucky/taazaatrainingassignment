using UsermanagementService.Models;
using System.Collections.Generic;
namespace UsermanagementService.Service
{
    public interface IUserRepository
    {
           int AddUser(User user);
          int UpdateUser(int id,User user);
          int DeleteUser(int id);
          User SearchUser(int id);
          IEnumerable<User> GetUsers();
    }
}