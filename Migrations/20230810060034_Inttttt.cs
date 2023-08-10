using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Person.Migrations
{
    public partial class Inttttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Playing",
                table: "Families");

            migrationBuilder.DropColumn(
                name: "Reading",
                table: "Families");

            migrationBuilder.DropColumn(
                name: "Singing",
                table: "Families");

            migrationBuilder.AddColumn<string>(
                name: "Hobbies",
                table: "Families",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hobbies",
                table: "Families");

            migrationBuilder.AddColumn<bool>(
                name: "Playing",
                table: "Families",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Reading",
                table: "Families",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Singing",
                table: "Families",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
