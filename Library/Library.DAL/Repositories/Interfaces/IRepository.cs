namespace Library.DAL.Repositories.Interfaces;

public interface IRepository<T> 
    where T : Entity
{
    Task<bool> IsExistsAsync(int id, CancellationToken token = default);
    Task<T> GetByIdAsync(int id, CancellationToken token = default);
    Task<IEnumerable<T>> GetAsync(CancellationToken token = default);
    Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter, CancellationToken token = default);
    Task<T> AddAsync(T entity, CancellationToken token = default);
    Task<T> UpdateAsync(T entity, CancellationToken token = default);
    Task DeleteAsync(T entity, CancellationToken token = default);
    Task<T?> FirstOrDefaultAsync(Expression<Func<T, bool>> filter, CancellationToken token = default);
    Task<T?> SingleOrDefaultAsync(Expression<Func<T, bool>> filter, CancellationToken token = default);
}