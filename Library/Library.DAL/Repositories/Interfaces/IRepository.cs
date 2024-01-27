namespace Library.DAL.Repositories.Interfaces;

public interface IBaseRepository<T> 
    where T : Entity
{
    Task<bool> IsExistsAsync(int id);
    Task<T> GetByIdAsync(int id);
    Task<IEnumerable<T>> GetAsync();
    Task<IEnumerable<T>> GetAsync(Func<T, bool> filter);
    Task AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<T?> FirstOrDefaultAsync(Func<T, bool> filter);
    Task<T?> SingleOrDefaultAsync(Func<T, bool> filter);
}