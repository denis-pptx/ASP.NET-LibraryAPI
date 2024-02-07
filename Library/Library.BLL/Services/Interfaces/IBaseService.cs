namespace Library.BLL.Services.Interfaces;

public interface IBaseService<TEntity, TEntityDto> 
    where TEntity : Entity
    where TEntityDto : EntityDto
{
    Task<TEntity> CreateAsync(TEntityDto entityDto, CancellationToken token = default);
    Task<IEnumerable<TEntity>> GetAsync(CancellationToken token = default);
    Task<TEntity> GetByIdAsync(int id, CancellationToken token = default);
    Task<TEntity> UpdateAsync(int id, TEntityDto entityDto, CancellationToken token = default);
    Task<TEntity> DeleteByIdAsync(int id, CancellationToken token = default);
}
