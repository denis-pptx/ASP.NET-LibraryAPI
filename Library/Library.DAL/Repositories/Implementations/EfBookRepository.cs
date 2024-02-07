using Library.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Library.DAL.Repositories.Implementations;

public class EfBookRepository : IRepository<Book>
{
    protected readonly ApplicationDbContext _dbContext;
    protected readonly DbSet<Book> _books;

    public EfBookRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _books = dbContext.Set<Book>();
    }

    public async Task<bool> IsExistsAsync(int id, CancellationToken token)
    {
        return await _books.AnyAsync(e => e.Id == id, token);
    }

    public async Task<Book> GetByIdAsync(int id, CancellationToken token)
    {
        var booksIncluded = _books
            .Include(b => b.Genre)
            .Include(b => b.Author)!;

        return await booksIncluded.SingleAsync(e => e.Id == id, token);
    }

    public async Task<IEnumerable<Book>> GetAsync(CancellationToken token)
    {
        var booksIncluded = _books
            .Include(b => b.Genre)
            .Include(b => b.Author)!;

        return await booksIncluded.ToListAsync(token);
    }

    public async Task<IEnumerable<Book>> GetAsync(Expression<Func<Book, bool>> filter, CancellationToken token)
    {
        var booksIncluded = _books
            .Include(b => b.Genre)
            .Include(b => b.Author)!;

        return await booksIncluded.Where(filter).ToListAsync(token);
    }

    public async Task<Book> AddAsync(Book book, CancellationToken token)
    {
        await _books.AddAsync(book, token);
        await _dbContext.SaveChangesAsync(token);

        _dbContext.Entry(book).Reference(b => b.Genre).Load();
        _dbContext.Entry(book).Reference(b => b.Author).Load();

        return book;
    }

    public async Task<Book> UpdateAsync(Book book, CancellationToken token)
    {
        _books.Update(book);
        await _dbContext.SaveChangesAsync(token);

        _dbContext.Entry(book).Reference(b => b.Genre).Load();
        _dbContext.Entry(book).Reference(b => b.Author).Load();

        return book;
    }

    public async Task DeleteAsync(Book book, CancellationToken token)
    {
        _books.Remove(book);
        await _dbContext.SaveChangesAsync(token);
    }

    public async Task<Book?> FirstOrDefaultAsync(Expression<Func<Book, bool>> filter, CancellationToken token)
    {
        var booksIncluded = _books
            .Include(b => b.Genre)
            .Include(b => b.Author)!;

        return await booksIncluded.FirstOrDefaultAsync(filter, token);
    }

    public async Task<Book?> SingleOrDefaultAsync(Expression<Func<Book, bool>> filter, CancellationToken token)
    {
        var booksIncluded = _books
            .Include(b => b.Genre)
            .Include(b => b.Author)!;

        return await booksIncluded.SingleOrDefaultAsync(filter, token);
    }
}
