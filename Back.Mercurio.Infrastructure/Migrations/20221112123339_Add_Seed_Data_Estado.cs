using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Mercurio.Infrastructure.Migrations
{
    public partial class Add_Seed_Data_Estado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assuntos",
                keyColumn: "Id",
                keyValue: new Guid("59d70ebd-45c2-422c-97d4-a72196b869bf"));

            migrationBuilder.DeleteData(
                table: "Assuntos",
                keyColumn: "Id",
                keyValue: new Guid("f647d069-0d8b-4407-bba8-77aed5bf3143"));

            migrationBuilder.InsertData(
                table: "Assuntos",
                columns: new[] { "Id", "Ativo", "Descricao" },
                values: new object[,]
                {
                    { new Guid("40fe795e-c60e-4afb-abf0-07c0c599d1d0"), true, "Falta o nome de um Supermercado ou Mercado" },
                    { new Guid("ce6b710e-1740-471a-b2ae-899cd2e433c8"), true, "Falta o nome de um Produto ou informação do Produto" }
                });

            migrationBuilder.InsertData(
                table: "Estados",
                columns: new[] { "Id", "Sigla" },
                values: new object[,]
                {
                    { new Guid("1424de85-0be0-4467-9f38-85f69dcae9ae"), "PR" },
                    { new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "AL" },
                    { new Guid("1796e1b5-268a-4999-aeff-d7d9d2802984"), "RR" },
                    { new Guid("19cc64f0-a02e-47d1-a213-174443b8e2ae"), "TO" },
                    { new Guid("26fe5cb4-34c3-4917-a173-87fcac49e51c"), "PA" },
                    { new Guid("2be8c546-da5a-4651-b81f-3e0e22f81c96"), "PB" },
                    { new Guid("33eb429c-eac5-46ee-99ec-f770e7e9865d"), "RN" },
                    { new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MG" },
                    { new Guid("3e53022f-1b95-4d14-917f-c02288a29494"), "RJ" },
                    { new Guid("3ff8be8a-e669-4626-aa47-f16b584e3939"), "SC" },
                    { new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CE" },
                    { new Guid("49138c5d-4d92-44c0-8776-c2976fb636ee"), "RS" },
                    { new Guid("5ffaeef0-a1e6-4e65-98eb-d89f89fe5a41"), "PI" },
                    { new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "AM" },
                    { new Guid("77fd3d28-b2ba-472e-8ce8-561cc2fff17e"), "SE" },
                    { new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "AC" },
                    { new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MA" },
                    { new Guid("9d8b78c8-fe99-44e9-a3af-13a3ad6ed732"), "MT" },
                    { new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ES" },
                    { new Guid("ad6c5137-98f4-4e1c-b2af-f77122672b3b"), "SP" },
                    { new Guid("d094382a-03b7-4d81-af59-95a9681ce34d"), "MS" },
                    { new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GO" },
                    { new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BA" },
                    { new Guid("f40419f3-6efb-485b-b08d-3adee1bc5be6"), "PE" },
                    { new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "AP" },
                    { new Guid("fa3af446-1bf4-4374-a1cc-ac0369ab0ec1"), "RO" },
                    { new Guid("fe9058f9-f26d-4c2f-8cc9-b1f0278d311f"), "DF" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assuntos",
                keyColumn: "Id",
                keyValue: new Guid("40fe795e-c60e-4afb-abf0-07c0c599d1d0"));

            migrationBuilder.DeleteData(
                table: "Assuntos",
                keyColumn: "Id",
                keyValue: new Guid("ce6b710e-1740-471a-b2ae-899cd2e433c8"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("1424de85-0be0-4467-9f38-85f69dcae9ae"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("1796e1b5-268a-4999-aeff-d7d9d2802984"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("19cc64f0-a02e-47d1-a213-174443b8e2ae"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("26fe5cb4-34c3-4917-a173-87fcac49e51c"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("2be8c546-da5a-4651-b81f-3e0e22f81c96"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("33eb429c-eac5-46ee-99ec-f770e7e9865d"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("384891ad-6783-475e-92aa-667d899c84a8"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("3e53022f-1b95-4d14-917f-c02288a29494"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("3ff8be8a-e669-4626-aa47-f16b584e3939"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("49138c5d-4d92-44c0-8776-c2976fb636ee"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("5ffaeef0-a1e6-4e65-98eb-d89f89fe5a41"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("77fd3d28-b2ba-472e-8ce8-561cc2fff17e"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("853f114f-c716-4414-ba99-16f09b37a939"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("9d8b78c8-fe99-44e9-a3af-13a3ad6ed732"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("ad6c5137-98f4-4e1c-b2af-f77122672b3b"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("d094382a-03b7-4d81-af59-95a9681ce34d"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("f40419f3-6efb-485b-b08d-3adee1bc5be6"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("fa3af446-1bf4-4374-a1cc-ac0369ab0ec1"));

            migrationBuilder.DeleteData(
                table: "Estados",
                keyColumn: "Id",
                keyValue: new Guid("fe9058f9-f26d-4c2f-8cc9-b1f0278d311f"));

            migrationBuilder.InsertData(
                table: "Assuntos",
                columns: new[] { "Id", "Ativo", "Descricao" },
                values: new object[] { new Guid("59d70ebd-45c2-422c-97d4-a72196b869bf"), true, "Falta o nome de um Produto ou informação do Produto" });

            migrationBuilder.InsertData(
                table: "Assuntos",
                columns: new[] { "Id", "Ativo", "Descricao" },
                values: new object[] { new Guid("f647d069-0d8b-4407-bba8-77aed5bf3143"), true, "Falta o nome de um Supermercado ou Mercado" });
        }
    }
}
