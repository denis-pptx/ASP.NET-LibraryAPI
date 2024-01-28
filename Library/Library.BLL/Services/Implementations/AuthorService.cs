namespace Library.BLL.Services.Implementations;

public class AuthorService : BaseService<Author, AuthorDto>, IAuthorService
{
    public AuthorService(IRepository<Author> entityRepository, IMapper mapper) 
        : base(entityRepository, mapper)
    {
    }
}
