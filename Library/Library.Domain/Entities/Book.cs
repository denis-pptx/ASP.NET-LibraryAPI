namespace Library.Domain.Entities;

public class Book : Entity
{
    public string ISBN { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public DateOnly? CaptureDate { get; set; }
    public DateOnly? ReturnDate { get; set; }

    public int GenreId { get; set; }
    public int AuthorId { get; set; }
}
