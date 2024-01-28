namespace Library.BLL;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AuthorDto, Author>().ReverseMap();

        CreateMap<GenreDto, Genre>().ReverseMap();

        CreateMap<BookDto, Book>().ReverseMap();

        CreateMap<UserDto, User>()
            .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.Password));

        CreateMap<User, UserDto>()
            .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.PasswordHash));
    }
}
