using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FestivalApplication.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtiestDatum",
                columns: table => new
                {
                    ArtiestDatumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(nullable: false),
                    Beginuur = table.Column<string>(nullable: true),
                    Einduur = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtiestDatum", x => x.ArtiestDatumId);
                });

            migrationBuilder.CreateTable(
                name: "ArtiestGenre",
                columns: table => new
                {
                    ArtiestGenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtiestGenre", x => x.ArtiestGenreId);
                });

            migrationBuilder.CreateTable(
                name: "FactuurProduct",
                columns: table => new
                {
                    FactuurProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aantal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactuurProduct", x => x.FactuurProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    StageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    ArtiestDatumId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.StageId);
                    table.ForeignKey(
                        name: "FK_Stage_ArtiestDatum_ArtiestDatumId",
                        column: x => x.ArtiestDatumId,
                        principalTable: "ArtiestDatum",
                        principalColumn: "ArtiestDatumId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    ArtiestGenreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                    table.ForeignKey(
                        name: "FK_Genre_ArtiestGenre_ArtiestGenreId",
                        column: x => x.ArtiestGenreId,
                        principalTable: "ArtiestGenre",
                        principalColumn: "ArtiestGenreId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Factuur",
                columns: table => new
                {
                    FactuurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(nullable: false),
                    FactuurProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factuur", x => x.FactuurId);
                    table.ForeignKey(
                        name: "FK_Factuur_FactuurProduct_FactuurProductId",
                        column: x => x.FactuurProductId,
                        principalTable: "FactuurProduct",
                        principalColumn: "FactuurProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    Prijs = table.Column<int>(nullable: false),
                    Beschrijving = table.Column<string>(nullable: true),
                    FactuurProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_FactuurProduct_FactuurProductId",
                        column: x => x.FactuurProductId,
                        principalTable: "FactuurProduct",
                        principalColumn: "FactuurProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Gebruiker",
                columns: table => new
                {
                    GebruikerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    Voornaam = table.Column<string>(nullable: true),
                    Gebruikersnaam = table.Column<string>(nullable: true),
                    Geboortedatum = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Telefoonnummer = table.Column<int>(nullable: false),
                    Huisnummer = table.Column<int>(nullable: false),
                    Postcode = table.Column<int>(nullable: false),
                    Dorp = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    FactuurId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.GebruikerId);
                    table.ForeignKey(
                        name: "FK_Gebruiker_Factuur_FactuurId",
                        column: x => x.FactuurId,
                        principalTable: "Factuur",
                        principalColumn: "FactuurId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Artiest",
                columns: table => new
                {
                    ArtiestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    Beschrijving = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Spotify = table.Column<string>(nullable: true),
                    ArtiestDatumId = table.Column<int>(nullable: true),
                    ArtiestGenreId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artiest", x => x.ArtiestId);
                    table.ForeignKey(
                        name: "FK_Artiest_ArtiestDatum_ArtiestDatumId",
                        column: x => x.ArtiestDatumId,
                        principalTable: "ArtiestDatum",
                        principalColumn: "ArtiestDatumId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artiest_ArtiestGenre_ArtiestGenreId",
                        column: x => x.ArtiestGenreId,
                        principalTable: "ArtiestGenre",
                        principalColumn: "ArtiestGenreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artiest_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artiest_ArtiestDatumId",
                table: "Artiest",
                column: "ArtiestDatumId");

            migrationBuilder.CreateIndex(
                name: "IX_Artiest_ArtiestGenreId",
                table: "Artiest",
                column: "ArtiestGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Artiest_ProductId",
                table: "Artiest",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Factuur_FactuurProductId",
                table: "Factuur",
                column: "FactuurProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Gebruiker_FactuurId",
                table: "Gebruiker",
                column: "FactuurId");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_ArtiestGenreId",
                table: "Genre",
                column: "ArtiestGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_FactuurProductId",
                table: "Product",
                column: "FactuurProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_ArtiestDatumId",
                table: "Stage",
                column: "ArtiestDatumId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artiest");

            migrationBuilder.DropTable(
                name: "Gebruiker");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Stage");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Factuur");

            migrationBuilder.DropTable(
                name: "ArtiestGenre");

            migrationBuilder.DropTable(
                name: "ArtiestDatum");

            migrationBuilder.DropTable(
                name: "FactuurProduct");
        }
    }
}
