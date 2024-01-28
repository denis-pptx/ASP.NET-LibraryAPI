using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DataSeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 29, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7422), new DateTime(2024, 2, 27, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 8, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7444), new DateTime(2024, 3, 8, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 18, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7447), new DateTime(2024, 3, 18, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7449), new DateTime(2024, 3, 3, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 3, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7450), new DateTime(2024, 3, 13, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7492), new DateTime(2024, 3, 23, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 16, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7494), new DateTime(2024, 3, 10, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 3, 16, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 20, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 3, 6, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 6, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 2, 29, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 24, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 2, 22, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7503), new DateTime(2024, 2, 27, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 3, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7505), new DateTime(2024, 3, 8, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 8, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7507), new DateTime(2024, 3, 3, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 29, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7509), new DateTime(2024, 3, 13, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 18, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 3, 18, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 6, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7513), new DateTime(2024, 2, 29, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7514), new DateTime(2024, 3, 6, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 16, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 3, 10, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 20, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7518), new DateTime(2024, 3, 16, 22, 10, 52, 914, DateTimeKind.Local).AddTicks(7519) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Login", "PasswordHash" },
                values: new object[] { 1, "admin", "$2a$11$G28u7EHEJ8HPvATIii1DRuLLd7LcAmMNKZY./2EsXCOb1wKvbgbGi" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 29, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1933), new DateTime(2024, 2, 27, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 8, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1955), new DateTime(2024, 3, 8, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 18, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1957), new DateTime(2024, 3, 18, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1959), new DateTime(2024, 3, 3, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 3, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1961), new DateTime(2024, 3, 13, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 23, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1963), new DateTime(2024, 3, 23, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 16, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1965), new DateTime(2024, 3, 10, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1967), new DateTime(2024, 3, 16, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 20, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1968), new DateTime(2024, 3, 6, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 6, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1970), new DateTime(2024, 2, 29, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 24, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1972), new DateTime(2024, 2, 22, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1974), new DateTime(2024, 2, 27, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 3, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1975), new DateTime(2024, 3, 8, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 8, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1977), new DateTime(2024, 3, 3, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2023, 12, 29, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1979), new DateTime(2024, 3, 13, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 18, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1980), new DateTime(2024, 3, 18, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 6, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1982), new DateTime(2024, 2, 29, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1984), new DateTime(2024, 3, 6, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 16, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1985), new DateTime(2024, 3, 10, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CaptureDate", "ReturnDate" },
                values: new object[] { new DateTime(2024, 1, 20, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1987), new DateTime(2024, 3, 16, 22, 5, 59, 751, DateTimeKind.Local).AddTicks(1987) });
        }
    }
}
