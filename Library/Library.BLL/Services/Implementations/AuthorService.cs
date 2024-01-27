using AutoMapper;
using Library.BLL.Models.DTO;
using Library.BLL.Services.Interfaces;
using Library.DAL.Repositories.Interfaces;
using Library.Domain.Entities;

namespace Library.BLL.Services.Implementations;

public class AuthorService(IRepository<Author> authorRepository, IMapper mapper) 
    : IAuthorService
{
    private readonly IRepository<Author> _authorRepository = authorRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<AuthorDto> CreateAuthorAsync(AuthorDto authorDto)
    {
        var author = _mapper.Map<Author>(authorDto);
        author = await _authorRepository.AddAsync(author);

        return _mapper.Map<AuthorDto>(author);
    }

    public async Task<IEnumerable<AuthorDto>> GetAuthorsAsync()
    {
        var authors = await _authorRepository.GetAsync();

        return _mapper.Map<IEnumerable<AuthorDto>>(authors);
    }
}
