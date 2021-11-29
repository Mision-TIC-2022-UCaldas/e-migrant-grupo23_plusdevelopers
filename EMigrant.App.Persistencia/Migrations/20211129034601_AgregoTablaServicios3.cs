using Microsoft.EntityFrameworkCore.Migrations;

namespace EMigrant.App.Persistencia.Migrations
{
    public partial class AgregoTablaServicios3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Serviios",
                table: "Serviios");

            migrationBuilder.RenameTable(
                name: "Serviios",
                newName: "Servicios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servicios",
                table: "Servicios",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Servicios",
                table: "Servicios");

            migrationBuilder.RenameTable(
                name: "Servicios",
                newName: "Serviios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Serviios",
                table: "Serviios",
                column: "Id");
        }
    }
}
