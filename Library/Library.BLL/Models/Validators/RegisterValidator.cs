namespace Library.BLL.Models.Validators;

public class RegisterValidator : AbstractValidator<RegisterDto>
{
    public RegisterValidator(IRepository<User> userRepository)
    {
        RuleFor(u => u.Login).ApplyLoginRules().ApplyLoginUniqueRule(userRepository);

        RuleFor(u => u.Password).ApplyPasswordRules();
    }
}
