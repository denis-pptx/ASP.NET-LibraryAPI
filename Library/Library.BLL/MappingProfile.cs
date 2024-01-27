using AutoMapper;
using Library.BLL.Models.DTO;
using Library.Domain.Entities;

namespace Library.BLL;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AuthorDto, Author>().ReverseMap();
    }
}
