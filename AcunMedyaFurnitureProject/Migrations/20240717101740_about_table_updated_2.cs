using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcunMedyaFurnitureProject.Migrations
{
    public partial class about_table_updated_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Image3",
                table: "Abouts");

            migrationBuilder.AddColumn<string>(
                name: "Item1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Item2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Item3",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Item4",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Item1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Item2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Item3",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Item4",
                table: "Abouts");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image3",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
