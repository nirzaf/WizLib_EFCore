using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WizLib_DataAccess.Migrations
{
    public partial class updateContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthor_Fluent_Authors_Author_Id",
                table: "Fluent_BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthor_Fluent_Books_Book_Id",
                table: "Fluent_BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_Fluent_BookDetails_BookDetail_Id",
                table: "Fluent_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_Books_fluent_Publishers_Publisher_Id",
                table: "Fluent_Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_category",
                table: "tbl_category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_fluent_Publishers",
                table: "fluent_Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_Books",
                table: "Fluent_Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_BookDetails",
                table: "Fluent_BookDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fluent_Authors",
                table: "Fluent_Authors");

            migrationBuilder.RenameTable(
                name: "tbl_category",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "fluent_Publishers",
                newName: "FluentPublishers");

            migrationBuilder.RenameTable(
                name: "Fluent_Books",
                newName: "FluentBooks");

            migrationBuilder.RenameTable(
                name: "Fluent_BookDetails",
                newName: "FluentBookDetails");

            migrationBuilder.RenameTable(
                name: "Fluent_Authors",
                newName: "FluentAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_Books_Publisher_Id",
                table: "FluentBooks",
                newName: "IX_FluentBooks_Publisher_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Fluent_Books_BookDetail_Id",
                table: "FluentBooks",
                newName: "IX_FluentBooks_BookDetail_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Category_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluentPublishers",
                table: "FluentPublishers",
                column: "Publisher_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluentBooks",
                table: "FluentBooks",
                column: "Book_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluentBookDetails",
                table: "FluentBookDetails",
                column: "BookDetail_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FluentAuthors",
                table: "FluentAuthors",
                column: "Author_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthor_FluentAuthors_Author_Id",
                table: "Fluent_BookAuthor",
                column: "Author_Id",
                principalTable: "FluentAuthors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthor_FluentBooks_Book_Id",
                table: "Fluent_BookAuthor",
                column: "Book_Id",
                principalTable: "FluentBooks",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBooks_FluentBookDetails_BookDetail_Id",
                table: "FluentBooks",
                column: "BookDetail_Id",
                principalTable: "FluentBookDetails",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentBooks_FluentPublishers_Publisher_Id",
                table: "FluentBooks",
                column: "Publisher_Id",
                principalTable: "FluentPublishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthor_FluentAuthors_Author_Id",
                table: "Fluent_BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_Fluent_BookAuthor_FluentBooks_Book_Id",
                table: "Fluent_BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_FluentBooks_FluentBookDetails_BookDetail_Id",
                table: "FluentBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_FluentBooks_FluentPublishers_Publisher_Id",
                table: "FluentBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluentPublishers",
                table: "FluentPublishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluentBooks",
                table: "FluentBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluentBookDetails",
                table: "FluentBookDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FluentAuthors",
                table: "FluentAuthors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "FluentPublishers",
                newName: "fluent_Publishers");

            migrationBuilder.RenameTable(
                name: "FluentBooks",
                newName: "Fluent_Books");

            migrationBuilder.RenameTable(
                name: "FluentBookDetails",
                newName: "Fluent_BookDetails");

            migrationBuilder.RenameTable(
                name: "FluentAuthors",
                newName: "Fluent_Authors");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "tbl_category");

            migrationBuilder.RenameIndex(
                name: "IX_FluentBooks_Publisher_Id",
                table: "Fluent_Books",
                newName: "IX_Fluent_Books_Publisher_Id");

            migrationBuilder.RenameIndex(
                name: "IX_FluentBooks_BookDetail_Id",
                table: "Fluent_Books",
                newName: "IX_Fluent_Books_BookDetail_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fluent_Publishers",
                table: "fluent_Publishers",
                column: "Publisher_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_Books",
                table: "Fluent_Books",
                column: "Book_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_BookDetails",
                table: "Fluent_BookDetails",
                column: "BookDetail_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fluent_Authors",
                table: "Fluent_Authors",
                column: "Author_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_category",
                table: "tbl_category",
                column: "Category_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthor_Fluent_Authors_Author_Id",
                table: "Fluent_BookAuthor",
                column: "Author_Id",
                principalTable: "Fluent_Authors",
                principalColumn: "Author_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_BookAuthor_Fluent_Books_Book_Id",
                table: "Fluent_BookAuthor",
                column: "Book_Id",
                principalTable: "Fluent_Books",
                principalColumn: "Book_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_Fluent_BookDetails_BookDetail_Id",
                table: "Fluent_Books",
                column: "BookDetail_Id",
                principalTable: "Fluent_BookDetails",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fluent_Books_fluent_Publishers_Publisher_Id",
                table: "Fluent_Books",
                column: "Publisher_Id",
                principalTable: "fluent_Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
