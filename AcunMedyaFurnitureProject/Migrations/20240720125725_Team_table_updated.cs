using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcunMedyaFurnitureProject.Migrations
{
    public partial class Team_table_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Açıklama",
                table: "Teams",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Teams",
                newName: "Açıklama");
        }
    }
}
