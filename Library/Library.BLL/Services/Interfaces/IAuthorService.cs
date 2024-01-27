using Library.BLL.Models.DTOs;

namespace Library.BLL.Services.Interfaces;

public interface IAuthorService
{
    Task<AuthorDto> CreateAuthorAsync(AuthorDto authorDto);
    Task<IEnumerable<AuthorDto>> GetAuthorsAsync();
    Task<AuthorDto> GetAuthorByIdAsync(int id);
    Task<AuthorDto> UpdateAuthorAsync(int id, AuthorDto authorDto);
    Task<AuthorDto> DeleteAuthorByIdAsync(int id);
}
