using Library.Domain.Entities;

namespace Library.BLL.Services.Implementations;

public class BookService : BaseService<Book, BookDto>, IBookService
{
    public BookService(IRepository<Book> entityRepository, IMapper mapper) 
        : base(entityRepository, mapper)
    {
    }

    public async Task<Book> GetByIsbnAsync(string isbn)
    {
        var book = await _entityRepository.SingleOrDefaultAsync(b => b.ISBN == isbn);

        if (book == null)
        {
            throw new ApiException(HttpStatusCode.NotFound, $"Book is not found");
        }

        return book;
    }
}
