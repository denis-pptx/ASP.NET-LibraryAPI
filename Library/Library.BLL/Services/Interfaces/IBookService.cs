using Library.BLL.Models.DTOs;
using Library.Domain.Entities;

namespace Library.BLL.Services.Interfaces;

public interface IBookService
{
    Task<Book> CreateBookAsync(BookDto bookDto);
    Task<IEnumerable<Book>> GetBooksAsync();
    Task<Book> GetBookByIdAsync(int id);
    Task<Book> UpdateBookAsync(int id, BookDto bookDto);
    Task<Book> DeleteBookByIdAsync(int id);
}