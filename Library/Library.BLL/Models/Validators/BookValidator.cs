namespace Library.BLL.Models.Validators;

public class BookValidator : AbstractValidator<BookDto>
{
    public BookValidator()
    {
        RuleFor(b => b.ISBN)
            .NotEmpty()
            .MinimumLength(10)
            .MaximumLength(30);

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
    }
}
