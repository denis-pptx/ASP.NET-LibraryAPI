namespace Library.BLL.Models.Validators;

public class LoginValidator : AbstractValidator<LoginDto>
{
    public LoginValidator()
    {
        RuleFor(u => u.Login).NotEmpty();

        RuleFor(u => u.Password).NotEmpty();
    }
}
