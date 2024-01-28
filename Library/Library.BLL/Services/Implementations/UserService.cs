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


    public async Task<User> GetByLoginAsync(string login)
    {
        var user = await _entityRepository.SingleOrDefaultAsync(x => x.Login == login);
        if (user == null)
        {
            throw new ApiException(HttpStatusCode.BadRequest, "Invalid login or password");
        }

        return user;
    }
}
