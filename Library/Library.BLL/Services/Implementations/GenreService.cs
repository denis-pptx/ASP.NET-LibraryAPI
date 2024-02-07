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

    public async override Task<Genre> CreateAsync(GenreDto genreDto, CancellationToken token)
    {
        if (await _entityRepository.FirstOrDefaultAsync(g => g.Name == genreDto.Name) is not null)
        {
            throw new ApiException(HttpStatusCode.Conflict, "Genre's name already exists");
        }

        var genre = _mapper.Map<GenreDto, Genre>(genreDto);
        var result = await _entityRepository.AddAsync(genre, token);

        return result;
    }

    public async override Task<Genre> UpdateAsync(int id, GenreDto genreDto, CancellationToken token)
    {
        if (!await _entityRepository.IsExistsAsync(id, token))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Genre is not found");
        }

        if (await _entityRepository.FirstOrDefaultAsync(g => g.Name == genreDto.Name && g.Id != id) is not null)
        {
            throw new ApiException(HttpStatusCode.Conflict, "Genre's name already exists");
        }

        genreDto.Id = id;

        var genre = await _entityRepository.GetByIdAsync(id, token);
        _mapper.Map(genreDto, genre);

        var result = await _entityRepository.UpdateAsync(genre, token);

        return result;
    }
}
