using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Mercurio.Infrastructure.Migrations
{
    public partial class Add_Tables_Assunto_Reporte_ProdutoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "Mercados",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCricao",
                table: "Mercados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataExclusao",
                table: "Mercados",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioAlteracao",
                table: "Mercados",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioCriacao",
                table: "Mercados",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UsuarioExclusao",
                table: "Mercados",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assuntos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assuntos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoUsuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoUsuarios_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoUsuarios_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoUsuarios_Mercados_MercadoId",
                        column: x => x.MercadoId,
                        principalTable: "Mercados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoUsuarios_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProdutoValorMedios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MercadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EstadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CidadeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoValorMedios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoValorMedios_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoValorMedios_Estados_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoValorMedios_Mercados_MercadoId",
                        column: x => x.MercadoId,
                        principalTable: "Mercados",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProdutoValorMedios_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reportes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Resposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssuntoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCricao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioCriacao = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioAlteracao = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UsuarioExclusao = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reportes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reportes_Assuntos_AssuntoId",
                        column: x => x.AssuntoId,
                        principalTable: "Assuntos",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Assuntos",
                columns: new[] { "Id", "Ativo", "Descricao" },
                values: new object[] { new Guid("0d5c299e-90d6-4b11-a082-5a28f7cf5d8b"), true, "Falta o nome de um Supermercado ou Mercado" });

            migrationBuilder.InsertData(
                table: "Assuntos",
                columns: new[] { "Id", "Ativo", "Descricao" },
                values: new object[] { new Guid("b60bbfa3-098c-457b-8b2e-1b84a0dc4275"), true, "Falta o nome de um Produto ou informação do Produto" });

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoUsuarios_CidadeId",
                table: "ProdutoUsuarios",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoUsuarios_EstadoId",
                table: "ProdutoUsuarios",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoUsuarios_MercadoId",
                table: "ProdutoUsuarios",
                column: "MercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoUsuarios_ProdutoId",
                table: "ProdutoUsuarios",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoValorMedios_CidadeId",
                table: "ProdutoValorMedios",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoValorMedios_EstadoId",
                table: "ProdutoValorMedios",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoValorMedios_MercadoId",
                table: "ProdutoValorMedios",
                column: "MercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoValorMedios_ProdutoId",
                table: "ProdutoValorMedios",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reportes_AssuntoId",
                table: "Reportes",
                column: "AssuntoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoUsuarios");

            migrationBuilder.DropTable(
                name: "ProdutoValorMedios");

            migrationBuilder.DropTable(
                name: "Reportes");

            migrationBuilder.DropTable(
                name: "Assuntos");

            migrationBuilder.DropColumn(
                name: "IdMercado",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "UsuarioCadastro",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "DataCricao",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "DataExclusao",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "UsuarioAlteracao",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "UsuarioCriacao",
                table: "Mercados");

            migrationBuilder.DropColumn(
                name: "UsuarioExclusao",
                table: "Mercados");
        }
    }
}
