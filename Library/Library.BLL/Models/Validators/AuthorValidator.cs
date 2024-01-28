namespace Library.BLL.Models.Validators;

public class AuthorValidator : AbstractValidator<AuthorDto>
{
    private readonly IRepository<Author> _authorReposistory;
    public AuthorValidator(IRepository<Author> authorReposistory)
    {
        _authorReposistory = authorReposistory;

        RuleFor(a => a.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(50);

        RuleFor(a => a)
            .Must(author => _authorReposistory
                .FirstOrDefaultAsync(a => a.Name == author.Name && a.Id != author.Id).Result == null)
            .WithMessage("This name already exists");
    }
}

