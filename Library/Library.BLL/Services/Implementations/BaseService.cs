namespace Library.BLL.Services.Implementations;

public abstract class BaseService<TEntity, TEntityDto> : IBaseService<TEntity, TEntityDto>
    where TEntity : Entity
    where TEntityDto : EntityDto
{
    protected readonly IRepository<TEntity> _entityRepository;
    protected readonly IMapper _mapper;

    public BaseService(IRepository<TEntity> entityRepository, IMapper mapper)
    {
        _entityRepository = entityRepository;
        _mapper = mapper;
    }

    public async Task<TEntity> CreateAsync(TEntityDto entityDto)
    {
        var entity = _mapper.Map<TEntityDto, TEntity>(entityDto);
        var result = await _entityRepository.AddAsync(entity);

        return result;
    }

    public async Task<TEntity> DeleteByIdAsync(int id)
    {
        if (!await _entityRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, $"{typeof(TEntity).Name} is not found");
        }

        var entity = await _entityRepository.GetByIdAsync(id);
        await _entityRepository.DeleteAsync(entity);

        return entity;
    }

    public async Task<IEnumerable<TEntity>> GetAsync()
    {
        var entities = await _entityRepository.GetAsync();

        return entities;
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        if (!await _entityRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, $"{nameof(TEntity)} is not found");
        }

        var entity = await _entityRepository.GetByIdAsync(id);

        return entity;
    }

    public async Task<TEntity> UpdateAsync(int id, TEntityDto entityDto)
    {
        if (!await _entityRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, $"{nameof(TEntity)} is not found");
        }

        var entity = await _entityRepository.GetByIdAsync(id);

        entityDto.Id = id;
        _mapper.Map(entityDto, entity);

        var result = await _entityRepository.UpdateAsync(entity);

        return result;
    }
}
