using ContactsCustomMiddleware.Models;
using Microsoft.EntityFrameworkCore;
namespace ContactsCustomMiddleware.Context
{
    public class ContactsDbContext:DbContext
    {
        public DbSet<Contacts> contacts{get;set;}
         public ContactsDbContext(DbContextOptions options):base(options)
       {

       }
       public ContactsDbContext ()
       {

        }

        
    }
}