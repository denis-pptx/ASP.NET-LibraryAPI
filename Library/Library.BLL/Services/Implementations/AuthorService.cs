using AutoMapper;
using Library.BLL.Exceptions;
using Library.BLL.Models.DTOs;
using Library.BLL.Services.Interfaces;
using Library.DAL.Repositories.Interfaces;
using Library.Domain.Entities;
using System.Net;

namespace Library.BLL.Services.Implementations;

public class AuthorService(IRepository<Author> authorRepository, IMapper mapper) 
    : IAuthorService
{
    private readonly IRepository<Author> _authorRepository = authorRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<Author> CreateAuthorAsync(AuthorDto authorDto)
    {
        var author = _mapper.Map<Author>(authorDto);
        var result = await _authorRepository.AddAsync(author);

        return result;
    }

    public async Task<Author> GetAuthorByIdAsync(int id)
    {
        if (!await _authorRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Author is not found");
        }

        var author = await _authorRepository.GetByIdAsync(id);
        return author;
    }

    public async Task<IEnumerable<Author>> GetAuthorsAsync()
    {
        var authors = await _authorRepository.GetAsync();

        return authors;
    }
    
    public async Task<Author> UpdateAuthorAsync(int id, AuthorDto authorDto)
    {
        if (!await _authorRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Author is not found");
        }

        var author = await _authorRepository.GetByIdAsync(id);

        authorDto.Id = id;
        _mapper.Map(authorDto, author);

        var result = await _authorRepository.UpdateAsync(author);

        return result;
    } 

    public async Task<Author> DeleteAuthorByIdAsync(int id)
    {
        if (!await _authorRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Author is not found");
        }

        var author = await _authorRepository.GetByIdAsync(id);
        await _authorRepository.DeleteAsync(author);

        return author;
    }
}
