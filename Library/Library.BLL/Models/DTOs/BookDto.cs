namespace Library.BLL.Models.DTOs;

public class BookDto
{
    public int Id { get; set; }
    public string ISBN { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }

    public DateTime? CaptureDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public int GenreId { get; set; }
    public int AuthorId { get; set; }
}
