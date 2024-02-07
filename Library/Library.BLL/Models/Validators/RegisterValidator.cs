namespace Library.BLL.Models.Validators;

public class RegisterValidator : AbstractValidator<RegisterDto>
{
    public RegisterValidator()
    {
        RuleFor(u => u.Login).ApplyLoginRules();

        RuleFor(u => u.Password).ApplyPasswordRules();
    }
}
