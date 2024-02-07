namespace Library.BLL.Services.Implementations;

public class BookService : BaseService<Book, BookDto>, IBookService
{
    public BookService(IRepository<Book> entityRepository, IMapper mapper) 
        : base(entityRepository, mapper)
    {
    }

    public async Task<Book> GetByIsbnAsync(string isbn, CancellationToken token)
    {
        var book = await _entityRepository.SingleOrDefaultAsync(b => b.ISBN == isbn, token);

        if (book == null)
        {
            throw new ApiException(HttpStatusCode.NotFound, "Book is not found");
        }

        return book;
    }

    public async override Task<Book> CreateAsync(BookDto bookDto, CancellationToken token)
    {
        if (await _entityRepository.FirstOrDefaultAsync(b => b.ISBN == bookDto.ISBN) is not null)
        {
            throw new ApiException(HttpStatusCode.Conflict, "Book's ISBN already exists");
        }

        var book = _mapper.Map<BookDto, Book>(bookDto);
        var result = await _entityRepository.AddAsync(book, token);

        return result;
    }

    public async override Task<Book> UpdateAsync(int id, BookDto bookDto, CancellationToken token)
    {
        if (!await _entityRepository.IsExistsAsync(id, token))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Book is not found");
        }

        if (await _entityRepository.FirstOrDefaultAsync(b => b.ISBN == bookDto.ISBN && b.Id != id) is not null)
        {
            throw new ApiException(HttpStatusCode.Conflict, "Book's ISBN already exists");
        }

        bookDto.Id = id;

        var book = await _entityRepository.GetByIdAsync(id, token);
        _mapper.Map(bookDto, book);

        var result = await _entityRepository.UpdateAsync(book, token);

        return result;
    }
}
