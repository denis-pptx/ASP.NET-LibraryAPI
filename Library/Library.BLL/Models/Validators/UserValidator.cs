namespace Library.BLL.Models.Validators;

public class UserValidator : AbstractValidator<UserDto>
{
    public UserValidator(IRepository<User> userRepository)
    {
        RuleFor(u => u.Login).ApplyLoginRules().ApplyLoginUniqueRule(userRepository);

        RuleFor(u => u.Password).ApplyPasswordRules();
    }
}
