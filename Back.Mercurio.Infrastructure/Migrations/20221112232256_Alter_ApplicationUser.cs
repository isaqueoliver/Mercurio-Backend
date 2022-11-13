using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Mercurio.Infrastructure.Migrations
{
    public partial class Alter_ApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Mercados_MercadoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_MercadoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "IdMercado",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "UsuarioCadastro",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "MercadoId",
                table: "Produtos",
                newName: "UsuarioCriacao");

            migrationBuilder.RenameColumn(
                name: "DataCadastro",
                table: "Produtos",
                newName: "DataCriacao");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "Produtos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataExclusao",
                table: "Produtos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioAlteracao",
                table: "Produtos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioExclusao",
                table: "Produtos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CidadeId",
                table: "Mercados",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "Mercados",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EstadoId",
                table: "Mercados",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioAlteracao",
                table: "Mercados",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mercados_CidadeId",
                table: "Mercados",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mercados_EstadoId",
                table: "Mercados",
                column: "EstadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mercados_Cidades_CidadeId",
                table: "Mercados",
                column: "CidadeId",
                principalTable: "Cidades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mercados_Estados_EstadoId",
                table: "Mercados",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mercados_Cidades_CidadeId",
                table: "Mercados");

            migrationBuilder.DropForeignKey(
                name: "FK_Mercados_Estados_EstadoId",
                table: "Mercados");

            migrationBuilder.DropIndex(
                name: "IX_Mercados_CidadeId",
                table: "Mercados");

            migrationBuilder.DropIndex(
                name: "IX_Mercados_EstadoId",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DataExclusao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "UsuarioAlteracao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "UsuarioExclusao",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "CidadeId",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "UsuarioAlteracao",
                table: "Mercados");

            migrationBuilder.RenameColumn(
                name: "UsuarioCriacao",
                table: "Produtos",
                newName: "MercadoId");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Produtos",
                newName: "DataCadastro");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Produtos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdMercado",
                table: "Produtos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCadastro",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Produtos",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Mercados",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Mercados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "AspNetUsers",
                type: "nvarchar(14)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_MercadoId",
                table: "Produtos",
                column: "MercadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Mercados_MercadoId",
                table: "Produtos",
                column: "MercadoId",
                principalTable: "Mercados",
                principalColumn: "Id");
        }
    }
}
