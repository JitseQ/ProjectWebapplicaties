using Microsoft.EntityFrameworkCore.Migrations;

namespace FestivalApplication.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Afbeelding",
                table: "Artiest",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Afbeelding",
                table: "Artiest");
        }
    }
}
