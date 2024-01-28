using Library.Domain.Entities;

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

    public new async Task<Genre> DeleteByIdAsync(int id)
    {
        if (!await _entityRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Genre is not found");
        }

        var genre = await _entityRepository.GetByIdAsync(id);

        var books = await _bookRepository.GetAsync(b => b.GenreId == genre.Id);
        if (books.Count() != 0)
        {
            throw new ApiException(HttpStatusCode.Conflict, "It is impossible to delete the genre while books have it");
        }

        await _entityRepository.DeleteAsync(genre);

        return genre;
    }
}
