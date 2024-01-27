namespace Library.DAL.Repositories.Implementations;

public class EfRepository<T>(ApplicationDbContext dbContext) 
    : IRepository<T> 
    where T : Entity
{
    protected readonly ApplicationDbContext _dbContext = dbContext;
    protected readonly DbSet<T> _entities = dbContext.Set<T>();

    public async Task<bool> IsExistsAsync(int id)
    {
        return await _entities.AnyAsync(e => e.Id == id);
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _entities.SingleAsync(e => e.Id == id);
    }

    public async Task<IEnumerable<T>> GetAsync()
    {
        return await _entities.ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAsync(Func<T, bool> filter)
    {
        return await Task.Run(() => _entities.Where(filter));
    }

    public async Task AddAsync(T entity)
    {
        await _entities.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        await Task.Run(() => _entities.Update(entity));
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(T entity)
    {
        await Task.Run(() => _entities.Remove(entity));
        await _dbContext.SaveChangesAsync();
    }

    public async Task<T?> FirstOrDefaultAsync(Func<T, bool> filter)
    {
        return await Task.Run(() => _entities.FirstOrDefault(filter));
    }

    public async Task<T?> SingleOrDefaultAsync(Func<T, bool> filter)
    {
        return await Task.Run(() => _entities.SingleOrDefault(filter));
    }
}
