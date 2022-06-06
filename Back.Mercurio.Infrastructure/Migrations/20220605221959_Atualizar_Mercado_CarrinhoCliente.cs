using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Mercurio.Infrastructure.Migrations
{
    public partial class Atualizar_Mercado_CarrinhoCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mercado",
                table: "CarrinhoCliente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mercado",
                table: "CarrinhoCliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
