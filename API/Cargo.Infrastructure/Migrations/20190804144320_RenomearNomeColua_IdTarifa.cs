using Microsoft.EntityFrameworkCore.Migrations;

namespace Cargo.Infrastructure.Migrations
{
    public partial class RenomearNomeColua_IdTarifa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SimulacaoTarifa_Tarifa_IdSimulacao",
                table: "SimulacaoTarifa");

            migrationBuilder.RenameColumn(
                name: "IdSimulacao",
                table: "SimulacaoTarifa",
                newName: "IdTarifa");

            migrationBuilder.RenameIndex(
                name: "IX_SimulacaoTarifa_IdSimulacao",
                table: "SimulacaoTarifa",
                newName: "IX_SimulacaoTarifa_IdTarifa");

            migrationBuilder.AddForeignKey(
                name: "FK_SimulacaoTarifa_Tarifa_IdTarifa",
                table: "SimulacaoTarifa",
                column: "IdTarifa",
                principalTable: "Tarifa",
                principalColumn: "IdTarifa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SimulacaoTarifa_Tarifa_IdTarifa",
                table: "SimulacaoTarifa");

            migrationBuilder.RenameColumn(
                name: "IdTarifa",
                table: "SimulacaoTarifa",
                newName: "IdSimulacao");

            migrationBuilder.RenameIndex(
                name: "IX_SimulacaoTarifa_IdTarifa",
                table: "SimulacaoTarifa",
                newName: "IX_SimulacaoTarifa_IdSimulacao");

            migrationBuilder.AddForeignKey(
                name: "FK_SimulacaoTarifa_Tarifa_IdSimulacao",
                table: "SimulacaoTarifa",
                column: "IdSimulacao",
                principalTable: "Tarifa",
                principalColumn: "IdTarifa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
