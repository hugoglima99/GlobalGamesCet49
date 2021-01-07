using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GlobalGamesCet49.Migrations
{
    public partial class ConnectBd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Inscricao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NumeroTelefone = table.Column<int>(nullable: false),
                    Morada = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscricao", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscricao");

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
    }
}
