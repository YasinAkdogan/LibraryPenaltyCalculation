using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryPenaltyCalculation.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weekend = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weekend2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NationalHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HolidayName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NationalHolidays_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Currency", "Name", "Weekend", "Weekend2" },
                values: new object[] { 1, "₺", "Turkey", "Saturday", "Sunday" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Currency", "Name", "Weekend", "Weekend2" },
                values: new object[] { 2, "د.إ", "Dubai", "Friday", "Saturday" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Currency", "Name", "Weekend", "Weekend2" },
                values: new object[] { 3, "$", "United States", "Saturday", "Sunday" });

            migrationBuilder.InsertData(
                table: "NationalHolidays",
                columns: new[] { "Id", "CountryId", "Date", "HolidayName" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yılbaşı" },
                    { 23, 2, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurban Bayramı" },
                    { 24, 2, new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurban Bayramı" },
                    { 25, 2, new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurban Bayramı" },
                    { 26, 2, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hac Mevsimi Başlıyor" },
                    { 27, 2, new DateTime(2022, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eylül Ekinoksu" },
                    { 28, 2, new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anma Günü" },
                    { 29, 2, new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ulusal Günü" },
                    { 22, 2, new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurban Bayramı" },
                    { 30, 2, new DateTime(2022, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aralık Gün Dönümü" },
                    { 32, 3, new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noel" },
                    { 33, 3, new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Şükran Günü" },
                    { 34, 3, new DateTime(2022, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ulusal Bağımsızlık günü" },
                    { 35, 3, new DateTime(2022, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martin Luther King Günü" },
                    { 36, 3, new DateTime(2022, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Başkan’nın Günü" },
                    { 37, 3, new DateTime(2022, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Şehitler Günü" },
                    { 38, 3, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "İşçi Bayramı" },
                    { 31, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yılbaşı" },
                    { 39, 3, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombus Günü" },
                    { 21, 2, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramazan Bayramı" },
                    { 19, 2, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramazan Bayramı" },
                    { 2, 1, new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ulusal Egemenlik ve Çocuk Bayramı" },
                    { 3, 1, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emek ve Dayanışma Günü" },
                    { 4, 1, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramazan Bayramı" },
                    { 5, 1, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramazan Bayramı" },
                    { 6, 1, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramazan Bayramı" },
                    { 7, 1, new DateTime(2022, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Atatürk'ü Anma, Gençlik ve Spor Bayramı" },
                    { 8, 1, new DateTime(2022, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurban Bayramı" },
                    { 20, 2, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ramazan Bayramı" },
                    { 9, 1, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurban Bayramı" },
                    { 11, 1, new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurban Bayramı" },
                    { 12, 1, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Demokrasi Bayramı" },
                    { 13, 1, new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zafer Bayramı" },
                    { 14, 1, new DateTime(2022, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cumhuriyet Bayramı" },
                    { 15, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yılbaşı" },
                    { 17, 2, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peygamberin Yükselişi" },
                    { 18, 2, new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mart Ekinoksu" },
                    { 10, 1, new DateTime(2022, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kurban Bayramı" },
                    { 40, 3, new DateTime(2022, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Veterans (Armistice) Günü" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NationalHolidays_CountryId",
                table: "NationalHolidays",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationalHolidays");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
