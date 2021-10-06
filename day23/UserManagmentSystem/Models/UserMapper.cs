using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace UserManagmentSystem.Models
{
    // now we are implementing fluent api for defining the structure or schema for user
    public class UserMapper
    {
        public UserMapper(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t=>t.Id);
            entityTypeBuilder.Property(t=>t.Name).IsRequired();
            entityTypeBuilder.Property(t=>t.PhoneNo).IsRequired();
            
        }
        
    }
}