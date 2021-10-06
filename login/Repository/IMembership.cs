using login.Models;
using System.Collections.Generic;
namespace login.Repository
{
    public interface IMembership
    {
         int AddUser(Membership membership);
         Membership SearchUser(string userName);

    }
}