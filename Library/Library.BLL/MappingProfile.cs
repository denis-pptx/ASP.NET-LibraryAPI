using AutoMapper;
using Library.BLL.Models.DTOs;
using Library.Domain.Entities;

namespace Library.BLL;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AuthorDto, Author>().ReverseMap();
        CreateMap<GenreDto, Genre>().ReverseMap();
    }
}
