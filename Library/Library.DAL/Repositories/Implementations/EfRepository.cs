namespace Library.DAL.Repositories.Implementations;

public class EfRepository<T>(ApplicationDbContext dbContext) 
    : IRepository<T> 
    where T : Entity
{
    protected readonly ApplicationDbContext _dbContext = dbContext;
    protected readonly DbSet<T> _entities = dbContext.Set<T>();

    public async Task<bool> IsExistsAsync(int id, CancellationToken token)
    {
        return await _entities.AnyAsync(e => e.Id == id, token);
    }

    public async Task<T> GetByIdAsync(int id, CancellationToken token)
    {
        return await _entities.SingleAsync(e => e.Id == id, token);
    }

    public async Task<IEnumerable<T>> GetAsync(CancellationToken token)
    {
        return await _entities.ToListAsync(token);
    }

    public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter, CancellationToken token)
    {
        return await _entities.Where(filter).ToListAsync(token);
    }

    public async Task<T> AddAsync(T entity, CancellationToken token)
    {
        await _entities.AddAsync(entity, token);
        await _dbContext.SaveChangesAsync(token);

        // For loading navigation properties.
        entity = await _entities.SingleAsync(e => e.Id == entity.Id, token);

        return entity;
    }

    public async Task<T> UpdateAsync(T entity, CancellationToken token)
    {
        _entities.Update(entity);
        await _dbContext.SaveChangesAsync(token);

        // For loading navigation properties.
        entity = await _entities.SingleAsync(e => e.Id == entity.Id, token);

        return entity;
    }

    public async Task DeleteAsync(T entity, CancellationToken token)
    {
        _entities.Remove(entity);
        await _dbContext.SaveChangesAsync(token);
    }

    public async Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> filter, CancellationToken token)
    {
        return await _entities.FirstOrDefaultAsync(filter, token);
    }

    public async Task<T?> SingleOrDefaultAsync(Expression<Func<T, bool>> filter, CancellationToken token)
    {
        return await _entities.SingleOrDefaultAsync(filter, token);
    }
}
