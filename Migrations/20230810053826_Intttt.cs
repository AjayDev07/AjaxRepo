using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Person.Migrations
{
    public partial class Intttt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsChecked",
                table: "Families",
                newName: "Singing");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Playing",
                table: "Families");

            migrationBuilder.DropColumn(
                name: "Reading",
                table: "Families");

            migrationBuilder.RenameColumn(
                name: "Singing",
                table: "Families",
                newName: "IsChecked");
        }
    }
}
