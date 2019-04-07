using Microsoft.EntityFrameworkCore.Migrations;

namespace Cargo.Infrastructure.Migrations
{
    public partial class InsercaoDeEnderecoEmColeta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Table_IdEndereco",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Parceiro_Table_IdEndereco",
                table: "Parceiro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table",
                table: "Table");

            migrationBuilder.RenameTable(
                name: "Table",
                newName: "Endereco");

            migrationBuilder.AddColumn<int>(
                name: "IdEndereco",
                table: "Coleta",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Coleta_IdEndereco",
                table: "Coleta",
                column: "IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Endereco_IdEndereco",
                table: "Cliente",
                column: "IdEndereco",
                principalTable: "Endereco",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Coleta_Endereco_IdEndereco",
                table: "Coleta",
                column: "IdEndereco",
                principalTable: "Endereco",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parceiro_Endereco_IdEndereco",
                table: "Parceiro",
                column: "IdEndereco",
                principalTable: "Endereco",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Endereco_IdEndereco",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_Coleta_Endereco_IdEndereco",
                table: "Coleta");

            migrationBuilder.DropForeignKey(
                name: "FK_Parceiro_Endereco_IdEndereco",
                table: "Parceiro");

            migrationBuilder.DropIndex(
                name: "IX_Coleta_IdEndereco",
                table: "Coleta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "IdEndereco",
                table: "Coleta");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Table");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table",
                table: "Table",
                column: "IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Table_IdEndereco",
                table: "Cliente",
                column: "IdEndereco",
                principalTable: "Table",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Parceiro_Table_IdEndereco",
                table: "Parceiro",
                column: "IdEndereco",
                principalTable: "Table",
                principalColumn: "IdEndereco",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
