using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FestivalApplication.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artiest",
                columns: table => new
                {
                    ArtiestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Beschrijving = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Spotify = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artiest", x => x.ArtiestId);
                });

            migrationBuilder.CreateTable(
                name: "Gebruiker",
                columns: table => new
                {
                    GebruikerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Voornaam = table.Column<string>(nullable: false),
                    Gebruikersnaam = table.Column<string>(nullable: false),
                    Geboortedatum = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Telefoonnummer = table.Column<string>(nullable: false),
                    Straatnaam = table.Column<string>(nullable: false),
                    Huisnummer = table.Column<int>(nullable: false),
                    Postcode = table.Column<int>(nullable: false),
                    Dorp = table.Column<string>(nullable: false),
                    IsAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.GebruikerId);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    StageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.StageId);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Prijs = table.Column<int>(nullable: false),
                    Beschrijving = table.Column<string>(nullable: false),
                    ArtiestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Artiest_ArtiestId",
                        column: x => x.ArtiestId,
                        principalTable: "Artiest",
                        principalColumn: "ArtiestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factuur",
                columns: table => new
                {
                    FactuurId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GebruikerId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factuur", x => x.FactuurId);
                    table.ForeignKey(
                        name: "FK_Factuur_Gebruiker_GebruikerId",
                        column: x => x.GebruikerId,
                        principalTable: "Gebruiker",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtiestGenre",
                columns: table => new
                {
                    ArtiestGenreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtiestId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtiestGenre", x => x.ArtiestGenreId);
                    table.ForeignKey(
                        name: "FK_ArtiestGenre_Artiest_ArtiestId",
                        column: x => x.ArtiestId,
                        principalTable: "Artiest",
                        principalColumn: "ArtiestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtiestGenre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtiestDatum",
                columns: table => new
                {
                    ArtiestDatumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtiestId = table.Column<int>(nullable: false),
                    StageId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Beginuur = table.Column<string>(nullable: false),
                    Einduur = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtiestDatum", x => x.ArtiestDatumId);
                    table.ForeignKey(
                        name: "FK_ArtiestDatum_Artiest_ArtiestId",
                        column: x => x.ArtiestId,
                        principalTable: "Artiest",
                        principalColumn: "ArtiestId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtiestDatum_Stage_StageId",
                        column: x => x.StageId,
                        principalTable: "Stage",
                        principalColumn: "StageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactuurProduct",
                columns: table => new
                {
                    FactuurProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactuurId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Aantal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactuurProduct", x => x.FactuurProductId);
                    table.ForeignKey(
                        name: "FK_FactuurProduct_Factuur_FactuurId",
                        column: x => x.FactuurId,
                        principalTable: "Factuur",
                        principalColumn: "FactuurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FactuurProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtiestDatum_ArtiestId",
                table: "ArtiestDatum",
                column: "ArtiestId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtiestDatum_StageId",
                table: "ArtiestDatum",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtiestGenre_ArtiestId",
                table: "ArtiestGenre",
                column: "ArtiestId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtiestGenre_GenreId",
                table: "ArtiestGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Factuur_GebruikerId",
                table: "Factuur",
                column: "GebruikerId");

            migrationBuilder.CreateIndex(
                name: "IX_FactuurProduct_FactuurId",
                table: "FactuurProduct",
                column: "FactuurId");

            migrationBuilder.CreateIndex(
                name: "IX_FactuurProduct_ProductId",
                table: "FactuurProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ArtiestId",
                table: "Product",
                column: "ArtiestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtiestDatum");

            migrationBuilder.DropTable(
                name: "ArtiestGenre");

            migrationBuilder.DropTable(
                name: "FactuurProduct");

            migrationBuilder.DropTable(
                name: "Stage");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Factuur");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Gebruiker");

            migrationBuilder.DropTable(
                name: "Artiest");
        }
    }
}
