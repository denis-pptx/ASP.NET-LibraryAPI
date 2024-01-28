namespace Library.BLL.Services.Implementations;

public class BookService : BaseService<Book, BookDto>, IBookService
{
    public BookService(IRepository<Book> entityRepository, IMapper mapper) 
        : base(entityRepository, mapper)
    {
    }
}
