namespace Library.BLL.Services.Implementations;

public class GenreService : BaseService<Genre, GenreDto>, IGenreService
{
    public GenreService(IRepository<Genre> entityRepository, IMapper mapper) 
        : base(entityRepository, mapper)
    {
    }
}
