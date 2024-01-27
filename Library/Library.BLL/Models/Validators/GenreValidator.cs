using FluentValidation;
using Library.BLL.Models.DTOs;
using Library.DAL.Repositories.Interfaces;
using Library.Domain.Entities;

namespace Library.BLL.Models.Validators;

public class GenreValidator : AbstractValidator<GenreDto>
{
    private readonly IRepository<Genre> _genreReposistory;

    public GenreValidator(IRepository<Genre> genreReposistory)
    {
        _genreReposistory = genreReposistory;

        RuleFor(a => a.Name)
           .NotEmpty()
           .MinimumLength(3)
           .MaximumLength(50)
           .Must(UniqueName)
           .WithMessage("This name already exists"); 
    }

    private bool UniqueName(string name)
    {
        Genre? genre = _genreReposistory.FirstOrDefaultAsync(a => a.Name == name).Result;

        return genre == null;
    }
}
