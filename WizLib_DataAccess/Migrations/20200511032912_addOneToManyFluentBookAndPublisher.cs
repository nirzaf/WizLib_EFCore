using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib_DataAccess.Migrations
{
    public partial class addOneToManyFluentBookAndPublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher_Id",
                table: "Fluent_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Fluent_Books_Publisher_Id",
                table: "Fluent_Books",
                column: "Publisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_fluent_Publishers_Publisher_Id",
                table: "Fluent_Books",
                column: "Publisher_Id",
                principalTable: "fluent_Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_fluent_Publishers_Publisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropIndex(
                name: "IX_Fluent_Books_Publisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropColumn(
                name: "Publisher_Id",
                table: "Fluent_Books");
        }
    }
}
