using Microsoft.EntityFrameworkCore.Migrations;

namespace GlobalGamesCet49.Migrations
{
    public partial class almostdone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "UserLogin");

            migrationBuilder.RenameColumn(
                name: "ImageFile",
                table: "UserLogin",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "PrimeiroNome",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Apelido",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "UserLogin",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "UserLogin");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "UserLogin",
                newName: "ImageFile");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "PrimeiroNome");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "Apelido");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "UserLogin",
                nullable: false,
                defaultValue: "");
        }
    }
}
