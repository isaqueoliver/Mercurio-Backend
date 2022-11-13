using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Mercurio.Infrastructure.Migrations
{
    public partial class Add_New_Colums_Identity_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assuntos",
                keyColumn: "Id",
                keyValue: new Guid("5f1b0c89-0e03-49e9-a0b4-f3cccac0209a"));

            migrationBuilder.DeleteData(
                table: "Assuntos",
                keyColumn: "Id",
                keyValue: new Guid("694c985f-bb96-4fe4-93f0-d093e976c7e5"));

            migrationBuilder.AddColumn<Guid>(
                name: "CidadeId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "AspNetUsers",
                type: "nvarchar(14)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "EstadoId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Assuntos",
                columns: new[] { "Id", "Ativo", "Descricao" },
                values: new object[] { new Guid("59d70ebd-45c2-422c-97d4-a72196b869bf"), true, "Falta o nome de um Produto ou informação do Produto" });

            migrationBuilder.InsertData(
                table: "Assuntos",
                columns: new[] { "Id", "Ativo", "Descricao" },
                values: new object[] { new Guid("f647d069-0d8b-4407-bba8-77aed5bf3143"), true, "Falta o nome de um Supermercado ou Mercado" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assuntos",
                keyColumn: "Id",
                keyValue: new Guid("59d70ebd-45c2-422c-97d4-a72196b869bf"));

            migrationBuilder.DeleteData(
                table: "Assuntos",
                keyColumn: "Id",
                keyValue: new Guid("f647d069-0d8b-4407-bba8-77aed5bf3143"));

            migrationBuilder.DropColumn(
                name: "CidadeId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Assuntos",
                columns: new[] { "Id", "Ativo", "Descricao" },
                values: new object[] { new Guid("5f1b0c89-0e03-49e9-a0b4-f3cccac0209a"), true, "Falta o nome de um Supermercado ou Mercado" });

            migrationBuilder.InsertData(
                table: "Assuntos",
                columns: new[] { "Id", "Ativo", "Descricao" },
                values: new object[] { new Guid("694c985f-bb96-4fe4-93f0-d093e976c7e5"), true, "Falta o nome de um Produto ou informação do Produto" });
        }
    }
}
