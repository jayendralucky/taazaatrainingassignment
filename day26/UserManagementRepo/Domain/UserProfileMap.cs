using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace UserManagementRepo.Domain
{
    public class UserProfileMap
    {
        
        public UserProfileMap(EntityTypeBuilder<UserProfile> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.FirstName).IsRequired();
            entityBuilder.Property(t => t.LastName).IsRequired();
            entityBuilder.Property(t => t.Address); 
        }
    }
}