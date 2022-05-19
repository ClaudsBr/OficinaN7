using Microsoft.EntityFrameworkCore.Migrations;

namespace OficinaN7.Migrations
{
    public partial class AjustandoServico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Services",
                newName: "Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Services",
                newName: "Name");
        }
    }
}
