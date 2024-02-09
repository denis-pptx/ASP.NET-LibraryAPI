namespace Library.BLL.Services.Interfaces;

public interface IUserService : IBaseService<User, UserDto>
{
    Task<User> GetByLoginAsync(string login, CancellationToken token = default);
    string CreateToken(User user);
}
