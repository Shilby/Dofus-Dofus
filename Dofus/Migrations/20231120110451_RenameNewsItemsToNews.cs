using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dofus.Migrations
{
    /// <inheritdoc />
    public partial class RenameNewsItemsToNews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NewsItems",
                table: "NewsItems");

            migrationBuilder.RenameTable(
                name: "NewsItems",
                newName: "News");

            migrationBuilder.AddPrimaryKey(
                name: "PK_News",
                table: "News",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_News",
                table: "News");

            migrationBuilder.RenameTable(
                name: "News",
                newName: "NewsItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NewsItems",
                table: "NewsItems",
                column: "Id");
        }
    }
}
