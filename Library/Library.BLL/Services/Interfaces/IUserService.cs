namespace Library.BLL.Services.Interfaces;

public interface IUserService : IBaseService<User, UserDto>
{
    Task<User> GetByLoginAsync(string login);
}
