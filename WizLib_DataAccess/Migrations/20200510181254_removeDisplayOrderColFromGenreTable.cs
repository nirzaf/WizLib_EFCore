using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib_DataAccess.Migrations
{
    public partial class removeDisplayOrderColFromGenreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Genres");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Genres",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
