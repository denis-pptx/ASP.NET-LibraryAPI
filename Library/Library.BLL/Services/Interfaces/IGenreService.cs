using Library.BLL.Models.DTOs;
using Library.Domain.Entities;

namespace Library.BLL.Services.Interfaces;

public interface IGenreService
{
    Task<Genre> CreateGenreAsync(GenreDto genreDto);
    Task<IEnumerable<Genre>> GetGenresAsync();
    Task<Genre> GetGenreByIdAsync(int id);
    Task<Genre> UpdateGenreAsync(int id, GenreDto genreDto);
    Task<Genre> DeleteGenreByIdAsync(int id);
}
