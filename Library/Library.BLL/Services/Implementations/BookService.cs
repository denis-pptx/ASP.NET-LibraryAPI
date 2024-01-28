using AutoMapper;
using Library.BLL.Exceptions;
using Library.BLL.Models.DTOs;
using Library.BLL.Services.Interfaces;
using Library.DAL.Repositories.Interfaces;
using Library.Domain.Entities;
using System.Net;

namespace Library.BLL.Services.Implementations;

public class BookService(IRepository<Book> bookRepository, IMapper mapper)
    : IBookService
{
    private readonly IRepository<Book> _bookRepository = bookRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<Book> CreateBookAsync(BookDto bookDto)
    {
        var book = _mapper.Map<Book>(bookDto);
        var result = await _bookRepository.AddAsync(book);

        return result;
    }

    public async Task<Book> GetBookByIdAsync(int id)
    {
        if (!await _bookRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Book is not found");
        }

        var book = await _bookRepository.GetByIdAsync(id);
        return book;
    }

    public async Task<IEnumerable<Book>> GetBooksAsync()
    {
        var books = await _bookRepository.GetAsync();

        return books;
    }

    public async Task<Book> UpdateBookAsync(int id, BookDto bookDto)
    {
        if (!await _bookRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Book is not found");
        }

        var book = await _bookRepository.GetByIdAsync(id);

        bookDto.Id = id;
        _mapper.Map(bookDto, book);

        var result = await _bookRepository.UpdateAsync(book);

        return result;
    }

    public async Task<Book> DeleteBookByIdAsync(int id)
    {
        if (!await _bookRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Book is not found");
        }

        var book = await _bookRepository.GetByIdAsync(id);
        await _bookRepository.DeleteAsync(book);

        return book;
    }
}
