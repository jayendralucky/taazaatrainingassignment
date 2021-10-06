using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace UserManagementRepo.Domain
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t=>t.Id);
            entityTypeBuilder.Property(t=>t.Email).IsRequired();
            entityTypeBuilder.Property(t=>t.Password).IsRequired();
            entityTypeBuilder.Property( t=>t.UserName).IsRequired();
            entityTypeBuilder.HasOne(t=>t.userProfile).WithOne(t=>t.user).HasForeignKey<UserProfile>(t=>t.Id);//one to one relationship
           
        }
    }
}