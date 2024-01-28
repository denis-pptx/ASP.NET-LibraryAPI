using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Library.DAL.Repositories.Implementations;

public class EfBookRepository : IRepository<Book>
{
    protected readonly ApplicationDbContext _dbContext;
    protected readonly DbSet<Book> _books;
    protected readonly IIncludableQueryable<Book, Author> _included;
    public EfBookRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        _books = dbContext.Set<Book>();

        _included = dbContext.Set<Book>()
            .Include(b => b.Genre)
            .Include(b => b.Author)!;
    }

    public async Task<bool> IsExistsAsync(int id)
    {
        return await _books.AnyAsync(e => e.Id == id);
    }

    public async Task<Book> GetByIdAsync(int id)
    {
        return await _included.SingleAsync(e => e.Id == id);
    }

    public async Task<IEnumerable<Book>> GetAsync()
    {
        return await _included.ToListAsync();
    }

    public async Task<IEnumerable<Book>> GetAsync(Func<Book, bool> filter)
    {
        return await Task.Run(() => _included.Where(filter));
    }

    public async Task<Book> AddAsync(Book book)
    {
        await _books.AddAsync(book);
        await _dbContext.SaveChangesAsync();

        return await _included.SingleAsync(b => b.Id == book.Id);
    }

    public async Task<Book> UpdateAsync(Book book)
    {
        await Task.Run(() => _books.Update(book));
        await _dbContext.SaveChangesAsync();

        return await _included.SingleAsync(b => b.Id == book.Id);
    }

    public async Task DeleteAsync(Book book)
    {
        await Task.Run(() => _books.Remove(book));
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Book?> FirstOrDefaultAsync(Func<Book, bool> filter)
    {
        return await Task.Run(() => _included.FirstOrDefault(filter));
    }

    public async Task<Book?> SingleOrDefaultAsync(Func<Book, bool> filter)
    {
        return await Task.Run(() => _included.SingleOrDefault(filter));
    }
}
