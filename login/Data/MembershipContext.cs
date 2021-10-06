using Microsoft.EntityFrameworkCore;
using login.Models;
namespace login.Data
{
    public class MembershipContext:DbContext
    {
         public DbSet<Membership> users{get;set;}
         public MembershipContext(DbContextOptions options):base(options)
        {

        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserMap(modelBuilder.Entity<Membership>());
        }
        
    }
}