namespace Library.BLL.Services.Interfaces;

public interface IBaseService<TEntity, TEntityDto> 
    where TEntity : Entity
    where TEntityDto : EntityDto
{
    Task<TEntity> CreateAsync(TEntityDto entityDto);
    Task<IEnumerable<TEntity>> GetAsync();
    Task<TEntity> GetByIdAsync(int id);
    Task<TEntity> UpdateAsync(int id, TEntityDto entityDto);
    Task<TEntity> DeleteByIdAsync(int id);
}
