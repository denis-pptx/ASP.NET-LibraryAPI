using Library.BLL.Models.DTOs;

namespace Library.BLL.Services.Interfaces;

public interface IGenreService
{
    Task<GenreDto> CreateGenreAsync(GenreDto genreDto);
    Task<IEnumerable<GenreDto>> GetGenresAsync();
    Task<GenreDto> GetGenreByIdAsync(int id);
    Task<GenreDto> UpdateGenreAsync(int id, GenreDto genreDto);
    Task<GenreDto> DeleteGenreByIdAsync(int id);
}
