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

    public async Task<AuthorDto> CreateAuthorAsync(AuthorDto authorDto)
    {
        var author = _mapper.Map<Author>(authorDto);
        var result = await _authorRepository.AddAsync(author);

        return _mapper.Map<AuthorDto>(result);
    }

    public async Task<AuthorDto> GetAuthorByIdAsync(int id)
    {
        if (!await _authorRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Author is not found");
        }

        var author = await _authorRepository.GetByIdAsync(id);
        return _mapper.Map<AuthorDto>(author);
    }

    public async Task<IEnumerable<AuthorDto>> GetAuthorsAsync()
    {
        var authors = await _authorRepository.GetAsync();

        return _mapper.Map<IEnumerable<AuthorDto>>(authors);
    }
    
    public async Task<AuthorDto> UpdateAuthorAsync(int id, AuthorDto authorDto)
    {
        if (!await _authorRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Author is not found");
        }

        var author = await _authorRepository.GetByIdAsync(id);

        authorDto.Id = id;
        _mapper.Map(authorDto, author);

        var result = await _authorRepository.UpdateAsync(author);

        return _mapper.Map<AuthorDto>(result);
    } 

    public async Task<AuthorDto> DeleteAuthorByIdAsync(int id)
    {
        if (!await _authorRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Author is not found");
        }

        var author = await _authorRepository.GetByIdAsync(id);
        await _authorRepository.DeleteAsync(author);

        return _mapper.Map<AuthorDto>(author);
    }
}
