using Library.BLL.Models.DTOs;
using Library.DAL.Entities;
using Library.DAL.Repositories.Implementations;

namespace Library.BLL.Services.Implementations;

public class AuthorService : BaseService<Author, AuthorDto>, IAuthorService
{
    private readonly IRepository<Book> _bookRepository;

    public AuthorService(
        IRepository<Author> entityRepository, 
        IRepository<Book> bookRepository, 
        IMapper mapper) 
        : base(entityRepository, mapper)
    {
        _bookRepository = bookRepository;
    }

    public async override Task<Author> DeleteByIdAsync(int id, CancellationToken token)
    {
        if (!await _entityRepository.IsExistsAsync(id, token))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Author is not found");
        }

        var author = await _entityRepository.GetByIdAsync(id, token);

        var books = await _bookRepository.GetAsync(b => b.AuthorId == author.Id, token);
        if (books.Count() != 0)
        {
            throw new ApiException(HttpStatusCode.Conflict, "It is impossible to delete the author while books have it");
        }

        await _entityRepository.DeleteAsync(author, token);
        return author;
    }

    public async override Task<Author> CreateAsync(AuthorDto authorDto, CancellationToken token)
    {
        if (await _entityRepository.FirstOrDefaultAsync(a => a.Name == authorDto.Name) is not null)
        {
            throw new ApiException(HttpStatusCode.Conflict, "Author's name already exists");
        }

        var author = _mapper.Map<AuthorDto, Author>(authorDto);
        var result = await _entityRepository.AddAsync(author, token);

        return result;
    }

    public async override Task<Author> UpdateAsync(int id, AuthorDto authorDto, CancellationToken token)
    {
        if (!await _entityRepository.IsExistsAsync(id, token))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Author is not found");
        }

        if (await _entityRepository.FirstOrDefaultAsync(a => a.Name == authorDto.Name && a.Id != id) is not null)
        {
            throw new ApiException(HttpStatusCode.Conflict, "Author's name already exists");
        }

        authorDto.Id = id;

        var author = await _entityRepository.GetByIdAsync(id, token);
        _mapper.Map(authorDto, author);

        var result = await _entityRepository.UpdateAsync(author, token);

        return result;
    }
}
