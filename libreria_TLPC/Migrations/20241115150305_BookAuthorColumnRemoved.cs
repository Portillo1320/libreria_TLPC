using Microsoft.EntityFrameworkCore.Migrations;

namespace libreria_TLPC.Migrations
{
    public partial class BookAuthorColumnRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_Publishers_PublisherId",
                table: "Book_Authors");

            migrationBuilder.DropIndex(
                name: "IX_Book_Authors_PublisherId",
                table: "Book_Authors");

            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Book_Authors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Book_Authors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_Authors_PublisherId",
                table: "Book_Authors",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_Publishers_PublisherId",
                table: "Book_Authors",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
