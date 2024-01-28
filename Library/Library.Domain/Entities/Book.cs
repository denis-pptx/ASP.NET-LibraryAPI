namespace Library.Domain.Entities;

public class Book : Entity
{
    public string ISBN { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public DateTime? CaptureDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public int GenreId { get; set; }
    public Genre? Genre { get; set; }

    public int AuthorId { get; set; }
    public Author? Author { get; set; }
}
