namespace Library.DAL.Data.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.Navigation(b => b.Author).AutoInclude();
        builder.Navigation(b => b.Genre).AutoInclude();

        builder.HasKey(x => x.Id);

        builder.Property(x => x.ISBN)
            .HasMaxLength(30)
            .IsRequired();

        builder.HasIndex(x => x.ISBN)
            .IsUnique();

        builder.Property(x => x.Name)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(x => x.Description)
            .HasMaxLength(300);

        builder.HasOne(x => x.Genre)
            .WithMany()
            .HasForeignKey(x => x.GenreId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Author)
            .WithMany()
            .HasForeignKey(x => x.AuthorId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
