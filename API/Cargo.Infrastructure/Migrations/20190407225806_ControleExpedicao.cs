using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cargo.Infrastructure.Migrations
{
    public partial class ControleExpedicao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Expedicao",
                columns: table => new
                {
                    IdExpedicao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expedicao", x => x.IdExpedicao);
                });

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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ExpedicaoColeta_Expedicao_IdExpedicao",
                        column: x => x.IdExpedicao,
                        principalTable: "Expedicao",
                        principalColumn: "IdExpedicao",
                        onDelete: ReferentialAction.NoAction);
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpedicaoColeta");

            migrationBuilder.DropTable(
                name: "Expedicao");
        }
    }
}
