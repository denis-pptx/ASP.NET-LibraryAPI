namespace Library.BLL;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<AuthorDto, Author>().ReverseMap();

        CreateMap<GenreDto, Genre>().ReverseMap();

        CreateMap<BookDto, Book>().ReverseMap();
    }
}
