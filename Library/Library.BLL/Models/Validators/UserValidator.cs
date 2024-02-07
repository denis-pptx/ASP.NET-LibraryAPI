namespace Library.BLL.Models.Validators;

public class UserValidator : AbstractValidator<UserDto>
{
    public UserValidator()
    {
        RuleFor(u => u.Login).ApplyLoginRules();

        RuleFor(u => u.Password).ApplyPasswordRules();
    }
}
