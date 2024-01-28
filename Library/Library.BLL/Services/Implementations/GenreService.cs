namespace Library.BLL.Services.Implementations;

public class GenreService(IRepository<Genre> genreRepository, IMapper mapper)
    : IGenreService
{
    private readonly IRepository<Genre> _genreRepository = genreRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<Genre> CreateGenreAsync(GenreDto genreDto)
    {
        var genre = _mapper.Map<Genre>(genreDto);
        var result = await _genreRepository.AddAsync(genre);

        return result;
    }

    public async Task<Genre> GetGenreByIdAsync(int id)
    {
        if (!await _genreRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Genre is not found");
        }

        var genre = await _genreRepository.GetByIdAsync(id);
        return genre;
    }

    public async Task<IEnumerable<Genre>> GetGenresAsync()
    {
        var genres = await _genreRepository.GetAsync();

        return genres;
    }

    public async Task<Genre> UpdateGenreAsync(int id, GenreDto genreDto)
    {
        if (!await _genreRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Genre is not found");
        }

        var genre = await _genreRepository.GetByIdAsync(id);

        genreDto.Id = id;
        _mapper.Map(genreDto, genre);

        var result = await _genreRepository.UpdateAsync(genre);

        return result;
    }

    public async Task<Genre> DeleteGenreByIdAsync(int id)
    {
        if (!await _genreRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Genre is not found");
        }

        var genre = await _genreRepository.GetByIdAsync(id);
        await _genreRepository.DeleteAsync(genre);

        return genre;
    }
}
