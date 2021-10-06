using Microsoft.EntityFrameworkCore;
using PatientRepository.Models;
namespace PatientRepository.DataAccess
{
    public class PatientDBContext:DbContext
    {
    public PatientDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
    {
        
    }
    public DbSet<Patient> patients{get;set;}//for local manipulation.
        
    }
}