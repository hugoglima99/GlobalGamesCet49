using Microsoft.EntityFrameworkCore.Migrations;

namespace GlobalGamesCet49.Migrations
{
    public partial class AddBd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contactos",
                table: "Contactos");

            migrationBuilder.RenameTable(
                name: "Contactos",
                newName: "Contacto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacto",
                table: "Contacto");

            migrationBuilder.RenameTable(
                name: "Contacto",
                newName: "Contactos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contactos",
                table: "Contactos",
                column: "Id");
        }
    }
}
