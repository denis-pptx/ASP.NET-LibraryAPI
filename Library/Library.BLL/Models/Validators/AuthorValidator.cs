﻿using FluentValidation;
using Library.BLL.Models.DTOs;
using Library.BLL.Services.Implementations;
using Library.BLL.Services.Interfaces;
using Library.DAL.Repositories.Interfaces;
using Library.Domain.Entities;

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
            .MaximumLength(50)
            .Must(UniqueName)
            .WithMessage("This name already exists");
    }

    private bool UniqueName(string name)
    {
        Author? author = _authorReposistory.FirstOrDefaultAsync(a => a.Name == name).Result;

        return author == null;
    }
}

