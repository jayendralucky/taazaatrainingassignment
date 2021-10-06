using System.Collections.Generic;
using login.Models;
using login.Data;
using System.Linq;
namespace login.Repository
{
    public class MembershipRepository : IMembership
    {
        MembershipContext _context;
    public MembershipRepository(MembershipContext context)
    {
        _context=context;
        
    }
        int IMembership.AddUser(Membership membership)
        {
            _context.Add(membership);
            int temp =_context.SaveChanges();
            return temp;
        }

        Membership IMembership.SearchUser(string userName)
        {
            var user=_context.users.FirstOrDefault(t=>t.UserName==userName);
            return user;
        }
    }
}