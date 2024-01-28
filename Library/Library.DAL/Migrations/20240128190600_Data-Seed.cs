using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "John Doe" },
                    { 2, "Jane Smith" },
                    { 3, "Robert Johnson" },
                    { 4, "Emily White" },
                    { 5, "Michael Brown" },
                    { 6, "Amanda Davis" },
                    { 7, "Christopher Wilson" },
                    { 8, "Sophia Turner" },
                    { 9, "Daniel Miller" },
                    { 10, "Olivia Clark" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Science Fiction" },
                    { 2, "Romance" },
                    { 3, "Mystery" },
                    { 4, "Thriller" },
                    { 5, "Fantasy" },
                    { 6, "Historical Fiction" },
                    { 7, "Biography" },
                    { 8, "Poetry" },
                    { 9, "Science" },
                    { 10, "Self-Help" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CaptureDate", "Description", "GenreId", "ISBN", "Name", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 29, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1933), null, 1, "1234567890", "The Galactic Odyssey", new DateTime(2024, 2, 27, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1953) },
                    { 2, 2, new DateTime(2024, 1, 8, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1955), null, 2, "0987654321", "Love Beyond Stars", new DateTime(2024, 3, 8, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1956) },
                    { 3, 3, new DateTime(2024, 1, 18, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1957), null, 3, "2345678901", "Whispers in the Shadows", new DateTime(2024, 3, 18, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1958) },
                    { 4, 4, new DateTime(2024, 1, 13, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1959), null, 4, "3456789012", "Thrill Seeker", new DateTime(2024, 3, 3, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1960) },
                    { 5, 5, new DateTime(2024, 1, 3, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1961), null, 5, "4567890123", "Realm of Dreams", new DateTime(2024, 3, 13, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1961) },
                    { 6, 6, new DateTime(2024, 1, 23, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1963), null, 6, "5678901234", "Time Traveler's Journal", new DateTime(2024, 3, 23, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1963) },
                    { 7, 7, new DateTime(2024, 1, 16, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1965), null, 7, "6789012345", "Inspirations", new DateTime(2024, 3, 10, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1965) },
                    { 8, 8, new DateTime(2024, 1, 10, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1967), null, 8, "7890123456", "Verses of the Soul", new DateTime(2024, 3, 16, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1967) },
                    { 9, 9, new DateTime(2024, 1, 20, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1968), null, 9, "8901234567", "Wonders of Science", new DateTime(2024, 3, 6, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1969) },
                    { 10, 10, new DateTime(2024, 1, 6, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1970), null, 10, "9012345678", "The Power Within", new DateTime(2024, 2, 29, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1971) },
                    { 11, 2, new DateTime(2023, 12, 24, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1972), null, 1, "1122334455", "Epic Journey", new DateTime(2024, 2, 22, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1972) },
                    { 12, 3, new DateTime(2024, 1, 13, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1974), null, 2, "5544332211", "Enchanted Love", new DateTime(2024, 2, 27, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1974) },
                    { 13, 4, new DateTime(2024, 1, 3, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1975), null, 3, "9876543210", "Secrets Unveiled", new DateTime(2024, 3, 8, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1976) },
                    { 14, 5, new DateTime(2024, 1, 8, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1977), null, 4, "1122334455", "Mind Games", new DateTime(2024, 3, 3, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1977) },
                    { 15, 6, new DateTime(2023, 12, 29, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1979), null, 5, "3344556677", "Mythical Realms", new DateTime(2024, 3, 13, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1979) },
                    { 16, 7, new DateTime(2024, 1, 18, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1980), null, 6, "7788990011", "Era of Kings", new DateTime(2024, 3, 18, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1981) },
                    { 17, 8, new DateTime(2024, 1, 6, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1982), null, 7, "2233445566", "Journey to Enlightenment", new DateTime(2024, 2, 29, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1983) },
                    { 18, 9, new DateTime(2024, 1, 10, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1984), null, 8, "6677889900", "Whispers of Nature", new DateTime(2024, 3, 6, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1984) },
                    { 19, 10, new DateTime(2024, 1, 16, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1985), null, 9, "1122334455", "Scientific Discoveries", new DateTime(2024, 3, 10, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1986) },
                    { 20, 1, new DateTime(2024, 1, 20, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1987), null, 10, "3344556677", "The Mindful Journey", new DateTime(2024, 3, 16, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1987) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
