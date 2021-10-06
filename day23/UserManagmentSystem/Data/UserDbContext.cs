using Microsoft.EntityFrameworkCore;
using UserManagmentSystem.Models;
namespace UserManagmentSystem.Data
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMapper(modelBuilder.Entity<User>());
        }
        public DbSet<User> users{get;set;}
        
    }
}