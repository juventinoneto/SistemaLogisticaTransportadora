using Microsoft.EntityFrameworkCore.Migrations;

namespace Cargo.Infrastructure.Migrations
{
    public partial class ColunaNomeDestinatario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomeDestinatario",
                table: "Coleta",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeDestinatario",
                table: "Coleta");
        }
    }
}
