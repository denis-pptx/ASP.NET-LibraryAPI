using Library.BLL.Models.DTOs;
using Library.DAL.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
namespace Library.BLL.Services.Implementations;

public class UserService : BaseService<User, UserDto>, IUserService
{
    public UserService(IRepository<User> entityRepository, IMapper mapper)
        : base(entityRepository, mapper)
    {
    }

    public async Task<User> GetByLoginAsync(string login, CancellationToken token)
    {
        var user = await _entityRepository.SingleOrDefaultAsync(x => x.Login == login, token);
        if (user == null)
        {
            throw new ApiException(HttpStatusCode.BadRequest, "Invalid login or password");
        }
        return user;
    }

    public async override Task<User> CreateAsync(UserDto userDto, CancellationToken token)
    {
        if (await _entityRepository.FirstOrDefaultAsync(u => u.Login == userDto.Login) is not null)
        {
            throw new ApiException(HttpStatusCode.Conflict, "This login already exists");
        }

        var user = _mapper.Map<UserDto, User>(userDto);
        var result = await _entityRepository.AddAsync(user, token);

        return result;
    }

    public async override Task<User> UpdateAsync(int id, UserDto userDto, CancellationToken token)
    {
        if (!await _entityRepository.IsExistsAsync(id, token))
        {
            throw new ApiException(HttpStatusCode.NotFound, "User is not found");
        }

        if (await _entityRepository.FirstOrDefaultAsync(u => u.Login == userDto.Login) is not null)
        {
            throw new ApiException(HttpStatusCode.Conflict, "This login already exists");
        }

        userDto.Id = id;

        var user = await _entityRepository.GetByIdAsync(id, token);
        _mapper.Map(userDto, user);

        var result = await _entityRepository.UpdateAsync(user, token);

        return result;
    }
}
