using UserManagementRepo.Domain;
using Microsoft.EntityFrameworkCore;

namespace UserManagementRepo.Repository
{
    public class ApplicationContext:DbContext
    {
                
       public ApplicationContext(DbContextOptions options):base(options)
       {

       }
        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap(modelBuilder.Entity<User>());


        }
        
    }
}