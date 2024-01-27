using Library.BLL.Models.DTO;

namespace Library.BLL.Services.Interfaces;

public interface IAuthorService
{
    Task<AuthorDto> CreateAuthorAsync(AuthorDto authorDto);

    Task<IEnumerable<AuthorDto>> GetAuthorsAsync();

    Task<AuthorDto> GetAuthorByIdAsync(int id);
}
