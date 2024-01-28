namespace Library.BLL.Models.Validators;

public class LoginValidator : AbstractValidator<LoginDto>
{
    public LoginValidator()
    {
        RuleFor(u => u.Login).ApplyLoginRules();

        RuleFor(u => u.Password).ApplyPasswordRules();
    }
}
