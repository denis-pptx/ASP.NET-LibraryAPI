namespace Library.BLL.Services.Implementations;

public class GenreService : BaseService<Genre, GenreDto>, IGenreService
{
    private readonly IRepository<Book> _bookRepository;

    public GenreService(
        IRepository<Genre> entityRepository, 
        IRepository<Book> bookRepository, 
        IMapper mapper) 
        : base(entityRepository, mapper)
    {
        _bookRepository = bookRepository;
    }

    public async override Task<Genre> DeleteByIdAsync(int id, CancellationToken token)
    {
        if (!await _entityRepository.IsExistsAsync(id, token))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Genre is not found");
        }

        var genre = await _entityRepository.GetByIdAsync(id, token);

        var books = await _bookRepository.GetAsync(b => b.GenreId == genre.Id, token);
        if (books.Count() != 0)
        {
            throw new ApiException(HttpStatusCode.Conflict, "It is impossible to delete the genre while books have it");
        }

        await _entityRepository.DeleteAsync(genre, token);

        return genre;
    }
}
