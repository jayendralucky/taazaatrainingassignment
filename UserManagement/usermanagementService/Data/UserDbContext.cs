using Microsoft.EntityFrameworkCore;
namespace usermanagementService.Data
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbcontextOptions options):base(options)
        
    }
}