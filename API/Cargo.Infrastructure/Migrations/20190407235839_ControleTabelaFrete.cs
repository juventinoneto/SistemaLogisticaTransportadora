using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cargo.Infrastructure.Migrations
{
    public partial class ControleTabelaFrete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarifa",
                columns: table => new
                {
                    IdTarifa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdColeta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarifa", x => x.IdTarifa);
                    table.ForeignKey(
                        name: "FK_Tarifa_Coleta_IdColeta",
                        column: x => x.IdColeta,
                        principalTable: "Coleta",
                        principalColumn: "IdColeta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SimulacaoTarifa",
                columns: table => new
                {
                    IdSimulacaoTarifa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    StatusSimulacaoTarifa = table.Column<string>(nullable: false),
                    IdSimulacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimulacaoTarifa", x => x.IdSimulacaoTarifa);
                    table.ForeignKey(
                        name: "FK_SimulacaoTarifa_Tarifa_IdSimulacao",
                        column: x => x.IdSimulacao,
                        principalTable: "Tarifa",
                        principalColumn: "IdTarifa",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SimulacaoTarifa_IdSimulacao",
                table: "SimulacaoTarifa",
                column: "IdSimulacao");

            migrationBuilder.CreateIndex(
                name: "IX_Tarifa_IdColeta",
                table: "Tarifa",
                column: "IdColeta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SimulacaoTarifa");

            migrationBuilder.DropTable(
                name: "Tarifa");
        }
    }
}
