using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cargo.Infrastructure.Migrations
{
    public partial class RemocaoTabela_ExpedicaoColeta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpedicaoColeta");

            migrationBuilder.AddColumn<int>(
                name: "ExpedicaoIdExpedicao",
                table: "Coleta",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Coleta_ExpedicaoIdExpedicao",
                table: "Coleta",
                column: "ExpedicaoIdExpedicao");

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_Expedicao_ExpedicaoIdExpedicao",
                table: "Coleta",
                column: "ExpedicaoIdExpedicao",
                principalTable: "Expedicao",
                principalColumn: "IdExpedicao",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_Expedicao_ExpedicaoIdExpedicao",
                table: "Coleta");

            migrationBuilder.DropIndex(
                name: "IX_Coleta_ExpedicaoIdExpedicao",
                table: "Coleta");

            migrationBuilder.DropColumn(
                name: "ExpedicaoIdExpedicao",
                table: "Coleta");

            migrationBuilder.CreateTable(
                name: "ExpedicaoColeta",
                columns: table => new
                {
                    IdExpedicaoColeta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdColeta = table.Column<int>(nullable: false),
                    IdExpedicao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpedicaoColeta", x => x.IdExpedicaoColeta);
                    table.ForeignKey(
                        name: "FK_ExpedicaoColeta_Coleta_IdColeta",
                        column: x => x.IdColeta,
                        principalTable: "Coleta",
                        principalColumn: "IdColeta",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpedicaoColeta_Expedicao_IdExpedicao",
                        column: x => x.IdExpedicao,
                        principalTable: "Expedicao",
                        principalColumn: "IdExpedicao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpedicaoColeta_IdColeta",
                table: "ExpedicaoColeta",
                column: "IdColeta");

            migrationBuilder.CreateIndex(
                name: "IX_ExpedicaoColeta_IdExpedicao",
                table: "ExpedicaoColeta",
                column: "IdExpedicao");
        }
    }
}
