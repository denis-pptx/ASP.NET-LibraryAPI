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

    public async virtual Task<TEntity> CreateAsync(TEntityDto entityDto, CancellationToken token)
    {
        var entity = _mapper.Map<TEntityDto, TEntity>(entityDto);
        var result = await _entityRepository.AddAsync(entity, token);

        return result;
    }

    public async virtual Task<TEntity> DeleteByIdAsync(int id, CancellationToken token)
    {
        if (!await _entityRepository.IsExistsAsync(id, token))
        {
            throw new ApiException(HttpStatusCode.NotFound, $"{typeof(TEntity).Name} is not found");
        }

        var entity = await _entityRepository.GetByIdAsync(id, token);
        await _entityRepository.DeleteAsync(entity, token);

        return entity;
    }

    public async virtual Task<IEnumerable<TEntity>> GetAsync(CancellationToken token)
    {
        var entities = await _entityRepository.GetAsync(token);

        return entities;
    }

    public async virtual Task<TEntity> GetByIdAsync(int id, CancellationToken token)
    {
        if (!await _entityRepository.IsExistsAsync(id, token))
        {
            throw new ApiException(HttpStatusCode.NotFound, $"{typeof(TEntity).Name} is not found");
        }

        var entity = await _entityRepository.GetByIdAsync(id, token);

        return entity;
    }

    public async virtual Task<TEntity> UpdateAsync(int id, TEntityDto entityDto, CancellationToken token)
    {
        entityDto.Id = id;

        if (!await _entityRepository.IsExistsAsync(id, token))
        {
            throw new ApiException(HttpStatusCode.NotFound, $"{nameof(TEntity)} is not found");
        }

        var entity = await _entityRepository.GetByIdAsync(id, token);
        _mapper.Map(entityDto, entity);

        var result = await _entityRepository.UpdateAsync(entity, token);

        return result;
    }
}
