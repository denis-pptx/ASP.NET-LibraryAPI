namespace Library.BLL.Models.Validators;

public class BookValidator : AbstractValidator<BookDto>
{
    private readonly IRepository<Book> _bookRepository;
    private readonly IRepository<Author> _authorRepository;
    private readonly IRepository<Genre> _genreRepository;

    public BookValidator(
        IRepository<Book> bookRepository, 
        IRepository<Author> authorRepository, 
        IRepository<Genre> genreRepository)
    {
        _bookRepository = bookRepository;
        _authorRepository = authorRepository;
        _genreRepository = genreRepository;

        RuleFor(b => b.ISBN)
            .NotEmpty()
            .MinimumLength(10)
            .MaximumLength(30);

        RuleFor(b => b)
            .Must(book => _bookRepository
                .FirstOrDefaultAsync(b => b.ISBN == book.ISBN && b.Id != book.Id).Result == null)
            .WithMessage("This ISBN already exists");

        RuleFor(b => b.Name)
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(50);

        RuleFor(b => b.Description)
            .MaximumLength(300);

        RuleFor(b => new { b.CaptureDate, b.ReturnDate })
            .Custom((dates, context) =>
            {
                if (dates.CaptureDate.HasValue 
                    && dates.ReturnDate.HasValue 
                    && !(dates.CaptureDate <= dates.ReturnDate))
                {
                    context.AddFailure("CaptureDate must be less than or equal to ReturnDate");
                }
            });

        RuleFor(b => b.AuthorId)
            .NotEmpty()
            .Must(AuthorId => _authorRepository.IsExistsAsync(AuthorId).Result)
            .WithMessage("There is no author with such AuthorId");

        RuleFor(b => b.GenreId)
            .NotEmpty()
            .Must(GenreId => _genreRepository.IsExistsAsync(GenreId).Result)
            .WithMessage("There is no author with such GenreId");
    }
}
