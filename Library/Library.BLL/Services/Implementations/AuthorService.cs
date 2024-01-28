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

    public new async Task<Author> DeleteByIdAsync(int id)
    {
        if (!await _entityRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Author is not found");
        }

        var author = await _entityRepository.GetByIdAsync(id);

        var books = await _bookRepository.GetAsync(b => b.AuthorId == author.Id);
        if (books.Count() != 0)
        {
            throw new ApiException(HttpStatusCode.Conflict, "It is impossible to delete the author while books have it");
        }

        await _entityRepository.DeleteAsync(author);

        return author;
    }
}
