using AutoMapper;
using Library.BLL.Exceptions;
using Library.BLL.Models.DTOs;
using Library.BLL.Services.Interfaces;
using Library.DAL.Repositories.Interfaces;
using Library.Domain.Entities;
using System.Net;

namespace Library.BLL.Services.Implementations;

public class GenreService(IRepository<Genre> genreRepository, IMapper mapper)
    : IGenreService
{
    private readonly IRepository<Genre> _genreRepository = genreRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<GenreDto> CreateGenreAsync(GenreDto genreDto)
    {
        var genre = _mapper.Map<Genre>(genreDto);
        var result = await _genreRepository.AddAsync(genre);

        return _mapper.Map<GenreDto>(result);
    }

    public async Task<GenreDto> GetGenreByIdAsync(int id)
    {
        if (!await _genreRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Genre is not found");
        }

        var genre = await _genreRepository.GetByIdAsync(id);
        return _mapper.Map<GenreDto>(genre);
    }

    public async Task<IEnumerable<GenreDto>> GetGenresAsync()
    {
        var genres = await _genreRepository.GetAsync();

        return _mapper.Map<IEnumerable<GenreDto>>(genres);
    }

    public async Task<GenreDto> UpdateGenreAsync(int id, GenreDto genreDto)
    {
        if (!await _genreRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Genre is not found");
        }

        var genre = await _genreRepository.GetByIdAsync(id);

        genreDto.Id = id;
        _mapper.Map(genreDto, genre);

        var result = await _genreRepository.UpdateAsync(genre);

        return _mapper.Map<GenreDto>(result);
    }

    public async Task<GenreDto> DeleteGenreByIdAsync(int id)
    {
        if (!await _genreRepository.IsExistsAsync(id))
        {
            throw new ApiException(HttpStatusCode.NotFound, "Genre is not found");
        }

        var genre = await _genreRepository.GetByIdAsync(id);
        await _genreRepository.DeleteAsync(genre);

        return _mapper.Map<GenreDto>(genre);
    }
}
