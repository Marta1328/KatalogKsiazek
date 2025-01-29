using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FidoJedrzejczak.KatalogKsiazek.DAO.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ksiazki",
                columns: table => new
                {
                    KsiazkaID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tytul = table.Column<string>(type: "TEXT", nullable: false),
                    Autor = table.Column<string>(type: "TEXT", nullable: false),
                    RokWydania = table.Column<int>(type: "INTEGER", nullable: false),
                    Wydawnictwo = table.Column<int>(type: "INTEGER", nullable: false),
                    Cena = table.Column<decimal>(type: "TEXT", nullable: false),
                    Typ = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ksiazki", x => x.KsiazkaID);
                });

            migrationBuilder.InsertData(
                table: "Ksiazki",
                columns: new[] { "KsiazkaID", "Autor", "Cena", "RokWydania", "Typ", "Tytul", "Wydawnictwo" },
                values: new object[,]
                {
                    { 1, "Jan Kowalski", 29.99m, 2000, 0, "Pierwsza Książka", 1 },
                    { 2, "Anna Nowak", 39.99m, 2015, 1, "Druga Książka", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ksiazki");
        }
    }
}
