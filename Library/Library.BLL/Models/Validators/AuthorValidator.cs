using FluentValidation;
using Library.BLL.Models.DTO;

namespace Library.BLL.Models.Validators;

public class AuthorValidator : AbstractValidator<AuthorDto>
{
    public AuthorValidator()
    {
        RuleFor(a => a.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(50);
    }
}

