using FluentValidation;
namespace UsermanagementService.Models
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(t=>t.username).Length(0,10);
            RuleFor( t=>t.Age).InclusiveBetween(18,60);
            
        }
        
    }
}