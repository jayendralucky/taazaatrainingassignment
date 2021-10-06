using UserManagmentRepositoryPractice.Domain;
using Microsoft.EntityFrameworkCore;
namespace UserManagmentRepositoryPractice.DataAcessLayer
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap(modelBuilder.Entity<User>());
        }
        
    }
}