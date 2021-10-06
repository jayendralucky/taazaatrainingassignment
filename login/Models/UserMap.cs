using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace login.Models
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<Membership> entityBuilder)
        {
            entityBuilder.HasKey(x => x.UserName);
            entityBuilder.Property(x => x.age).IsRequired();
            entityBuilder.Property(x => x.Password).IsRequired();
        }
    }
}