using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace UserManagmentRepositoryPractice.Domain
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t=>t.Id);
            entityTypeBuilder.Property(t=>t.Email).IsRequired();
            entityTypeBuilder.Property(t=>t.Password).IsRequired();
            entityTypeBuilder.Property(t=>t.UserName).IsRequired();
        }
        
    }
}