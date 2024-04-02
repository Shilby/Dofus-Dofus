using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dofus.Migrations
{
    /// <inheritdoc />
    public partial class UpdateApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE `AspNetUsers` CHANGE `LastName` `Reponse_Secrete` VARCHAR(255);");
            migrationBuilder.Sql("ALTER TABLE `AspNetUsers` CHANGE `FirstName` `Question_Secrete` VARCHAR(255);");

            migrationBuilder.AddColumn<string>(
                name: "Pseudo",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }


        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pseudo",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Reponse_Secrete",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Question_Secrete",
                table: "AspNetUsers",
                newName: "FirstName");
        }
    }
}
