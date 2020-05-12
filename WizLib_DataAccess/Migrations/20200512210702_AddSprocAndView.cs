using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib_DataAccess.Migrations
{
    public partial class AddSprocAndView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR ALTER VIEW dbo.GetOnlyBookDetails
                AS
                SELECT  m.ISBN,m.Title,m.Price FROM dbo.Books m
            ");

            migrationBuilder.Sql(@"CREATE PROCEDURE dbo.getAllBookDetails   
                    @bookId int
                AS   

                    SET NOCOUNT ON;  
                    SELECT  *  FROM dbo.Books b
	                WHERE b.Book_Id=@bookId
                GO  
            ");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW dbo.GetOnlyBookDetails");

            migrationBuilder.Sql("DROP PROCEDURE dbo.getAllBookDetails");
        }
    }
}
