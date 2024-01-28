using Library.Domain.Entities;

namespace Library.BLL.Services.Interfaces;

public interface IBookService : IBaseService<Book, BookDto>
{
    Task<Book> GetByIsbnAsync(string isbn);
}