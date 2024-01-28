using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Login = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ISBN = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true),
                    CaptureDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    GenreId = table.Column<int>(type: "INTEGER", nullable: false),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                table: "User",
                columns: new[] { "Id", "Login", "PasswordHash" },
                values: new object[] { 1, "admin", "$2a$11$fJlETe9LRWppe9/hAhuURuhh1f861OhsUeth8geFDW6k3k4BwMbMS" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CaptureDate", "Description", "GenreId", "ISBN", "Name", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 12, 29, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(5), "A thrilling journey through the galaxy.", 1, "011234567891223", "The Galactic Odyssey", new DateTime(2024, 2, 27, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(23) },
                    { 2, 6, new DateTime(2024, 1, 8, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(25), "Exploring the realms of love beyond the stars.", 2, "301234567891423", "Love Beyond Stars", new DateTime(2024, 3, 8, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(26) },
                    { 3, 8, new DateTime(2024, 1, 18, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(27), null, 8, "051234567869123", "Whispers in the Shadows", new DateTime(2024, 3, 18, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(28) },
                    { 4, 6, new DateTime(2024, 1, 13, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(29), null, 3, "012346567891273", "Thrill Seeker", new DateTime(2024, 3, 3, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(30) },
                    { 5, 1, new DateTime(2024, 1, 3, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(31), null, 10, "01234567899123", "Realm of Dreams", new DateTime(2024, 3, 13, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(31) },
                    { 6, 8, new DateTime(2024, 1, 23, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(33), null, 2, "012345367891523", "Time Traveler's Journal", new DateTime(2024, 3, 23, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(33) },
                    { 7, 9, new DateTime(2024, 1, 16, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(35), null, 9, "012234567189123", "Inspirations", new DateTime(2024, 3, 10, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(35) },
                    { 8, 9, new DateTime(2024, 1, 10, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(36), null, 4, "012345679289123", "Verses of the Soul", new DateTime(2024, 3, 16, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(37) },
                    { 9, 3, new DateTime(2024, 1, 20, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(38), null, 2, "01234597566789123", "Wonders of Science", new DateTime(2024, 3, 6, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(39) },
                    { 10, 6, new DateTime(2024, 1, 6, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(40), null, 1, "240123456789123", "The Power Within", new DateTime(2024, 2, 29, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(40) },
                    { 11, 4, new DateTime(2023, 12, 24, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(42), "An epic adventure with twists and turns.", 2, "012683456789123", "Epic Journey", new DateTime(2024, 2, 22, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(42) },
                    { 12, 9, new DateTime(2024, 1, 13, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(43), "A magical tale of enchanted love.", 7, "0123456789124123", "Enchanted Love", new DateTime(2024, 2, 27, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(44) },
                    { 13, 2, new DateTime(2024, 1, 3, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(45), null, 10, "0123459856789123", "Secrets Unveiled", new DateTime(2024, 3, 8, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(46) },
                    { 14, 7, new DateTime(2024, 1, 8, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(47), null, 5, "0121453456789123", "Mind Games", new DateTime(2024, 3, 3, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(47) },
                    { 15, 6, new DateTime(2023, 12, 29, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(48), null, 5, "0123484567891232", "Mythical Realms", new DateTime(2024, 3, 13, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(49) },
                    { 16, 7, new DateTime(2024, 1, 18, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(50), null, 1, "01234567891236412", "Era of Kings", new DateTime(2024, 3, 18, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(51) },
                    { 17, 7, new DateTime(2024, 1, 6, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(52), null, 4, "1240123456789123", "Journey to Enlightenment", new DateTime(2024, 2, 29, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(52) },
                    { 18, 6, new DateTime(2024, 1, 10, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(54), null, 8, "0122345637189123", "Whispers of Nature", new DateTime(2024, 3, 6, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(54) },
                    { 19, 7, new DateTime(2024, 1, 16, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(55), null, 8, "10122324567891623", "Scientific Discoveries", new DateTime(2024, 3, 10, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(56) },
                    { 20, 6, new DateTime(2024, 1, 20, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(57), "Embark on a mindful journey of self-discovery.", 3, "0123456789123555", "The Mindful Journey", new DateTime(2024, 3, 16, 23, 6, 39, 288, DateTimeKind.Local).AddTicks(58) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Name",
                table: "Authors",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ISBN",
                table: "Books",
                column: "ISBN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_Name",
                table: "Genres",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Login",
                table: "User",
                column: "Login",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
