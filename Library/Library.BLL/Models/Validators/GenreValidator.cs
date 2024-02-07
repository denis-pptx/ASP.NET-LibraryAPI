namespace Library.BLL.Models.Validators;

public class GenreValidator : AbstractValidator<GenreDto>
{
    public GenreValidator()
    {
        RuleFor(a => a.Name)
           .NotEmpty()
           .MinimumLength(3)
           .MaximumLength(50);
    }
}
