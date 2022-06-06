using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Mercurio.Infrastructure.Migrations
{
    public partial class Relation_Produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdMercado",
                table: "Produtos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdMercado",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
