using Microsoft.EntityFrameworkCore.Migrations;

namespace Cargo.Infrastructure.Migrations
{
    public partial class AlterarObrigatoriedadeColuna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_Parceiro_IdParceiro",
                table: "Coleta");

            migrationBuilder.AlterColumn<int>(
                name: "IdParceiro",
                table: "Coleta",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_Parceiro_IdParceiro",
                table: "Coleta",
                column: "IdParceiro",
                principalTable: "Parceiro",
                principalColumn: "IdParceiro",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_Parceiro_IdParceiro",
                table: "Coleta");

            migrationBuilder.AlterColumn<int>(
                name: "IdParceiro",
                table: "Coleta",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_Parceiro_IdParceiro",
                table: "Coleta",
                column: "IdParceiro",
                principalTable: "Parceiro",
                principalColumn: "IdParceiro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
