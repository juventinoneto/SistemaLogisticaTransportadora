using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cargo.Infrastructure.Migrations
{
    public partial class ControleColetaDefinicaoCargas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parceiros",
                table: "Parceiros");

            migrationBuilder.RenameTable(
                name: "Parceiros",
                newName: "Parceiro");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Parceiro",
                newName: "IdParceiro");

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "Parceiro",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdEndereco",
                table: "Parceiro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Parceiro",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parceiro",
                table: "Parceiro",
                column: "IdParceiro");

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    IdEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RuaAvenida = table.Column<string>(maxLength: 40, nullable: false),
                    Bairro = table.Column<string>(maxLength: 30, nullable: false),
                    Cep = table.Column<string>(maxLength: 20, nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Cidade = table.Column<string>(maxLength: 30, nullable: false),
                    Uf = table.Column<string>(maxLength: 2, nullable: false),
                    Complemento = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.IdEndereco);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Documento = table.Column<string>(maxLength: 15, nullable: false),
                    IdEndereco = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Table_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Table",
                        principalColumn: "IdEndereco",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coleta",
                columns: table => new
                {
                    IdColeta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(nullable: false),
                    IdParceiro = table.Column<int>(nullable: false),
                    Data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coleta", x => x.IdColeta);
                    table.ForeignKey(
                        name: "FK_Coleta_Cliente_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Coleta_Parceiro_IdParceiro",
                        column: x => x.IdParceiro,
                        principalTable: "Parceiro",
                        principalColumn: "IdParceiro",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parceiro_IdEndereco",
                table: "Parceiro",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdEndereco",
                table: "Cliente",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Coleta_IdCliente",
                table: "Coleta",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Coleta_IdParceiro",
                table: "Coleta",
                column: "IdParceiro");

            migrationBuilder.AddForeignKey(
                name: "FK_Parceiro_Table_IdEndereco",
                table: "Parceiro",
                column: "IdEndereco",
                principalTable: "Table",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parceiro_Table_IdEndereco",
                table: "Parceiro");

            migrationBuilder.DropTable(
                name: "Coleta");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parceiro",
                table: "Parceiro");

            migrationBuilder.DropIndex(
                name: "IX_Parceiro_IdEndereco",
                table: "Parceiro");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Parceiro");

            migrationBuilder.DropColumn(
                name: "IdEndereco",
                table: "Parceiro");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Parceiro");

            migrationBuilder.RenameTable(
                name: "Parceiro",
                newName: "Parceiros");

            migrationBuilder.RenameColumn(
                name: "IdParceiro",
                table: "Parceiros",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parceiros",
                table: "Parceiros",
                column: "Id");
        }
    }
}
