namespace Library.BLL.Services.Interfaces;

public interface IAuthorService
{
    Task<Author> CreateAuthorAsync(AuthorDto authorDto);
    Task<IEnumerable<Author>> GetAuthorsAsync();
    Task<Author> GetAuthorByIdAsync(int id);
    Task<Author> UpdateAuthorAsync(int id, AuthorDto authorDto);
    Task<Author> DeleteAuthorByIdAsync(int id);
}
