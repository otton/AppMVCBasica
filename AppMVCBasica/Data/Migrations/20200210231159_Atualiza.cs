using Microsoft.EntityFrameworkCore.Migrations;

namespace AppMVCBasica.Data.Migrations
{
    public partial class Atualiza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Endereco",
                table: "Produtos",
                newName: "Descricao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Produtos",
                newName: "Endereco");
        }
    }
}
