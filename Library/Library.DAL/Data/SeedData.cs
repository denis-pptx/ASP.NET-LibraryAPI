namespace Library.DAL.Data;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        SeedUsers(modelBuilder);
        SeedGenres(modelBuilder);
        SeedAuthors(modelBuilder);
        SeedBooks(modelBuilder);
    }

    private static void SeedUsers(ModelBuilder modelBuilder)
    {
        var users = new[]
        {
            new User 
            { 
                Id = 1, 
                Login = "admin", 
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin") 
            }
        };

        modelBuilder.Entity<User>().HasData(users);
    }

    private static void SeedGenres(ModelBuilder modelBuilder)
    {
        var genres = new[]
        {
            new Genre { Id = 1, Name = "Science Fiction" },
            new Genre { Id = 2, Name = "Romance" },
            new Genre { Id = 3, Name = "Mystery" },
            new Genre { Id = 4, Name = "Thriller" },
            new Genre { Id = 5, Name = "Fantasy" },
            new Genre { Id = 6, Name = "Historical Fiction" },
            new Genre { Id = 7, Name = "Biography" },
            new Genre { Id = 8, Name = "Poetry" },
            new Genre { Id = 9, Name = "Science" },
            new Genre { Id = 10, Name = "Self-Help" },
        };

        modelBuilder.Entity<Genre>().HasData(genres);
    }

    private static void SeedAuthors(ModelBuilder modelBuilder)
    {
        var authors = new[]
        {
            new Author { Id = 1, Name = "John Doe" },
            new Author { Id = 2, Name = "Jane Smith" },
            new Author { Id = 3, Name = "Robert Johnson" },
            new Author { Id = 4, Name = "Emily White" },
            new Author { Id = 5, Name = "Michael Brown" },
            new Author { Id = 6, Name = "Amanda Davis" },
            new Author { Id = 7, Name = "Christopher Wilson" },
            new Author { Id = 8, Name = "Sophia Turner" },
            new Author { Id = 9, Name = "Daniel Miller" },
            new Author { Id = 10, Name = "Olivia Clark" },
        };

        modelBuilder.Entity<Author>().HasData(authors);
    }

    private static void SeedBooks(ModelBuilder modelBuilder)
    {
        var books = new[]
        {
            new Book
            {
                Id = 1,
                ISBN = "1234567890",
                Name = "The Galactic Odyssey",
                GenreId = 1,
                AuthorId = 1,
                CaptureDate = DateTime.Now.AddDays(-30),
                ReturnDate = DateTime.Now.AddDays(30)
            },
            new Book
            {
                Id = 2,
                ISBN = "0987654321",
                Name = "Love Beyond Stars",
                GenreId = 2,
                AuthorId = 2,
                CaptureDate = DateTime.Now.AddDays(-20),
                ReturnDate = DateTime.Now.AddDays(40)
            },
            new Book
            {
                Id = 3,
                ISBN = "2345678901",
                Name = "Whispers in the Shadows",
                GenreId = 3,
                AuthorId = 3,
                CaptureDate = DateTime.Now.AddDays(-10),
                ReturnDate = DateTime.Now.AddDays(50)
            },
            new Book
            {
                Id = 4,
                ISBN = "3456789012",
                Name = "Thrill Seeker",
                GenreId = 4,
                AuthorId = 4,
                CaptureDate = DateTime.Now.AddDays(-15),
                ReturnDate = DateTime.Now.AddDays(35)
            },
            new Book
            {
                Id = 5,
                ISBN = "4567890123",
                Name = "Realm of Dreams",
                GenreId = 5,
                AuthorId = 5,
                CaptureDate = DateTime.Now.AddDays(-25),
                ReturnDate = DateTime.Now.AddDays(45)
            },
            new Book
            {
                Id = 6,
                ISBN = "5678901234",
                Name = "Time Traveler's Journal",
                GenreId = 6,
                AuthorId = 6,
                CaptureDate = DateTime.Now.AddDays(-5),
                ReturnDate = DateTime.Now.AddDays(55)
            },
            new Book
            {
                Id = 7,
                ISBN = "6789012345",
                Name = "Inspirations",
                GenreId = 7,
                AuthorId = 7,
                CaptureDate = DateTime.Now.AddDays(-12),
                ReturnDate = DateTime.Now.AddDays(42)
            },
            new Book
            {
                Id = 8,
                ISBN = "7890123456",
                Name = "Verses of the Soul",
                GenreId = 8,
                AuthorId = 8,
                CaptureDate = DateTime.Now.AddDays(-18),
                ReturnDate = DateTime.Now.AddDays(48)
            },
            new Book
            {
                Id = 9,
                ISBN = "8901234567",
                Name = "Wonders of Science",
                GenreId = 9,
                AuthorId = 9,
                CaptureDate = DateTime.Now.AddDays(-8),
                ReturnDate = DateTime.Now.AddDays(38)
            },
            new Book
            {
                Id = 10,
                ISBN = "9012345678",
                Name = "The Power Within",
                GenreId = 10,
                AuthorId = 10,
                CaptureDate = DateTime.Now.AddDays(-22),
                ReturnDate = DateTime.Now.AddDays(32)
            },
            new Book
            {
                Id = 11,
                ISBN = "1122334455",
                Name = "Epic Journey",
                GenreId = 1,
                AuthorId = 2,
                CaptureDate = DateTime.Now.AddDays(-35),
                ReturnDate = DateTime.Now.AddDays(25)
            },
            new Book
            {
                Id = 12,
                ISBN = "5544332211",
                Name = "Enchanted Love",
                GenreId = 2,
                AuthorId = 3,
                CaptureDate = DateTime.Now.AddDays(-15),
                ReturnDate = DateTime.Now.AddDays(30)
            },
            new Book
            {
                Id = 13,
                ISBN = "9876543210",
                Name = "Secrets Unveiled",
                GenreId = 3,
                AuthorId = 4,
                CaptureDate = DateTime.Now.AddDays(-25),
                ReturnDate = DateTime.Now.AddDays(40)
            },
            new Book
            {
                Id = 14,
                ISBN = "1122334455",
                Name = "Mind Games",
                GenreId = 4,
                AuthorId = 5,
                CaptureDate = DateTime.Now.AddDays(-20),
                ReturnDate = DateTime.Now.AddDays(35)
            },
            new Book
            {
                Id = 15,
                ISBN = "3344556677",
                Name = "Mythical Realms",
                GenreId = 5,
                AuthorId = 6,
                CaptureDate = DateTime.Now.AddDays(-30),
                ReturnDate = DateTime.Now.AddDays(45)
            },
            new Book
            {
                Id = 16,
                ISBN = "7788990011",
                Name = "Era of Kings",
                GenreId = 6,
                AuthorId = 7,
                CaptureDate = DateTime.Now.AddDays(-10),
                ReturnDate = DateTime.Now.AddDays(50)
            },
            new Book
            {
                Id = 17,
                ISBN = "2233445566",
                Name = "Journey to Enlightenment",
                GenreId = 7,
                AuthorId = 8,
                CaptureDate = DateTime.Now.AddDays(-22),
                ReturnDate = DateTime.Now.AddDays(32)
            },
            new Book
            {
                Id = 18,
                ISBN = "6677889900",
                Name = "Whispers of Nature",
                GenreId = 8,
                AuthorId = 9,
                CaptureDate = DateTime.Now.AddDays(-18),
                ReturnDate = DateTime.Now.AddDays(38)
            },
            new Book
            {
                Id = 19,
                ISBN = "1122334455",
                Name = "Scientific Discoveries",
                GenreId = 9,
                AuthorId = 10,
                CaptureDate = DateTime.Now.AddDays(-12),
                ReturnDate = DateTime.Now.AddDays(42)
            },
            new Book
            {
                Id = 20,
                ISBN = "3344556677",
                Name = "The Mindful Journey",
                GenreId = 10,
                AuthorId = 1,
                CaptureDate = DateTime.Now.AddDays(-8),
                ReturnDate = DateTime.Now.AddDays(48)
            },
        };

        modelBuilder.Entity<Book>().HasData(books);
    }
}
