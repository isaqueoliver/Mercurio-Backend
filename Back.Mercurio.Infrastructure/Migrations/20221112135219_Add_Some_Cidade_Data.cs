using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back.Mercurio.Infrastructure.Migrations
{
    public partial class Add_Some_Cidade_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("0046173a-2945-4d67-bc59-393e23cc0d8d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SERRANOPOLIS DE MINAS" },
                    { new Guid("00571265-5a18-4f09-8326-2050b084baac"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARAPORA" },
                    { new Guid("00ac73e3-46ab-495f-88c9-6b85a96eb09b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IBITURUNA" },
                    { new Guid("00f4134b-0382-4b0a-88db-6045fbcc377a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NOVO TRIUNFO" },
                    { new Guid("01208e36-0f55-45b4-aeb2-c83d50f22e08"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CANDIBA" },
                    { new Guid("01446710-66bd-4a55-b035-b1bf84c7f988"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MIRAVANIA" },
                    { new Guid("019aea2d-6c9c-4dd6-afc9-f36b78f8e539"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CAXIAS" },
                    { new Guid("021c5d47-3b13-47d1-9ae0-c8185945dc24"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CAMPO ALEGRE DE GOIAS" },
                    { new Guid("02308cb4-27b7-4577-bbc4-375303a6e853"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO THOME DAS LETRAS" },
                    { new Guid("023835bf-38c0-44a4-8dae-cc992943d69b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SENHORA DOS REMEDIOS" },
                    { new Guid("023867e7-7f55-4882-84fc-3dca47a07b9f"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "IGREJA NOVA" },
                    { new Guid("02474fe9-fcd7-438c-9d53-2af8af79ba8b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA RITA DE MINAS" },
                    { new Guid("026295d2-7100-425d-b8b5-59a1229cbe4d"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "JARAGUA" },
                    { new Guid("027c9f30-25be-46f1-8344-ef836685c7e6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO SEBASTIAO DO RIO PRETO" },
                    { new Guid("0293d7a6-3dfe-4a60-bf84-8390721ea9e1"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ALOANDIA" },
                    { new Guid("029cdcbc-e649-4d53-ab40-b155ff6204e7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARANDAI" },
                    { new Guid("02bff3f9-d2a0-46fb-b7ca-2ef38cca9a3a"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "BARREIRINHA" },
                    { new Guid("02c53be9-40df-46ae-886f-f6a60060ea7b"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PAO DE ACUCAR" },
                    { new Guid("02e4f530-744a-40a3-b4c5-805212062741"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALTO JEQUITIBA" },
                    { new Guid("02f1992b-dd24-4e67-86f4-407cf0347808"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CAUCAIA" },
                    { new Guid("0315780e-be95-4f88-86b5-0170d7fbf096"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTO ANTONIO DO GRAMA" },
                    { new Guid("032bad30-5ea5-42d5-9634-0cc6f53fcd13"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DIONISIO" },
                    { new Guid("032de41a-3036-4c1f-af15-f9293fcfa0d1"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ARAIOSES" },
                    { new Guid("03696668-6d89-470a-b997-cf645062a5ae"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ALTO SANTO" },
                    { new Guid("03853713-db3d-4879-afc1-4ea6f6d4d8e8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VARGEM GRANDE DO RIO PARDO" },
                    { new Guid("03b63b29-0f80-4e17-bf0a-7dcbf6f5683e"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "LIMA CAMPOS" },
                    { new Guid("03bdb15e-c1a4-4292-8fee-37964ec8ce98"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ACREUNA" },
                    { new Guid("03cb954f-13a3-4a88-9da6-3464e2bb5ed3"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "CAMPESTRE" },
                    { new Guid("03d19354-8ecc-41ec-9a40-d93bcc39e977"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "SAO GABRIEL DA CACHOEIRA" },
                    { new Guid("03efc359-5fa6-449c-919d-d64c7fa8b8e8"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "NOVA OLINDA DO NORTE" },
                    { new Guid("03f16f4d-a93d-43c8-a44b-4b2b20979abb"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "JORDAO" },
                    { new Guid("04029ef2-8dde-4402-b986-149e949b21a6"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "GOVERNADOR LINDENBERG" },
                    { new Guid("047d68d4-8fea-4d46-bd74-4980b891532f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TUCANO" },
                    { new Guid("049f89e6-eb48-4560-85f5-8119523c6a76"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MALHADA" },
                    { new Guid("04a79551-7b94-4152-8a95-2611b031e2d9"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "FORMOSO" },
                    { new Guid("04c3cb67-015e-4b63-a24d-d8c29dcdcb70"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DESTERRO DO MELO" },
                    { new Guid("04d6ac42-63e0-42be-a43e-74b320d27f87"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITUBERA" },
                    { new Guid("04dbc33c-11eb-4ff4-a804-8c0a1791dcef"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MANHUMIRIM" },
                    { new Guid("04f3e655-9cef-49c9-9aa7-710bc403c5ce"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMPESTRE" },
                    { new Guid("04f9ea30-9b07-44d7-a607-914c03ac15df"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JUSSARI" },
                    { new Guid("0500d259-7568-4cce-b822-d7ac52bea32b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LAGOA SANTA" },
                    { new Guid("054eb3de-3fc6-4788-bbe2-03fd7c2e1082"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "OLARIA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("05665a1d-da9d-4f54-b853-8fb8ae11c652"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAMPO FORMOSO" },
                    { new Guid("05e7c143-41fe-4087-8ab2-f356300dee7e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONSELHEIRO LAFAIETE" },
                    { new Guid("05f2d076-1bba-4df5-80f2-ccc0ddbc958d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PARAIPABA" },
                    { new Guid("06043080-1036-49a2-ac47-d338df9c65fe"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ANAJATUBA" },
                    { new Guid("0604bcc6-f036-4a64-8da6-e547ee7f9270"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA VITORIA" },
                    { new Guid("060b276e-b87f-4bde-95d6-e7e7bf6d3679"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SILVIANOPOLIS" },
                    { new Guid("065a81aa-b48d-41b4-a0c5-539c0339666b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "INCONFIDENTES" },
                    { new Guid("065fa8c6-17b7-469f-a56f-55c7176ec2d9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BARRA DO ROCHA" },
                    { new Guid("068df452-ef4e-4a05-8d12-7b1d4a4b01a6"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ARAGOIANIA" },
                    { new Guid("06ca98d1-194e-4f9c-b1d7-65487621675e"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "JOAQUIM GOMES" },
                    { new Guid("06d1eee0-df15-4170-84d3-6b7078047c92"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NINHEIRA" },
                    { new Guid("06f8aa2f-7766-4296-92f8-15045cb32674"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONTE AZUL" },
                    { new Guid("070274f8-a3fd-4680-8f06-b296bb2bf363"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ECOPORANGA" },
                    { new Guid("07128dbd-800a-4cdf-b073-0800810c6afe"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "GUAJERU" },
                    { new Guid("0722835b-c5eb-4db9-a682-5103c1e3a6e2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PAVAO" },
                    { new Guid("075df655-f6f3-4448-846b-6e013ded1420"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANCLERLANDIA" },
                    { new Guid("079b63b1-5be9-4676-a256-56d55b7ae90e"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PIRAPEMAS" },
                    { new Guid("079f09af-8e00-465f-b253-c66325b6f033"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "VALENTE" },
                    { new Guid("07c44514-0817-4356-88eb-7204be1ca710"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IRAMAIA" },
                    { new Guid("07c7f02f-42aa-48cd-8c2d-e1b4e4fa67f3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ANTONIO GONCALVES" },
                    { new Guid("07d29031-4e23-4ef3-92f8-17189dd7c65a"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "MUQUI" },
                    { new Guid("07e046fd-12cb-4bea-a6be-159c6898fa3d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO DAS MISSOES" },
                    { new Guid("07ec2fab-2b2e-4e2a-97d4-43e59d2a82fa"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ESTIVA" },
                    { new Guid("07f4cb9b-628b-4c1f-aa36-970baba9db63"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ITARUMA" },
                    { new Guid("0801ddc8-e942-4b7a-8796-759848a57256"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO JOAO DOS PATOS" },
                    { new Guid("08038765-c5c1-4735-8a16-65096d394af2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CONTENDAS DO SINCORA" },
                    { new Guid("085d1c46-4dc8-45ba-b1c4-4520768da3fd"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ARACATU" },
                    { new Guid("0878f91b-fb6e-4a9c-97f7-fad04fd307c1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "OURO FINO" },
                    { new Guid("08faae8e-26a9-4d0d-82d3-fdecda9edd17"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTA BARBARA" },
                    { new Guid("095b5b87-7d76-44b9-8c0e-6f02be64598f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITANAGRA" },
                    { new Guid("095eb1ff-d98a-49ed-9644-f747112136a3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO FRANCISCO DO CONDE" },
                    { new Guid("0990399b-95bf-4cef-911e-bc7aa7a2ca6e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CABECEIRA GRANDE" },
                    { new Guid("09a3cdcf-b235-4d11-892c-5ee7c160390f"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "PANCAS" },
                    { new Guid("09b0693d-60fc-4609-96c7-5d742e8b6e4f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIEDADE DE CARATINGA" },
                    { new Guid("09b3c0ad-a74f-45d7-9098-392ab2bbd840"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BELMIRO BRAGA" },
                    { new Guid("09d60e27-bf9e-4f5d-81e7-7b55ce7af344"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IBITIURA DE MINAS" },
                    { new Guid("0a020a5b-5290-4146-a859-92f3796f50b4"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "TURIACU" },
                    { new Guid("0a07e0f8-6488-4217-bd3c-7c5051943d61"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITINGA" },
                    { new Guid("0a3ba37f-f733-4c16-b036-d8098abc73fd"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PARATINGA" },
                    { new Guid("0a4af495-6d8c-45c9-85c1-b6803bb2eae7"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ITINGA DO MARANHAO" },
                    { new Guid("0a5478a3-9f69-418e-858b-f74826ae04be"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO GONCALO DO RIO PRETO" },
                    { new Guid("0a59d010-3ee7-4ec3-aa73-38939be6d163"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PONTO DOS VOLANTES" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("0a5a3f04-216e-4e83-a156-a4f3c35fe5f3"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BARREIRINHAS" },
                    { new Guid("0a6fc4cd-c516-4ea8-9e76-830fcd3432d1"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "JENIPAPO DOS VIEIRAS" },
                    { new Guid("0a72a800-aa5e-4a97-ac95-5d25b34cc4c7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTANA DO GARAMBEU" },
                    { new Guid("0a7d76a5-f247-4bac-8bcb-bd66df951fc6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ESTRELA DO INDAIA" },
                    { new Guid("0a934c79-0ff5-4ea4-82e2-4d01b1c3b7b0"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BOM LUGAR" },
                    { new Guid("0ad35250-b0ca-4021-8f16-cb3a5006fa5b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO SEBASTIAO DA BELA VISTA" },
                    { new Guid("0ad513de-650e-42c0-8f87-9be6dca38d23"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MADRE DE DEUS DE MINAS" },
                    { new Guid("0adc0b7f-56cc-461d-9309-abfc22cafdc2"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ALTO RIO NOVO" },
                    { new Guid("0ae21bd1-6876-4eba-971d-7b1d814e079c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FERVEDOURO" },
                    { new Guid("0b148557-7ddb-4526-915f-3eb253cee476"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SITIO DO MATO" },
                    { new Guid("0b2d392f-b33a-4d00-9c6f-b4046f085474"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ILICINEA" },
                    { new Guid("0b3ed5af-4910-4539-82f6-802cb7b85f2f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONQUISTA" },
                    { new Guid("0b615538-196c-4f20-8dde-d59d9d0f3ac9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PINTADAS" },
                    { new Guid("0b7c292d-145e-4a2a-a204-62a18cd04e2d"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BURITINOPOLIS" },
                    { new Guid("0bb4a154-a488-4d2b-85a4-456cf1cc8a07"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GOIANA" },
                    { new Guid("0bb6ad82-de0c-4355-86e4-9d14bd78df2a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ASTOLFO DUTRA" },
                    { new Guid("0bc76be5-28df-4954-aab0-2ff3acf7d13c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "OURO PRETO" },
                    { new Guid("0bd701ae-7864-474b-abec-e0d55397ff69"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "JATI" },
                    { new Guid("0c0d634d-3de9-43d3-bec9-9112f1013089"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TAPIRAI" },
                    { new Guid("0c1a37ab-c5e9-48c9-bf23-d1dd07306f36"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SAO PATRICIO" },
                    { new Guid("0c3af92c-f115-47c0-9dda-d7ad052c76f6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FERROS" },
                    { new Guid("0c74d98f-1747-4361-b725-2ffc4f7092aa"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO JOSE DOS BASILIOS" },
                    { new Guid("0c9aaaba-63b1-4d70-a2e9-919ebe0bbbdd"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FELISBURGO" },
                    { new Guid("0cb692c9-74f9-42c6-9674-574559cd8aef"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "GUARAMIRANGA" },
                    { new Guid("0cb6e80d-d93b-4dc9-9f92-370d0b7c181a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MARACAS" },
                    { new Guid("0cc0c858-89f6-4f7d-88d0-880dc08a96c8"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "APUIARES" },
                    { new Guid("0cda8914-8469-43dd-9848-18f087b76e31"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO VICENTE FERRER" },
                    { new Guid("0d52ec37-7921-4001-b8df-25f4b19dcf1e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IRECE" },
                    { new Guid("0d56aa96-e0b0-435d-ac4d-463aad851004"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CHAPADA GAUCHA" },
                    { new Guid("0d56c218-f5aa-410a-8b0b-6f3ff39c58e2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAPIM BRANCO" },
                    { new Guid("0d7803b5-5525-4134-a04b-9b683fd38659"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARAPONGA" },
                    { new Guid("0d9e37a1-41a4-48e4-a1fe-ad8748181cd2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "GAVIAO" },
                    { new Guid("0e266f49-9da4-45a1-8e93-61f0e2d49ab3"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CROATA" },
                    { new Guid("0e3f6841-2e53-4068-8756-88526f740df1"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CARINHANHA" },
                    { new Guid("0e65b7c2-f3a5-4b6c-9bb7-cc381760ab29"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BURITICUPU" },
                    { new Guid("0e69e89f-2adf-412d-a3ce-0c7ebf1060b4"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CANARANA" },
                    { new Guid("0e7fa79a-2f51-4f2e-aab2-40502e47108c"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "IGACI" },
                    { new Guid("0e8f087c-ab1f-4e93-b3d2-1f1c83147e34"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PALMAS DE MONTE ALTO" },
                    { new Guid("0eafbeea-583c-47d8-9a4f-809370973dc9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ELOI MENDES" },
                    { new Guid("0eb7b04e-336d-4c4a-9fd6-b09a3d576113"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA CRUZ DE MINAS" },
                    { new Guid("0ef6aaad-aa83-462a-8ee7-817e420df480"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CORUMBA DE GOIAS" },
                    { new Guid("0f30eff7-d383-4a7e-87d0-337c5b7819aa"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "HIDROLANDIA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("0f344bc2-c683-4964-a052-54c311fd66ea"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JAIBA" },
                    { new Guid("0f440574-372a-409a-ac73-52d0f2a06e32"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITUACU" },
                    { new Guid("0f60b06d-12d8-4e16-9aab-bcfe43b57155"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "NOVO AIRAO" },
                    { new Guid("0f865076-282a-4db6-815a-8cd1936d2e46"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CONDEUBA" },
                    { new Guid("0f9154bf-9518-4420-86af-7d4dbdc132fb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ANGELANDIA" },
                    { new Guid("0fa1348e-6e74-4645-9b1d-29f2dcc3be3e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVO CRUZEIRO" },
                    { new Guid("0fc13cc6-50a9-4ca1-b10c-540d47bd43e6"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "VEREDA" },
                    { new Guid("0fdedfe3-8419-47e6-be30-580b11c84b03"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO GONCALO DO PARA" },
                    { new Guid("103c3983-d4de-45da-a63b-7608b1fbb29a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LUISBURGO" },
                    { new Guid("106055be-3f46-4f5e-8bd1-fbe8d719e2ce"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "COLUNA" },
                    { new Guid("107e9dae-3938-4fab-a1ad-afeab8ba1c7c"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "RIALMA" },
                    { new Guid("107fc9b9-ca5a-4a51-93ae-ef905ccacf29"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MONTEIROPOLIS" },
                    { new Guid("10c22b99-9c5e-493d-9f20-c3d6699b9e9b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SENADOR MODESTINO GONCALVES" },
                    { new Guid("10ef9e9b-d191-4b80-b2b6-f31050211005"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONCEICAO DA BARRA DE MINAS" },
                    { new Guid("1108ad0e-9a58-4642-b323-4262438a17c2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONGONHAS" },
                    { new Guid("1111ae2f-a4ea-415c-94af-a98d3a9eed94"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VERMELHO NOVO" },
                    { new Guid("11265a3f-7a7e-43b9-b06c-a5b3c4344626"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LAJINHA" },
                    { new Guid("113ddce4-4737-40b9-80a4-f1938b58412a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GLAUCILANDIA" },
                    { new Guid("11fead0b-0271-41a6-a661-85ac0a2f3709"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIEDADE DE PONTE NOVA" },
                    { new Guid("121598cc-f58d-44a9-bd5c-39ffbedf47bd"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBIRAPITANGA" },
                    { new Guid("122a9243-f676-49c9-856a-91dd1e20eea8"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BACABEIRA" },
                    { new Guid("123120fb-b25f-4964-99fe-ff6898202175"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NOVA AURORA" },
                    { new Guid("124ed314-67bc-4ebe-bfa1-dc901b71737d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IBIRACI" },
                    { new Guid("125796a4-2c7f-42de-b6e4-9845b1981d26"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DIVINO DAS LARANJEIRAS" },
                    { new Guid("127cc86f-6812-4bf0-9f25-3f9a0f3ba27d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IRAI DE MINAS" },
                    { new Guid("12951934-6c0c-4d55-aa27-f43b48bded81"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PARIPUEIRA" },
                    { new Guid("129dc233-41d6-4019-a5fa-06547569a680"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SANTANA DO ACARAU" },
                    { new Guid("129e7c2d-21a3-4910-a9a7-4a087da3e7d1"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "URUTAI" },
                    { new Guid("12b5bb55-f46f-409a-a98d-8bd4be94d8e4"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TREMEDAL" },
                    { new Guid("12c6a8d6-c239-4c5d-baaf-20a48514cf7b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PORTEIRAO" },
                    { new Guid("12cbdaf3-2864-4fc7-a755-07e159db1104"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ALCOBACA" },
                    { new Guid("12ddf9ae-c2b7-4a75-9ada-5919d8ce5d5c"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "IRANDUBA" },
                    { new Guid("12f6f030-7fb2-4183-8d40-e0c9009f58bb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO PRETO" },
                    { new Guid("1317b4c9-ea37-4527-9265-33dc798a7af4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO GOTARDO" },
                    { new Guid("132b9807-3af8-4ebe-90d2-acfc370a8edb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA MARIA DE ITABIRA" },
                    { new Guid("1332788f-8c23-438b-a017-8e1eb1fbb8bc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIAU" },
                    { new Guid("135090d5-8d25-4209-95cf-cbe0c2b9cfd2"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTA TEREZA DE GOIAS" },
                    { new Guid("13633702-9daf-4b9e-ac8f-c1436cc16f6b"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "IPIXUNA" },
                    { new Guid("136539ec-523c-4aed-9bf4-0816bfcf30e8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JABORANDI" },
                    { new Guid("137ec34b-cbed-40c7-b77e-b3ca570a4c3b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALFENAS" },
                    { new Guid("13896dfb-eae4-43e1-b22c-2dc051df223b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CRISTINA" },
                    { new Guid("139e04cb-ccdd-4da2-9940-4a8d7c9d1097"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BOQUIRA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("13a985d5-c90d-4073-ac94-0f173ae19880"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO GABRIEL" },
                    { new Guid("13c459f7-2ba1-468e-ad16-1e31789394e5"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "UBAITABA" },
                    { new Guid("1400cc60-12b4-4e94-8c6d-d839f1823526"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ANDORINHA" },
                    { new Guid("1418dbfc-3296-475e-a0c6-51160adee77e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PIRIPA" },
                    { new Guid("146511cf-2650-486c-b0a6-500a7d1a3e43"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARAPUA" },
                    { new Guid("14a02476-b4bf-439b-980a-4f5603c7860e"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "CAPELA" },
                    { new Guid("153b9b3c-2f9d-4444-b409-7c21b6c7e4ea"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ARENOPOLIS" },
                    { new Guid("153c4608-44cd-44ad-92f7-720cb168b1b5"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTA CRUZ CABRALIA" },
                    { new Guid("157c6861-45ef-41e4-8099-e285da4ffaff"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "GONGOGI" },
                    { new Guid("159a0d02-f2e0-46c9-bbe4-9d0d023a840b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAGIMIRIM" },
                    { new Guid("159b8011-4618-48a1-8333-c0d8c746a00c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "DOM PEDRO" },
                    { new Guid("15e22f52-a323-46f2-9a98-749571034733"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LAGOA DA PRATA" },
                    { new Guid("15fb0514-7f85-4bb6-9996-f416b6ad6162"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PAULA CANDIDO" },
                    { new Guid("160e8663-66fe-4b4e-b801-092cabd2faa3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBOTIRAMA" },
                    { new Guid("161996f8-49db-414a-afa6-67154c41d981"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITUMIRIM" },
                    { new Guid("16233694-05c2-49cf-ad70-187e994bac59"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LAJEDINHO" },
                    { new Guid("164f5200-c558-4df7-8a10-a6a2742f8c64"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMPOS ALTOS" },
                    { new Guid("1671c821-62bf-4e43-99e4-c76ae566db18"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO FRANCISCO DE SALES" },
                    { new Guid("16923002-7813-4a62-89a5-7cd6e6dc82d7"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PEDRO DO ROSARIO" },
                    { new Guid("16971e7e-ebca-4c9d-b305-ede000e79ec8"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "JOAO NEIVA" },
                    { new Guid("16bffbd1-4d09-43c4-afb6-ccf4edb97af8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAMBE DO MATO DENTRO" },
                    { new Guid("16e56a3d-be0f-4873-baac-c6c8255fd4fe"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MACAUBAS" },
                    { new Guid("170a801b-b5c5-4d1e-808d-cbbf2bce4572"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO TOMAS DE AQUINO" },
                    { new Guid("170dd697-3e86-4209-85ae-5fc7c4b34074"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARGIRITA" },
                    { new Guid("171ac935-a0a2-4e6d-a42d-f92d6aac0784"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "INACIOLANDIA" },
                    { new Guid("171be01d-7def-4e3f-9cf5-53175bd8724f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBITITA" },
                    { new Guid("17339e6b-82ce-4060-ae9f-9b5022927c26"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIACHO DOS MACHADOS" },
                    { new Guid("17894d16-0467-411e-827c-e0ac604b3707"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ENGENHEIRO CALDAS" },
                    { new Guid("17a9bc4f-2510-475d-9ddb-379bec6e3d59"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "MANOEL URBANO" },
                    { new Guid("17de2a4e-3d76-435a-90ee-8b019b1b3a27"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MACAJUBA" },
                    { new Guid("18130e55-8029-45ca-ab7a-611f3cbc0c53"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOTELHOS" },
                    { new Guid("181e5fae-4592-41e0-b208-044a0f3a9c90"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO BENTO" },
                    { new Guid("18591c20-f17d-4ad9-bb2d-f5c78fc0196a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VOLTA GRANDE" },
                    { new Guid("18784346-5957-4b02-bc5a-a2324787dcfe"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MORRINHOS" },
                    { new Guid("1884e888-9a62-42e0-b3b2-b6cb40d5deda"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ACAJUTIBA" },
                    { new Guid("18940aa1-a2b0-4531-b41d-992d802fe584"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JANDAIRA" },
                    { new Guid("18b4238c-77c5-474e-9b6b-59dba869efeb"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "FONTE BOA" },
                    { new Guid("18daf288-5abd-4c8d-8bca-4961df6fb565"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "RUBIATABA" },
                    { new Guid("194c3144-a32b-4ec6-986e-f752ff300e45"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORONEL PACHECO" },
                    { new Guid("197eae08-b5ed-4542-b126-9c730c785efa"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MARTINOPOLE" },
                    { new Guid("199c9735-1e79-4e9a-98a0-3df2636d3c83"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MOSSAMEDES" },
                    { new Guid("19bb5dcd-8f82-4326-a66d-e796fcb266e2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BARAO DE MONTE ALTO" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("1a19dd2e-b11f-436a-bb09-15b8201853d7"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "GUARACIABA DO NORTE" },
                    { new Guid("1a418be5-c05b-4203-8a3c-ad2daa8bd0eb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PARAISOPOLIS" },
                    { new Guid("1a9182d3-9f8d-48bc-874e-48f67cdba443"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CHALE" },
                    { new Guid("1acabe7a-97ff-4d9b-991c-dbd58d6d575d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ARNEIROZ" },
                    { new Guid("1acb0e18-93eb-408e-ada2-296cbdc1ce86"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PRESIDENTE JUSCELINO" },
                    { new Guid("1b120d3c-d27e-4779-8468-bc4cb5896d77"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "PEDRO CANARIO" },
                    { new Guid("1b264054-a60f-4bf9-933d-43c5e0bc1d60"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "AMATURA" },
                    { new Guid("1b284d49-89cb-476c-86ec-4b6f594eabb8"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "LAGOA DO MATO" },
                    { new Guid("1b922bc6-0318-4e3d-aee7-ce29852d88be"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO SEBASTIAO DO OESTE" },
                    { new Guid("1b97b19f-06be-47bb-8d9f-458c34a7b113"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIBEIRAO VERMELHO" },
                    { new Guid("1b98ad49-8897-43fd-a544-e6a839b328de"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVA BELEM" },
                    { new Guid("1bb30639-f60b-4a1c-b690-c0f64676aa1c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TEODORO SAMPAIO" },
                    { new Guid("1bc10173-6ad8-47bb-b800-d05615b8897f"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SAO GONCALO DO AMARANTE" },
                    { new Guid("1bdcaa24-a6ef-4df4-8f31-e0dfd8e1ddcf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOSE DO DIVINO" },
                    { new Guid("1bde0745-63c5-421a-b81f-b802b66bf9cd"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MATERLANDIA" },
                    { new Guid("1be17e4f-f66a-468c-b80b-fa143c98b223"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "IRACEMA" },
                    { new Guid("1bebc43a-9fb9-4dd7-96b8-44996d1c5371"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DIVINOLANDIA DE MINAS" },
                    { new Guid("1bf94ef7-5f95-4e3f-8bd1-3e9a822fd44d"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BALSAS" },
                    { new Guid("1c07e120-9d2c-46cd-8ba4-7de56eb327ba"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITABIRINHA" },
                    { new Guid("1c786062-2fc4-4882-a514-d59a95d98268"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONCEICAO DOS OUROS" },
                    { new Guid("1c91068b-31b2-40fd-b0f0-45e72bc62a2d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "POCOES" },
                    { new Guid("1cb52388-e0db-4eb7-8870-393b6e62fa08"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITACARAMBI" },
                    { new Guid("1cbf69dd-bc21-4e7a-b3ba-4edd3410d336"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "CANUTAMA" },
                    { new Guid("1cc95dbf-feee-44cf-9136-cf8605abefbf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VIRGINOPOLIS" },
                    { new Guid("1d1d6087-e5b2-4a1a-a7c1-06ec13a653f0"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "JARDIM" },
                    { new Guid("1d350287-b116-4eec-b4d2-6d8d00f19e3b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LAGOA GRANDE" },
                    { new Guid("1d465e0f-5cbc-48e0-afd4-722fc0cc6da1"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "BARRO" },
                    { new Guid("1d5c0ca1-c460-49fe-a137-f2e18227ebd2"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "PRESIDENTE KENNEDY" },
                    { new Guid("1dc194db-4fa4-48ad-8b7a-d7e21f1ff6de"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "CORURIPE" },
                    { new Guid("1def4f1e-376d-435c-82ff-e6481b1005f7"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PINDORETAMA" },
                    { new Guid("1e2f0c86-c546-4c55-a483-171dede6e0ca"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MARIBONDO" },
                    { new Guid("1e5b8069-99c8-4b52-aa5e-a0c2c37b7e64"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MINADOR DO NEGRAO" },
                    { new Guid("1e8a15c9-858c-424d-8cd5-ec233bb6a6c0"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BRAZABRANTES" },
                    { new Guid("1e8b4ee9-f644-4a89-94f0-4dca0bf8407c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ENTRE RIOS DE MINAS" },
                    { new Guid("1e9073c0-8260-482d-ac20-4089abac8a04"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONCEICAO DAS PEDRAS" },
                    { new Guid("1eaa1b40-4a91-46e9-949a-25b967c19313"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CAVALCANTE" },
                    { new Guid("1eb0cc5b-5aca-494d-9ca1-1e9b1feda0a1"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TANQUINHO" },
                    { new Guid("1ed1cdc0-2522-4125-a6f4-ceee5a386826"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MEDEIROS" },
                    { new Guid("1ef3ecf0-5578-44b1-8f09-b40fef526892"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PRESIDENTE TANCREDO NEVES" },
                    { new Guid("1f109090-2537-4f35-be74-c31d9396f0ec"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAJUIPE" },
                    { new Guid("1f216541-4504-4207-9bf4-a8549c66ce14"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SERRO" },
                    { new Guid("1f8326ca-903f-4036-9ec6-4e4a7fdd4285"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "VILA PAVAO" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("1f880038-2d25-4142-9026-f36ec9701703"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTO ANTONIO DO RETIRO" },
                    { new Guid("1fc29a68-a6cc-4824-bf48-0024c26c715f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARACITABA" },
                    { new Guid("1fcf14d9-aff8-455e-8e7d-49c97a838dab"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "PORTO ACRE" },
                    { new Guid("1fd574bc-2238-4925-9abb-f0ead5203fc8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IBIRACATU" },
                    { new Guid("2000a073-1dc4-4e2e-a337-6c3def376353"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JUATUBA" },
                    { new Guid("2013ef81-27b1-43e3-accc-93100ec85b8d"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "SANTO ANTONIO DO ICA" },
                    { new Guid("201c4b81-409e-4cf2-95f3-cd3c6f65bd47"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PORTO FRANCO" },
                    { new Guid("201e83ab-8310-45da-a245-a505966c93c7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "OLIMPIO NORONHA" },
                    { new Guid("20291cf8-a152-4034-98bd-34aa5e6e246e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JAGUARIPE" },
                    { new Guid("20354207-3c43-4301-81aa-c469cbe0f728"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ROSARIO" },
                    { new Guid("203dfff1-03b5-4144-b6a4-70d2e25899da"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MATA VERDE" },
                    { new Guid("20486d0b-17eb-4835-a4c0-43ca108a6ed5"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CORIBE" },
                    { new Guid("205c9edb-97f5-4886-aaaf-ae6fad92f1e4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GOIABEIRA" },
                    { new Guid("20810f03-a868-4a19-91b6-1323e387c444"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GOIAS" },
                    { new Guid("20e48c4e-31d1-4bc0-ab53-55146a214f3a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO LOURENCO" },
                    { new Guid("210812ee-3e63-4e29-9235-48569f2b6114"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ARACU" },
                    { new Guid("210a3111-b389-4ee4-9d20-553c5e7add54"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "CONCEICAO DA BARRA" },
                    { new Guid("2136ebdd-6871-4e87-855a-7581ae967ec8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA BARBARA DO LESTE" },
                    { new Guid("21505f85-994b-4c67-93c0-cefd1d51f3c9"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MAIRIPOTABA" },
                    { new Guid("215f40d3-fd34-4e5d-a7bc-4f6ea62f72e7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA HELENA DE MINAS" },
                    { new Guid("2190214d-578b-4122-9964-f40c2d7f8b42"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "IUNA" },
                    { new Guid("21cd8ab1-b531-4c04-b12c-612b17ea526f"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "MAUES" },
                    { new Guid("21e7d34f-e02b-4ef2-b480-16ff82507749"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAVERAVA" },
                    { new Guid("21fee6dd-2014-4a81-a1b2-a6f03b2bb145"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAMBACURI" },
                    { new Guid("221f947b-6848-4061-8d7a-3379dbf13215"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MATRINCHA" },
                    { new Guid("224e5d8d-9dc7-478f-8859-e6502a76f03b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ITUMBIARA" },
                    { new Guid("227f2a0f-4b87-476c-b7a8-89d758117f12"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "FORMOSA DO RIO PRETO" },
                    { new Guid("2298e65d-5686-4ee0-b876-feffdbac450e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "URUOCA" },
                    { new Guid("22a3d511-cc8f-4e2f-a69f-2ff725f12f3e"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "BUJARI" },
                    { new Guid("22a41efd-d6da-4931-a659-a86897d0dad5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "POCO FUNDO" },
                    { new Guid("23075e9d-55f0-40fb-8c4c-047f119d2c19"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RUBIM" },
                    { new Guid("23438491-1f45-4b0d-9783-bf08afac8521"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CURACA" },
                    { new Guid("2345a9b1-927f-4c91-899e-6d10c77bf8be"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "UNAI" },
                    { new Guid("2345e4e1-ce4e-4a9a-8459-fba33b80a515"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TAPIRAMUTA" },
                    { new Guid("234d4b45-baa7-42d4-bd4b-f8de867929d5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MATIAS CARDOSO" },
                    { new Guid("23562d35-2437-413e-b248-0f1fe17b364a"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "NOVO ORIENTE" },
                    { new Guid("23621b88-882f-40a1-8e92-7dce6f217822"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CAJAPIO" },
                    { new Guid("2375782f-24a2-426f-9cd1-90ca997107e6"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "BARBALHA" },
                    { new Guid("237bb29d-d395-4e2f-9481-9d92940d6e5b"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "FELIZ DESERTO" },
                    { new Guid("239a2dad-2d63-4bd3-8df6-b16c96d89030"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PETROLINA DE GOIAS" },
                    { new Guid("23d6711a-d4f6-44a4-a1ca-2f26337ff8f4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAPITAO ANDRADE" },
                    { new Guid("24131897-4746-4747-9a8c-cf605ae313d2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CURVELO" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("2420f063-12e1-4386-821c-0aa16652f10f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CIPO" },
                    { new Guid("243308dc-e586-4e0d-ab9b-d9ed35e2e6aa"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO GERALDO DA PIEDADE" },
                    { new Guid("24545527-3cfb-478b-890d-26311b429de0"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTO ANTONIO DA BARRA" },
                    { new Guid("24801ac0-c5e5-484f-a987-9afc39a647f2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBICOARA" },
                    { new Guid("249b1e15-d338-4580-b873-349d14f1906d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO GONCALO DO ABAETE" },
                    { new Guid("24a22b73-964c-43b4-81c8-78c42ceb12e3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MARILAC" },
                    { new Guid("24c6ed93-65f4-415d-b27c-3f14ed29e1de"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CICERO DANTAS" },
                    { new Guid("24d7fe09-ee16-436b-8fe5-1c1613945086"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA MARIA DO SUACUI" },
                    { new Guid("24e551af-8788-4d18-8e8c-b8a475d4a5c3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "OURICANGAS" },
                    { new Guid("250deeda-8116-440e-a69d-ff0d0e1c10e1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOTUMIRIM" },
                    { new Guid("251c07c4-277a-42d9-94dc-6139be5fa3e8"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "JAGUARE" },
                    { new Guid("252f2817-6d18-4d6f-924b-b29b28bd186c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "UTINGA" },
                    { new Guid("253db183-2f35-4f3e-be79-a351df71c4f2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ENCRUZILHADA" },
                    { new Guid("254412ab-3000-493d-9950-17fb34734851"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "CACIMBINHAS" },
                    { new Guid("25aff3f7-f908-481b-a051-456e039d43be"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CONCEICAO DA FEIRA" },
                    { new Guid("25eb98c0-060f-41a5-b692-12d7c4ef75d7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PARAOPEBA" },
                    { new Guid("25f517d8-9c09-4195-8ee1-4e6a54a6626d"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ATILIO VIVACQUA" },
                    { new Guid("2656ddaf-9ce9-44e2-8a84-7138fb375e3f"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "GIRAU DO PONCIANO" },
                    { new Guid("266a6f55-2802-4e3e-97d6-33ad84b92742"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DIVISOPOLIS" },
                    { new Guid("268e2644-e7ae-4bff-ba43-7386cad1025c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO SEBASTIAO DO ANTA" },
                    { new Guid("269bfc6b-54c5-41f4-b951-16ff08585c9b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONTALVANIA" },
                    { new Guid("26c770c6-7c48-4347-b1e6-eca81fa107b5"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "SAO ROQUE DO CANAA" },
                    { new Guid("2710fab1-0db0-4e9e-b4df-9e44dbaac37f"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "COROATA" },
                    { new Guid("273159f3-59bc-4269-b6a8-92bd593d0754"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "BAIXIO" },
                    { new Guid("27704c9e-90b7-4286-b2b9-9019a39a5e20"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TANQUE NOVO" },
                    { new Guid("2798c6f6-fc65-4af4-b29d-e5acde972e1b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SALTO DA DIVISA" },
                    { new Guid("280f14c2-f6e4-4188-961e-cbc372000489"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PEDRO ALEXANDRE" },
                    { new Guid("28314b11-41c1-4ee1-a1b4-f09de75f7c25"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RAPOSOS" },
                    { new Guid("28634910-17d0-4a0f-8afc-71cba2cface3"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "PRESIDENTE FIGUEIREDO" },
                    { new Guid("288b6679-93b0-469d-8627-e9ae063a0cf3"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GOIANDIRA" },
                    { new Guid("2897049b-64ab-4d21-aee3-504e28f92da6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BELO HORIZONTE" },
                    { new Guid("28a8e672-333b-44d2-bcf6-71b5a0fe1244"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JAGUAQUARA" },
                    { new Guid("28ac5a7d-b4b6-443c-a3a6-9227bdf0903d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "URUBURETAMA" },
                    { new Guid("29061de7-c141-4f23-9b8b-c5dab4e5198f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BROTAS DE MACAUBAS" },
                    { new Guid("2925fb1b-70b2-4f4f-8cee-8d13da5135ad"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ESPINOSA" },
                    { new Guid("2928acee-164a-4de0-afe0-194215dc5882"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CACHOEIRA DE PAJEU" },
                    { new Guid("292a89b6-5224-4499-b014-cf411c9ff04c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PORTO SEGURO" },
                    { new Guid("293efacc-a455-4afb-9421-fed286d44657"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ALTO PARAISO DE GOIAS" },
                    { new Guid("2954e4b7-e84d-44c0-8d0f-4b22b09d7093"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "FLORES DE GOIAS" },
                    { new Guid("295c06ef-7458-4511-af3a-22b6c7ee770f"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ALTO ALEGRE DO PINDARE" },
                    { new Guid("29a47bce-b83e-489c-9780-f290ba3cedc6"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ACAILANDIA" },
                    { new Guid("2a533afc-f07b-4092-a471-c866246c9a81"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LAJEDAO" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("2a688ea7-cc72-4222-a91d-b8378690622f"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CACHOEIRA DOURADA" },
                    { new Guid("2a88f91e-5dc5-42ab-b9fe-daae9dbf32b0"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "VILA BOA" },
                    { new Guid("2abe05a9-4cd5-4144-aab4-1d237c87661e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "QUIXABEIRA" },
                    { new Guid("2ac7fde2-589b-4eec-9a3b-76da213cdc53"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "VITORIA" },
                    { new Guid("2b173aad-5d99-4fcd-81b7-8804689d14b3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMBUQUIRA" },
                    { new Guid("2b5ae185-1d61-4ba9-8c5c-f39bed94afa9"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "LORETO" },
                    { new Guid("2b6385ee-1398-4fe4-a42c-9a64c7100717"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PAULO RAMOS" },
                    { new Guid("2b96bb72-3d8f-44d0-b2a1-ed6aa7816a91"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BELO VALE" },
                    { new Guid("2bb15cc6-e89d-47ec-b994-cdd11e96516f"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PADRE BERNARDO" },
                    { new Guid("2bbb1a9d-d459-4ea5-ba86-2782b7bc2e86"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "IRAUCUBA" },
                    { new Guid("2bc90f61-a221-4d95-9518-06aaa9afd12e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTANA DA VARGEM" },
                    { new Guid("2bdd9240-ad6a-43bf-b510-c8cf9c4e1ee6"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "BARRA DE SAO MIGUEL" },
                    { new Guid("2bde46fe-3480-4dac-ac06-8d6db21f697d"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "SANTANA" },
                    { new Guid("2bf60197-2f9b-4ee5-ae04-8a1e14c5e00a"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SENADOR POMPEU" },
                    { new Guid("2bfcf0c2-9366-4c78-9668-581361050f02"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA MARIA DO SALTO" },
                    { new Guid("2c253367-d715-43b3-bdfb-bf182b611681"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONGONHAS DO NORTE" },
                    { new Guid("2c33005b-5d1d-4de5-88ae-9cbd938bc935"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITUIUTABA" },
                    { new Guid("2c752f30-8a0f-4db6-a2f0-5f2dcd14e5a6"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "URANDI" },
                    { new Guid("2c97d3d2-d7ce-4e9d-81c5-6088bda97255"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO FRANCISCO DE PAULA" },
                    { new Guid("2cb29176-1f76-4b9c-b090-ba15df1dd4be"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "OLINDINA" },
                    { new Guid("2cb58335-e4d6-4d59-bc3f-9bab60c59496"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "ANORI" },
                    { new Guid("2cd02ee5-b863-4c2c-b06d-4fa1e52776db"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ANTAS" },
                    { new Guid("2ceacab1-0aca-4fb2-9c9d-2cf28eb4b787"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CONCEICAO DO LAGO-ACU" },
                    { new Guid("2cee9ecb-144b-4144-ae20-6f1a3f7429ae"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JOAO MONLEVADE" },
                    { new Guid("2d3b3367-4a1b-4df6-a3b8-64651b88389b"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MATINHA" },
                    { new Guid("2d898804-de60-4b5f-bf21-13befe0f3c4e"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NOVA ROMA" },
                    { new Guid("2dc17063-8e95-4627-86ee-41aa21116a21"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BONFINOPOLIS DE MINAS" },
                    { new Guid("2dfee8cb-4005-4535-9337-89a21c99fa64"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DIAMANTINA" },
                    { new Guid("2e0183e7-0879-4e3e-ba2c-714986777f2d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ABAIRA" },
                    { new Guid("2e1c3fe4-5157-470c-b11e-0f74da662b9d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IGARAPE" },
                    { new Guid("2e1de986-6e05-43b9-a35f-b74e860c6a34"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "MARECHAL FLORIANO" },
                    { new Guid("2e24586d-ac82-4327-8aee-5a7a73fa6a21"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IBIAI" },
                    { new Guid("2e29e67b-e4cd-46c3-933c-493cbfa88d98"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "PEDRA BRANCA DO AMAPARI" },
                    { new Guid("2e4d5438-346b-471e-8315-f230ccae4744"), new Guid("fe9058f9-f26d-4c2f-8cc9-b1f0278d311f"), "BRASILIA" },
                    { new Guid("2e847c18-cd10-441c-8f2c-acd12185b6ea"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "JAGUARUANA" },
                    { new Guid("2e9aed52-b38d-4b4f-8fa7-168a167e92b3"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PALMEIRAS DE GOIAS" },
                    { new Guid("2eff9983-64e8-44d0-8035-43aa880e53c9"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "LAGOA SANTA" },
                    { new Guid("2f59c23b-c2e3-4ba6-a7cf-c3c8ca9d0df9"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "BERURI" },
                    { new Guid("2f6cd70a-7a45-410c-9aa6-1c19ee641643"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NOVO HORIZONTE" },
                    { new Guid("2f7b8eba-1972-4c6c-9620-b9bdcb794c44"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IPABA" },
                    { new Guid("2fd51fc4-3929-47ff-8ac1-7179b2614a2b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ALTO HORIZONTE" },
                    { new Guid("2fec837b-826e-4066-8bc0-8bb15fa743f2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ESTRELA DALVA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("30142eb8-8592-45ce-ba12-16e82f369e78"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONGONHAL" },
                    { new Guid("3046d229-3b66-4fe8-85e3-f0749e3cb65c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARANAIBA" },
                    { new Guid("30738c56-d541-486e-a613-c68ada0d6abd"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MATHIAS LOBATO" },
                    { new Guid("307ab271-19da-4bfb-8ada-b5ab6feb2acf"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "DEPUTADO IRAPUAN PINHEIRO" },
                    { new Guid("30cdc9da-b265-476d-ac49-2bab12777582"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAPELA NOVA" },
                    { new Guid("30f229f6-e25c-4535-aa1f-9d52c73e1d18"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CURRAL DE DENTRO" },
                    { new Guid("30f9d1d0-caf1-44bc-8ca6-cc582e32c637"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PALESTINA DE GOIAS" },
                    { new Guid("31017c55-4dfa-4649-bc35-cdce32a0b654"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IAPU" },
                    { new Guid("3123cc6a-fa6d-4f0d-8017-7e0212fecc74"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MARANHAOZINHO" },
                    { new Guid("3129da4c-56a5-47b1-b6e9-91a12095dcd8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MARAU" },
                    { new Guid("313e37c7-b27e-4c88-9c80-024ee723d914"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ERERE" },
                    { new Guid("3142468a-161f-47ed-bb5c-d73d45e65f88"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MANOEL VITORINO" },
                    { new Guid("314c9e47-3751-4cba-b88b-0ebca121d074"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LEME DO PRADO" },
                    { new Guid("315ca71c-b4fe-4836-96ef-af270a24b5c4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO DO PACUI" },
                    { new Guid("315f22e4-86f8-4503-af58-710b51f4a157"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MUCAMBO" },
                    { new Guid("31771ec4-5acc-40e2-b4d4-1cb19fffc06c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MORRO DO CHAPEU" },
                    { new Guid("31925257-246b-4f00-9cb2-4b33732e134a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBIPITANGA" },
                    { new Guid("319d536a-6f0b-4e53-b615-004d2175596a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DORESOPOLIS" },
                    { new Guid("31c65b75-4c1b-4089-b795-05eb4e83a350"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "TONANTINS" },
                    { new Guid("31cddcac-81f1-4edc-aac2-54b7289c9e98"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARRANCAS" },
                    { new Guid("31db46b8-6268-4b13-a517-9ac335b27311"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "ALVARAES" },
                    { new Guid("31f9dd07-eb1d-43e3-9584-af1ec1c3f1a8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "VALENCA" },
                    { new Guid("322ff59a-e8b9-4aac-b235-7a722fe14e05"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "SAO MATEUS" },
                    { new Guid("323bcdfd-ad99-481d-bf76-4a690c0df0c3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BOM JESUS DA SERRA" },
                    { new Guid("3269a27e-702c-41cd-83e6-f067f32b6790"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "VARGEM GRANDE" },
                    { new Guid("32a4a98f-2f11-40d4-93df-5eae01fc9052"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CORRENTINA" },
                    { new Guid("32c3bf41-05dc-4417-840b-d31acd9c254b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PIRITIBA" },
                    { new Guid("32ce9e6a-a62b-404a-9621-bb5e24c73554"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LAPAO" },
                    { new Guid("32ecb171-2b2c-4a61-b5ee-f097db6d13c1"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTA RITA DE CASSIA" },
                    { new Guid("3318fa98-4b57-40c6-80eb-f894d1112b4c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BAIANOPOLIS" },
                    { new Guid("3336e47f-52bb-45e9-942a-b466ea300b0a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTANA DE PIRAPAMA" },
                    { new Guid("333858f4-8814-4d17-8ada-3de85925022d"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CORREGO DO OURO" },
                    { new Guid("333b7f92-8f90-4829-8185-6cbac2dbe859"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "BOCA DO ACRE" },
                    { new Guid("33414464-ab66-40e9-896f-00299ef51bb3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GOUVEIA" },
                    { new Guid("337a8d33-f93e-4847-801c-96b1fbc16b31"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MARAGOGIPE" },
                    { new Guid("338d7f1a-dcc1-4f0e-a85d-3677c0e8bdb5"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "POJUCA" },
                    { new Guid("33925165-b80f-4058-a4db-8496bd72dac2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VESPASIANO" },
                    { new Guid("33c4ea2e-59e6-4be7-ac44-0386291a6a32"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "DAVINOPOLIS" },
                    { new Guid("33d81390-9d45-4b74-a429-e57f33c50f09"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO FELIX DE MINAS" },
                    { new Guid("3404dbf7-f4d9-4722-a4c9-a3386eea4299"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ITAPECURU MIRIM" },
                    { new Guid("340f577a-8732-4795-ac56-767a2dff891a"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PRESIDENTE JUSCELINO" },
                    { new Guid("344a2415-0a7a-4c20-a8ef-8c9edd143cb7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MURIAE" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("344afdd4-169c-4d83-b9d1-a7ae497f3d29"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO MIGUEL DO ANTA" },
                    { new Guid("34748775-ac09-4eaa-8e4f-d15d77cf9e58"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "AMERICANO DO BRASIL" },
                    { new Guid("348e24db-3038-4e5c-a9b7-ef2aae604431"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "VALPARAISO DE GOIAS" },
                    { new Guid("34992c97-db64-44ec-96ab-79fdb23269a5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PAPAGAIOS" },
                    { new Guid("349d3a2d-2bf5-4944-86f4-f78f3bc5585c"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CABECEIRAS" },
                    { new Guid("34d87c00-1f22-49c4-8345-696bc1f58ebc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LAGAMAR" },
                    { new Guid("34ddacb4-2813-4abb-b12c-b78a0c89899b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO JOSE DA VITORIA" },
                    { new Guid("34f2ae6c-64a9-4619-93f1-789de47805d0"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "FEIJO" },
                    { new Guid("34f93040-4ebd-424a-bbbf-57c5566621c4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIUMHI" },
                    { new Guid("34fbb1b0-ee48-455e-898c-b27ba79d7ff6"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MASSAPE" },
                    { new Guid("35218206-6806-483e-b655-9ec5381a85fe"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEDRA DOURADA" },
                    { new Guid("353be00c-ce3d-4672-ac8e-23dee7f14285"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "COLINAS DO SUL" },
                    { new Guid("355fa734-dfa0-4227-a6ce-f00ab36fdd0b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORREGO DO BOM JESUS" },
                    { new Guid("3562b9af-6d42-44d9-866f-c7581b98016a"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "TARRAFAS" },
                    { new Guid("35a2a2ca-4ab8-4734-baca-c55be2d2b847"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BACURITUBA" },
                    { new Guid("35a48e86-8239-44d5-b2f8-ae6b0a1a3a61"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "TAQUARAL DE GOIAS" },
                    { new Guid("35b11d37-e50d-4b29-9f98-0880ff303ef3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MUNHOZ" },
                    { new Guid("35c9e05d-31e1-41c1-8b67-e4136a7f1e96"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JACUI" },
                    { new Guid("3601e0a1-cbff-48e8-ad03-67530fe0ba2f"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ANICUNS" },
                    { new Guid("36083f48-58bd-4df4-b507-b3bf000dfc24"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LUIS EDUARDO MAGALHAES" },
                    { new Guid("36457693-2c5e-437e-9388-f6ba9cbe616b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NIQUELANDIA" },
                    { new Guid("366ee1a1-a2db-49fb-a19c-b0b984e7688e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CARIRIACU" },
                    { new Guid("3676a73a-f1cf-4b2f-bc93-3a4b730f81b8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARAI" },
                    { new Guid("36838d1f-6544-4d9f-8337-53d864c1a421"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PINDOBACU" },
                    { new Guid("36ab4630-2b37-4de6-8d40-c4e2396947e9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONCEICAO DAS ALAGOAS" },
                    { new Guid("36ace506-67d9-4a15-99db-10c2ddff19e2"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SAO LUIZ DO NORTE" },
                    { new Guid("36d38abf-2245-4738-9692-a101c31100ef"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "QUEBRANGULO" },
                    { new Guid("36f1c557-fe5c-47a3-bf69-ab5ca34c4b19"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "QUELUZITO" },
                    { new Guid("371f7a74-6e8f-4234-b3fe-61448899e1a8"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "NOVA RUSSAS" },
                    { new Guid("3724efdf-1f70-4357-9602-48bd15289b17"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ITAIPAVA DO GRAJAU" },
                    { new Guid("37335877-c8a6-47e3-853c-5e5b6fcb12d7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "OLHOS-D AGUA" },
                    { new Guid("375b6896-2564-4556-9782-2cd28368481e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FREI GASPAR" },
                    { new Guid("3769c6ba-806a-4b36-9cf6-262837740fb2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TUMIRITINGA" },
                    { new Guid("37995aaa-3e63-47e8-87d9-665f6f9b879d"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SANTA HELENA" },
                    { new Guid("37ae8530-769b-4204-a4c5-416b0f67f9dc"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAPITANGA" },
                    { new Guid("37be067a-db71-4694-a6ca-99ab5c17bf7e"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "MAZAGAO" },
                    { new Guid("37c1b1ec-8e9f-4333-8410-616ab63da921"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO EVANGELISTA" },
                    { new Guid("37ecf469-720e-4e96-9cd5-f8e09076ebb1"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "VARJAO" },
                    { new Guid("3857c681-174c-4223-ad60-855ad98d3b79"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO DOMINGOS DO PRATA" },
                    { new Guid("3882121e-0291-4d14-969b-b08406ee487f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JUSSIAPE" },
                    { new Guid("389a5f56-9e0c-4f88-9509-6d4b60e073b9"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BURITI BRAVO" },
                    { new Guid("38a94078-e755-43fc-82e9-4f4c706df2b8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SALINAS" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("38abf0d2-e8ac-44aa-b35c-009f41e85f4c"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "SILVES" },
                    { new Guid("38d0e049-404e-4f73-b181-a9a947e2e8e5"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SAO DOMINGOS" },
                    { new Guid("38e816d9-528c-4461-9b4b-cfd4566d77fa"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "VITORINO FREIRE" },
                    { new Guid("38ede79b-03d0-4fd0-bdaf-56ead1ad4b52"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONSOLACAO" },
                    { new Guid("38f086be-ca4b-420e-bf34-b80f833ab344"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TARUMIRIM" },
                    { new Guid("38f3d1f1-b5be-4fc2-bc07-3c73e627a73d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUARARA" },
                    { new Guid("39236883-acf0-4e56-a132-03dd78addb98"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIRAJUBA" },
                    { new Guid("393cb81d-bc43-4775-9982-d694a6dd77b3"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "BATALHA" },
                    { new Guid("394da3c6-93fc-4232-b40a-2fd2e7f6cafe"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TOCANTINS" },
                    { new Guid("39830909-8f2d-4df4-b421-05f2068ed1ec"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ERICO CARDOSO" },
                    { new Guid("399b222b-7df3-447c-bc64-da7f4bdc149b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "TRES RANCHOS" },
                    { new Guid("39af68e3-fb0e-478d-8cbd-0ef7e0e5bf38"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "TEJUCUOCA" },
                    { new Guid("3a00a32e-462f-4db6-bfe6-1845f588c7ab"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORONEL XAVIER CHAVES" },
                    { new Guid("3a220282-7365-4758-8e97-5ee428a31cb0"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "FORMOSA" },
                    { new Guid("3a2218c2-5a16-453b-ad52-77ce1019a1c2"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "SAO GABRIEL DA PALHA" },
                    { new Guid("3a45af45-579c-4b2f-aa0e-0f52c6e31c4c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEDRAS DE MARIA DA CRUZ" },
                    { new Guid("3a62cac1-3e9e-4683-9ea5-a4dda743e17a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MATEUS LEME" },
                    { new Guid("3a671a8c-3975-48a5-835f-d359c33f3e8e"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CERES" },
                    { new Guid("3a6c8807-6c7a-4f82-9d1f-ff3b8fb56b77"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SENADOR FIRMINO" },
                    { new Guid("3a839f11-6b6f-4a22-b01a-b2e53af48717"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MANGA" },
                    { new Guid("3ab3c590-160c-4639-9d8d-b01e7aa55888"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAUBARA" },
                    { new Guid("3aee921f-120e-4dbb-80d7-028642376aea"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "INIMUTABA" },
                    { new Guid("3af0bcd6-c7d9-4018-8cff-b513ba337487"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BERIZAL" },
                    { new Guid("3afb66bc-03cf-4318-9722-f8868ead08e7"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CRIXAS" },
                    { new Guid("3b2d80a9-c9cc-4f37-81fd-caa883c70ea1"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "JUNCO DO MARANHAO" },
                    { new Guid("3b4bf0ad-aaae-4177-bd67-faf48afe06fd"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "EIRUNEPE" },
                    { new Guid("3b5bd984-711d-4e29-a5bc-5bc77edb6b6a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SOLEDADE DE MINAS" },
                    { new Guid("3b67ba5e-4471-41ab-a839-fc74f222f2e3"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "MARILANDIA" },
                    { new Guid("3b6f4a1d-4211-4a2e-858d-628e9e5a147a"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "ITACOATIARA" },
                    { new Guid("3b72859c-571c-4d8d-bba7-73a304a4568b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARANGOLA" },
                    { new Guid("3b85954e-1c11-42db-b95b-2689f843b02a"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MARACANAU" },
                    { new Guid("3b967895-e116-488d-9240-8c13e77bd006"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SIMAO PEREIRA" },
                    { new Guid("3bad03ab-9bde-45ff-8b4b-27dc8b390236"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "RIO NOVO DO SUL" },
                    { new Guid("3bd21cf8-c558-4026-a57a-43c06af4524c"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "SERRA DO NAVIO" },
                    { new Guid("3bfaad8a-2463-4310-891d-9538f823ec74"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ROSARIO DA LIMEIRA" },
                    { new Guid("3c28c989-8ccf-40d7-b6d6-962196a88571"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "URUCUIA" },
                    { new Guid("3c59aa3f-80d8-4538-8468-b047efee9d37"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MACURURE" },
                    { new Guid("3c672ee4-8759-48cd-8418-d6c320389baf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "EXTREMA" },
                    { new Guid("3cba84c0-a2b2-4af6-a448-8b9fa0c479fe"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "GRANJA" },
                    { new Guid("3cc7b29b-fd79-4d3e-bbaa-426c597b541b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTANOPOLIS" },
                    { new Guid("3ce1a8f6-1cbb-4ffb-8850-dbb0627dcbf0"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RESSAQUINHA" },
                    { new Guid("3cfaaff5-f697-4be5-a3ec-f3166dc29336"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAMARANDIBA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("3d892812-401e-45ad-b416-9a911ba12ab1"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "SANTA TERESA" },
                    { new Guid("3dc1979f-e678-4522-b927-03f8ee12300e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITABUNA" },
                    { new Guid("3dc1b274-d2da-44b4-9663-f5b338ad4e25"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CEDRAL" },
                    { new Guid("3dd8e68c-3a69-4896-8037-fc3faf81b8c1"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TERRA NOVA" },
                    { new Guid("3df60942-0c9c-4a25-9157-c8bc8067453c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "DUQUE BACELAR" },
                    { new Guid("3e0ecfc9-fd2b-4b91-a67b-78b3d1d846a3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TEIXEIRAS" },
                    { new Guid("3e26f161-2d52-4973-bd5f-026c0c0b8d81"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PLANALTO" },
                    { new Guid("3e3966f4-f454-4da5-938c-ae36eb64eef5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DELTA" },
                    { new Guid("3e3cb7d1-8b32-4aaa-a0f2-616824d6a49d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO DO MANHUACU" },
                    { new Guid("3e3d8e81-46d3-43de-896d-5f2d029f2dbb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "AREADO" },
                    { new Guid("3e4f0d0f-3830-46bf-a0ad-6787f8b3b7e1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEDRO LEOPOLDO" },
                    { new Guid("3e59725c-b8da-45dd-9f40-6568ed3f9496"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BURITIRAMA" },
                    { new Guid("3e649a71-ef4a-4607-b95b-ea1e7a0ddde4"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IRARA" },
                    { new Guid("3e97d477-2e80-47bc-a102-748f4848c92a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NOVA ITARANA" },
                    { new Guid("3eaaa550-fcfe-4773-a081-acfecf3dc41c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO JOAO DO CARU" },
                    { new Guid("3ecd2ae0-031f-49e1-8098-1d6beecebeb2"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ITAJA" },
                    { new Guid("3edb312b-6b3d-4a8f-a7f1-3f167bf2d11b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JOAQUIM FELICIO" },
                    { new Guid("3ef20c7d-3b48-45e0-89d2-022cc1bc3a22"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SAO JOAO D ALIANCA" },
                    { new Guid("3f2c110d-d7f5-499d-8e7e-6770fabcbe0d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TURVOLANDIA" },
                    { new Guid("3f8a1db2-033c-4c88-9abe-a7a990119a1e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JACOBINA" },
                    { new Guid("3fb9388c-ba14-42b0-b0a8-b84c74f80e67"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "COLINAS" },
                    { new Guid("3fc20b73-ea09-4633-8377-f4248b765303"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO JOSE DE RIBAMAR" },
                    { new Guid("3fcb6f9f-4422-4db3-a164-7cb3e88de99a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTO ANTONIO DO ITAMBE" },
                    { new Guid("3fdb6153-473f-47e7-9166-e1b5a5639659"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO PARDO DE MINAS" },
                    { new Guid("3fe45a83-a900-4f6d-838d-3f523a3c7dd5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SENADOR JOSE BENTO" },
                    { new Guid("3fec168f-70f6-4cc2-b7b2-c9c5126a7f16"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PERDIZES" },
                    { new Guid("40072db3-5580-43c5-a84f-9539162087c8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RAFAEL JAMBEIRO" },
                    { new Guid("401275d5-1d69-4a39-a914-e0563b13812a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARANTINA" },
                    { new Guid("401fa980-754c-418b-bbb6-29834a5cf35b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAQUARA" },
                    { new Guid("4049bc5e-a6b7-437d-94b6-27f643a83131"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "INHUMAS" },
                    { new Guid("40720aa5-d2cb-473c-a864-c0732f06c148"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CANDIDO MENDES" },
                    { new Guid("409c9363-3033-4018-9720-95903a2d9be0"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DOM CAVATI" },
                    { new Guid("40af0ab5-e575-411c-98f5-e065ed8438f8"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "HEITORAI" },
                    { new Guid("40d2aa01-2b60-4487-b008-2a1e3721564c"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PAULO JACINTO" },
                    { new Guid("40da6756-c6ed-4f05-9b58-9a1802aece47"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CRISTIANOPOLIS" },
                    { new Guid("41136d64-4119-46d2-9bb4-89f61acd6814"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAREACU" },
                    { new Guid("4118386c-8a8d-4a54-b81f-596589915b1b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CENTRAL DE MINAS" },
                    { new Guid("41348964-396d-4b53-99d1-2a6263d0a8d1"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CANDEAL" },
                    { new Guid("41475c8d-1efb-4d2d-b706-87f0bc53cfd9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONCEICAO DO MATO DENTRO" },
                    { new Guid("41750d78-9b4c-4d41-8e7b-23debaba4a95"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAMAMU" },
                    { new Guid("41ebb73b-ac89-4b99-8848-5157dd48acef"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CANAA" },
                    { new Guid("42214b68-137b-43b7-b58b-fe6695569b76"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SERRA AZUL DE MINAS" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("42587e8c-ca25-4dd2-af28-65aa3cfaa452"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PARAMIRIM" },
                    { new Guid("425eb9f2-c1bb-4158-9db0-285800cf01ca"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "EUGENOPOLIS" },
                    { new Guid("427b1ce1-1b4b-4a3f-a550-981ad2869ad2"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO FRANCISCO DO MARANHAO" },
                    { new Guid("42b0fd93-5d33-4817-ba9c-a5d4fe338882"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO ACIMA" },
                    { new Guid("42c5bbe8-720c-4785-a754-4a3c71eec14b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIMENTA" },
                    { new Guid("42f9cf95-2e2b-4ec8-b20b-336915ecd730"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONSELHEIRO PENA" },
                    { new Guid("431b1891-7be1-403e-870f-3390be2c907b"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CATUNDA" },
                    { new Guid("43274396-293d-40a2-9d73-ebebb1450bf3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PLANALTINO" },
                    { new Guid("432d8582-f228-44e7-a7a7-f65c36be53ea"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VICOSA" },
                    { new Guid("4358f432-815b-4dbe-98ad-cc2ad53c38b7"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAETITE" },
                    { new Guid("439da1a7-5890-4e5a-9b77-b05251a00006"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "APICUM-ACU" },
                    { new Guid("43bc680d-9e5e-4916-82aa-848029e624f3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "GENTIO DO OURO" },
                    { new Guid("43bdc4cc-6c02-497c-9feb-153b1e72d0a5"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "FORTUNA" },
                    { new Guid("43f0c884-8868-4183-b490-30299808c664"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BARROCAS" },
                    { new Guid("443a8710-fd3d-4f00-a9a1-e1aaa79a373b"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "ANAMA" },
                    { new Guid("44a605af-f04d-4ad6-be17-8fdbaf1233df"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CAMPO LIMPO DE GOIAS" },
                    { new Guid("44cf334d-f419-4d3e-a5c4-c18b9baf1e43"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DOM BOSCO" },
                    { new Guid("44e1e68d-22fc-4a57-b041-af33c74cba69"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALVINOPOLIS" },
                    { new Guid("44fa3bf1-38ef-4eb2-b81b-052da0035810"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LAJE" },
                    { new Guid("4508a3c2-024c-474b-a3b9-370c42517eb9"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SENADOR ALEXANDRE COSTA" },
                    { new Guid("451d56df-1fff-475b-a740-6eaa6c441022"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ORATORIOS" },
                    { new Guid("4520e74e-1a4b-4ff3-9705-f61896534202"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "VARZEA DA ROCA" },
                    { new Guid("4525b38a-4578-4d01-beb5-00760e3aff23"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GONCALVES" },
                    { new Guid("4554350d-8dcc-4590-a288-cabb4ab8ff28"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PEDRA BRANCA" },
                    { new Guid("455e0890-b24d-41e5-ba0f-cb0148613646"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CASTRO ALVES" },
                    { new Guid("4569d25d-1fbf-4bcf-b2ca-5eaa375674ce"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO PEDRO DOS FERROS" },
                    { new Guid("45725bd8-251c-4488-b751-64ab01bf6707"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PONTO NOVO" },
                    { new Guid("458ef455-e3f1-4b09-9359-4210eff29cd8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GRUPIARA" },
                    { new Guid("45bc22b4-7fbe-45bd-af8c-502df76f473c"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "BREJO SANTO" },
                    { new Guid("45d6f964-9749-4290-ad1b-b83d412773c6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IJACI" },
                    { new Guid("463f1bab-d762-4e33-90bc-30e831ee6f45"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ZE DOCA" },
                    { new Guid("464d0487-8479-4a98-93c4-675ada1bbeea"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOSE DA SAFIRA" },
                    { new Guid("46741bb2-d5fa-46fc-8960-4d0b559f9a75"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CATUJI" },
                    { new Guid("468aba02-f5c8-4129-8c81-0045b2d3704c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CALDAS" },
                    { new Guid("468c97bb-ec95-471d-91ae-c666e5a580e5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOSE DA VARGINHA" },
                    { new Guid("46aa0f0e-d851-4305-b93f-941c45720f68"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "DOM MACEDO COSTA" },
                    { new Guid("46b8329f-7d96-4602-9ab2-eb190bfafede"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CACHOEIRA ALTA" },
                    { new Guid("46cc42ef-dd72-41c9-b490-6ba0cfb421e6"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "ASSIS BRASIL" },
                    { new Guid("46dbc339-c3ef-47a2-bf2f-4ed5692dff52"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONTE ALEGRE DE MINAS" },
                    { new Guid("4714f846-9a20-48fe-bead-a067b20f9839"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "TERESINA DE GOIAS" },
                    { new Guid("47180260-9534-4b43-a6de-467f01508139"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOM JESUS DO GALHO" },
                    { new Guid("471838b7-173a-455d-a9d5-a756f8012ce5"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "JOAO LISBOA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("472d0d35-756e-4801-a810-e30b2cabc946"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CENTRO DO GUILHERME" },
                    { new Guid("474276ed-1ef8-4de4-9af4-2f6f465924be"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "TARTARUGALZINHO" },
                    { new Guid("478275bf-1f1d-4edf-abc6-d628f78eead2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONTE BELO" },
                    { new Guid("47953655-0597-45d4-aedb-efe5410c19c6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMPINA VERDE" },
                    { new Guid("4796ffb9-efa7-4005-91cf-11169e1828a5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VIRGINIA" },
                    { new Guid("479885b1-fc7c-452b-9323-54e0598063b4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TEOFILO OTONI" },
                    { new Guid("47a5b653-5025-4aa4-88e4-b9be88457921"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ANTONINA DO NORTE" },
                    { new Guid("47b2e70d-01ca-4136-8f3a-09e914af4d0d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ITAICABA" },
                    { new Guid("47e22bbd-20ef-4ca0-9f84-7e0f94120acf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "AGUA COMPRIDA" },
                    { new Guid("47fa350b-69c9-407b-ac92-3803d6df4ea6"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IGUAI" },
                    { new Guid("486b7013-edad-45cf-afe0-9c8a90314a8b"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "JURUA" },
                    { new Guid("4885ef3e-f5a8-4765-9d2a-c712520d4460"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "OLHO D AGUA DAS CUNHAS" },
                    { new Guid("48ac7538-27dc-4f71-9df7-2e8e5a42c911"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JIQUIRICA" },
                    { new Guid("48c7bc3f-24d5-43fc-9b1d-971c20d0836c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "VITORIA DO MEARIM" },
                    { new Guid("48ed6d4d-4af3-4dd9-b747-cf182d1073f7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SETUBINHA" },
                    { new Guid("491467b0-fc3b-4473-9728-87416ee12789"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LAGOA DOURADA" },
                    { new Guid("493f92a1-8b4e-476b-a700-bca30bf22643"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITABERABA" },
                    { new Guid("4945be52-675d-4a35-9b96-2126b8a7605d"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PROFESSOR JAMIL" },
                    { new Guid("494a18d1-6d4e-4fb3-8484-82d6d93b0400"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "JUAZEIRO DO NORTE" },
                    { new Guid("494ba790-80ae-47ff-881b-7dc01fa236ea"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ITATIRA" },
                    { new Guid("49580e1c-87a7-4ab8-8a48-3cd091981f93"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ABADIA DE GOIAS" },
                    { new Guid("49764dae-db7c-4262-bbaa-090614eed7ca"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CARIRE" },
                    { new Guid("4976b515-a1cb-4fa8-87b4-5000ce1596e1"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "AMELIA RODRIGUES" },
                    { new Guid("499fd706-5914-42c0-85c2-9b520e2bc27b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CRISTIANO OTONI" },
                    { new Guid("49afab94-a73f-4cf9-aaf5-b4d974916a87"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO GERALDO" },
                    { new Guid("49c04557-90e4-4847-928f-d99f5363d02f"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "GRAJAU" },
                    { new Guid("4a1cf7cb-6f54-4253-b1bc-7b561d3822ab"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBIQUERA" },
                    { new Guid("4a6827cb-b4f9-44bb-bd37-2c0fe6855b1e"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SITIO NOVO" },
                    { new Guid("4a6ec0b8-6d10-45e6-83ab-3db3b515934d"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "URUANA" },
                    { new Guid("4a7c04a1-f236-4376-9031-e848ec546929"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "AGUA BOA" },
                    { new Guid("4aaea1c0-4219-4ee7-a180-ba42032db696"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ARACAS" },
                    { new Guid("4ad26278-1b7b-4c19-92d5-0037ff5d85de"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "AXIXA" },
                    { new Guid("4ae45525-cf5f-4953-8182-cc278ab32471"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MOEDA" },
                    { new Guid("4aeef8d4-ed9c-42b5-8fed-8a43b49f47cb"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SERRA PRETA" },
                    { new Guid("4b003fd7-b112-4c16-9de4-44e2db349d9f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAUDE" },
                    { new Guid("4b2bb3e2-dfec-445a-ae99-c21d0d1f6bad"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOSE DO MANTIMENTO" },
                    { new Guid("4b6819bb-fd64-4884-9fd8-72b369bef486"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GOIANIRA" },
                    { new Guid("4b6d875c-1c7c-45e3-b6cd-d3b80f0f5121"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SANTA LUZIA" },
                    { new Guid("4b8301f4-78f0-4d0b-b0f9-a129a3e175b1"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "NOVO LINO" },
                    { new Guid("4bbcde97-766f-441f-9734-f78124770620"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PEREIRO" },
                    { new Guid("4bcafce0-c44d-4280-a293-1d73b129b38a"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CORUMBAIBA" },
                    { new Guid("4be68743-67fc-4a30-a2f2-201f4ecfd359"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BOTUPORA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("4bf1ca9a-1f24-46c3-8b82-57f6c5856701"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMPANHA" },
                    { new Guid("4bf801d3-b184-43fe-a6f8-a05620cd3733"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIRACEMA" },
                    { new Guid("4bfab932-790b-40bb-a864-82513c326e51"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAIRU" },
                    { new Guid("4c4725d8-c11d-4622-b365-20aca5aa7110"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ACAIACA" },
                    { new Guid("4c600e27-c274-491a-8822-468cb0b294bb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VERDELANDIA" },
                    { new Guid("4c7c0976-d0c9-4fbe-adc1-24515811cb84"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PRESIDENTE KUBITSCHEK" },
                    { new Guid("4cdfed52-27b2-408e-bca2-1b91dc709e42"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "SOORETAMA" },
                    { new Guid("4cf4a5aa-5165-4198-a06e-13faff350f4d"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SATUBA" },
                    { new Guid("4d27b5f8-807d-4c7e-a96b-6fb9269b53a5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JANUARIA" },
                    { new Guid("4d40210e-8fd0-4535-91f1-2d95fd03db5f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MONTE SANTO" },
                    { new Guid("4d4b6f67-ed32-4e22-acfd-9380a3f20edf"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ARAME" },
                    { new Guid("4e0626ad-89f5-4d71-80b2-b1725ee990a9"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "QUIXERAMOBIM" },
                    { new Guid("4e38e694-4f15-48de-b85c-f99d84696035"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LASSANCE" },
                    { new Guid("4e3c9398-5206-4abe-8bf9-bcc3f1932f4d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "JAGUARIBE" },
                    { new Guid("4e417340-bc55-4e4a-9f74-128d549ba5eb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MARTINS SOARES" },
                    { new Guid("4e4a6d82-0091-4f8c-8783-1cf43dda4773"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAXAMBU" },
                    { new Guid("4e53576a-fe8b-497e-86d2-eec33b310f78"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CHOROZINHO" },
                    { new Guid("4e8be951-3e21-414b-8c90-4d0961501142"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARAGUARI" },
                    { new Guid("4e9ccbbc-fe6a-4da4-a449-f3edc69e8ae2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PILAO ARCADO" },
                    { new Guid("4eda7f30-64ec-49ea-99eb-530fcc61eec6"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BURITI DE GOIAS" },
                    { new Guid("4ee84990-8843-4530-a02d-e11847313dbe"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "AGUAS LINDAS DE GOIAS" },
                    { new Guid("4f0a5d2a-41a4-4acc-ba26-b08b48b130f9"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "IACIARA" },
                    { new Guid("4f2d8411-32ce-46ed-9444-30e2363fa878"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "OURO VERDE DE MINAS" },
                    { new Guid("4f68342a-2683-4363-8fdd-417957a446cc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONSENHOR PAULO" },
                    { new Guid("4f8edd10-dd34-46bd-bac7-715775115d62"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BREJOLANDIA" },
                    { new Guid("4f9476d6-1cf5-49e3-8746-1812b4a12808"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RIACHO DE SANTANA" },
                    { new Guid("4fb3b3e1-c274-4a87-a905-aa0c66ec5687"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "VARZEA ALEGRE" },
                    { new Guid("4fc52404-2721-4c89-8e27-ed589b198c10"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PENEDO" },
                    { new Guid("4fd94d14-c4c7-46bc-b9a9-f711d9f015f0"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SENHOR DO BONFIM" },
                    { new Guid("4ff1be0c-5196-4203-ad3f-90465ad369fa"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CAMPOS BELOS" },
                    { new Guid("50134d98-5db8-44c0-b6a0-9f3942b78634"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IBIRITE" },
                    { new Guid("50284a6a-b5e8-4087-a430-3537aedd106f"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BARAO DE GRAJAU" },
                    { new Guid("5038c9cb-b205-4fff-8d35-5f524d081d0b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ARATUIPE" },
                    { new Guid("50443d7e-e28f-4918-9a13-edd516cfa58a"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ITARANA" },
                    { new Guid("5055f0ea-b07d-4aa6-8e96-156dc39c9aff"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BONFINOPOLIS" },
                    { new Guid("505c8d2e-67d3-4951-8bcf-bb0d3f8ea0bf"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAFARNAUM" },
                    { new Guid("50698675-1e02-49d9-9a24-aa8f1e5b4e4b"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "GROAIRAS" },
                    { new Guid("5077f817-6290-435c-9d7e-15bc13391382"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MILHA" },
                    { new Guid("508d1ebf-e138-452e-9baa-66e6c0103a5b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NOVA CRIXAS" },
                    { new Guid("508dd013-89e5-4427-8c2c-c582c7303096"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAMBE" },
                    { new Guid("50a7965a-59df-4c21-a731-9806aac41337"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SERICITA" },
                    { new Guid("50bf674c-d314-4a4d-be86-69ec8f431beb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVA UNIAO" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("50d89383-5b13-400c-8ede-3a32d6877e03"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PACUJA" },
                    { new Guid("50def404-b4d8-4354-8434-d44f1be2756a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "VARZEA DO POCO" },
                    { new Guid("510ae321-59e2-42b4-a8cd-500c20c48ede"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NOVO BRASIL" },
                    { new Guid("513cc747-fb2f-47f7-9c81-b852f5631bf6"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTA TEREZINHA DE GOIAS" },
                    { new Guid("5180a298-cbb6-43de-89c5-ac545cb4c9fc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAPUTIRA" },
                    { new Guid("5183580a-2b86-4702-91fa-c26135609c33"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IUIU" },
                    { new Guid("519f9828-4315-4fa7-9b0b-322de2c4e93a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAPEVA" },
                    { new Guid("51ae5728-2b97-48ae-9224-b57ba142b4fa"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "ESTRELA DE ALAGOAS" },
                    { new Guid("51b30609-fe35-4c70-acee-c769cbbdea30"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO RAIMUNDO DO DOCA BEZERRA" },
                    { new Guid("51d8c6b2-c485-412c-8b0c-2eb3bf17d528"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAPITAO ENEAS" },
                    { new Guid("51e5a09f-8377-4f15-9cb7-0b8f2f2eab2f"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ABAIARA" },
                    { new Guid("51f6b364-4d04-4bc7-8629-45c578d119e3"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CENTRO NOVO DO MARANHAO" },
                    { new Guid("52012ff7-0788-40f9-b7d0-1f0ef8207102"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ALEXANIA" },
                    { new Guid("52176eb0-9a7f-44a1-ac12-2e40742cf0d8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOSE DO JACURI" },
                    { new Guid("52272fa8-64c6-4193-980f-977e060af6d7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "AGUAS VERMELHAS" },
                    { new Guid("5237090f-4dda-4fe0-860c-9c427af2382e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PENAFORTE" },
                    { new Guid("52472a30-280c-4994-bfd3-f41102cd689e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "DARIO MEIRA" },
                    { new Guid("52541a92-35f3-4c1d-a953-0e4aa6d5448e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONTE SANTO DE MINAS" },
                    { new Guid("526feeee-d1c6-472b-89db-c66c9f14ac75"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "CASTELO" },
                    { new Guid("5296dbca-3a20-437e-8256-2989b909f5fa"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOM REPOUSO" },
                    { new Guid("52b4bb6e-f175-48f2-83ce-bca2c5655867"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RUBELITA" },
                    { new Guid("52ba14b3-8e41-4742-81f4-d1a571df690b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IPATINGA" },
                    { new Guid("52e4e7d4-0469-491e-931c-cb5da4b5d645"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MARANGUAPE" },
                    { new Guid("530f4c65-74f9-4af5-81cb-958c5e8d3716"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVO ORIENTE DE MINAS" },
                    { new Guid("5336bc53-f1c7-4e62-9b19-04254d7e62ed"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NOVO GAMA" },
                    { new Guid("534c0375-9212-4af0-9d73-7f5801593c80"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "TEFE" },
                    { new Guid("53505feb-c8bb-4f12-bd76-3b86f166014a"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "UARINI" },
                    { new Guid("536ef38b-e548-40f4-92da-e4cdc32fc957"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GAMELEIRAS" },
                    { new Guid("53850a01-8709-42d0-9593-4173d9714563"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA RITA DE CALDAS" },
                    { new Guid("538c26de-afdb-401c-ad3d-e5d98cf83588"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BUENO BRANDAO" },
                    { new Guid("539bf949-e413-4d2c-a23b-8af78da7b61d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVA RESENDE" },
                    { new Guid("53a9d24c-a831-4bfa-be14-2e30b55b2b52"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAMARI" },
                    { new Guid("53c5b8a5-8b0d-42b8-a3a6-da7ea59bfa33"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MILAGRES DO MARANHAO" },
                    { new Guid("53ccfd42-26c5-4b31-b27e-3e4655ac7e70"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SIMOLANDIA" },
                    { new Guid("53db968a-e95c-44fd-ab9a-77418c17f4ab"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "GUACUI" },
                    { new Guid("53fb394a-2dff-4999-9b85-9241c9ee206f"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CAJARI" },
                    { new Guid("5401ab84-ff30-4e97-864c-b54562b04599"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ARACOIABA" },
                    { new Guid("542a3abd-7640-4a6b-a83a-aed64caef241"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VEREDINHA" },
                    { new Guid("54357c3c-61d2-4789-867b-37357d07cf6a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO GONCALO DOS CAMPOS" },
                    { new Guid("54396a5c-0e72-4468-910c-3efb72fd3f0c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PARIPIRANGA" },
                    { new Guid("54ba940b-bf06-4f83-98dd-e5e7cbfb5b15"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PATROCINIO DO MURIAE" },
                    { new Guid("54fa8e66-15c6-4cf4-901d-7523af73649f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAPETINGA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("54fddc26-3c3e-4883-b6a5-4f79e0b864e3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "XIQUE-XIQUE" },
                    { new Guid("556c1bbf-ebd2-4e3d-b6d5-0ebfab671963"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "JACUIPE" },
                    { new Guid("55809631-7a3c-41a5-9bbb-ad2ca794f1d1"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "FLEXEIRAS" },
                    { new Guid("5590e5d6-ecad-4a45-8dd4-97d7b2d9923e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MONSENHOR TABOSA" },
                    { new Guid("55a1c7f3-6526-4500-a91c-6b9d4a434a66"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CANTAGALO" },
                    { new Guid("55a54c93-c2a1-4456-a560-d8c215349b37"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PORANGA" },
                    { new Guid("55b8d112-c988-41db-8d46-5aac83b77024"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NORDESTINA" },
                    { new Guid("55c1498c-7274-4f23-b9e0-5f22f2f98afe"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "TARAUACA" },
                    { new Guid("55d69a0c-867e-4703-b450-384fb5643b8b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NAZARE" },
                    { new Guid("55dd063c-1a0f-4a57-8d21-6b94fb5c56fb"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "CUTIAS" },
                    { new Guid("55e6a97c-1f63-485c-a13b-40e02f3dd44b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MUQUEM DE SAO FRANCISCO" },
                    { new Guid("55efd777-845c-428a-8a99-04c771fc4441"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTA ROSA DE GOIAS" },
                    { new Guid("55f88da9-1c15-4fd1-ab11-f581a381d150"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMPO FLORIDO" },
                    { new Guid("561dc3e2-7e33-4279-85f7-9d3fddcf7c8f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CORACAO DE MARIA" },
                    { new Guid("5634ddb7-af3d-4bb0-bd92-6a5323994342"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "FAINA" },
                    { new Guid("5657c7fb-e284-4041-b9c1-4c3b72e7d9ad"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "IPAUMIRIM" },
                    { new Guid("566636ca-0544-448a-8338-ace8912d2480"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "RIO PRETO DA EVA" },
                    { new Guid("56a6280e-3a6e-4594-8583-19b9e26ba6d2"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO FRANCISCO DO BREJAO" },
                    { new Guid("56c87415-9684-4735-ac45-4dded6bea067"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVA ERA" },
                    { new Guid("56ca5dd8-017b-4d03-a4f1-3eb0f99a45a2"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "AGUA DOCE DO MARANHAO" },
                    { new Guid("570f9b99-9c30-452a-b9c2-7facc2a140b5"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PIATA" },
                    { new Guid("57319947-29f9-43ca-abb6-c651a554ade2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITARANTIM" },
                    { new Guid("573f9848-6474-4c68-86ba-30f63957dc6c"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CAMPINACU" },
                    { new Guid("57896a4b-8d72-47d9-bf7d-65d087e60d41"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MONTIVIDIU" },
                    { new Guid("579879c0-6609-4ba1-ab05-82878c130e9a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CLARAVAL" },
                    { new Guid("57b931aa-7e81-4f7b-a8f1-c14a7dbb5954"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LARANJAL" },
                    { new Guid("57ece2a2-bbe4-43c1-8ffb-297bf1367468"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO MANSO" },
                    { new Guid("581397fe-9ee0-41c0-82a2-82bb032176fa"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "INGAI" },
                    { new Guid("5830df13-99f9-431e-bd09-f30e072c3551"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MATRIZ DE CAMARAGIBE" },
                    { new Guid("58483372-bf4c-441f-9829-5ac3d59cb84b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "UAUA" },
                    { new Guid("58610c69-1e42-4d59-8aaf-7bea56d85a22"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOSE DO ALEGRE" },
                    { new Guid("58a7bb5a-6c01-4271-a73f-bfaf919508ed"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA RITA DE JACUTINGA" },
                    { new Guid("58c9af27-817b-4f51-bbd3-7e934653a2b5"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MORADA NOVA" },
                    { new Guid("58df9a91-a87d-4cf5-84ec-54c1838281a1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ANDRELANDIA" },
                    { new Guid("5905161e-5570-4dca-88f0-c57ec89b400a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAEM" },
                    { new Guid("5935ec2f-6b62-4b6b-8673-1e6e68910cc7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JOAO PINHEIRO" },
                    { new Guid("59883280-f559-4e98-8c9b-fbbffe79f61d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LUMINARIAS" },
                    { new Guid("5a1fff79-d036-4e52-b564-2ebf530a9c30"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MORRINHOS" },
                    { new Guid("5a24deef-67f1-41f0-be5a-07f2c16a6bac"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO DO PARAISO" },
                    { new Guid("5a424cc3-9e3d-48ec-bf72-4cf26c006f0f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "URUCUCA" },
                    { new Guid("5a65fdc8-f029-4b5d-8d32-2f3ec38d476c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ICARAI DE MINAS" },
                    { new Guid("5a84d2ed-9f2c-42ee-9e36-bbd6a08abfb8"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "PINHEIROS" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("5aeec8e9-79d0-4884-bea5-af26bddf75a3"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "GOVERNADOR NUNES FREIRE" },
                    { new Guid("5af2aef8-073d-4a46-a3c7-c01c9d7d22f5"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "LAGO DA PEDRA" },
                    { new Guid("5b006c28-315b-4793-bbc1-3dfeb038a7da"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO DA PONTE" },
                    { new Guid("5b2d6097-760f-4547-9bc4-809132fb0e47"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ABADIA DOS DOURADOS" },
                    { new Guid("5b436058-368d-487a-88cc-383161c8307b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "POUSO ALEGRE" },
                    { new Guid("5b58f496-ab86-4748-874b-77df8efdb1d4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DIVISA NOVA" },
                    { new Guid("5b72aa71-fc9d-4ef8-b11e-bd4aed51b5c3"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "RIO BANANAL" },
                    { new Guid("5b8683a9-409c-48fc-99a9-f6ee11c69549"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SERRANIA" },
                    { new Guid("5b9a3619-7668-46e2-a758-fbbdddd14959"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "FEIRA NOVA DO MARANHAO" },
                    { new Guid("5bb3c544-762d-4ef9-82bf-297a9c277d80"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MIRABELA" },
                    { new Guid("5be8ff36-5464-484d-859f-aa896cd17dad"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CANA VERDE" },
                    { new Guid("5bebbd4e-1a00-48f8-8a31-fafa2a214280"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO DESIDERIO" },
                    { new Guid("5c09e8d9-c678-4d16-8482-6b1b50ff7286"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTO ESTEVAO" },
                    { new Guid("5c255566-f9a4-4cde-8f54-885235aefee9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SENTO SE" },
                    { new Guid("5c45afc7-e519-483b-8862-182d7ec5839c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "GONCALVES DIAS" },
                    { new Guid("5c7ab5b5-3367-40ef-8dc2-483cb5473755"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FRANCISCO DUMONT" },
                    { new Guid("5c9714c2-fefb-4eb1-8f21-60a493428e67"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONTE SIAO" },
                    { new Guid("5cc3ed69-263a-48c3-9826-c5f2fdbc3c39"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "AURILANDIA" },
                    { new Guid("5d035cdb-8060-43c9-95a1-baede287faad"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MATOES" },
                    { new Guid("5d18ed24-aa87-4ab0-a1dd-be8a20b9f952"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO FELIX" },
                    { new Guid("5d2b2ea7-e605-4797-ab00-09b97428de38"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SOBRALIA" },
                    { new Guid("5d35fd5d-4d77-4e69-9f45-936e9fe3b698"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAPARICA" },
                    { new Guid("5d412a7a-3e3e-4565-b570-e7e69083c7d5"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BOM JESUS DAS SELVAS" },
                    { new Guid("5d8404a1-bf17-4d3f-b1ee-f2cfa8de80d0"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DIVINO" },
                    { new Guid("5d84cb13-617a-477b-9f72-b19a8f1c4d13"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BANZAE" },
                    { new Guid("5d93cfc0-8b4f-4532-923d-308e694b109c"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "COLATINA" },
                    { new Guid("5d9838ea-7acd-43be-9941-a666fc1aada2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ESTRELA DO SUL" },
                    { new Guid("5da9078c-0253-462f-a5c6-5ca77cd2c3d2"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "HIDROLINA" },
                    { new Guid("5e1551f6-0aff-4829-8109-5a52e70b4696"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO BRAS DO SUACUI" },
                    { new Guid("5e260ea3-1867-420c-905e-df8790892d46"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "IGUATU" },
                    { new Guid("5e38fc50-abbd-42ae-ab29-b3dc5f2373a3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALTO CAPARAO" },
                    { new Guid("5e59d2c3-b684-4c07-ad70-262365dd575e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CRATO" },
                    { new Guid("5e8e9150-dc42-41e6-8758-2ec6611c5919"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MULUNGU" },
                    { new Guid("5e977a08-ac5c-4c6f-a865-edd821d5b630"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GRAO MOGOL" },
                    { new Guid("5e9b7dd7-fca9-49dc-9ed5-10d46fdf8334"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SANTA LUZIA DO NORTE" },
                    { new Guid("5ebc8552-e88b-4c89-82bd-3c137f162332"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MATUTINA" },
                    { new Guid("5ebd597e-4b62-4cdb-b446-91041ebd360f"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SANTA FILOMENA DO MARANHAO" },
                    { new Guid("5ec5bf01-fa35-4fd8-bfcd-8b9757c27eda"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "AGUA DOCE DO NORTE" },
                    { new Guid("5ece4db3-96b1-4cdd-9c04-107bac38276b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVA MODICA" },
                    { new Guid("5ed06377-ed3c-4b9f-b7b2-4592fe5ebc2d"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "ANADIA" },
                    { new Guid("5f5e38d5-f691-4d56-b3d7-213c4696c9ee"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "TAQUARANA" },
                    { new Guid("5f63ef54-a449-4399-b7f8-a66a434e58c8"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CAMPINORTE" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("5f837658-a197-4647-a003-92f317c740ec"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MARIANA" },
                    { new Guid("5fc74889-44ce-4c24-bca2-71d0bcd61cf3"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "BELA CRUZ" },
                    { new Guid("5fd12659-9cdf-4706-8637-f0b827107f17"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIRAPORA" },
                    { new Guid("5ff72b9d-cc43-4a48-abe1-1b28d75c5274"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PORTELANDIA" },
                    { new Guid("603d996c-c11d-485b-ba56-e3117763551c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAMBAIBA" },
                    { new Guid("6042e692-2bec-4cdf-b33a-a04c056646e1"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "IBARETAMA" },
                    { new Guid("60645823-471c-4595-a4f8-c4388411f520"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "OIAPOQUE" },
                    { new Guid("60a8157d-fb80-40e5-b7a8-15aa43595f94"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MINDURI" },
                    { new Guid("60ae0cd9-be8e-4b2e-9288-e105e2fe1b76"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO NOVO" },
                    { new Guid("60b5d9c2-119f-4c04-af30-f427b10f65e2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMANDUCAIA" },
                    { new Guid("610563c9-01e1-47b0-8414-99bf87d95350"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PONTE NOVA" },
                    { new Guid("61318378-e8b6-4f83-82ca-7b04078837dc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVORIZONTE" },
                    { new Guid("6171610b-74a8-400f-bb16-f93da2c71f2e"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "SAO JOSE DO CALCADO" },
                    { new Guid("619f75b2-66ca-4b2a-8b54-c177bb1aea37"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "BORBA" },
                    { new Guid("61d7639d-c535-4f7c-9986-649f10efd43e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "UMBURATIBA" },
                    { new Guid("61f114c5-9973-4cc4-8765-d9b4dc12bdf2"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "COCALZINHO DE GOIAS" },
                    { new Guid("62133cc6-9405-4ec4-be8d-41d67cf58237"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TURMALINA" },
                    { new Guid("623f254d-455e-4850-a3cc-9002ad32b677"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "AGUA FRIA DE GOIAS" },
                    { new Guid("624ceecf-6906-4650-9818-be274e2e7ba1"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BOA VISTA DO TUPIM" },
                    { new Guid("62543263-f218-47e0-95f5-2e3574e1953a"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "DORES DO RIO PRETO" },
                    { new Guid("62631e4d-2db9-4bb1-a30a-4a0500ae0cd3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO ESPERA" },
                    { new Guid("62cf3c8b-3873-4703-995f-0becb83c76a4"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NAZARIO" },
                    { new Guid("631645a2-85f6-4c27-a3c6-79e05a060704"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JAGUARARI" },
                    { new Guid("6335d4f1-f577-4058-964b-a08d837bd7c2"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PARANAIGUARA" },
                    { new Guid("6348562c-1e75-4899-bceb-daafc0306ba6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO PARANAIBA" },
                    { new Guid("6353d25b-d672-4e3f-b375-d08a43da9727"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CASA NOVA" },
                    { new Guid("63931275-8103-4fff-9c59-434aefd82e17"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOCAIUVA" },
                    { new Guid("63b7208c-31c8-4eab-8d67-c463c08fe32b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SENHORA DO PORTO" },
                    { new Guid("63b9ed60-a70d-4d99-b97b-0ea9ff0a2811"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "URUCARA" },
                    { new Guid("63ce5d23-6079-41d7-8bbd-b1204567acfd"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PARICONHA" },
                    { new Guid("6407aa13-5fb7-440f-bf1d-4bdbc7567240"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CASA GRANDE" },
                    { new Guid("642645c1-1b45-4ea1-bb94-111a9c4192ce"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MIRADOR" },
                    { new Guid("64491490-b5a4-4896-8b0c-3383c0be906e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBIPEBA" },
                    { new Guid("644d1cc4-bf74-4e63-b18c-290c8d11bbe4"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "TIMON" },
                    { new Guid("6451c40b-d4be-465c-bd88-5165e6d59a0e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "AIUABA" },
                    { new Guid("6455c521-9883-456c-85b5-a61de468a2b6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUAPE" },
                    { new Guid("64626068-d10c-4286-9b70-0f2088720b0c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MATIPO" },
                    { new Guid("6486ef01-1834-4aed-ae91-44a2c3958383"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBIRAPUA" },
                    { new Guid("648e8682-44a7-4503-a9c3-cbb5930ad69e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMACHO" },
                    { new Guid("64abea5a-471c-42cb-b9ba-632afed0c558"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NOVA REDENCAO" },
                    { new Guid("64b44934-3ff2-464c-a915-4c25c7b1fef1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALBERTINA" },
                    { new Guid("64c9dfd9-c9ba-4c27-9e4c-a49fa1e21d3e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA RITA DO SAPUCAI" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("64ca98b5-a768-4ada-bc8d-5d38c386fab5"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RIO DE CONTAS" },
                    { new Guid("64d3d02c-b5bc-49c0-b7a6-82d406dc07ae"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CATOLANDIA" },
                    { new Guid("64dfe97c-f7d0-4dbb-b3e8-25dbc982dfd8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "GUARATINGA" },
                    { new Guid("64f1ed41-ce1b-45b5-b885-c48d86ce43da"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "TASSO FRAGOSO" },
                    { new Guid("650cbaab-e6d7-4a0d-882e-0a0c457e0fe0"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BONOPOLIS" },
                    { new Guid("653df837-9c86-4c0c-833f-10630acddbc0"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "BOM JESUS DO NORTE" },
                    { new Guid("65441b5b-d73b-424e-82fb-f46b96c83ee8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MENDES PIMENTEL" },
                    { new Guid("65535d11-cbb6-45c2-bd63-ad14ee51d226"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NACIP RAYDAN" },
                    { new Guid("658a42eb-3b96-4132-acf1-db04e304aead"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MERCES" },
                    { new Guid("65c9440b-eabd-4656-8417-2cc545499b3b"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "JUNDIA" },
                    { new Guid("65e7c97a-9d22-4246-9459-5ee1f5076fcb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JAGUARACU" },
                    { new Guid("6605b6cc-921e-4d5d-86ed-c92873651155"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "VILA VELHA" },
                    { new Guid("6632f4f7-2d99-4750-b6fc-818804a4886d"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "FERNANDO FALCAO" },
                    { new Guid("663ba296-8af0-41f0-aee4-c60e452006b2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FRANCISCO BADARO" },
                    { new Guid("6675e171-69b7-46be-b0cc-387b934858fe"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VIEIRAS" },
                    { new Guid("668e6efa-d988-4e29-9574-093fa8a98d3e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO BATISTA DO GLORIA" },
                    { new Guid("6697df64-43e5-49fe-bb77-7d3900b6b208"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PALMELO" },
                    { new Guid("66a05878-56c9-40d2-a280-1f61630e2c97"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FREI INOCENCIO" },
                    { new Guid("66a8707d-a0e2-4739-91d7-dc6936c18d11"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GOIANAPOLIS" },
                    { new Guid("66b3cd5a-35f2-4df6-9710-a7f298896f69"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JITAUNA" },
                    { new Guid("66e52c25-daf5-48de-9ae6-577ce6e83f60"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAMACAN" },
                    { new Guid("672f1334-9376-4839-b4ee-14ec07a77640"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NAZARENO" },
                    { new Guid("67531da8-7be4-4c91-be03-0819fbbf5e3b"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "MARATAIZES" },
                    { new Guid("6758eafa-9825-485f-92fd-fe5022e15cfe"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITATIAIUCU" },
                    { new Guid("675b7f74-b515-49e5-8bf7-3277c8511d4a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "HELIOPOLIS" },
                    { new Guid("675c32fd-69bb-456c-88ab-a746ad97287d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IACU" },
                    { new Guid("678a3a1c-0c55-4ccd-ab57-0e1f0d61ee52"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORREGO DANTA" },
                    { new Guid("67a475fe-0082-4652-845d-e0279cfb83b3"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO RAIMUNDO DAS MANGABEIRAS" },
                    { new Guid("67acf0c3-c2b8-4f41-8dd2-f539727c8b5e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CHACARA" },
                    { new Guid("67c23e3c-e6c5-4271-b9ca-cf9fbd31575d"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "ITAPIRANGA" },
                    { new Guid("67d176d4-0579-49f8-b2ff-30e9c7364c9c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO BENEDITO DO RIO PRETO" },
                    { new Guid("67d6e740-24b4-4e91-ac65-75a9ed1dd77c"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CRUZ" },
                    { new Guid("67e2cfc6-8a25-4734-b5fb-9c3fc5b6090d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ARARENDA" },
                    { new Guid("67ed5cb7-fe66-43eb-a766-697996c2fc6e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PRADOS" },
                    { new Guid("681628e5-6cdf-4f3c-97a0-3960113a7da9"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ADELANDIA" },
                    { new Guid("6820b10c-0ab8-430c-b3a8-b4ce82c18c84"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTALUZ" },
                    { new Guid("6827d508-251e-47e9-9359-e2543dd2ac0a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "UMBURANAS" },
                    { new Guid("6832c9a5-d279-44d5-b1c1-967390d8b499"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "ARAPIRACA" },
                    { new Guid("684b2970-25b1-4999-9ed8-f9f5499ee06a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RUY BARBOSA" },
                    { new Guid("68663be3-7c20-45e7-9dbb-3f230bbc2315"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO FELIX DE BALSAS" },
                    { new Guid("68b03caf-375e-4d88-ac13-99877bafa0a1"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "HIDROLANDIA" },
                    { new Guid("68b7f227-3860-4e20-bcd1-3ce7df2d8f46"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALTO RIO DOCE" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("68ea52ec-d5f1-4e22-b080-57b629311ef7"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ITAPAGE" },
                    { new Guid("68fc1fa4-6f94-4053-9513-fdf81b0b0d6e"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PILAR" },
                    { new Guid("691e620d-0827-4a33-b984-16fcad584fd9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MARLIERIA" },
                    { new Guid("69364134-ee87-4ee9-9a9e-f91e9191adc9"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CAMPESTRE DE GOIAS" },
                    { new Guid("694ec095-29c0-4000-94d0-01c4009cbc78"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NOVA VENEZA" },
                    { new Guid("69775611-6f37-4e82-98e7-fac2e273fb2a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BUERAREMA" },
                    { new Guid("697ac449-ca21-4480-939e-3feeb8cb1425"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "VIANOPOLIS" },
                    { new Guid("6990540b-62b7-4bdf-b479-5d93035239c0"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "AGUIA BRANCA" },
                    { new Guid("69b742f9-27ca-49f0-a3c1-1bb6fbbda599"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO SEBASTIAO DO RIO VERDE" },
                    { new Guid("69b8991c-92de-4b7c-af72-20a2d984cc00"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CACHOEIRA DOURADA" },
                    { new Guid("69f93516-4da3-47db-a3f1-4733178d40a7"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "AMERICA DOURADA" },
                    { new Guid("69fd61ef-2339-418b-8ddb-6de39f9ca86d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "QUIJINGUE" },
                    { new Guid("6a18e70c-058b-485a-9cca-9ceaf27ca685"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BARRA DO MENDES" },
                    { new Guid("6a3a5041-b351-45ca-8bf0-b4dcf51c373f"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "FEIRA GRANDE" },
                    { new Guid("6a597b89-6233-467f-aed9-7d5b47f17ef6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IMBE DE MINAS" },
                    { new Guid("6a70d5a9-1af7-4c37-a99f-035a755377dd"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTA HELENA DE GOIAS" },
                    { new Guid("6ac36ddc-cedc-4a3d-91c7-5ae75e4b516a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARMO DO PARANAIBA" },
                    { new Guid("6ad3ec6e-9e9f-4a04-bb3a-0a7ca0c672ba"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PLANALTINA" },
                    { new Guid("6ad8e9e1-f2b8-4ff0-8664-66aeb17c35fe"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIEDADE DO RIO GRANDE" },
                    { new Guid("6af24e23-6cea-44a2-ad39-15db1a90353b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JACUTINGA" },
                    { new Guid("6afe9882-6a9a-482e-b943-35e7fbcf80bd"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "APIACA" },
                    { new Guid("6b34d4fb-1bc8-4915-9e9a-0e59dc470613"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BALDIM" },
                    { new Guid("6b77e2c3-2a3d-4603-925a-5548366a627b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "QUEIMADAS" },
                    { new Guid("6b8ca17e-e6e4-4c8d-96e0-5336ae45b259"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "EDEIA" },
                    { new Guid("6bb32032-70df-4980-a14a-69cf1f723b07"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUIDOVAL" },
                    { new Guid("6bbc2452-510e-4467-8028-807b2805428c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUIMARANIA" },
                    { new Guid("6bd782f2-7edc-4d0d-9874-890ab6fc54da"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO DA LAGOA" },
                    { new Guid("6befc3f7-ad9f-41fb-8b9c-8a137205bff9"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "OROS" },
                    { new Guid("6bf178f3-d696-4c29-8917-aae4f64fe647"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PAULINO NEVES" },
                    { new Guid("6bf88b81-b273-467c-ae39-637eb93d4ad1"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MORAUJO" },
                    { new Guid("6c2e0fd5-70a6-48fb-9279-8242c0922b16"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "OUVIDOR" },
                    { new Guid("6c358cb7-64ff-4e35-af15-88f9bc2b17b1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CACHOEIRA DA PRATA" },
                    { new Guid("6c87f766-e1cd-4cfc-a857-7c327ffacda5"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "INDEPENDENCIA" },
                    { new Guid("6c8a5503-2d2c-4004-a086-22f9667114c8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTO ANTONIO DE JESUS" },
                    { new Guid("6c9116a4-75a1-48c4-832b-4c9654b088d8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONFINS" },
                    { new Guid("6c99170e-6dc0-4800-b526-eb6f8e5d21dd"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LAGOA FORMOSA" },
                    { new Guid("6ca6861e-49d9-433d-ba1e-0e21607ee978"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARVALHOPOLIS" },
                    { new Guid("6caec01c-c5ba-4b5f-bebe-733272c3b685"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO GONCALO DO SAPUCAI" },
                    { new Guid("6cafcc3a-4c68-449c-a3e5-f3005143ebef"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VARGINHA" },
                    { new Guid("6cc48829-c05b-4660-b905-7e954e3f3fe0"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "UNA" },
                    { new Guid("6cc99b61-1a19-4df7-b4d7-19ea5197dc52"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "SAO DOMINGOS DO NORTE" },
                    { new Guid("6cfd3f39-0300-468f-8778-21faf291ad9b"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "DIVINO DE SAO LOURENCO" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("6d15ab95-3ff7-4746-b9d9-68fb40a6614e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO FELIPE" },
                    { new Guid("6d56bac3-dde0-470d-8b77-7fcc75b70b4b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CLARO DOS POCOES" },
                    { new Guid("6d622e31-2856-4e3f-b03d-799267b78ac5"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "OUROLANDIA" },
                    { new Guid("6d8998a8-e6ea-496f-8076-072283a231ca"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GUARANI DE GOIAS" },
                    { new Guid("6ddf3ca6-439b-4fc2-a95d-f32dcbc1d5c6"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CONCEICAO DO COITE" },
                    { new Guid("6dfebf5e-e852-4842-a653-6b1da577ec83"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BOM JARDIM DE GOIAS" },
                    { new Guid("6e31aead-1167-4c03-86f3-42896144bac7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOSE DO GOIABAL" },
                    { new Guid("6e3852de-e011-4452-9395-2f7a10e83bcb"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "COTEGIPE" },
                    { new Guid("6e58d622-7ee9-4e53-803f-3a034a2089bf"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CAIAPONIA" },
                    { new Guid("6e5c6fc1-0608-4422-bd56-30805a6aaab1"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTO ANTONIO DO DESCOBERTO" },
                    { new Guid("6e71b4cf-079d-4c43-bc5b-584a7b870b47"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARVALHOS" },
                    { new Guid("6e975770-b194-4ead-a7e3-c79379e558fe"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NEROPOLIS" },
                    { new Guid("6ea8fe86-7717-4955-a2f8-4143bdeb001c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PATOS DE MINAS" },
                    { new Guid("6eaec20d-910e-4036-9bae-d227b535e075"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MARAVILHA" },
                    { new Guid("6ed42fc5-5ba9-45fa-afb0-703cd3e1ee0b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NEPOMUCENO" },
                    { new Guid("6f4391fd-78b6-4c0d-bfae-ce79be9803dd"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GUARAITA" },
                    { new Guid("6f632548-1e74-4aa2-8550-620dfcff8d49"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PIRENOPOLIS" },
                    { new Guid("6f7a9263-aa96-4015-ac70-8f6ecc8f091c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BERILO" },
                    { new Guid("6f8493f2-db89-47b2-bfc3-fbec0e04cd04"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "FEIRA DE SANTANA" },
                    { new Guid("6fba4808-a765-4b67-95f1-b84d03d0ef9a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JEQUITINHONHA" },
                    { new Guid("6ff60f39-1e90-4659-bbc2-b08987145b62"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "ATALAIA DO NORTE" },
                    { new Guid("70128a5f-a74b-4869-98df-3e7307553eb9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "GLORIA" },
                    { new Guid("70312829-8b41-4ef4-99ea-b2bef96521a4"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JEQUIE" },
                    { new Guid("70524993-477c-4927-88b4-17cabe6ff658"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CACU" },
                    { new Guid("70613110-bd26-4838-9806-c853e22de572"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORONEL FABRICIANO" },
                    { new Guid("70b46eca-ad4b-40a5-8e41-3593105a269e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CRATEUS" },
                    { new Guid("71029285-7637-424d-9611-27156e88ff6b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PORANGATU" },
                    { new Guid("71032468-23e3-45d4-9345-2caa8cd68aac"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BOM JARDIM" },
                    { new Guid("7130304d-cf15-46d1-94eb-cce9286670f2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CASSIA" },
                    { new Guid("71594bf7-687c-4e98-915c-19d12dbde6cb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JESUANIA" },
                    { new Guid("71801b96-af7f-4323-a47f-5aadefec685d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MOEMA" },
                    { new Guid("71827e93-f532-4c49-9f19-bfb5d50a47c0"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SATUBINHA" },
                    { new Guid("71a40b32-ffa9-4894-9c06-9002b00a3295"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BAIXA GRANDE" },
                    { new Guid("71c40591-7779-4b9f-91c6-f16da056767a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PAI PEDRO" },
                    { new Guid("71d21738-8baa-4626-9ce0-c0677502d0f6"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "TAUA" },
                    { new Guid("71e0d2e2-1392-48b4-9e40-250da1012aa0"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TEIXEIRA DE FREITAS" },
                    { new Guid("71e3c0da-84cc-4cf5-a29a-68363fb75b78"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "QUITERIANOPOLIS" },
                    { new Guid("721d6b18-d91e-4d75-b1c6-c3fdf506bad3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "WANDERLEY" },
                    { new Guid("7233f1f0-237d-4b17-8468-b129a370f174"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ALAGOINHAS" },
                    { new Guid("72442978-3b23-4c17-9df7-d019b2abcdd9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "COIMBRA" },
                    { new Guid("724de54a-da2d-4fe3-bedb-d850f271c116"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "JATAI" },
                    { new Guid("725d0341-466a-4ed7-a664-998749a172b0"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CATURAI" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("7268148d-61d9-4b4b-a9c0-bbcc1d7af4c2"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "TIANGUA" },
                    { new Guid("72706796-de19-4053-8804-4b309f23692b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "DIORAMA" },
                    { new Guid("72910656-7ad8-4200-b2d9-cb7be1e5f2ba"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAMPO ALEGRE DE LOURDES" },
                    { new Guid("72947fd7-6200-4c12-b6a1-551cf2cd800a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORINTO" },
                    { new Guid("72c9e354-9f13-4292-b7d3-26b06aa0607c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MAIRI" },
                    { new Guid("72d93d7b-d32f-4257-9011-f2a9c79c6b48"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PACO DO LUMIAR" },
                    { new Guid("72e98d2b-e6cb-4467-a9d4-14127d537a08"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ICHU" },
                    { new Guid("72ffe0ec-704e-4d8c-a73f-ff620d3e895e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAGIBA" },
                    { new Guid("73110a6f-0dcc-4422-ae79-d4851c1bb234"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "LAGOA GRANDE DO MARANHAO" },
                    { new Guid("731415c0-feb4-4245-a039-d2103164fa1b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ANGUERA" },
                    { new Guid("7318399f-efd7-4e3c-96d6-b48f93234929"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "SENA MADUREIRA" },
                    { new Guid("7359eb16-9bf8-41f3-b667-33c7ff3dc12c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO JOAO DO PARAISO" },
                    { new Guid("735c28d8-ee4c-4404-91e8-6fa0d8331df9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MUNIZ FERREIRA" },
                    { new Guid("736c0289-cbe7-4e3e-baca-f80e72d73f06"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO FRANCISCO" },
                    { new Guid("738f27b0-d47c-4e26-90e2-859f966db835"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOM JARDIM DE MINAS" },
                    { new Guid("73bb980f-91d7-4e11-9254-079786b05e5e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "GUANAMBI" },
                    { new Guid("73dec1dc-dfed-4768-9a66-81f39c6a1e0d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TRES MARIAS" },
                    { new Guid("73fa5932-d12f-4c7d-a3a3-eec0edc3c370"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARMO DA MATA" },
                    { new Guid("741faef1-20e3-4b78-83f5-537128fd9443"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TIRADENTES" },
                    { new Guid("742d76e3-4921-4307-a0eb-345ad742432c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PERDIGAO" },
                    { new Guid("7449dc62-eb88-48ae-baff-4886a94d30b8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PRATA" },
                    { new Guid("744d2867-b50a-432e-801e-3f171cdb1f19"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "BARREIRA" },
                    { new Guid("74531c3c-39ba-473b-9917-a01d305c67f6"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "JAUPACI" },
                    { new Guid("746988b8-d077-4de2-b66a-872a9a9a904f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITANHOMI" },
                    { new Guid("749c8770-a14b-4679-a9c3-7f75e7dd6c79"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "JERONIMO MONTEIRO" },
                    { new Guid("74d6a663-39f8-4adc-89e0-1f96fad12773"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ILHEUS" },
                    { new Guid("74f4ac5e-4b24-40d0-bc85-60a3f2e6d9e4"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BIRITINGA" },
                    { new Guid("74f5091a-97d3-49e8-bec7-9aa901bea492"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LIMEIRA DO OESTE" },
                    { new Guid("74ff03a0-2220-4ad6-a34f-e57cd41705b0"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MORADA NOVA DE MINAS" },
                    { new Guid("751432ce-4caf-406f-8452-37759fe8f950"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "NOVA COLINAS" },
                    { new Guid("75317638-fc52-4281-a5fe-7a3ebc1f660f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BARBACENA" },
                    { new Guid("7569f047-cad4-471f-9d10-5d921496f4fe"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BAEPENDI" },
                    { new Guid("758dd686-3547-4620-908f-4efd04ecba64"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "POTIRETAMA" },
                    { new Guid("75cee1c5-387c-4a01-a5cd-158a20cdc69d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CANAPOLIS" },
                    { new Guid("75ebc511-b163-4774-80ed-4fddba1e69d5"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CONCEICAO DO JACUIPE" },
                    { new Guid("75f43e95-edf5-45de-b664-ed5efb390326"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ESPIRITO SANTO DO DOURADO" },
                    { new Guid("75f6f836-2e0a-4365-9be8-f2f6182d4974"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PINHEIRO" },
                    { new Guid("760168e5-668e-46a4-acee-aef3e2a2b29e"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "IRUPI" },
                    { new Guid("7633da55-4ef2-4880-a93b-e82a04c7ee06"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CEZARINA" },
                    { new Guid("7675a3e5-4140-4929-a3b1-f1734fd6be47"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "ATALAIA" },
                    { new Guid("76832a12-fcf4-4db8-aee7-266d5d0b8b21"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CIDADE OCIDENTAL" },
                    { new Guid("76f987eb-e996-41d7-a3a3-732d154659a5"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MONTES ALTOS" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("76fdab0a-9f3b-4841-87fd-bb832518b2c6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "UBAI" },
                    { new Guid("7722f0d4-f76f-4cf7-b55b-456bd21e16fb"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ITAUCU" },
                    { new Guid("77373d41-110b-4f1e-b0b0-196feac441f4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MALACACHETA" },
                    { new Guid("7748f158-e798-4b65-852e-e84f28975181"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MOMBACA" },
                    { new Guid("774a06f3-0afd-4bdf-b8f2-02d618742391"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SALITRE" },
                    { new Guid("774d8490-0fd8-4bcf-9bdc-aeaf04fc4b8d"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ANAPOLIS" },
                    { new Guid("7751b131-0883-4be7-ba67-983cd2d5cb0d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PARACURU" },
                    { new Guid("775504d3-5cc9-46e7-b06f-1230201ca96f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAU DE MINAS" },
                    { new Guid("776cb090-36fe-4997-9ecd-2516813b7d23"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAPETINGA" },
                    { new Guid("779a2a61-557d-44e0-967a-6edd10db2c57"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUARACIAMA" },
                    { new Guid("779a563e-7f22-4af2-b182-1ee135fbfaaa"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BARROSO" },
                    { new Guid("77ba9c85-f627-4f18-95a5-9856979004f4"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "MANAUS" },
                    { new Guid("77d4a9bc-acdc-4b96-84ad-fc74dd86b03f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO DA MATA" },
                    { new Guid("7813b7eb-75c8-44cd-a469-4fa39c75272e"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "TIMBIRAS" },
                    { new Guid("782b585c-0d3a-4701-921b-c00f4e412022"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PASSA-VINTE" },
                    { new Guid("786d37a4-3fba-4427-a8d3-64c404b89fab"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORREGO FUNDO" },
                    { new Guid("78a307b4-fb00-4c21-8479-19ceca2eea6b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CHAPADAO DO CEU" },
                    { new Guid("78b1bf8d-f35e-4cdf-a91c-def6d452d2cf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARMOPOLIS DE MINAS" },
                    { new Guid("78c0d999-f0c9-47a3-bc89-64c3d8d03fdc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIEDADE DOS GERAIS" },
                    { new Guid("78c5cacc-2d56-48ce-a5e5-6f3c1476632d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CONCEICAO DO ALMEIDA" },
                    { new Guid("78c786f4-aab2-4a84-bdac-21ca6925aa6b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SARZEDO" },
                    { new Guid("78ea04b6-9712-43d6-90f6-758142a82edd"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "SANTA MARIA DE JETIBA" },
                    { new Guid("79369475-463f-4018-bf79-386bee6fc67c"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "RIO BRANCO" },
                    { new Guid("7943880f-fd5e-4c2e-a254-63c9badf0e3e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PIRAI DO NORTE" },
                    { new Guid("797c77ca-b4b2-4e91-b44a-c27246f8dadc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BRASILIA DE MINAS" },
                    { new Guid("79d3de04-52af-43ec-8934-de249e7df77f"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ARUANA" },
                    { new Guid("7a057374-2be0-499a-918e-dc90b601e1a7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALEM PARAIBA" },
                    { new Guid("7a09f321-6d72-46bf-aee3-01e0e9cdb2a8"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SENADOR LA ROCQUE" },
                    { new Guid("7a881683-c846-47c7-9aaa-8a5b883effd7"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PIO XII" },
                    { new Guid("7a886e0e-8923-4643-b415-ebcaae8889fc"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PALMACIA" },
                    { new Guid("7a99ba2f-05cb-41b5-829f-0d1f841be8b5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO PEDRO DO SUACUI" },
                    { new Guid("7aa1061e-7726-4cb8-bd9f-8502ad5440a8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MULUNGU DO MORRO" },
                    { new Guid("7af5f89c-0b14-45f6-b19a-c509fd05f22d"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SITIO D ABADIA" },
                    { new Guid("7b4ef65f-ca79-4162-84a7-37eb90a41e2e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PORTEIRAS" },
                    { new Guid("7b73eb9a-17b0-4025-ac9e-d3ed7b21b7c1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VISCONDE DO RIO BRANCO" },
                    { new Guid("7b912b5e-aa10-4e4f-801c-53c5bf213f8d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO VERMELHO" },
                    { new Guid("7bad51fc-0c40-4bd6-a0b3-8679001f3410"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "NOVA VENECIA" },
                    { new Guid("7badbe9e-10bf-4f7e-b264-acc1528979d2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BOM JESUS DA LAPA" },
                    { new Guid("7bae729c-9826-4cad-8b64-3d3cc27540b6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAUNA" },
                    { new Guid("7bbe4d82-8642-4787-94a7-b0b19fe5c5be"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MORRO DO PILAR" },
                    { new Guid("7bcbeb76-477a-4006-bc4b-cc0e8e6133c6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CEDRO DO ABAETE" },
                    { new Guid("7be8da36-ca61-410c-a541-66ae6643c288"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LAGOA DOS PATOS" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("7bf9bc51-6734-47c5-8ed3-a7a062d34995"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALMENARA" },
                    { new Guid("7bfe2eac-b7e4-4cd7-86c6-35dc94b0ac23"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MARTINHO CAMPOS" },
                    { new Guid("7c07a129-f35c-46a3-bb51-44e97f168eb6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CRISTALIA" },
                    { new Guid("7c0bd410-ba11-4b42-9e51-2a0d8a89be0f"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "LAGO DO JUNCO" },
                    { new Guid("7c22d782-a3d6-4b6f-b0b1-879afd45917f"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SAO JOSE DA TAPERA" },
                    { new Guid("7c3d1fd0-73bf-485a-9456-bcaa2d4f3c00"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "IBITIRAMA" },
                    { new Guid("7c576b7c-73bc-486c-be59-35ee084e176f"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "BAIXO GUANDU" },
                    { new Guid("7c7dfe23-6682-4091-b837-a8a60b40e18c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CORDEIROS" },
                    { new Guid("7ca150a8-66c0-43bb-88b6-85e874fc78ba"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "AGUANIL" },
                    { new Guid("7cd30e7b-c8e7-467a-ae4d-567f1ed55ff8"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "QUIRINOPOLIS" },
                    { new Guid("7cd72228-aa3d-4653-b50e-105b3085d147"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CRUZ DAS ALMAS" },
                    { new Guid("7d38cdca-570c-489e-9c49-e2d34cf2b15e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITORORO" },
                    { new Guid("7d425b68-0057-407d-88a4-4b2b7096513a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FARIA LEMOS" },
                    { new Guid("7d72a94c-a117-41c9-8924-3a7c921ac15a"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "TUTOIA" },
                    { new Guid("7dbb9f3d-384a-4822-b54e-9068f4ded162"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NOVA FATIMA" },
                    { new Guid("7dbc6ab0-a774-4ebb-b692-beb5e9e82dd5"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "IGARAPE DO MEIO" },
                    { new Guid("7dc1dcd6-563a-438b-ad4a-9ef5fe89b892"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FUNILANDIA" },
                    { new Guid("7dcab072-40e7-49c4-87ad-3dd999a50e4b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITATIM" },
                    { new Guid("7dd61811-ef14-48fc-92ca-fd39858b4faa"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SABARA" },
                    { new Guid("7dde1480-0cca-4764-8f41-956545a4bc40"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "GANDU" },
                    { new Guid("7e0b0f3d-770c-49c6-8371-b5741724716f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAPAGIPE" },
                    { new Guid("7e23f6aa-2b48-49f0-8225-d43925fc9ba7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAJURI" },
                    { new Guid("7e3a00bc-80a0-4536-b3ed-568f19384a16"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CATALAO" },
                    { new Guid("7e649373-1d0b-4084-99fe-2c48be464771"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAPECERICA" },
                    { new Guid("7e6dfe4c-7df1-4f19-bfb1-2beedf4eeca3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAMOGI" },
                    { new Guid("7e7f19f9-e0b1-422e-ae7b-7ef14e9181d9"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ICO" },
                    { new Guid("7eafeacf-cb54-49a6-b296-080b651d05c1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARNEIRINHO" },
                    { new Guid("7ebc92aa-db65-45d7-996e-0e3e97245dc4"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "COARACI" },
                    { new Guid("7ebd8bd1-60bd-403b-9093-e07100ad8aa4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONTAGEM" },
                    { new Guid("7ecaf921-81a9-429c-864d-bf0566efef55"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PIRACANJUBA" },
                    { new Guid("7eed1cd0-bd70-4bfd-aeaa-f1688f1656a9"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PRESIDENTE VARGAS" },
                    { new Guid("7f437bfd-db12-4fac-8086-125784d734ea"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JENIPAPO DE MINAS" },
                    { new Guid("7f5bce89-39a2-4a5a-a035-bf1dca1a7213"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "CAREIRO" },
                    { new Guid("7f89d732-f32d-4ea6-8f1c-563e5330addf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MIRAI" },
                    { new Guid("7faf3314-5152-4855-9998-176a6c62a1f0"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PRESIDENTE DUTRA" },
                    { new Guid("7fb02446-66c7-4987-9f18-e06affce93b5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIRANGUCU" },
                    { new Guid("7fc7d91a-025f-4a85-9629-a7c74d2df11b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "POSSE" },
                    { new Guid("7fd3b974-0c56-45d7-8bff-0e321b7bcc7f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SERRINHA" },
                    { new Guid("7fdcdacc-5348-4c61-ad74-38960f764721"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SABINOPOLIS" },
                    { new Guid("7fec8656-4154-4ec9-b956-eb2e1d24aa94"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MAJOR ISIDORO" },
                    { new Guid("8066c6f9-5eaf-45f5-8185-6399b7ae48f4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VARZELANDIA" },
                    { new Guid("807007a0-fcba-4256-b1a1-75f87c27e21b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LAJEDO DO TABOCAL" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("807c365d-b995-455b-b06d-e83d1ecb367a"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "MANAQUIRI" },
                    { new Guid("807de6cc-da81-4d60-b295-e142846dc905"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "SAO SEBASTIAO DO UATUMA" },
                    { new Guid("80931c19-a2bb-4963-a08a-e2b6adef0652"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RODELAS" },
                    { new Guid("80d6ee34-4748-41f9-a753-f0adbd8cae6d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PACOTI" },
                    { new Guid("80e25be0-5e47-4328-9137-9866ff58ca87"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "LAVRAS DA MANGABEIRA" },
                    { new Guid("810611b6-8729-44bc-adf8-e865401c850e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "IPU" },
                    { new Guid("812788fb-750b-46ae-8486-223338a3efd0"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PARAMOTI" },
                    { new Guid("8127ba19-ac4f-4c06-9ee2-df95398d855f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RETIROLANDIA" },
                    { new Guid("81772b26-98a8-4954-ad82-9139cba0380d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITIUBA" },
                    { new Guid("818b2483-1fac-43e6-8d57-5fed9d60c9b1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARMO DO RIO CLARO" },
                    { new Guid("81c50aae-e3ba-4af9-a5f2-499bd99b7dd1"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MATA GRANDE" },
                    { new Guid("81c58a65-7151-4c83-b039-7ce4d248966d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ANDARAI" },
                    { new Guid("81d502e0-c58f-4a2b-9c90-bf04b655caed"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "JOVIANIA" },
                    { new Guid("82450dde-cbbb-460c-838b-c8245bb75182"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JURUAIA" },
                    { new Guid("824fa0e5-aab4-4ed5-8ffb-aba0c3a04374"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PRATINHA" },
                    { new Guid("825f2f71-6dab-4703-b6dc-fcd82e386ea9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PRUDENTE DE MORAIS" },
                    { new Guid("82764522-2bec-428d-8ae2-836bf35b280d"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PERITORO" },
                    { new Guid("82968544-93ba-4f66-b888-b5025107fcd0"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SIMOES FILHO" },
                    { new Guid("82bd7f4f-ab72-4095-9161-f6813618dd65"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DORES DO TURVO" },
                    { new Guid("82f49135-8c24-466d-9001-7e59acab8c71"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "HELIODORA" },
                    { new Guid("8301400e-bfa0-4a0c-9abb-b0288091be5e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TEOFILANDIA" },
                    { new Guid("83064a9f-6555-4a5c-aa24-e7f1301fbeed"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALAGOA" },
                    { new Guid("83237bd9-76ca-484c-9887-344543e6408e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ATALEIA" },
                    { new Guid("8351cfc5-297c-4280-8fd2-1b677e037639"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "IPIRANGA DE GOIAS" },
                    { new Guid("835fd5ae-1f81-46d9-8305-800ad2929e3c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BANDEIRA" },
                    { new Guid("836a471b-5224-4247-92be-7e8264b44a94"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SERRA DOURADA" },
                    { new Guid("83897a8c-25e4-406b-8d02-edb4b01ca4b9"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ALTANEIRA" },
                    { new Guid("8393a24d-24b7-427a-8e9c-698df5d205ce"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "RAPOSA" },
                    { new Guid("83a7eed1-2d53-438e-945d-edd47e114154"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "TURURU" },
                    { new Guid("83b57072-70c4-491a-87b0-c7fa1d2e3409"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CHORROCHO" },
                    { new Guid("83bb0828-cb02-4a70-8ef7-3f2851604983"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RIO REAL" },
                    { new Guid("83d21d87-d612-4b4a-b932-703e2c63c1af"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVA PONTE" },
                    { new Guid("83f15724-9f8e-4fb8-96ab-4d0cb1b98c71"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TOCOS DO MOJI" },
                    { new Guid("840df711-7fe4-4740-8203-2cec206677dc"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SAO MIGUEL DOS MILAGRES" },
                    { new Guid("842bfb29-6362-49ac-a0cd-9a8ae4094b29"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "MACAPA" },
                    { new Guid("844559ef-369e-4952-ae8d-6916a766fc18"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NOVA VICOSA" },
                    { new Guid("84562b56-de64-4e99-bec6-5437e6d474a7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JOSENOPOLIS" },
                    { new Guid("8471c98f-b5bb-46b4-9fe7-9b109b1ec709"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARMO DA CACHOEIRA" },
                    { new Guid("848b8166-ee43-4754-8083-3596b860a165"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PRESIDENTE DUTRA" },
                    { new Guid("84c2d40e-fd75-4a6d-bb43-97ae25e1c3c5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DATAS" },
                    { new Guid("850ffd2f-b1a2-4111-8e4d-a55af0ecdc85"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BALIZA" },
                    { new Guid("8520ba32-2d36-46d4-8304-2fda0661ee70"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "SANTA LEOPOLDINA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("85446b4f-e85c-4bb5-a649-8ac0004aea1d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CABO VERDE" },
                    { new Guid("854c3004-a542-4312-b573-0f693bfffb88"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MIRANDA DO NORTE" },
                    { new Guid("856d317e-4410-4c4c-a589-5d2af411b269"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LENCOIS" },
                    { new Guid("857f7b30-c776-4e1f-9e36-6dea9a1792d3"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ALTO PARNAIBA" },
                    { new Guid("85df197a-8b7f-418d-9f4f-24e939d04f70"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SERRA DOS AIMORES" },
                    { new Guid("8609851c-853d-417e-b565-8aa2e00efdbf"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SOLONOPOLE" },
                    { new Guid("86463625-c3dd-4b18-9afa-2e7cfa96e499"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITANHANDU" },
                    { new Guid("867c9927-5aea-40fc-a1cd-3bac6a0bed06"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PINDOBA" },
                    { new Guid("8695416b-3cb2-4511-8839-4642f9fc9a51"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBICARAI" },
                    { new Guid("86e0f6a2-70e2-4962-bbde-80da8464aa27"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NOVA SOURE" },
                    { new Guid("86e6282b-f244-444f-9e64-3db90b224293"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BRASOPOLIS" },
                    { new Guid("8722d521-d7f2-4897-82bb-c193be320ba5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BRAS PIRES" },
                    { new Guid("874cfd5b-81a6-4541-8f77-9c7c766d0217"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MINAS NOVAS" },
                    { new Guid("874d13c3-f827-49ec-8f6d-3c09659cf596"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEDRALVA" },
                    { new Guid("8761d357-d1f0-43a6-b2e2-e616668ac4f8"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "AFONSO CLAUDIO" },
                    { new Guid("877be4f1-0722-4980-bf8e-df4239ffe23d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEQUI" },
                    { new Guid("879a77cb-e17e-48bf-91cb-5d09cacbfb38"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "AMONTADA" },
                    { new Guid("87d7391f-05f4-4a96-99de-b7fc83d01a40"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CRUZILIA" },
                    { new Guid("87e34710-7645-4a52-ae04-ade60fd39b96"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "OURO BRANCO" },
                    { new Guid("88266df5-3bf5-44dd-bd7a-d18b3c017ddb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VERISSIMO" },
                    { new Guid("883fcf65-eb22-4791-98eb-80d922a221ab"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA RITA DE IBITIPOCA" },
                    { new Guid("88a11e5b-cb61-432f-bd1c-d2dda3e89158"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VIRGEM DA LAPA" },
                    { new Guid("88b8ad7f-ffc9-4972-a347-5b0070469722"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "BARRA DE SAO FRANCISCO" },
                    { new Guid("88cc8698-9639-4462-8b3e-bdeb98ad0924"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBICUI" },
                    { new Guid("88eb93dd-e1fa-44cb-b35c-ca3982629d8b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PARAGUACU" },
                    { new Guid("89651977-1f5f-42f2-b7b2-685772c71fe7"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "NOVA OLINDA" },
                    { new Guid("898dd55d-40d1-45a5-8652-1c2d7320e2e0"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOM SUCESSO" },
                    { new Guid("89aae050-d159-4c5c-8b64-0d27d0eba3c6"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ARAGARCAS" },
                    { new Guid("89ae775d-e3c7-419e-88c7-5de97dfd5e7e"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "CAMPO GRANDE" },
                    { new Guid("89c27015-99c4-42fc-aba0-69c9f0db3a9c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ANAGE" },
                    { new Guid("89c91a56-d3d8-4fa4-918b-b4a955f2b26c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SANTA QUITERIA DO MARANHAO" },
                    { new Guid("89f0b901-ce8d-4399-a4bd-c7187e416a7d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONCEICAO DA APARECIDA" },
                    { new Guid("89fb4cce-1fb9-4094-bd27-36b46f92710e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FLORESTAL" },
                    { new Guid("8a07e30a-04c0-48a8-818d-975ebd4dc899"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SAO LUIS DO CURU" },
                    { new Guid("8a37ba75-5476-4566-b884-e33d37c11a98"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PASSA TEMPO" },
                    { new Guid("8a4ae5a5-0e2a-440f-9eee-24522755acf4"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CASTELANDIA" },
                    { new Guid("8a98e7f2-780e-4d5e-8d9c-07dd3dbaf878"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ESMERALDAS" },
                    { new Guid("8a99fa2e-ce23-4145-adc3-976149f6d6e8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CATAS ALTAS DA NORUEGA" },
                    { new Guid("8ab8f1e9-fae8-41b9-93a2-457802c87fdc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PAIVA" },
                    { new Guid("8ad70e2e-218d-4e72-b0d5-ae7153b5d86c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BARREIRAS" },
                    { new Guid("8af42f3b-7852-4781-b6be-d887ddce6e90"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PIRES DO RIO" },
                    { new Guid("8b0dabf7-aade-4fec-83e4-fdebd87a1187"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PORTEIRINHA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("8b1e12ec-7cbf-4039-b78e-718604f2e6da"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARCEBURGO" },
                    { new Guid("8b398813-96ec-4c82-b3c0-b982e1818aed"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RIACHAO DAS NEVES" },
                    { new Guid("8b4d9508-439d-41fb-b9ea-218f54034e33"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAMARAJU" },
                    { new Guid("8b5eb03d-4772-4968-9d76-41a2ee9661dd"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RIO DO PIRES" },
                    { new Guid("8b633018-a579-425e-9d9a-d334f1e5114d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CRUCILANDIA" },
                    { new Guid("8b6bd0c7-79b1-4ff6-b8b2-6aa15c9c002e"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "JARAMATAIA" },
                    { new Guid("8b8d192a-4b52-46d6-9e3b-8a297ba2949c"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ICAPUI" },
                    { new Guid("8b9811ce-0bc6-475f-9e11-d4b89f8fec46"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MONTE ALEGRE DE GOIAS" },
                    { new Guid("8b9b8936-d330-4cd9-95d8-61d31d1619a8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VARGEM ALEGRE" },
                    { new Guid("8be3cf82-b902-4762-a7e2-45840b4bdaf2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ARATACA" },
                    { new Guid("8be4b874-7f60-43dd-8ce4-911cca07752d"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ARAGUAPAZ" },
                    { new Guid("8bff000d-7592-460b-ab36-788228f864f4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARCOS" },
                    { new Guid("8c30eafd-8ed6-494f-97e6-5fb20f23e0c3"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "MARAA" },
                    { new Guid("8c3ac31e-104e-44e3-bb8f-5dcdca475887"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "FORTIM" },
                    { new Guid("8c68cfc8-769e-4927-a725-b2cc7904d306"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "PORTO WALTER" },
                    { new Guid("8c9bd2f2-b622-4713-af96-69170dbdac1b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JAPONVAR" },
                    { new Guid("8ca8e66b-40f0-4e05-bbc4-e4ba2751f71f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DOURADOQUARA" },
                    { new Guid("8cb9386f-1b7c-445a-bad1-daca376a48e9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TAPIRA" },
                    { new Guid("8cc8524a-6c61-440b-beab-094ec32ef716"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CUMARI" },
                    { new Guid("8cee7666-ec02-4ecb-9e5e-eda45c7ed0c1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIBEIRAO DAS NEVES" },
                    { new Guid("8cfccf70-e105-4ae2-9af2-ac9aeee2b8e5"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BERNARDO DO MEARIM" },
                    { new Guid("8d1a2a72-36c6-41f7-9c63-10872746e502"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BRAUNAS" },
                    { new Guid("8d9d1c2a-aef2-402e-aaad-df3fac802947"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SANTA INES" },
                    { new Guid("8d9db50e-4bfc-4bdb-9f22-ea849e6dd23c"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PALMEIRA DOS INDIOS" },
                    { new Guid("8dcc79c0-988b-4ff8-b98b-f7152678f2d1"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "JEQUIA DA PRAIA" },
                    { new Guid("8deb3b8c-21a1-4c4d-b989-34a046798383"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LAMIM" },
                    { new Guid("8df5a193-acd7-4e93-b2c2-ff98d17f5fea"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ITAGUARI" },
                    { new Guid("8df70c0e-0687-409a-a2db-1ce87ed83102"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RECREIO" },
                    { new Guid("8e0e9d71-5c8a-42b2-af48-de4e64fd390d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MAETINGA" },
                    { new Guid("8e3d70a1-c654-4124-b932-a34b82948829"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PARAUNA" },
                    { new Guid("8e5b86ca-6e21-4adc-a246-2778080e8f8a"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CAROLINA" },
                    { new Guid("8e646a34-4e39-44ca-bfaf-339b7303681b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "AURELINO LEAL" },
                    { new Guid("8e77cc67-51e5-419b-8dc9-8ef310c1585d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITIRUCU" },
                    { new Guid("8ea509a2-e15b-47c4-bcb1-0e8717e5f627"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA LUZIA" },
                    { new Guid("8ec9ef21-9303-49b9-82ea-317296c52bd1"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "FORQUILHA" },
                    { new Guid("8ef7e133-7dec-427f-b215-0d145b7da041"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MUCURI" },
                    { new Guid("8f258d9f-d354-4022-80ea-b806d008aaac"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JACINTO" },
                    { new Guid("8f3c49b7-c03c-4c5f-ba05-61c4d7fdf210"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BREJO DE AREIA" },
                    { new Guid("8f402b8c-01b9-49c3-9060-7832429f24fd"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "DOMINGOS MARTINS" },
                    { new Guid("8f60c1e0-edc2-45b3-9f7e-f6732b0f45bd"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SAO LUIS DE MONTES BELOS" },
                    { new Guid("8f734a4c-5141-4b02-be78-ca2a7f07c5a3"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SENADOR CANEDO" },
                    { new Guid("8f9868c5-5724-431a-8b18-1a8a06ab3881"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "RIBAMAR FIQUENE" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("8fb00706-2047-4649-9d86-ab924fda6940"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IRAQUARA" },
                    { new Guid("8fc8a99b-3b5e-4683-b987-9bf2764e37cf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BUGRE" },
                    { new Guid("8fd16323-e86d-4893-9feb-d1c2e28c107d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "WENCESLAU BRAZ" },
                    { new Guid("8fd203b0-22da-49e0-9dfa-40f48bece1ee"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JUIZ DE FORA" },
                    { new Guid("900bcf86-5b8e-4d7c-98c7-ecbe3374a2a2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIRAUBA" },
                    { new Guid("900d14a8-77df-4568-8fa3-4d8d057ef253"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LIMA DUARTE" },
                    { new Guid("905f4c73-410e-473c-b989-827e9f2aded8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTA TERESINHA" },
                    { new Guid("9074760b-6539-4e8c-adcd-3fe8d63f1ba5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITABIRITO" },
                    { new Guid("907a0ad4-11b3-45ca-b13e-2d31dc3583b9"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "VICENTINOPOLIS" },
                    { new Guid("90842a40-421a-4f71-b2f3-82a6e7f6d8c7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "COMERCINHO" },
                    { new Guid("908d9fe0-06ec-4c81-9fa7-217bbb1fc7e4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PRESIDENTE OLEGARIO" },
                    { new Guid("90a0a20a-1128-43ae-b40c-3b5d4262888e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MADALENA" },
                    { new Guid("90a50ffb-b550-41e4-941f-1e838bd35f6f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CHAPADA DO NORTE" },
                    { new Guid("90e0dfda-53c7-44cf-bdee-5fec4f30b727"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BIQUINHAS" },
                    { new Guid("910acec3-e0b1-475f-836e-8641606d4cc7"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BARRO ALTO" },
                    { new Guid("9122a627-5970-4004-8dfe-16e31f7ebca6"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SOBRAL" },
                    { new Guid("912a0871-44ba-4d9c-8a4e-70c02b4a133d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "UBAPORANGA" },
                    { new Guid("915463bf-3e92-47bc-8693-a1f4c3fe3569"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ITAPIUNA" },
                    { new Guid("916e95f3-ede1-44de-b709-c5534b2dfce5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMPO DO MEIO" },
                    { new Guid("91749adc-da37-4039-a7a5-511aae90705b"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CHAPADINHA" },
                    { new Guid("91b21625-67fd-4cdc-9eff-8acef9083cbe"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ANCHIETA" },
                    { new Guid("91b471cb-c85e-43bb-bb59-091f954c90cf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMBUI" },
                    { new Guid("91b7425d-d106-4773-9f31-621171b5da78"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BREJOES" },
                    { new Guid("922a5fe9-801a-41d5-a70c-1d8232a2da1d"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BURITI" },
                    { new Guid("92399d19-25aa-4839-9a87-a5273e434a21"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "OLIVEIRA" },
                    { new Guid("924d1250-b78b-4644-876a-6fb6886ec392"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "JAGUARIBARA" },
                    { new Guid("9257ac24-f040-4ba2-9c83-d6130de0c8bb"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "AURORA" },
                    { new Guid("925f51eb-3b7e-4356-9e7d-509f87686357"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PALMA" },
                    { new Guid("926b2cc7-9780-478c-9140-b128acbc226c"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "MANCIO LIMA" },
                    { new Guid("926f989c-ccff-4d7e-8371-5d349fe79764"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CROMINIA" },
                    { new Guid("92963c69-f814-44be-bd73-1ae7ce9fd7f5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FRANCISCOPOLIS" },
                    { new Guid("92a0ea57-9eff-48d3-b653-35bf30c10356"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "CACHOEIRO DE ITAPEMIRIM" },
                    { new Guid("92c15781-7395-4a3b-8de6-3952e5ab5562"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "BELEM" },
                    { new Guid("92cc884c-fa7d-485f-9c69-4cbef59daa1d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FORMIGA" },
                    { new Guid("92d28198-85be-4da8-870e-c315e7bb106d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CHAVAL" },
                    { new Guid("92e35713-18b5-49f3-bd58-d0e152003345"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FRANCISCO SA" },
                    { new Guid("92fdd810-4251-4f0c-9e1f-e6bf835a02d1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DIVINOPOLIS" },
                    { new Guid("92fdf460-ee82-45ad-b993-06d115521154"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUARACIABA" },
                    { new Guid("930f4543-a885-47e2-8fb8-631b5b8f6a3d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO SEBASTIAO DO MARANHAO" },
                    { new Guid("931d7d07-e645-42f5-ab93-ab0cc375a8fb"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "COCOS" },
                    { new Guid("93237ce7-dacf-4975-a80f-0810f6637864"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ITAPIPOCA" },
                    { new Guid("9342827f-b0f1-46cb-9fc5-9caad4421295"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CANDEIAS" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("93566a31-fc20-4231-9355-9d35ba871f53"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "OLINDA NOVA DO MARANHAO" },
                    { new Guid("938e4915-ccd0-44cd-8906-ff25b7032f03"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DOM JOAQUIM" },
                    { new Guid("93a9b6f3-b8d6-4855-81f6-1c11bead8c6a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MAR DE ESPANHA" },
                    { new Guid("93b25993-ded3-432e-b5f0-4307e718898b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO JOSE DO JACUIPE" },
                    { new Guid("93b26148-02b8-448e-91d9-4ebd92805779"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "EUNAPOLIS" },
                    { new Guid("93c097a5-cbfd-4078-8b68-7ac30d93bf60"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEDRO TEIXEIRA" },
                    { new Guid("93ee7e78-33be-4153-b7e6-fbe9a22b7632"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "VITORIA DA CONQUISTA" },
                    { new Guid("941147c9-3731-4e63-a9d4-a38a0ebf9d51"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SILVANIA" },
                    { new Guid("941543dd-20b2-4563-99ce-553a443fe1a4"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CARIDADE" },
                    { new Guid("9436d5b9-2f7a-4e7d-967e-52db1b2f3fc1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITURAMA" },
                    { new Guid("94a1c70c-a913-47d6-b9dd-564202b0264c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "FATIMA" },
                    { new Guid("94cd9145-acd4-4359-8f89-591f91e49f67"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MORROS" },
                    { new Guid("94cdce1d-48bb-4f1e-b1c0-e9988f007e21"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "COQUEIRAL" },
                    { new Guid("94f21025-5df3-4f43-b8a0-83ee0e5fbf39"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MAGALHAES DE ALMEIDA" },
                    { new Guid("94fa4e89-51d4-434e-80e4-205059207c58"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO DOMINGOS DAS DORES" },
                    { new Guid("95062233-4c9c-4590-9b0f-2e02d8dfa53d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TAIOBEIRAS" },
                    { new Guid("951a9ad3-89b1-48c8-a3bb-a8017ca81a98"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "BELO MONTE" },
                    { new Guid("952c8761-70be-48eb-bed5-e9296c881484"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAPELA DO ALTO ALEGRE" },
                    { new Guid("95339009-604f-4c10-9679-6e19ed0e9c91"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "FORMOSA DA SERRA NEGRA" },
                    { new Guid("9540a75c-aa1a-43ee-b813-8d3c12bd3727"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA EFIGENIA DE MINAS" },
                    { new Guid("9548d5e8-eacf-4ce7-a9ae-c932d1dc52c5"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "LABREA" },
                    { new Guid("957c148d-136c-4cfa-b1f4-71e7f7d04c5b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PADRE CARVALHO" },
                    { new Guid("959fe448-ee8a-493c-bd7a-bad81c82bb4c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO VICENTE DE MINAS" },
                    { new Guid("95a2d4e6-c2ef-4822-bd68-7ae7d14ae573"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SANTA RITA" },
                    { new Guid("95ba55fc-2150-4bfb-a804-b8627dba1736"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORDISBURGO" },
                    { new Guid("95d2f4bd-388a-4685-86dd-c5491fb31a78"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GOUVELANDIA" },
                    { new Guid("95d8968b-db11-4ce5-bdad-95ff37de4c3e"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PILAR DE GOIAS" },
                    { new Guid("960f337a-fd04-4e5c-aff6-7896844cb7fc"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CENTRAL DO MARANHAO" },
                    { new Guid("9634634b-537a-44ea-9b62-2dafc493f21d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO SEBASTIAO DO PASSE" },
                    { new Guid("966e84fc-f350-47a6-9d1c-f6a21bdcf63f"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PALMEIRANDIA" },
                    { new Guid("967ddca8-4c24-4a60-b2ff-876fa686ad9d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CARAIBAS" },
                    { new Guid("96a32724-1655-4854-8809-77b2990ce353"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "IPORA" },
                    { new Guid("96a657e8-9d1c-4f47-a002-ae525732b31b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SALVADOR" },
                    { new Guid("96b09d22-cf17-4f05-b9d6-d494d2ce58fe"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO POMBA" },
                    { new Guid("96c21caf-5ab4-42b2-879e-ff8853cdfa98"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ORIZANIA" },
                    { new Guid("971470bd-81b5-4812-8a49-b86d40c9dfbf"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "COITE DO NOIA" },
                    { new Guid("9715d967-f5cd-4a62-b726-32a06ab41c35"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "PONTO BELO" },
                    { new Guid("971d534b-19e9-49a3-bebc-fb99a5ab4ccc"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "BARROQUINHA" },
                    { new Guid("972e8dfc-12aa-4c4c-8f34-d641bd63601e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTO ANTONIO DO AMPARO" },
                    { new Guid("97412fdb-9a59-4a19-b52c-ae92c63f6ae3"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "PLACIDO DE CASTRO" },
                    { new Guid("97632b0f-69e8-4753-acf4-8517fbe362f2"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "BOA ESPERANCA" },
                    { new Guid("976a563d-fa17-49c7-b61d-f85afadca113"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MADRE DE DEUS" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("97cc4451-d778-4d84-9a0d-166c00c67356"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "POUSO ALTO" },
                    { new Guid("97f09fa0-bdc9-4e6d-9c07-3fec930d6246"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "LAJEADO NOVO" },
                    { new Guid("9842438a-0d4a-4ca7-9c6c-ffe589a4d6ed"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PALMEIRAS" },
                    { new Guid("9874e12e-582d-4ae7-8792-e23bb8788aac"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MONTES CLAROS DE GOIAS" },
                    { new Guid("9882b037-74de-43ff-88b4-737164aad226"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MUNDO NOVO" },
                    { new Guid("98be0a0e-39e6-463d-ac00-e4d353399a24"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FELIXLANDIA" },
                    { new Guid("98c530e3-cbaf-47c7-b67d-5de588bc3938"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IPUPIARA" },
                    { new Guid("98c7c112-6cbc-43a2-a5e3-b00fd896819d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO PIRACICABA" },
                    { new Guid("98c9cc15-9f9f-4e09-95ff-927690034c97"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "IPAMERI" },
                    { new Guid("990f1c93-0d30-43f3-87d8-aa478a5f6a39"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PRESIDENTE SARNEY" },
                    { new Guid("993f6bf1-3869-4754-9de8-b5aa71963de9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JACARACI" },
                    { new Guid("994e15f3-5ee7-4a77-bc42-28b47664d7d3"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SAO MIGUEL DO ARAGUAIA" },
                    { new Guid("99ad1660-4ef8-49d8-8487-998fd1ac486d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO DO MANTENINHA" },
                    { new Guid("99c07492-cc20-4790-955b-b4099dc9d806"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PAULISTAS" },
                    { new Guid("99c9febd-71de-4120-ae0d-618b2ebb7341"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAETANOPOLIS" },
                    { new Guid("99cd5b1b-b2de-446b-8408-2e06cbd98722"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MORRO DA GARCA" },
                    { new Guid("99f6489e-810b-4e37-990e-0494540b75e5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARMESIA" },
                    { new Guid("9a1f2547-e250-4aac-b61c-805e69a69e77"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO DOMINGOS DO MARANHAO" },
                    { new Guid("9a31bf34-f66e-44a1-86e2-1ce21daa06ec"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CRISTALINA" },
                    { new Guid("9a77b557-a308-4806-982b-4af3986753d5"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "IPAPORANGA" },
                    { new Guid("9ab91da0-fa1f-418a-bc17-5d9ce06c199b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAOBIM" },
                    { new Guid("9acf5268-871a-4a34-9560-96e46a3ce600"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PRIMEIRA CRUZ" },
                    { new Guid("9ad3078d-bd2f-41af-8674-27b184bc9396"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIRANGA" },
                    { new Guid("9aeda8e0-cd6e-4bb7-a0ca-ca2de5625b70"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CENTRALINA" },
                    { new Guid("9aedf4c5-a980-4539-8296-677a4932f7f5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ANTONIO CARLOS" },
                    { new Guid("9b61551a-4313-4de4-a811-6678b9a23adb"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "CALCOENE" },
                    { new Guid("9b80e635-cd3e-4032-8caf-dbcee9c596f7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PAINEIRAS" },
                    { new Guid("9ba73a93-31e6-49cc-a806-b60179945814"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "FAZENDA NOVA" },
                    { new Guid("9bb4629e-2a46-4a70-be26-24f319d9d4e9"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PORTO RICO DO MARANHAO" },
                    { new Guid("9bc6dcbc-4043-4c44-b357-fc02bb0bbecf"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAPEBI" },
                    { new Guid("9c5d1917-3764-481a-96d6-642ce13ee069"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GOVERNADOR VALADARES" },
                    { new Guid("9ca356a8-41a9-43e3-b8f1-95d50dd9f57f"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "DOIS RIACHOS" },
                    { new Guid("9ca9c0ef-7d35-4ca9-bbae-4b18a4202ac3"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "DAVINOPOLIS" },
                    { new Guid("9cb469e5-cea4-4885-bab6-a44379e6a976"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CATURAMA" },
                    { new Guid("9cece925-9199-42aa-b8a4-5bebaf00a9f9"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CACHOEIRA GRANDE" },
                    { new Guid("9d144cb2-5dfa-4f99-b6dc-43f36370e39f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO ROQUE DE MINAS" },
                    { new Guid("9d54c732-7746-41f2-8415-65572a29353c"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "GUAJARA" },
                    { new Guid("9d6248ad-e12d-490f-87e1-40b6f54fd103"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TAQUARACU DE MINAS" },
                    { new Guid("9d6b65fb-07cf-47ac-b183-09d0effb8b2b"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "VILA VALERIO" },
                    { new Guid("9d8b533f-22d5-4e08-ae28-627f89f40dfb"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BARRA DO CORDA" },
                    { new Guid("9dc77db0-3014-450c-a25d-9d39013ac43d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "REMANSO" },
                    { new Guid("9de7dd42-f43c-47e5-84ed-82ea542cf16a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IBIA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("9e35eb00-1e3a-4260-bf2f-99f09beaeaa6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MARIA DA FE" },
                    { new Guid("9e3d90d4-e6df-40ec-bb8e-8a53bd50c229"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JEQUERI" },
                    { new Guid("9e70a3ca-9ab7-4dd1-8e7d-8d959b83c723"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IGUATAMA" },
                    { new Guid("9e7d04ba-973b-4bda-97dd-295ae00c1cab"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTO ANTONIO DE GOIAS" },
                    { new Guid("9ebc82f8-cb37-4b17-9d1d-0c5898bcf7c8"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SAO JOAO DA PARAUNA" },
                    { new Guid("9ecc58d3-31a6-4883-8592-e54c5d5a2477"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "MARECHAL THAUMATURGO" },
                    { new Guid("9ef7d1fa-2733-469f-af55-405124930257"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LADAINHA" },
                    { new Guid("9f027aa5-7905-4867-94a0-237461d1fd55"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ICONHA" },
                    { new Guid("9f0e2e66-da89-4928-b74f-740e96e41df3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAIPE" },
                    { new Guid("9f86da85-94c2-4b25-9fa4-7649822be9e6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MANTENA" },
                    { new Guid("9f8d14d4-cf2f-44d8-9927-3d79efcd2b9e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LUZ" },
                    { new Guid("9fa89153-8191-4906-bbc1-2e9fd856a401"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RIBEIRA DO AMPARO" },
                    { new Guid("9fae98f0-7158-4b06-9a7b-0c50c509b317"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "POTENGI" },
                    { new Guid("9fc1fefa-be39-4d20-be8f-77821ee2c592"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JOSE RAYDAN" },
                    { new Guid("9fc6f587-5089-4005-8686-51bef509c3d2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO FRANCISCO DO GLORIA" },
                    { new Guid("a0009933-eec3-41f5-9f18-13f2d740a4fd"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PE DE SERRA" },
                    { new Guid("a027eb77-d9db-4a0f-bf65-3474787c5bdb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BERTOPOLIS" },
                    { new Guid("a0475bea-b139-4ac4-a430-9fb5cf7657a1"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MIGUEL CALMON" },
                    { new Guid("a05f57f7-5cf8-4bb0-ab82-a98ecb2e20bf"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "VIANA" },
                    { new Guid("a06dff3d-f1f9-4a0f-9e52-2877c82b1277"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SIMONESIA" },
                    { new Guid("a0d5222d-5385-4d01-a7b6-bd94801c13dc"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ACOPIARA" },
                    { new Guid("a0ea5c6c-96ee-4f43-abc3-c3d2a63eb919"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ANTONIO PRADO DE MINAS" },
                    { new Guid("a0fec6e0-248f-4926-80db-c0ea330d91df"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ITAREMA" },
                    { new Guid("a1068da4-b7cb-47ac-a46d-ed914243d418"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MORRO AGUDO DE GOIAS" },
                    { new Guid("a15011ec-596b-4b64-b1be-5996366ba3ac"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ANHANGUERA" },
                    { new Guid("a1528e17-e677-41ba-aa2c-e370cdc82447"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ALMADINA" },
                    { new Guid("a182b7a2-f9a2-4ebf-8ace-d631004f7613"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SACRAMENTO" },
                    { new Guid("a19947c2-1ca9-4722-9b92-94b779b00a35"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RIACHAO DO JACUIPE" },
                    { new Guid("a1a5ca60-a18e-492f-9a4e-14e1f1ca3a27"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "EUCLIDES DA CUNHA" },
                    { new Guid("a1be6b22-614d-4aab-b514-6a38ce6a5db1"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LAGOA REAL" },
                    { new Guid("a1edf374-3218-41bf-9835-dfb946e7ebe1"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CRISTOPOLIS" },
                    { new Guid("a20552fe-d633-4f80-b970-d976746882cc"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "IBIRACU" },
                    { new Guid("a2066ba1-f96e-4f64-91e7-668c7031fbeb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONCEICAO DO RIO VERDE" },
                    { new Guid("a2517701-d214-46e2-b578-ff14d11ffb3e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO DOMINGOS" },
                    { new Guid("a29a89e5-3974-4193-9db7-d3367cabb862"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TAPARUBA" },
                    { new Guid("a2ba1fac-9ee5-4e13-8022-2920d3135a69"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JEQUITAI" },
                    { new Guid("a2cc4438-05a3-4295-8a95-e9b3d910fd2f"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SAO LUIS DO QUITUNDE" },
                    { new Guid("a2d37013-33af-4a91-bd98-195a91ac0da5"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ARAGUANA" },
                    { new Guid("a2d67fa5-99fb-48bd-86a5-73fdbafd96ec"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "MUNIZ FREIRE" },
                    { new Guid("a2de43f3-559f-43fe-b84d-f8f2b884f1c5"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "POCO DAS TRINCHEIRAS" },
                    { new Guid("a2f340d6-91cc-4323-a511-bb3291383e2d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IRAJUBA" },
                    { new Guid("a2f62fbd-42e4-4f69-8c67-984fdeec87bb"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "LUZIANIA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("a31230cb-8b52-4731-b959-acdc7648846f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NATALANDIA" },
                    { new Guid("a316fd02-926e-4735-92b9-8628e495ad54"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SATIRO DIAS" },
                    { new Guid("a31f8ceb-47cc-40f2-97da-c9dc95a5e96d"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "AGUA BRANCA" },
                    { new Guid("a344cebd-c7b8-4f11-a863-3f6ff4ff882a"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "GOVERNADOR NEWTON BELLO" },
                    { new Guid("a3508d7e-5e96-4ed2-950a-5822a5493a21"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "ACRELANDIA" },
                    { new Guid("a37c10a2-e13e-437b-8561-617f7b7ed506"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO LUIS" },
                    { new Guid("a3ba4fd5-8348-41c9-a968-e41bae434347"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RIO DO ANTONIO" },
                    { new Guid("a3c01bda-9696-49fb-b4d8-66623f245b12"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORDISLANDIA" },
                    { new Guid("a412aff8-6841-45ea-90c4-d13c8c64d207"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CALDAS NOVAS" },
                    { new Guid("a43ec836-867d-4bad-a7d0-77cc78678eb7"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "INHAMBUPE" },
                    { new Guid("a445e849-682a-448b-bf42-97a48031de49"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "AFONSO CUNHA" },
                    { new Guid("a44a75d7-db05-4b70-8070-340079a4cfe4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PORTO FIRME" },
                    { new Guid("a478b731-ae2f-41f4-b2a0-7ace72954dc3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DELFIM MOREIRA" },
                    { new Guid("a499c5b6-d9df-4e6f-82b6-5ddcd69994f8"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "TROMBAS" },
                    { new Guid("a4b12a90-1819-4e8e-8789-4017da3ce71e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUARANESIA" },
                    { new Guid("a4e7f57a-7dbe-4f9e-85ed-f4ccb6abde0c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "FILADELFIA" },
                    { new Guid("a4e8055f-a9c3-4fe6-94a0-905b84cf1cb3"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "XAPURI" },
                    { new Guid("a4eaa7d0-63e4-4a5c-9347-854cae6ad862"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "GUAIUBA" },
                    { new Guid("a4f036ae-3739-4503-9b92-87f51c3c9858"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GUAPO" },
                    { new Guid("a51fdc16-6a3d-4bf2-ac67-867c9da41698"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MACARANI" },
                    { new Guid("a564e12c-3ba7-4b3f-95ee-126b86ccc089"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BURITI ALEGRE" },
                    { new Guid("a5664d12-60be-425b-ad66-b1c86bdf19f6"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "OLIVEIRA DOS BREJINHOS" },
                    { new Guid("a59f3dcd-d3ee-4068-b51f-9c015de56c9d"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BELAGUA" },
                    { new Guid("a62b6f03-9459-4c90-a641-052df94a206b"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "LAGO DOS RODRIGUES" },
                    { new Guid("a65fba75-c42a-4337-8348-327e07c1dff3"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GOIANIA" },
                    { new Guid("a6913d9f-9d95-4271-8116-e4518329774e"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BREJO" },
                    { new Guid("a6bc158b-981a-4add-9e4b-39a3372d9a25"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RESENDE COSTA" },
                    { new Guid("a6cc34da-de0c-43fa-a104-881e3d9121d4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GALILEIA" },
                    { new Guid("a719d096-b0e9-4d2f-90d5-85a811dfa0c2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FRONTEIRA DOS VALES" },
                    { new Guid("a729ed76-4841-4aa1-9309-fb6e65d4d7fa"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEQUERI" },
                    { new Guid("a739f2c0-736a-4ef8-b68d-60b5f5485a39"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "RERIUTABA" },
                    { new Guid("a744c10c-d523-42be-89f6-72d9fde4d1c5"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "TURVELANDIA" },
                    { new Guid("a7463eb1-cf5c-45af-b645-1b70496b66ac"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JANAUBA" },
                    { new Guid("a747f132-9891-4c56-ad70-4ae9d51d257a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JOSE GONCALVES DE MINAS" },
                    { new Guid("a756ecf1-3fd7-4d11-bc19-8533727f7a9c"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GAMELEIRA DE GOIAS" },
                    { new Guid("a77b3f80-ced0-446d-b81c-f9096b210900"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ALFREDO CHAVES" },
                    { new Guid("a8088cae-f0f3-4532-95c3-fc682bec148c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "AMAPA DO MARANHAO" },
                    { new Guid("a828de59-dc0d-4300-94a5-e784751d0db8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JOAIMA" },
                    { new Guid("a83bd632-2734-439e-9a52-34b99d0c82ea"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GOIANESIA" },
                    { new Guid("a86232af-27c5-4bb7-bd7a-8e688625fecc"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ALTAMIRA DO MARANHAO" },
                    { new Guid("a881e580-cbfb-4f1e-baad-1ab4df075f4e"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "APUI" },
                    { new Guid("a8955e0d-0692-4060-94d5-f4ee12f5d2aa"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "COROACI" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("a8adf8ee-bcd2-4e82-8a85-5f9fa8afcb39"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PORTO DE PEDRAS" },
                    { new Guid("a8cd1556-12b8-4054-8cac-f872c6978958"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO MIGUEL DAS MATAS" },
                    { new Guid("a8dcbaa0-0bdb-45fd-ac42-47c3da0d701a"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GOIATUBA" },
                    { new Guid("a8dcfe2d-f285-43b9-bd6d-4de4734047b3"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "RIO VERDE" },
                    { new Guid("a9492557-fd09-4afb-bd59-61102cd04f7d"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "JAPURA" },
                    { new Guid("a956955d-62b0-42d3-9be1-43243c5df0fc"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MACEIO" },
                    { new Guid("a970f317-a300-4312-a65b-c38b70a5071c"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "CARNEIROS" },
                    { new Guid("a9891f3b-741b-47f6-becd-13aaf11ca420"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTO ANTONIO DO AVENTUREIRO" },
                    { new Guid("a995a540-5dc7-4f48-9aab-170af3cf76e3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MILAGRES" },
                    { new Guid("a999b81f-aaaf-4299-bba3-63baadb5fb20"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JUVENILIA" },
                    { new Guid("a9f20556-d72a-4d78-bb4c-08c79c1ae9dd"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "TAMBORIL" },
                    { new Guid("aa05f01b-336e-46f0-9a7b-e803aff750de"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "INHAPI" },
                    { new Guid("aa135064-e690-40e9-875f-803257c6644c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "IMPERATRIZ" },
                    { new Guid("aa45b9fd-d078-4abf-a498-0f46e6745bed"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LAFAIETE COUTINHO" },
                    { new Guid("aa69aa0a-ba55-47ca-9e2b-7005383cdc9d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MARMELOPOLIS" },
                    { new Guid("aa78e23c-0014-49cb-897d-4aea5387d6e1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "UBERLANDIA" },
                    { new Guid("aa897e94-2f37-496d-856a-313e221d8621"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NATERCIA" },
                    { new Guid("aaa78314-d215-49cd-ad4e-a82c0735c27a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAPARAO" },
                    { new Guid("aad1bc8e-dd83-491b-a343-dbe270edcb8b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "AMARGOSA" },
                    { new Guid("aaedc0c4-92e6-4a30-b8ea-ac8df9eba900"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "AMAPA" },
                    { new Guid("ab1205d8-bf37-4ce1-a58b-6b9ca1458abf"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "QUIXERE" },
                    { new Guid("ab278178-2c89-4217-9172-e252d94d03dc"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PERI MIRIM" },
                    { new Guid("ab27dc32-9026-4023-8be8-847d69db176f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BELO CAMPO" },
                    { new Guid("ab2e1988-45f4-49c5-a5da-9d4c45febf65"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NOVA IGUACU DE GOIAS" },
                    { new Guid("ab47c844-7e72-4b3f-9b75-9f1ed47ffb27"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CRUZEIRO DA FORTALEZA" },
                    { new Guid("ab4e3b0e-d098-4749-847e-5c66b3d6b3a5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PADRE PARAISO" },
                    { new Guid("ab7d4b9a-0c55-4693-9102-67689f23d555"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONEGO MARINHO" },
                    { new Guid("ab9408a0-38be-434a-9e1f-6ad12c5314c8"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PARAIBANO" },
                    { new Guid("abaa23d2-c2fc-4e78-9aee-208f6bd384af"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CHIADOR" },
                    { new Guid("abae7998-2f83-489c-bc18-4e2ebabd599c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "AGUA FRIA" },
                    { new Guid("abc12ce2-877d-4bbe-8a11-358c346a53a9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CATU" },
                    { new Guid("abd7663d-3ab5-447b-8274-8dad30db6755"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MARECHAL DEODORO" },
                    { new Guid("abeaeb16-dd8f-453e-be7f-3cd38dab4d91"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA MARGARIDA" },
                    { new Guid("ac19ce1e-4f39-446e-aac3-bb8dacf07dbe"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BOA NOVA" },
                    { new Guid("ac288805-d01f-47fe-97ae-2a56eebc575d"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "IBATIBA" },
                    { new Guid("ac2b5ece-55dc-4d0a-a360-7fa4d7f48f4c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO PEDRO DA AGUA BRANCA" },
                    { new Guid("ac3cf170-cf55-469e-9728-9f11b13d56d3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTO ANTONIO DO RIO ABAIXO" },
                    { new Guid("ac3f2ea0-b8ea-480d-9b74-af6c3464dd9a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LICINIO DE ALMEIDA" },
                    { new Guid("ac447347-2b97-4ca4-9e16-f886aa9e6a03"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PORTO REAL DO COLEGIO" },
                    { new Guid("acb2cf2a-0a77-4cf8-94ac-9f1803bd58d2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "DOM BASILIO" },
                    { new Guid("acc4201b-d934-4d05-b2c5-a50063d0ceb9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CANAVIEIRAS" },
                    { new Guid("acde7eeb-79d4-43b0-b7da-6fbcfd2de931"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTANA DO DESERTO" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("acf3ec59-5f19-41ef-b60f-62645acb2889"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MOZARLANDIA" },
                    { new Guid("ad03e6c8-bafe-44a4-97c3-9e6306dd7345"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONJOLOS" },
                    { new Guid("ad215eb3-6e7a-4fc1-93a5-40bc3b5d5478"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MARAGOGI" },
                    { new Guid("ad2ba71e-f029-42ff-96c4-36abf28e18a6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DONA EUSEBIA" },
                    { new Guid("ad6c7044-e16e-40b5-a64f-ded0da10aab0"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "FUNDAO" },
                    { new Guid("ad7bfe09-457e-4bab-93f9-e2fa9e787f1d"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NOVA AMERICA" },
                    { new Guid("ad8c6031-9bcb-4665-9e7e-f6044a247303"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MEDEIROS NETO" },
                    { new Guid("ada9500c-c280-4451-9ddb-0041d7dbd12d"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "NOVA IORQUE" },
                    { new Guid("ada96bcd-abda-4b08-8923-1cb7594d4015"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "FARIAS BRITO" },
                    { new Guid("adaa8e52-4b5b-4881-bb05-c2d488019df9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JUCURUCU" },
                    { new Guid("addc19e9-2482-4f80-a827-e3dff571acbd"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "LAGOA DA CANOA" },
                    { new Guid("ae47efd6-3dd7-4094-8bc0-0849b4da667f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAPIM GROSSO" },
                    { new Guid("ae5ec161-ba06-41ad-a666-70efb6eda4a9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CANDIDO SALES" },
                    { new Guid("ae704306-d288-4d4d-9525-9563f1eacce4"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MIRANGABA" },
                    { new Guid("ae8507d9-7175-485a-9202-60079dd0b6e8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VAZANTE" },
                    { new Guid("ae873919-3984-4ba0-82c6-4711094c954a"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "BRASILEIA" },
                    { new Guid("ae899311-5f01-4f00-8aa5-b48136af5169"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TRES PONTAS" },
                    { new Guid("aef14dfa-ceaa-401a-8d49-8a04a29547c6"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ITAITINGA" },
                    { new Guid("af1c5d8a-18a5-4b50-b2ae-044ed0ab5160"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTA RITA DO ARAGUAIA" },
                    { new Guid("af4d5720-b1d3-4a64-ae2c-cb326da6014b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CANUDOS" },
                    { new Guid("af7d4dbf-9b30-4073-b11a-d4f2c8bdca69"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "DELMIRO GOUVEIA" },
                    { new Guid("b0082695-0cfb-41f8-a9bb-8c265e505e6a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAATIBA" },
                    { new Guid("b01d9427-f82b-4108-b9b1-442986604e69"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "COQUEIRO SECO" },
                    { new Guid("b027cf30-23bb-4058-b002-c6cdaa47e732"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SERRANO DO MARANHAO" },
                    { new Guid("b0695252-26ca-4550-9ca3-c2c3bcf319f7"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ANAPURUS" },
                    { new Guid("b0793882-ec75-405d-993d-e7a0a0563559"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "PIUMA" },
                    { new Guid("b07c8926-3cf2-4477-b6db-60f90756fd88"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BEQUIMAO" },
                    { new Guid("b0823d74-8db1-4441-abdc-8cf3f81157b3"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "AQUIRAZ" },
                    { new Guid("b084b929-41f7-4503-a971-e541105bbeea"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MARACACUME" },
                    { new Guid("b08e570b-32d5-4b98-b66a-5757d59b9db2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MAIQUINIQUE" },
                    { new Guid("b0addaf3-4e9e-4c51-9346-0cf5754ee371"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ERVALIA" },
                    { new Guid("b0c369b2-58da-4b7a-92db-6855fe00c53e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITABIRA" },
                    { new Guid("b108e1c5-854d-4e60-a7d6-5aa51726dd6b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MARAVILHAS" },
                    { new Guid("b10a0973-a2d1-4d44-835d-2604e847ff46"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "PARINTINS" },
                    { new Guid("b15a15b3-7579-4a59-bbfd-54ab04d68cfd"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAETE" },
                    { new Guid("b189e433-4498-4447-a363-1f5606ee3f99"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MONTIVIDIU DO NORTE" },
                    { new Guid("b19e05b2-5a91-498f-9edf-2c5b3bc691fd"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "DIAS D AVILA" },
                    { new Guid("b1b4ea77-5325-47b7-84cc-d9ab0f47e898"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IGARATINGA" },
                    { new Guid("b1bd1f4b-f9b5-4846-9259-3bc762a979a8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PAU BRASIL" },
                    { new Guid("b216c1a4-bc56-41ca-b8c7-619832427f18"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MARIO CAMPOS" },
                    { new Guid("b22f3616-3e05-49f4-aed9-c72319b28d20"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BACABAL" },
                    { new Guid("b2661f96-2cdf-496e-b4b4-e86657181f80"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONTEZUMA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("b278dda8-2891-4786-abe5-e9456ffc7adf"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PINDAI" },
                    { new Guid("b2db1adb-d54b-482a-bb19-aaf9db4a7754"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "AIURUOCA" },
                    { new Guid("b2e75e65-25d1-413b-b08d-251a38b086c5"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "SAO PAULO DE OLIVENCA" },
                    { new Guid("b34a132a-ee31-4178-89ac-beb8cb0d096f"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "HUMBERTO DE CAMPOS" },
                    { new Guid("b35d3898-0ee7-4034-a20b-6a1e23d437ce"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO DO ORIENTE" },
                    { new Guid("b35f9f3a-27da-433c-a043-682ed8267ecb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA RITA DO ITUETO" },
                    { new Guid("b3722af0-0b95-48f8-981e-2169cdb1f7c5"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ALTO ALEGRE DO MARANHAO" },
                    { new Guid("b3c9444c-34c9-4c82-932d-b70064af3b29"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "DIVINOPOLIS DE GOIAS" },
                    { new Guid("b3c99412-71d2-4b91-a1f6-ff267473164b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORREGO NOVO" },
                    { new Guid("b3cc337f-8c82-4734-8398-c11fd1582631"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BURITIS" },
                    { new Guid("b3fba24a-536f-4397-ada9-0c5239f8929a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "VARZEA NOVA" },
                    { new Guid("b406ddf5-a6f6-4219-bd9e-8385b9bd28de"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAJUBA" },
                    { new Guid("b435d3fd-fd26-4f10-b162-e775dce6a645"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MAURILANDIA" },
                    { new Guid("b499ed96-e76d-4496-88ff-15a749697099"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIRANGUINHO" },
                    { new Guid("b4d93b1a-29cc-4ca2-a9fc-450ca7951144"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BOM JESUS DE GOIAS" },
                    { new Guid("b4d9cd3d-6533-4923-82e1-f50d8cf5a1de"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CALDAZINHA" },
                    { new Guid("b4ffda57-7a04-47bb-a464-3c2bec74a40e"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BENEDITO LEITE" },
                    { new Guid("b51846ad-1862-49e9-bb1c-cea7dd7c8b9c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITACARE" },
                    { new Guid("b5601edf-ef1f-44ec-9742-ecc61897a5ce"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "GRACA" },
                    { new Guid("b56bc04f-58f6-4eaa-9936-b133d912e3b6"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "SERRA" },
                    { new Guid("b57b686f-f50e-41ef-ba25-4432b92ed248"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "INDIARA" },
                    { new Guid("b585c6f9-9a51-4945-a66d-d7a7c7906ebb"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SUCUPIRA DO RIACHAO" },
                    { new Guid("b587648e-9d73-4584-bb85-e0295ac00aaf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IBERTIOGA" },
                    { new Guid("b58c2941-e11f-493f-9739-2fc6cdaa15b1"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "CHA PRETA" },
                    { new Guid("b59e61eb-d2ce-4dd0-9f27-a8ef35592970"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "COARI" },
                    { new Guid("b5dabe32-003f-4441-9406-1646b16aec75"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITANHEM" },
                    { new Guid("b5ff6c37-7a25-4707-97e5-ff9e7c4feb79"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTA FE DE GOIAS" },
                    { new Guid("b6b3f31f-0b8e-4d4e-8ab7-bf5758fb7562"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SERRA DO RAMALHO" },
                    { new Guid("b6cd0f00-c51a-44b8-a733-d14e4ebb2751"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOM DESPACHO" },
                    { new Guid("b6d177f5-5934-40f0-8f9e-b721113d0097"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "GOVERNADOR LUIZ ROCHA" },
                    { new Guid("b71e6237-b642-447a-b0ab-d1b1fabce0b3"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ORIZONA" },
                    { new Guid("b7260164-9736-4dcd-a0e0-0cf8e321050f"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PALESTINA" },
                    { new Guid("b7878d26-aba9-49ab-895b-6e8fc7878d0b"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CEDRO" },
                    { new Guid("b79bbeb4-c05b-4976-a382-ec043f9dec4a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTANA DO JACARE" },
                    { new Guid("b7d1f712-687c-4fa4-a926-91fba5459b1b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SERRANOS" },
                    { new Guid("b7d65451-d2ae-4239-805e-2a6bab3674e6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RESPLENDOR" },
                    { new Guid("b7d85b18-70a9-4df5-aac7-af3dd7dd8a3d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "IBICUITINGA" },
                    { new Guid("b7ffda1a-e40b-49b2-be1f-656bc0f30fc8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARACAI" },
                    { new Guid("b823425d-3dce-4d55-a997-bd483beea516"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "RODRIGUES ALVES" },
                    { new Guid("b8371274-119e-46d7-82e6-0735be5efccd"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CRISOLITA" },
                    { new Guid("b85c9df6-00ae-444b-b9c4-b72b6b354e7b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MUTUNOPOLIS" },
                    { new Guid("b8bfe8f1-23e8-4e25-aba3-7c9f650eb199"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BARRA LONGA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("b8e2af22-90c1-4c93-86fe-136cd97f9198"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CATAGUASES" },
                    { new Guid("b92c1004-2edb-4489-8523-285daf2b0cdb"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBIASSUCE" },
                    { new Guid("b953659f-ff97-4007-8ab0-32014cbfc5a7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTANA DE CATAGUASES" },
                    { new Guid("b954f257-7d57-4978-ae87-bfa2f109acd4"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "DAMOLANDIA" },
                    { new Guid("b976ef16-dbc7-4b59-bf2e-d6b1e5808a4f"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SAO JOSE DA LAJE" },
                    { new Guid("b99828c0-a6c3-4ec7-bdbf-f8e291dbe645"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "TRAIPU" },
                    { new Guid("b9a91eef-0a95-4e71-8b30-4aa2a87c8ac9"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MATA ROMA" },
                    { new Guid("b9eb203c-4887-407e-9101-0ff65f4edd92"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTANA DO MANHUACU" },
                    { new Guid("ba02d58d-69f8-495b-89fc-6ff235a01feb"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IPECAETA" },
                    { new Guid("ba149995-633b-4839-967c-0f2806518e09"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GONZAGA" },
                    { new Guid("ba250b46-40d6-45a1-84f2-9996db022947"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ARATUBA" },
                    { new Guid("ba2d11fe-18e9-4961-8cce-cee0205488cc"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "IVOLANDIA" },
                    { new Guid("ba3e88ad-ace6-4280-a40d-331d93e5c166"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTANA DO PARAISO" },
                    { new Guid("ba625f21-5974-4db4-a6d6-8e6036662598"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ISRAELANDIA" },
                    { new Guid("ba7c1035-360c-4fb3-abd8-0c2dace02779"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SETE LAGOAS" },
                    { new Guid("ba87bb43-ccce-4eae-94e3-9b9657d6fe45"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUARDA-MOR" },
                    { new Guid("ba9bfdf1-c926-4cc9-850c-32bb1a3d28db"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JEREMOABO" },
                    { new Guid("bab861c3-35eb-4a87-b893-c77795987ab4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAPINOPOLIS" },
                    { new Guid("bac09813-181a-4350-9101-c2d8a70299bf"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTO AMARO" },
                    { new Guid("bac654da-a9fe-41d2-85cb-8e2445930428"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PIRAPETINGA" },
                    { new Guid("bac84c91-ee73-41cf-95de-fd159d2679f1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TUPACIGUARA" },
                    { new Guid("bad883a6-5e4d-4250-8e7b-88efc711a058"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NOVA CANAA" },
                    { new Guid("bada462d-1864-4414-93b0-cf14991509e6"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "IBATEGUARA" },
                    { new Guid("baf27581-239f-41c3-9ea2-7d31ed2b5ef3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO ROMAO" },
                    { new Guid("bb26b6e2-c25f-4d46-8ea7-b9e2328d71c1"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBIRATAIA" },
                    { new Guid("bb314b65-40aa-40b0-9666-cd71d31cbbfa"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CURURUPU" },
                    { new Guid("bb32db35-ba2a-443a-84f1-d76dba621e85"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITACAMBIRA" },
                    { new Guid("bb341ccf-6f4a-495c-9744-ace13d90a6ad"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PASSAGEM FRANCA" },
                    { new Guid("bb53be44-8478-43d9-9eaf-51f4abf8f151"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SABOEIRO" },
                    { new Guid("bb5b49d3-2da4-4414-8a01-4e497b0c2947"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "INHAPIM" },
                    { new Guid("bb74463a-ca4d-484d-9dc8-d99ce7dcda19"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "QUIXADA" },
                    { new Guid("bb74dfc7-eb40-422b-9654-cfdacdca46b0"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CARDEAL DA SILVA" },
                    { new Guid("bb941fe1-0dfa-48a5-923a-5ff4264f294c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOM JESUS DO AMPARO" },
                    { new Guid("bbd32ba8-4b35-40ea-8030-af56bb3b27b1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JORDANIA" },
                    { new Guid("bbd498c8-9b24-4ce9-a4e8-9fb25612ab2f"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "UMARI" },
                    { new Guid("bc071dfc-37c8-445b-8297-72a2c7e72f25"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MORTUGABA" },
                    { new Guid("bc0c95e3-2e1c-47bd-a04d-5e648932c0b3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CLAUDIO" },
                    { new Guid("bc185ce0-34e4-4247-80a8-fbaba8ba62b2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MEDINA" },
                    { new Guid("bc613b89-6373-4021-ac6a-6195cc9060c1"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ARACRUZ" },
                    { new Guid("bc6742cb-67b0-47be-ad79-23ca4ad2cc0d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SEBASTIAO LARANJEIRAS" },
                    { new Guid("bc715c30-5a8d-44fe-930c-5ad1dcfbad67"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BARRO PRETO" },
                    { new Guid("bc80f6aa-f2cd-407c-977e-b1a8c7dc65a7"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "AVELINOPOLIS" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("bc842689-1c8e-4d09-8da0-09ac5b16bd14"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "OLIVEIRA FORTES" },
                    { new Guid("bc9028b6-696b-4c32-ac04-e7d685f2aef9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "APUAREMA" },
                    { new Guid("bcd3537f-3fef-4e67-9957-e0b52441f502"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "ITAMARATI" },
                    { new Guid("bcee8718-6705-4225-aeff-987642ce293a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ROMARIA" },
                    { new Guid("bd021f2a-a52b-49ea-a18e-a5e4cc02c074"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BARRA DA ESTIVA" },
                    { new Guid("bd0dc381-7730-496f-a228-b68b53057861"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTA BRIGIDA" },
                    { new Guid("bd22a55a-0106-481d-93d0-089761fc465b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PRADO" },
                    { new Guid("bd3c3d15-3a14-4676-b040-6eb090cf0d69"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "OLHO D AGUA DO CASADO" },
                    { new Guid("bd520172-3ed6-497c-b804-03fdb90feb75"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JEQUITIBA" },
                    { new Guid("bd5e4df8-6faf-4e07-990c-10d21b76a5e2"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "AMARANTE DO MARANHAO" },
                    { new Guid("bd61d676-6677-4170-98ce-8c4e85afe4e8"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ITAGUACU" },
                    { new Guid("bd719130-d9b0-4a56-a495-384b8749637f"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "JUSSARA" },
                    { new Guid("bd7fd983-df1d-43de-819c-5e151b1e2afa"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "VARJOTA" },
                    { new Guid("bd86b60b-c7dd-4c3d-8335-62581317271b"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PASSO DE CAMARAGIBE" },
                    { new Guid("bd92ca2e-13f9-49ff-a388-0baa92defd55"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAPUCAI-MIRIM" },
                    { new Guid("bdee4772-57ae-4503-8aba-06cb2f104de7"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PIACABUCU" },
                    { new Guid("bdf562d3-445e-4ed8-af5e-ed8f44676e1d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SAO BENEDITO" },
                    { new Guid("bdf8c3b5-851e-4402-b438-cca41ffe71d9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOM JESUS DA PENHA" },
                    { new Guid("be0b81fc-964b-4b80-8db4-571a362945a3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LONTRA" },
                    { new Guid("be249999-b16d-4719-8b9c-5b851287daa8"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO MATEUS DO MARANHAO" },
                    { new Guid("be7b3be3-bf9a-42b8-8a8a-a3f5a892c207"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PAULO AFONSO" },
                    { new Guid("be9f46fd-4124-4dc3-a07d-9ba31e83bbe6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO PEDRO DA UNIAO" },
                    { new Guid("becd6769-a19e-45b0-abfb-7d7bf36367d0"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "AMPARO DO SERRA" },
                    { new Guid("bed19cd7-542b-4dae-8c63-b7d8c4473cc9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FORTALEZA DE MINAS" },
                    { new Guid("bf0f2f9c-eb68-4bf9-a202-09e3c62aa522"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "POMPEU" },
                    { new Guid("bf3a8afb-38b6-41df-94c8-ffdac046c8c2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BONINAL" },
                    { new Guid("bf4f92c6-5c32-496d-9943-c5f6ff7783c7"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAETANOS" },
                    { new Guid("bf6f0c60-6328-4da2-9ba5-0a05e280075a"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "BARCELOS" },
                    { new Guid("bf6faaeb-3aac-4fa3-80f8-9f068c0e9a53"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PEDREIRAS" },
                    { new Guid("bf705b4f-6a34-4215-b4cd-b228ae8f0dd2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TOMBOS" },
                    { new Guid("bfe2c860-7a78-4540-9e72-1b37ce594c4d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TIROS" },
                    { new Guid("bff4f884-8a0b-49e0-9f29-2d69dc03cc04"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CANSANCAO" },
                    { new Guid("bffdbabb-2a13-42ff-b8dd-130ebed241ba"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO BERNARDO" },
                    { new Guid("c010fdec-5d87-4994-a11c-135b015dc6cd"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PEROLANDIA" },
                    { new Guid("c0409e2b-8054-4624-b52c-6dee0066c862"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MARZAGAO" },
                    { new Guid("c05f4bdd-d5bc-4756-8251-7804a67847d8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTA MARIA DA VITORIA" },
                    { new Guid("c05f68ff-eb6a-422b-8045-ba6be08234e2"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CIDELANDIA" },
                    { new Guid("c082cdb3-323c-47c7-8b40-8e1969d4abcd"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PRATAPOLIS" },
                    { new Guid("c0a86d05-a49f-4f94-9c56-9ecd2c9b0c35"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RAUL SOARES" },
                    { new Guid("c0cdce6f-c5b9-4cb8-88bb-df1d4dc5205c"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ALEGRE" },
                    { new Guid("c0d9081c-cd27-46d1-8ec8-90551fade02d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUANHAES" },
                    { new Guid("c0ebd97f-1259-4be4-a8d0-6fde2aa92dfa"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MESQUITA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("c1254c07-8ac9-4b76-b3b3-79fd0196374d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DELFINOPOLIS" },
                    { new Guid("c1402f60-9fb6-4af5-9d93-8b8505ac884e"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "MONTANHA" },
                    { new Guid("c14d00e2-71fe-407f-a893-d4492ba45611"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "CRUZEIRO DO SUL" },
                    { new Guid("c151a79c-f60e-4717-9c32-8100db53c629"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARAUJOS" },
                    { new Guid("c155e6ad-0919-4a0e-aa25-4b9cd4f4188a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CATAS ALTAS" },
                    { new Guid("c19fd72e-e740-4287-95ba-27c2eb06115c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MONCAO" },
                    { new Guid("c1b54ce5-9ddf-4519-8a3c-5d10d2ebf905"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "RIO QUENTE" },
                    { new Guid("c1e37aff-2602-4e8e-91e0-58a83ae9e428"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA CRUZ DO ESCALVADO" },
                    { new Guid("c226aa54-716a-4da7-96ce-76aebe1e8992"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAPE" },
                    { new Guid("c23f69e1-5b47-4dd1-9735-d801442b786a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CRISOPOLIS" },
                    { new Guid("c2b3fd0a-56b7-4397-adac-c0ca538bd42f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CRISTAIS" },
                    { new Guid("c2cf5f85-1ddb-424d-a581-0f38d58ff254"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MATIAS BARBOSA" },
                    { new Guid("c2fa3f0e-d74b-405e-baac-0ea27516fc5b"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SANTANA DO MUNDAU" },
                    { new Guid("c31f207d-7d6b-4416-9754-14035d0b96ac"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "TURVANIA" },
                    { new Guid("c337f614-ec08-476d-8c6b-0b0d7eefc0ce"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DOM SILVERIO" },
                    { new Guid("c34e2817-cb63-48b3-996d-510ca59d7dee"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "EPITACIOLANDIA" },
                    { new Guid("c3ad1f40-849f-45df-a070-2466ef5dec38"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MAR VERMELHO" },
                    { new Guid("c3b3db4f-789d-463f-9ad3-84b0395f3b27"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BRASILANDIA DE MINAS" },
                    { new Guid("c3c4677a-c9e0-46ce-b2c8-9ba6dec7fd01"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "UBATA" },
                    { new Guid("c3e8bd65-690c-4199-a2f4-0aa85e8ce8ec"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BANDEIRA DO SUL" },
                    { new Guid("c412b7f1-0baa-4d7c-bbf8-683f069a0417"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "VIANA" },
                    { new Guid("c4206b65-3dd1-491a-8914-a8390f8d4d4d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DIVISA ALEGRE" },
                    { new Guid("c4390f96-2665-4aa4-9a89-b2cafa436b69"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "VILA PROPICIO" },
                    { new Guid("c4470540-1d1d-4398-a350-b1d3303e0778"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAPEACU" },
                    { new Guid("c4577992-6070-4fa6-8f73-a602f1e42aff"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SITIO DO QUINTO" },
                    { new Guid("c46af2ab-96ee-4f3e-b9eb-4444a7ebec95"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "JAPARATINGA" },
                    { new Guid("c46afa79-9146-4619-ad4a-b1bbdd0cb5aa"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PARA DE MINAS" },
                    { new Guid("c48d5416-8867-47d3-a6d2-e8497230c520"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO CASCA" },
                    { new Guid("c4abe775-028d-4de3-8b36-bb7cf3da7fcd"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEDRA DO ANTA" },
                    { new Guid("c4dfbc29-224c-49f9-b3d4-ee7ee3209779"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ENGENHEIRO NAVARRO" },
                    { new Guid("c4e61ce4-6fc3-474b-88c5-d96867670c2c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CASCALHO RICO" },
                    { new Guid("c4faac63-f338-45e0-9afe-5ed7553ba298"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VARZEA DA PALMA" },
                    { new Guid("c507af75-1217-4379-b1a0-ab6e6f86c5f8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PRESIDENTE JANIO QUADROS" },
                    { new Guid("c529ae06-47ee-4f6e-87c0-140559d106c0"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "TANQUE D ARCA" },
                    { new Guid("c5620dbb-7eee-45af-8112-3822b9ebd587"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO DO PRADO" },
                    { new Guid("c5705d4c-044c-44c8-9e24-f88407c1085d"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "MIMOSO DO SUL" },
                    { new Guid("c5806340-5d8c-47da-bdf6-8d41d16fbb39"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CANDEIAS" },
                    { new Guid("c58204d9-27e4-4f40-8539-3eaa97e8cf09"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALPINOPOLIS" },
                    { new Guid("c5950021-9b32-4447-8221-16df803a6c62"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ACARAU" },
                    { new Guid("c5b63178-3249-4153-9947-931eb13e4fa4"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTA RITA DO NOVO DESTINO" },
                    { new Guid("c5d18285-793c-4892-bb1d-2831652c2420"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO GONCALO DO RIO ABAIXO" },
                    { new Guid("c692c4c5-fda7-46e6-9f10-59e41228e7e4"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CONDE" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("c6ad8ee8-16be-4edb-989f-db2b2b3eba33"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FORMOSO" },
                    { new Guid("c6cd43f1-9093-4d43-a41f-c17c13555744"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ESPERANTINOPOLIS" },
                    { new Guid("c6e2ddf2-8473-4e55-9085-c04c8082fbc1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO SEBASTIAO DA VARGEM ALEGRE" },
                    { new Guid("c6ebdbe4-fafc-4b14-b6fb-468e07c1d344"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PIRANHAS" },
                    { new Guid("c704ac0b-ab1e-4dfe-a32b-c0ca3885f13e"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SAO FRANCISCO DE GOIAS" },
                    { new Guid("c723dbef-c61e-4fe1-b432-902dfda32969"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARATINGA" },
                    { new Guid("c752dff3-b2b3-4457-b7d0-7f7bf982c45d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CANINDE" },
                    { new Guid("c75414c9-b105-456f-977a-598572e64f9f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITUTINGA" },
                    { new Guid("c78e2fd5-a71c-4922-a99f-9a6c68f79b66"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PARAMBU" },
                    { new Guid("c7949f15-e4e2-4cd5-98d8-b6df46361b0c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "UNIAO DE MINAS" },
                    { new Guid("c808295b-22d3-43cd-8f61-80c0512b4c53"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NOVO PLANALTO" },
                    { new Guid("c808f32c-02a1-48a7-8645-c9bb2509c918"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CAMACARI" },
                    { new Guid("c81a8f6e-b2b8-4c6d-bf70-b0c639e68d4e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMPO AZUL" },
                    { new Guid("c843c07f-7d4d-4fb7-af0e-da2ca1d2cbe2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MASCOTE" },
                    { new Guid("c8537c7d-426d-4456-a6ce-c626c78d672d"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MARA ROSA" },
                    { new Guid("c85acc14-5f7d-488e-b042-b1194a5c0d2f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ARACI" },
                    { new Guid("c8682bcb-367c-47bf-87af-89a32ba7e399"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TIMOTEO" },
                    { new Guid("c885063f-97d4-48ad-aefc-9caf93bc05f4"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PRESIDENTE MEDICI" },
                    { new Guid("c8af119e-8f4b-4c8f-9a1d-63b67f9704dd"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PALMOPOLIS" },
                    { new Guid("c8d60279-bac8-452d-a467-1d3bfe175fd6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA BARBARA" },
                    { new Guid("c932b5a7-c6e9-4004-a80a-802b3e0f52f8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ARAMARI" },
                    { new Guid("c94bae3d-53a7-409e-92fc-3724629e0e6b"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "NINA RODRIGUES" },
                    { new Guid("c94f7e7a-835d-4760-9a52-811a4c7591f3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GURINHATA" },
                    { new Guid("c95430b6-930b-43cf-9d80-5faec2849ce7"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SAO MIGUEL DO PASSA QUATRO" },
                    { new Guid("c983a68d-c6cd-495c-85ff-f6969888d9ca"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ARARIPE" },
                    { new Guid("c9a7e0c2-f27a-49b5-bb2f-58df083e8a70"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "GOVERNADOR ARCHER" },
                    { new Guid("c9a9d2d1-7eb0-4347-90c2-3d17ccb0b813"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PENTECOSTE" },
                    { new Guid("c9bb4e34-55b1-44bc-8561-3bbec4f6fc4c"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ARACATI" },
                    { new Guid("ca31f52e-e421-4d75-986a-721f6449f3a6"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SANTA LUZIA DO PARUA" },
                    { new Guid("ca342b83-d928-42f4-942b-0c94a49b96c4"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "GRANJEIRO" },
                    { new Guid("ca3fdc42-52b3-425a-be0c-43dbfb2f56ad"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "GOVERNADOR EDISON LOBAO" },
                    { new Guid("ca503472-607b-4a4d-988f-793f46f0e05c"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "BEBERIBE" },
                    { new Guid("ca696571-f21c-452d-bb36-c5de3338c6e6"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "JIJOCA DE JERICOACOARA" },
                    { new Guid("ca750edb-aed0-4eb8-a0cf-92777bb25073"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "CAJUEIRO" },
                    { new Guid("ca783c03-525b-4054-9d02-c14c98dc15d3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CACULE" },
                    { new Guid("ca8f426b-33a2-4f66-9128-7e5f9bdd7eb3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CRAVOLANDIA" },
                    { new Guid("ca91932b-750a-4a93-8781-c47ecfc29ec7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DESTERRO DE ENTRE RIOS" },
                    { new Guid("caa7ec75-92ab-467d-9211-5ed922bcf9ef"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ITAPURANGA" },
                    { new Guid("caad9404-2273-4fa0-b35e-423f663d4533"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALFREDO VASCONCELOS" },
                    { new Guid("cac9448b-0534-4e12-9ad3-19834035f457"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PALMINOPOLIS" },
                    { new Guid("cadb3e43-b167-491e-b7d6-251fa7414865"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MATO VERDE" },
                    { new Guid("cb45d41b-654d-4f35-8cdc-3fccf0e7ce8e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CAMPOS SALES" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("cb809c09-4f1b-4226-8059-2bb43e4ca2ff"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTA CRUZ DE GOIAS" },
                    { new Guid("cba7e2cb-effc-41d5-893a-dda89aafc6d7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOA ESPERANCA" },
                    { new Guid("cbb357cb-a0bc-45eb-aefd-b52d5a5556a9"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SANTANA DO CARIRI" },
                    { new Guid("cbdddee9-78b6-42ce-b7f4-ab72dd693e5d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DURANDE" },
                    { new Guid("cbe29d8f-ae5f-4dde-9f0e-cd2b523b4254"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "RUSSAS" },
                    { new Guid("cbf024fd-396a-43c3-aabc-133f08182e28"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "MANICORE" },
                    { new Guid("cc395557-1a6b-4e21-a096-b08fe4c60463"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MUCUGE" },
                    { new Guid("cc7d3ccd-a637-4fc7-bb69-e91e9d0d922b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BARRA" },
                    { new Guid("cc81972f-c352-4927-81c7-87e28cec8141"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PESCADOR" },
                    { new Guid("cca49122-8950-427e-8402-942d70c2425b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMPOS GERAIS" },
                    { new Guid("cca60511-808e-499c-8ede-98ac9bfe6418"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "TAPAUA" },
                    { new Guid("ccc6c5a4-4ed4-4dd2-84c3-8182e9ec4715"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VARJAO DE MINAS" },
                    { new Guid("ccd5c8a0-524d-4776-8954-baa910e3b398"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "POCRANE" },
                    { new Guid("cce0baa6-1297-4f39-922c-a81e7362e775"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PATROCINIO" },
                    { new Guid("ccf6aebd-3bcc-4d2f-9b3d-2ab54e5fd318"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MINEIROS" },
                    { new Guid("cd3ceacf-0890-456c-a786-93dedf38710e"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "JATOBA" },
                    { new Guid("cd3e434e-b04a-4315-8411-a5c2e00f6c08"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "TEOTONIO VILELA" },
                    { new Guid("cd56eb36-949e-463d-a85f-ca430908d7f9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAJU DO COLONIA" },
                    { new Guid("cdb4ca18-4a86-4ddc-b823-6d94520d5157"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BELO ORIENTE" },
                    { new Guid("cdb512c8-3a05-4328-9dc6-7920ec6108e0"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "PORTO GRANDE" },
                    { new Guid("cdcf694a-ca8a-4d97-82ec-72b55e37f0bc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IPANEMA" },
                    { new Guid("cddd5904-ffdc-4867-93a8-e7f9db78fedf"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "AGUA LIMPA" },
                    { new Guid("cdfc9e9d-7d69-494d-85db-746435946882"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MATA DE SAO JOAO" },
                    { new Guid("cdfdf634-4382-4934-a88a-5c39135e0904"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SENADOR AMARAL" },
                    { new Guid("ce070032-03bf-417e-8778-5ab3729a744e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CASCAVEL" },
                    { new Guid("ce0d3c7f-fd19-4bc6-8778-8f11b613dc26"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "OLHO D AGUA DAS FLORES" },
                    { new Guid("ce2b5a9e-2fca-4bee-99af-cb17fe06a003"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "TABATINGA" },
                    { new Guid("ce2fe743-f829-4a18-9353-eef3ebf5e789"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ICATU" },
                    { new Guid("ce4cd8ff-dacd-4e99-b685-207057d83437"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "RIACHAO" },
                    { new Guid("ce579cf5-39e9-478a-983a-b383be8e4710"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IGAPORA" },
                    { new Guid("ce7bde9a-f903-468f-8b13-45d4a653f171"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARICANDUVA" },
                    { new Guid("ce9f1725-7176-4009-a9d7-be15a8844dd0"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ABARE" },
                    { new Guid("ceb02cbd-db51-4521-8abf-4d81f8630e7c"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BRITANIA" },
                    { new Guid("cecd4060-c621-4e1c-8ae7-b4c4f2ff2d63"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAGI" },
                    { new Guid("ced02619-fc2e-4c49-b404-f40e8b736732"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MARAJA DO SENA" },
                    { new Guid("cef98d3c-801c-456e-9ac7-e0a04134effc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DORES DO INDAIA" },
                    { new Guid("cf147024-7e21-46fc-93e5-bf65baa70ad0"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "INDIANOPOLIS" },
                    { new Guid("cf448925-4b69-47ac-a452-714090063e88"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IPUIUNA" },
                    { new Guid("cfa0afef-62d9-45f1-973e-85544675ca42"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RITAPOLIS" },
                    { new Guid("cfc71ebc-1a13-47d9-926f-03be5fd865ac"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "VITORIA DO JARI" },
                    { new Guid("cfe70a16-baf4-482b-ac43-db1346243016"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CAMPOS VERDES" },
                    { new Guid("cff2ba9b-e951-42ab-a526-63de6edfc87d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PIQUET CARNEIRO" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("d0056885-a55f-43fe-aa6f-2ca88ae1abbd"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "OLHO D AGUA GRANDE" },
                    { new Guid("d0063b0e-3ece-40be-a40d-137dbf5ee93c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "WAGNER" },
                    { new Guid("d03d5436-8e7c-48d5-8600-e35de7ae1fb2"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CODO" },
                    { new Guid("d03fb534-5c41-4839-aaf7-a6220b23b94d"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ABADIANIA" },
                    { new Guid("d046ab42-d058-4667-8c53-d045cbeb9a6b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CUPARAQUE" },
                    { new Guid("d04bb969-3fe2-4409-941b-b6a0dc6019f0"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BONITO" },
                    { new Guid("d04e1797-80ec-4d68-b6b4-fc40da487c57"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "URUACU" },
                    { new Guid("d0550081-9eb3-4b0c-9b98-23f5d6b319eb"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MANSIDAO" },
                    { new Guid("d0a8b1ed-d598-4829-ba2d-5b91ee0a7f38"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ITAGUARU" },
                    { new Guid("d0ab3f78-afc9-44cd-aada-cbd46322852a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTA INES" },
                    { new Guid("d0b3ea91-e493-4cd8-9a66-72067a799758"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUAXUPE" },
                    { new Guid("d0ee9261-497b-43c8-baab-f0dace8dbdc5"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MATOES DO NORTE" },
                    { new Guid("d12c2c21-9311-4a80-bb9b-bdd649eccc3e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CACHOEIRA" },
                    { new Guid("d16ac77d-3320-4d9a-b58c-e04fdd010b89"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "ROTEIRO" },
                    { new Guid("d186a1da-6c1e-4982-b124-60b8c90cf806"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO BENTO ABADE" },
                    { new Guid("d194e1d3-ff6d-4195-81d3-783e81c00b66"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SERITINGA" },
                    { new Guid("d1c139aa-b725-42fd-9c6a-7c98f42a4b57"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SAO MIGUEL DOS CAMPOS" },
                    { new Guid("d1e6ab1b-70af-4b9f-ac37-b45d10439b3b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIACHINHO" },
                    { new Guid("d1e9957a-6060-437e-b6d1-a0b8ae88c93a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SERRA DO SALITRE" },
                    { new Guid("d20a211e-9e37-4f00-ae57-bbd6f37e9a95"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SUCUPIRA DO NORTE" },
                    { new Guid("d2155086-f1b3-494a-a813-6eade37982e3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JUSSARA" },
                    { new Guid("d2367a71-e12d-4df2-a7ab-e59a44b464bb"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "HUMAITA" },
                    { new Guid("d23fc1b9-3311-40db-844f-913ff678f35c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BARRA DO CHOCA" },
                    { new Guid("d25721c6-72cd-4d34-b5a3-1c61f8d6ead7"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "BREJETUBA" },
                    { new Guid("d27a9d9b-ac66-45ff-af82-38ceb725290e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IPIAU" },
                    { new Guid("d2aab07b-1338-4c2e-8ab9-07224d0db003"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LUISLANDIA" },
                    { new Guid("d2b83e22-5e3a-461c-94fa-6bfac88193df"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA JULIANA" },
                    { new Guid("d2c544b0-16f6-4578-ae0f-53f253261c61"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MILAGRES" },
                    { new Guid("d2de3779-19c1-47cb-8e0b-aeb148c0a8b8"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "TRAIRI" },
                    { new Guid("d2de3be0-2200-41fc-ae55-c4824a268b38"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ESPERA FELIZ" },
                    { new Guid("d306edd9-7f0a-4fb0-8c29-e8ed61a8195f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BARRO ALTO" },
                    { new Guid("d3b8ca90-323d-466c-8cb2-969ce740b478"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "CAPIXABA" },
                    { new Guid("d3e52650-7ed8-43ca-b989-106fb1ede6d4"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NILO PECANHA" },
                    { new Guid("d3f0357e-7bc4-4a57-bf78-773fcd00f903"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "CAAPIRANGA" },
                    { new Guid("d3f412de-c10f-41b7-864f-eac75c7684d4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "REDUTO" },
                    { new Guid("d3fa25c6-d00b-43e1-accc-dfc37e81b8dd"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "ENVIRA" },
                    { new Guid("d40b9e31-a41b-45ee-b5e9-a338336e1995"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO TIAGO" },
                    { new Guid("d410b4f1-d0e1-4c25-a368-a9f0ec2ce58b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MUTUM" },
                    { new Guid("d420911e-c5ab-4ae1-b245-d2487b08d246"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "GOVERNADOR MANGABEIRA" },
                    { new Guid("d4333b0c-074e-4f71-80b3-cfc6e6633ec8"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "BANABUIU" },
                    { new Guid("d44b5dda-17fc-43eb-8fe2-26f4cb09f103"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "AMORINOPOLIS" },
                    { new Guid("d463af99-5d77-46cf-a706-ff2904219e40"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "BOCA DA MATA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("d46fe97d-6d2e-438c-abe3-102891b843e1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VARGEM BONITA" },
                    { new Guid("d47ec0c9-b5b1-4380-9947-a6ac7da53d73"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ITABERAI" },
                    { new Guid("d484de6f-4cdc-4292-9968-2dd576278ecf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA BARBARA DO TUGURIO" },
                    { new Guid("d4a2039e-f577-469f-8967-f836f8afa97e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DESCOBERTO" },
                    { new Guid("d4d675fb-6126-4ac8-9988-9ad42aca92ee"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CATUTI" },
                    { new Guid("d4e58126-eba0-4271-a518-4a1397050ce5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JECEABA" },
                    { new Guid("d50cd478-90fa-42d8-8be5-7d219f0ca84e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CABACEIRAS DO PARAGUACU" },
                    { new Guid("d519fd5e-7205-4253-8d8f-13aec00b6ec3"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "SENADOR GUIOMARD" },
                    { new Guid("d522c570-b925-40cc-9530-7fdf8bb6cf63"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO NEPOMUCENO" },
                    { new Guid("d527e14e-ead1-47d3-ac45-0af2f8e3e641"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA FE DE MINAS" },
                    { new Guid("d52a721b-b0f4-4323-9294-1bf02194fef7"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO LUIS GONZAGA DO MARANHAO" },
                    { new Guid("d539926d-44c5-472e-85e3-ab22db1d6a79"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "RIANAPOLIS" },
                    { new Guid("d53ef8a8-faba-4219-8928-37cb06a7cef2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SEM-PEIXE" },
                    { new Guid("d579f9da-fede-48b9-9e73-d6bdfe4d2332"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SANTANA DO IPANEMA" },
                    { new Guid("d5875a31-cd3c-4283-885d-5ae83755d42f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NANUQUE" },
                    { new Guid("d598ff0a-b464-4baf-ab03-b47750bbd66d"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "PAUINI" },
                    { new Guid("d5abc90d-f696-420c-aa0e-57922a376065"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "APARECIDA DO RIO DOCE" },
                    { new Guid("d5aded5d-9aa5-4940-a020-4b9696daf02a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SOUTO SOARES" },
                    { new Guid("d60295f6-8b66-4317-8d8c-f2b92bb1bcc1"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTA BARBARA DE GOIAS" },
                    { new Guid("d613b247-115c-4600-84f0-dceadd299348"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JAMPRUCA" },
                    { new Guid("d65a50be-1994-4b91-8631-2af82ef277bb"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "REDENCAO" },
                    { new Guid("d6be7722-f84c-473d-8d46-ff0ed0ab65fd"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO JOAO BATISTA" },
                    { new Guid("d6cac080-cc87-4228-9f32-a576e4aad1f8"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "MUCURICI" },
                    { new Guid("d6d8e1ba-2605-4b22-a34f-16efa1bab5ca"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PITANGUI" },
                    { new Guid("d6ea8d30-e7dc-4c4c-af08-31d3139aaf59"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "VICOSA" },
                    { new Guid("d704b1d5-760e-4675-990e-d535bb3cd6ac"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "CAMPO ALEGRE" },
                    { new Guid("d7069b6e-88e4-4f1a-b991-e48003078abe"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "CONCEICAO DO CASTELO" },
                    { new Guid("d70b007d-8169-4cc4-9b8a-363be36e17ce"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTO HIPOLITO" },
                    { new Guid("d745b8b3-b439-4235-a2b8-c54f9442cb91"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "NOVA OLINDA DO MARANHAO" },
                    { new Guid("d7488d6e-f75f-478f-a8fd-67be333f403e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "UBERABA" },
                    { new Guid("d762ca23-03cd-4351-a3b1-1f6aab823e84"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ALVORADA DO NORTE" },
                    { new Guid("d7868e3e-016c-40f6-aa74-62eace70db8f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FRUTAL" },
                    { new Guid("d789e0e1-6f87-4549-9e46-bf0d82bbf95a"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SANTA QUITERIA" },
                    { new Guid("d7c34875-9732-403c-82fa-05d9e5268980"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "IPIACU" },
                    { new Guid("d7ccf8d8-2e1a-403c-8f17-96e0e99bafd8"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "POCAO DE PEDRAS" },
                    { new Guid("d7d0c1fd-dfe6-4bf1-9dd1-e1b9b3bc2b88"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PALHANO" },
                    { new Guid("d7ecd922-7900-4e2d-a047-5c178e663ed6"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "BOA VISTA DO RAMOS" },
                    { new Guid("d8186ff9-1f01-477d-8a22-9a926859c02b"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "JUCAS" },
                    { new Guid("d8220458-0a60-44c1-b7a5-a8a411a87353"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ABAETE" },
                    { new Guid("d8830583-8a1a-42c9-8af0-c7348029a652"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SANTANA DO MARANHAO" },
                    { new Guid("d90464a5-3eff-4816-b7c9-3a3f9d453cb9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DORES DE CAMPOS" },
                    { new Guid("d91290bb-06a6-49f3-9db0-45288971bc2d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MORPARA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("d91b0712-3d88-425a-884e-529cbc29eaad"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "AMARALINA" },
                    { new Guid("d95a4149-162c-4cf8-9f82-cfcd1cdcf90f"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "GUIMARAES" },
                    { new Guid("d9633773-2d7f-419c-af8a-8d90dbe49c42"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAPICURU" },
                    { new Guid("d980da3a-1bc7-4306-860b-8bdf2fe25cac"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTO ANTONIO DO MONTE" },
                    { new Guid("d9b0f54a-7345-4c70-b47b-d164ef19ebb7"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "ITAUBAL" },
                    { new Guid("d9bf2308-9c3d-4304-af17-573e6ed82732"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BARAO DE COCAIS" },
                    { new Guid("d9e3e2ce-f86e-4bdf-90a3-5dd2bd0ab5f6"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SAO SIMAO" },
                    { new Guid("d9fe969f-f8f8-4528-bac1-47dcd1d43cc4"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "IBIAPINA" },
                    { new Guid("d9fff66e-ea4f-4737-9899-a138885f7a5f"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SANTO AMARO DO MARANHAO" },
                    { new Guid("da257c2a-4ba7-4999-9d81-4af0777f14df"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RIBEIRAO DO LARGO" },
                    { new Guid("da322844-7df9-47da-bd9f-28a809c1e0ca"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "APORE" },
                    { new Guid("da40cf1b-b743-43d0-9a7d-fcd93dab9a21"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ESPLANADA" },
                    { new Guid("da4361c0-7828-4741-a0b3-0bc275f36f58"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FORTUNA DE MINAS" },
                    { new Guid("da4b5697-a68d-4911-8ab6-e2a769a4c5db"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MIRADOURO" },
                    { new Guid("db097bc1-45fa-46f1-b0b0-7b67b76de385"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "OLIVENCA" },
                    { new Guid("db30dae4-df1b-403b-9c93-372aee66015d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "UIBAI" },
                    { new Guid("db3b2ae4-89c2-4d32-babd-8b6bf411d29b"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "GENERAL SAMPAIO" },
                    { new Guid("db4633f8-40a3-41a1-b928-6107930f3d21"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONTE CARMELO" },
                    { new Guid("db6c8590-5c9e-4446-8517-f3c3487ccdd2"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "BOA VIAGEM" },
                    { new Guid("dbe5606c-ac02-4381-a9a4-6169d183e629"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "PRACUUBA" },
                    { new Guid("dbf80e2b-cce8-4160-9417-371c9f1de7d2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOSE DA BARRA" },
                    { new Guid("dbffcc93-aa2a-4444-b52b-eec379b86984"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "UMIRIM" },
                    { new Guid("dc1230bf-aca8-4984-ba17-7a098befe835"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ABRE CAMPO" },
                    { new Guid("dc22cb2e-4e2c-4b1b-ab69-86716b4c2191"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "QUARTEL GERAL" },
                    { new Guid("dc510ebe-541a-46dd-9e55-e7025e8c35ee"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RODEIRO" },
                    { new Guid("dc849825-d9e3-407f-99f2-cd334a081c87"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BIAS FORTES" },
                    { new Guid("dcf03269-00cd-4fc4-b4ab-ad33320ef151"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTO ANTONIO DO JACINTO" },
                    { new Guid("dcfae23c-50a2-4c08-ae7f-43f6c61366a2"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "VENDA NOVA DO IMIGRANTE" },
                    { new Guid("dcfb41c2-6305-4283-9909-7b02f05cf9d2"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SERRANOPOLIS" },
                    { new Guid("dcfe4917-ed5c-4305-a59d-bf9d50a33289"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "NHAMUNDA" },
                    { new Guid("dd0231c4-4848-4e30-9193-24032b7a42ac"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ESTRELA DO NORTE" },
                    { new Guid("dd68a8ef-bdfd-4481-9619-b04867741711"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "COROMANDEL" },
                    { new Guid("dd6976bb-36bc-4384-875a-563c1aa3c218"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MACHADO" },
                    { new Guid("dde97e54-c14a-4a89-af5c-14b1ca66f5a9"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "BRANQUINHA" },
                    { new Guid("ddeaa54d-7170-4803-a8c5-e48a6c8a6e1b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "VIRGOLANDIA" },
                    { new Guid("de0684d4-829d-4d2e-9edc-595dfdf4dc65"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CORONEL JOAO SA" },
                    { new Guid("de42a32d-78c4-44b5-ace4-7d3dc37bd762"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PONTALINA" },
                    { new Guid("de552092-5cc3-4396-b2f0-cce1c42b2038"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IBITIARA" },
                    { new Guid("de5a9b7d-a27d-4c27-b4fd-704502472920"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ENTRE RIOS" },
                    { new Guid("de8c7003-5f0a-44bf-889b-a6be3a86b0bd"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MIMOSO DE GOIAS" },
                    { new Guid("dee85521-4b13-4a6f-ab5d-0a5933764e6d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LAURO DE FREITAS" },
                    { new Guid("def2aa34-5a33-4b65-a500-8026d070a738"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTA LUZIA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("df635820-936f-4604-b308-64b58dfab400"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SAO SEBASTIAO" },
                    { new Guid("df94a7e6-48d8-429f-92b9-082bae380b96"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ELISIO MEDRADO" },
                    { new Guid("dfad4d26-0019-4286-9edb-f739ad7255f0"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO GERALDO DO BAIXIO" },
                    { new Guid("dfb72e2e-dfa8-4062-a519-aeeafe1c6dc7"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "FORTALEZA" },
                    { new Guid("dfc2fe0f-581c-4986-9975-4631fb6775ad"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "GOVERNADOR EUGENIO BARROS" },
                    { new Guid("dfcadc48-9102-4424-8456-dac9d42d632c"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CARIUS" },
                    { new Guid("dfcfae61-fbcc-461a-9b23-20aa1a0c94c7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEDRINOPOLIS" },
                    { new Guid("dfdd9ca2-3419-4bad-ba15-69d4435d82e8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "FIRMINO ALVES" },
                    { new Guid("e00fc9c5-546b-4c3b-af51-4fd84ef615b8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "URUANA DE MINAS" },
                    { new Guid("e015582f-aa74-43c0-bfef-c057222856e7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CIPOTANEA" },
                    { new Guid("e01989fc-7775-4366-bd39-257d568cd933"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "AGUAS FORMOSAS" },
                    { new Guid("e0369b37-d25a-483e-8b02-fd05bc41b713"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SAO BRAS" },
                    { new Guid("e0548bb4-358a-4ef8-9518-9fef38b30ed5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DIVINESIA" },
                    { new Guid("e068166d-2541-44be-b55a-3c10e5f7cfb9"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MARCO" },
                    { new Guid("e09608d5-8741-4b8f-b50c-165c8c2b09f6"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ADUSTINA" },
                    { new Guid("e0cc4b96-7f61-4cde-a117-e9294122d9a4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "POCOS DE CALDAS" },
                    { new Guid("e0e0ee52-dde1-45ff-bdb4-5b31746c7fe2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ANDRADAS" },
                    { new Guid("e0e6367f-281a-4a35-953e-fac16636c458"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "BELA VISTA DE GOIAS" },
                    { new Guid("e0fc59d0-e612-465d-9efb-a30bcfba1e4b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MAMBAI" },
                    { new Guid("e160250a-5c19-47db-ad61-33caf968d705"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BUENOPOLIS" },
                    { new Guid("e1866315-ec3e-49e9-8dfc-78d80d4e828d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IPIRA" },
                    { new Guid("e1be1d08-2932-49f3-ac4d-b385d4a09b43"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DORES DE GUANHAES" },
                    { new Guid("e1c78a01-ae77-458d-bae6-a0c09b3db9df"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DIOGO DE VASCONCELOS" },
                    { new Guid("e1df2d5b-bbc1-4442-9ee6-d564b93f3bb5"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "UNIAO DOS PALMARES" },
                    { new Guid("e1fd7714-0ab6-4829-9f53-9337e2d3d3c7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PLANURA" },
                    { new Guid("e2093579-7a2e-4c51-8ac5-04630f16304d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVA SERRANA" },
                    { new Guid("e20b5e1e-ea10-43f3-97c1-2882d3887d9a"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ALCANTARAS" },
                    { new Guid("e229ce18-051d-42a3-b9b3-63197c14db2b"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PIRES FERREIRA" },
                    { new Guid("e237fdbb-6493-42b4-bace-034f793acb36"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "AUTAZES" },
                    { new Guid("e23b1162-c294-4bf5-94cd-e0a89d9166d1"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "TUNTUM" },
                    { new Guid("e257edfb-c95f-4e0c-be44-fb3739f4d716"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FRONTEIRA" },
                    { new Guid("e27eceda-3fa8-484c-ba82-8dfda4a3b3a7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BORDA DA MATA" },
                    { new Guid("e28f405c-5ce4-46a8-bc18-b564e88d5566"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "FORTALEZA DOS NOGUEIRAS" },
                    { new Guid("e2b3d2e2-b92e-42e6-89df-0aecfd210713"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "COMENDADOR GOMES" },
                    { new Guid("e2b484b1-5f02-4e22-95eb-248efdffff95"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ANTONIO CARDOSO" },
                    { new Guid("e2d64a1c-2f35-4300-9368-753e9b9e28ea"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BOA VISTA DO GURUPI" },
                    { new Guid("e321d901-5aa0-463d-9f39-f0da3faa1dc0"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAPELINHA" },
                    { new Guid("e32a1ea1-63ad-4749-b702-09ad440a924d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CANAPOLIS" },
                    { new Guid("e348f1e8-4a63-454e-a7ba-54ef48e821ce"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ENTRE FOLHAS" },
                    { new Guid("e384c6fd-14f2-4d67-bdc6-eb422a41588b"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "IGARAPE GRANDE" },
                    { new Guid("e3852885-a7c9-4456-86ac-bea94abd3213"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BOCAINA DE MINAS" },
                    { new Guid("e39e0d1d-8d62-4667-82c2-2c514e74783c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "RIBEIRA DO POMBAL" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("e424e9d6-5fda-4bd8-8bc5-510b13694de7"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MIRAIMA" },
                    { new Guid("e431df9d-0099-4fec-acaf-1f174e77cefc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PERIQUITO" },
                    { new Guid("e46c68c2-faab-4bcd-87d3-2c9d39336653"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITABELA" },
                    { new Guid("e472bd13-0387-4348-8e60-57a9013d7d32"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LIBERDADE" },
                    { new Guid("e47ab588-bba4-40cd-88d0-14fcf02aa27f"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "GUARAPARI" },
                    { new Guid("e4af6cc8-0b9d-4657-922c-3c6e5c4b83df"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "DOVERLANDIA" },
                    { new Guid("e50032d7-1e78-453d-b26b-881d78073650"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SENADOR CORTES" },
                    { new Guid("e51ebcf3-6736-4a24-a24f-c1748bc615a0"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "RIO DOCE" },
                    { new Guid("e537d8f4-feef-41db-a556-0926184419d2"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CARMO DO RIO VERDE" },
                    { new Guid("e553c31c-8aee-415b-a261-e756b99ad2d8"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TAPEROA" },
                    { new Guid("e557425e-24bc-4921-a09c-3648f3baaef1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "INHAUMA" },
                    { new Guid("e56eb8e0-ea08-4ee3-bbe1-bfb312652eb0"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LAVRAS" },
                    { new Guid("e5779643-4f46-4d78-a05a-0e675c575c13"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ACARAPE" },
                    { new Guid("e5a0e69e-98b3-4a48-ad91-0207c0a5c696"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTANA" },
                    { new Guid("e5cff0a0-abc1-4694-bbc8-89c949a3c3f5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARMO DE MINAS" },
                    { new Guid("e5dad49c-922c-45e4-aaf3-41b0e8ba27d2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CACHOEIRA DE MINAS" },
                    { new Guid("e5fe5b15-c7d9-47d7-9f32-8efc552226b4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUIRICEMA" },
                    { new Guid("e611c111-8e03-496c-93fa-30f5aac3c216"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BACURI" },
                    { new Guid("e647b9cb-c07b-4e7a-a96f-22db63a7b599"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "OURO BRANCO" },
                    { new Guid("e66aaf2b-525d-45dc-a93d-aa5c223edc20"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "CAREIRO DA VARZEA" },
                    { new Guid("e66cee7c-2bcb-4d40-9d84-9dc6442c6a73"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "MIRINZAL" },
                    { new Guid("e6cd6585-6430-43b0-8ddb-ff2f8ae01e15"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAMARATI DE MINAS" },
                    { new Guid("e6d8b5e4-cb66-4b07-b0e6-5fe42d3b0995"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "JANDAIA" },
                    { new Guid("e6e916ca-46bf-4f73-9f14-350bb05af1b0"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CHORO" },
                    { new Guid("e70c1b6c-e04c-4368-814e-9f52b08c183e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BELA VISTA DE MINAS" },
                    { new Guid("e723242b-e42e-48d7-8575-314fd0c44e6d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "PEDRAO" },
                    { new Guid("e7504116-880d-48f5-ad6e-7ffc5c4fd8a9"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CAPISTRANO" },
                    { new Guid("e78c950a-aedb-40b3-9508-12145edb4fef"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMPO BELO" },
                    { new Guid("e79fcb3c-cd05-4fad-a6bf-fdef4f7ef25f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SARDOA" },
                    { new Guid("e7aefd0f-386f-4467-b51f-210af5cde503"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "OURO VERDE DE GOIAS" },
                    { new Guid("e7c758f8-2b63-4a84-b50f-def8e48eafa3"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MUNDO NOVO" },
                    { new Guid("e7d81dc7-62a9-480e-bb78-9ad300e542f8"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CAMPESTRE DO MARANHAO" },
                    { new Guid("e7e290fb-8438-4757-9554-76bbaf60f8a3"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "GUARINOS" },
                    { new Guid("e7ee9bc0-b876-46d8-803e-7983503fcc80"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "TEREZOPOLIS DE GOIAS" },
                    { new Guid("e8142591-74a6-46bf-9e2d-16f3faa09280"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "IGRAPIUNA" },
                    { new Guid("e81edc90-7f5c-4250-b9ec-f5b832fdb133"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAMPANARIO" },
                    { new Guid("e835cfdd-af34-4818-abdf-c69b154fad62"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORONEL MURTA" },
                    { new Guid("e856abab-b5f5-4068-a0a2-84f91ffabd29"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JURAMENTO" },
                    { new Guid("e887ec74-2a8d-4496-83ff-3908b0cd42cf"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PACATUBA" },
                    { new Guid("e8a47b69-6dd3-4f87-869b-8eca5c17e122"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MOIPORA" },
                    { new Guid("e8b3e67e-6b4b-459c-9bcc-9fa6ddfe23cb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITUETA" },
                    { new Guid("e8ebebe4-f46e-4239-802f-20473c4a4a1e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PINGO-D AGUA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("e8fae44f-08d4-4464-9579-d4ee4cd9a423"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TOLEDO" },
                    { new Guid("e905367a-9669-4f4b-8e82-12f2432ccbfc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAMONTE" },
                    { new Guid("e910b541-4d9e-49e0-a52c-febedd521772"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ROCHEDO DE MINAS" },
                    { new Guid("e926d826-6012-4847-859a-5d4824fa4a0d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "BATURITE" },
                    { new Guid("e941a6e2-b4c7-40eb-b785-73c4cdf78050"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SERRA DA SAUDADE" },
                    { new Guid("e944463d-cc90-4059-841e-6895f198e048"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "FERREIRA GOMES" },
                    { new Guid("e955fa76-4168-471c-9d57-974c424941ab"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "MINACU" },
                    { new Guid("e98e01cf-6205-4646-8957-dc84138673c7"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "JACARE DOS HOMENS" },
                    { new Guid("e98f01b5-1576-4bed-a7e6-ab722ed6fe66"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVA LIMA" },
                    { new Guid("e99b6e82-8200-4029-8fcd-c4778902a38b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SENHORA DE OLIVEIRA" },
                    { new Guid("e9a5a151-63f9-4bcc-8789-e56f984d96a7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FRUTA DE LEITE" },
                    { new Guid("e9a6b9c0-88e6-4638-819e-6d1b35d07557"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "ASSARE" },
                    { new Guid("e9d4fdd1-085d-416c-b61e-b27d8077174e"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CARUTAPERA" },
                    { new Guid("ea1109bc-1679-4ac5-b5f7-1b69b7742773"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LAMARAO" },
                    { new Guid("ea1df4ca-01d1-4ebc-8b01-9ebde9190e72"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "NOVA GLORIA" },
                    { new Guid("ea44dca3-f8d4-40f0-af8a-87dd2ad521a6"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "VICOSA DO CEARA" },
                    { new Guid("ea7d8696-bff2-47c1-9e5b-ccb1a7260325"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MUZAMBINHO" },
                    { new Guid("ea7e6463-6b34-476d-b19b-25392b10eb02"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAETE" },
                    { new Guid("ea7f9b65-176c-49d1-ac11-f61b9d17343f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEDRA DO INDAIA" },
                    { new Guid("eaa682d7-2564-46d5-9ef8-56a907270261"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "BARRA DE SANTO ANTONIO" },
                    { new Guid("eae84c9d-8d33-4d3b-960a-f085d3bf0641"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "JUNQUEIRO" },
                    { new Guid("eae9ce54-605e-4d1a-a53c-536583effcdd"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "SANTA ISABEL" },
                    { new Guid("eaed97cc-0744-4a72-b020-99c49a32fefd"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "PACAJUS" },
                    { new Guid("eb002ee8-0759-4514-97e4-018569792833"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PASSABEM" },
                    { new Guid("eb2b85cd-3d61-4e48-aed3-4c37c6d1df65"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "DAMIANOPOLIS" },
                    { new Guid("eb38b18f-4484-4c9a-8cab-5418dd96d936"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAIANA" },
                    { new Guid("eb450257-11c8-4c85-b3a9-12c2fa876deb"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "GUARANI" },
                    { new Guid("eb98a786-c2bc-4529-9e0d-fcd952b50bef"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JUAZEIRO" },
                    { new Guid("eb9cfa6e-38f8-4216-96af-2946d4eb2c47"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "COLONIA LEOPOLDINA" },
                    { new Guid("ebadd2fe-1963-4c38-b128-49b5442596ea"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "FIRMINOPOLIS" },
                    { new Guid("ebc8418e-a192-48a2-b7da-ee6f5fee6318"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "IPUEIRAS" },
                    { new Guid("ebce2882-51f5-4eb3-813d-2ea488e8d02d"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "CODAJAS" },
                    { new Guid("ebd89935-fc29-4153-a9e8-ac6f5e8f86b8"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PASTOS BONS" },
                    { new Guid("ebef6750-7a0e-4ba1-b3c5-affa2a593896"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "COELHO NETO" },
                    { new Guid("ebfe6315-763e-433d-b613-ecf1f2401872"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTANA DO RIACHO" },
                    { new Guid("ec190151-cfa6-4622-848e-b6be2fd0031b"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ITAPACI" },
                    { new Guid("ec1cc7dc-2f68-46d5-9202-0e1d0fd66002"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FREI LAGONEGRO" },
                    { new Guid("ec2d5503-1b8e-441c-8f8d-24dc397fa3bc"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SOBRADINHO" },
                    { new Guid("ec3e3fef-89f3-4026-80cd-daae032f4a20"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LAMBARI" },
                    { new Guid("ec479ac2-d38f-4ced-82dd-7bcef323a7ef"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PONTO CHIQUE" },
                    { new Guid("ec87bcbe-ead4-4625-921c-f53834c3583d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JOANESIA" },
                    { new Guid("ecc86649-a897-403b-a996-2058108845b9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "POTIRAGUA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("ecdf0c22-5927-4a53-b6df-fcdafe47ec6f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NAQUE" },
                    { new Guid("ece45c4c-03ec-4620-b04a-0873d42a5695"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ANGICAL" },
                    { new Guid("eceb5a5d-bb93-4b2d-8f1b-d661a4a530d6"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO DOMINGOS DO AZEITAO" },
                    { new Guid("ecf419b6-7629-449b-8cef-75dcd713bdaf"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "GRACA ARANHA" },
                    { new Guid("ecff514c-3cc8-4ef5-8d57-34e29b5a2fea"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CAPITOLIO" },
                    { new Guid("ed65a1e1-1036-4d42-8227-61531f7e9d40"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "TABULEIRO DO NORTE" },
                    { new Guid("ed79dccf-62ee-47f6-acd1-806a17f3e9b2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOSE DA LAPA" },
                    { new Guid("ed7d5c8c-ee10-4cfe-bd1d-40c65811388a"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "UIRAPURU" },
                    { new Guid("ed941b5c-0a89-40d5-a479-9545defad3f5"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "CRAIBAS" },
                    { new Guid("edc41f9d-d06a-4e45-bfd2-248bfba7606d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FAMA" },
                    { new Guid("edfacf69-40d1-4a21-b04f-4dffd3c855de"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PATIS" },
                    { new Guid("ee016374-36a4-4990-ade6-84f847e62b52"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "TUFILANDIA" },
                    { new Guid("ee29bca6-e39e-4081-ad00-84f5e29f15df"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "SANTA ISABEL DO RIO NEGRO" },
                    { new Guid("ee2e0faa-e571-4e7b-bc19-fe5275d725ef"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CALDEIRAO GRANDE" },
                    { new Guid("ee300cf2-ab91-4717-b281-1be1b4ab5180"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MATINA" },
                    { new Guid("ee5e845b-4fd1-44b5-8d55-66531783e530"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "JUTAI" },
                    { new Guid("ee77a1c8-d1d9-49c5-a997-c2d0bf9e080e"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MESSIAS" },
                    { new Guid("ee9a6042-383e-43c1-9b9d-b989cf52b94a"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "SENADOR RUI PALMEIRA" },
                    { new Guid("eed1f18a-0f5a-43f9-ae3b-f2d9b99f706a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ITAGUARA" },
                    { new Guid("eede7f61-4f3e-4291-9ec8-611882d28169"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MALHADA DE PEDRAS" },
                    { new Guid("eee6a0a6-fcc0-49b0-aa97-c4e40b60ac0b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MIRANTE" },
                    { new Guid("eee8ad5d-93ec-4e44-969f-59c5731ff389"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA CRUZ DE SALINAS" },
                    { new Guid("eeeb9ec3-e2ea-4cc4-bc86-4de246206f38"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PRESIDENTE BERNARDES" },
                    { new Guid("eef2b891-7c00-4474-afae-1ffc28604e64"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "AIMORES" },
                    { new Guid("ef0bb7ae-c86e-4fce-9b9e-ce1bd8798f6c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SALINAS DA MARGARIDA" },
                    { new Guid("ef0f6dfc-f5db-4925-b7d2-0cab99e2434c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PARNARAMA" },
                    { new Guid("ef186c67-e97d-4b75-9639-cbfd4840a79d"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "WENCESLAU GUIMARAES" },
                    { new Guid("ef2ee617-9621-4f7f-82c4-e03d546abe84"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BICAS" },
                    { new Guid("ef37148c-55b9-4d84-a520-71c5d13d41a6"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "MURICI" },
                    { new Guid("ef38f940-4bae-4a52-9ca4-a1a1a7dc8186"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SILVEIRANIA" },
                    { new Guid("ef47e511-2500-44d7-a2fe-0946607d181a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CORACAO DE JESUS" },
                    { new Guid("ef54d2a3-c00d-4a9c-8a4b-a2fd94162713"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "EUSEBIO" },
                    { new Guid("ef5b01ef-c67f-41ab-8cb1-dc2a7e51ca8d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PASSA QUATRO" },
                    { new Guid("ef5f6672-049a-4ea6-97a3-145f9379a7b7"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONTE FORMOSO" },
                    { new Guid("ef6435b0-7c46-4ea8-ad85-4b3dc9226f1a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ONCA DE PITANGUI" },
                    { new Guid("ef6b0c07-1613-423e-8e51-b69251e1f89c"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "LINHARES" },
                    { new Guid("ef9e668b-98b5-4c4d-a025-15fd8b6fd62f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BAMBUI" },
                    { new Guid("efab1b1b-22cf-4a87-8059-c1ac0f887395"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SEABRA" },
                    { new Guid("efe73af4-e274-43ed-b29d-c632e84e1fe9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALVARENGA" },
                    { new Guid("f004beb8-ca27-4e2d-bc53-8b02c306c1bf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MATOZINHOS" },
                    { new Guid("f006b8c8-74c3-4f97-a535-a8229171a1e9"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO ROBERTO" },
                    { new Guid("f01cf383-16d7-4f46-b808-c5786ad57075"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "COUTO DE MAGALHAES DE MINAS" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("f02f07b5-8faf-412d-803f-d49c3929a814"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "APORA" },
                    { new Guid("f035d93e-0e3d-4701-9ba1-bd8d767d4c0c"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "AUGUSTO DE LIMA" },
                    { new Guid("f03f03ee-f19e-4d94-aa74-8d87ed768a2c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "VERA CRUZ" },
                    { new Guid("f0492f5c-745d-43b1-895a-894735d4f146"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARINOS" },
                    { new Guid("f0c7bb78-93f2-4714-85ec-5b0be4a13d85"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BURITIRANA" },
                    { new Guid("f0c9b861-ae19-44d3-9698-ea0509423ae9"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CARAVELAS" },
                    { new Guid("f0e6b57d-763f-4746-8393-4ae110c7bda9"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "TRINDADE" },
                    { new Guid("f118a07c-44e2-43e1-9b4e-a3750a9db9f4"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "PANAMA" },
                    { new Guid("f11ea05c-60de-4b3f-aa81-30c4a1662f48"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PORTO CALVO" },
                    { new Guid("f1219b80-5329-40de-9889-944a6f47bd2b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAQUIM DE BICAS" },
                    { new Guid("f122f3a2-4fd7-4fb0-96dc-a5e75e732988"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "JOSELANDIA" },
                    { new Guid("f12ed523-b3da-4df2-988e-d6e1936a07de"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ALCANTARA" },
                    { new Guid("f13342cb-6924-45e3-9551-0122fb738f95"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FELICIO DOS SANTOS" },
                    { new Guid("f1fddcc0-bb41-494a-af66-7c8c292ca71b"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "TURILANDIA" },
                    { new Guid("f26c98e2-24af-47ef-827b-0f99d0b7b676"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA ROSA DA SERRA" },
                    { new Guid("f273eb72-7dce-4c1e-a126-1ac1d1740032"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "LIMOEIRO DE ANADIA" },
                    { new Guid("f2c6e4dd-374e-4bc6-9763-d08745a01cbf"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONCEICAO DE IPANEMA" },
                    { new Guid("f2f9e9ce-abb2-4e3e-afe9-b5f31300791f"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "COREAU" },
                    { new Guid("f2ffc666-64f6-4517-9915-27f0c56013dd"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "ITAPIRAPUA" },
                    { new Guid("f30b5656-3b92-41f5-83b8-a91fb0a9f0fe"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO PEDRO DOS CRENTES" },
                    { new Guid("f31785bd-ab81-45ae-a0e6-0b5ebc0f4395"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MARCIONILIO SOUZA" },
                    { new Guid("f3231629-30f9-4d2f-b611-07044d7ac524"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "VARZEDO" },
                    { new Guid("f33eca04-062d-404a-bc9f-969689db54e0"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "AIQUARA" },
                    { new Guid("f3492478-68e9-4706-b97d-cdfd2d070b84"), new Guid("7ad1495c-996e-4c95-95da-01d3c458b61e"), "SANTA ROSA DO PURUS" },
                    { new Guid("f361a00f-21b7-4e2b-9b56-1936558789b8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARMO DO CAJURU" },
                    { new Guid("f380cdbf-6081-495d-bcf8-07d11c6f095b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTANA DOS MONTES" },
                    { new Guid("f3d0b49f-cce1-4512-b7a6-051fe2877882"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO SEBASTIAO DO PARAISO" },
                    { new Guid("f3f592f8-8552-4287-9b0c-4f6a32204675"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ALDEIAS ALTAS" },
                    { new Guid("f40cbc3b-f079-4d1f-a85f-e767e6d6509f"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "URUCURITUBA" },
                    { new Guid("f426c271-df7f-426c-9a82-260139011ad4"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BURITIZEIRO" },
                    { new Guid("f443a0a6-dd88-4970-a754-fcfd1ac8ba1e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "UBAJARA" },
                    { new Guid("f45a54e5-4f59-40a3-be67-3559312f7391"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SERROLANDIA" },
                    { new Guid("f46b1a22-6b8a-4439-a20b-74473f7e56ab"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LEOPOLDINA" },
                    { new Guid("f49564d5-1bbf-425a-a66d-3847e2b1db85"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "RIO LARGO" },
                    { new Guid("f4d1154c-b1c1-4c77-b12a-c21ab2bfa150"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MAURITI" },
                    { new Guid("f552e780-7892-4c28-b101-ff7f55b071b8"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MACHACALIS" },
                    { new Guid("f57351fb-bcfa-486e-a7a2-82ea1feca3b5"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "LUIS DOMINGUES" },
                    { new Guid("f57b873d-e3bd-4af2-a4ac-2ff118fe472a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARACUAI" },
                    { new Guid("f5b8498d-b1d4-4df8-83d7-c94a2f2c3d53"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "LEOPOLDO DE BULHOES" },
                    { new Guid("f5c60910-643d-4cfa-bc04-ad0d27ae965a"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "NOVA IBIA" },
                    { new Guid("f5cbf2e4-2e3b-499e-b60d-cc916a2f4a37"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BRUMADINHO" },
                    { new Guid("f5d1136f-a718-4c33-b1ba-07944eec0603"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "ITAPEMIRIM" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("f61eec84-82c1-4937-a267-934099006641"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PASSOS" },
                    { new Guid("f624886a-3c35-4a6d-a604-841c2c7ac319"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "MANACAPURU" },
                    { new Guid("f634d7b8-a114-4efe-ba87-cda8f856ccf0"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TANHACU" },
                    { new Guid("f63c9489-79ae-4474-9b3e-4eb0fc5115ac"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CAMOCIM" },
                    { new Guid("f671584d-a05b-436c-a808-cc1801af3c8c"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "MANTENOPOLIS" },
                    { new Guid("f67f2a23-23f8-4e51-aaca-92c09afc654f"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "CENTRAL" },
                    { new Guid("f69c7448-955d-44c6-9dc0-0c941ebbd6e6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PARACATU" },
                    { new Guid("f6b696d9-5533-4ec8-900a-3e0d2a32a05d"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ANTONIO DIAS" },
                    { new Guid("f6dbd47f-57fa-4aa4-9aa1-7a8815eb82e6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTA BARBARA DO MONTE VERDE" },
                    { new Guid("f6ed3511-82d6-4a56-bc79-23f96bb2128d"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "URBANO SANTOS" },
                    { new Guid("f7275ee8-2797-468b-9cf6-0091fa0fc83b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MONTES CLAROS" },
                    { new Guid("f7772c7a-6ac6-46b9-a193-18b797ac868f"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "CANAPI" },
                    { new Guid("f787c7ec-0864-4314-a41f-a64632469e47"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "CACHOEIRA DE GOIAS" },
                    { new Guid("f788f855-e1f5-4c83-9dac-54d8c0a9e776"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ARARI" },
                    { new Guid("f7ed5d21-70fa-4dfe-acc6-d791aebcec6e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MERUOCA" },
                    { new Guid("f82ae292-9d4d-4b7c-a659-6777b1af97a9"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JABOTICATUBAS" },
                    { new Guid("f84bac34-17e4-413d-a7d9-c6f9ad285e5d"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "FRECHEIRINHA" },
                    { new Guid("f85e71be-a3e1-40e1-a196-eed7d4cc2c7b"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "EWBANK DA CAMARA" },
                    { new Guid("f85f0b78-ffe0-486f-920c-f34eedff8090"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SAO FELIX DO CORIBE" },
                    { new Guid("f8abea63-66cd-4aa5-9edd-c26d9443b734"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PENALVA" },
                    { new Guid("f8be4f74-84d4-4a9f-87d4-00e3c06e352c"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TEOLANDIA" },
                    { new Guid("f8dcbdc3-eb8b-4955-af66-fac81fb17b19"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SANTO ANTONIO DOS LOPES" },
                    { new Guid("f911f44d-1e32-4f3a-9030-c90eaf354a2d"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "GODOFREDO VIANA" },
                    { new Guid("f95b6223-64da-4181-85df-4658754b3431"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "POTE" },
                    { new Guid("f99c155a-b83a-4eff-8dc9-2f4a3c353dad"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "SANTA CRUZ DA VITORIA" },
                    { new Guid("f9a58d56-b184-4cb2-a3e1-fdf04a287fa3"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "APARECIDA DE GOIANIA" },
                    { new Guid("f9a71e50-cb0c-40d9-ad5b-7c6d93b53d67"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEDRA BONITA" },
                    { new Guid("f9b2c097-e7e4-4e06-9b2b-275a99a0a4d6"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MURITIBA" },
                    { new Guid("f9bba1eb-e83c-4317-998a-ec7aa4862491"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "FEIRA DA MATA" },
                    { new Guid("f9c81a3f-b213-46f1-b2b4-25428fababf2"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARBONITA" },
                    { new Guid("f9f99500-efc2-4810-907e-54f23d7c0750"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CATARINA" },
                    { new Guid("fa3d458b-465b-4f83-8be0-b49d8e325aa6"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "DOM VICOSO" },
                    { new Guid("fa438f7e-eeee-4e6d-9e05-842967bc6b68"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "NOVO ARIPUANA" },
                    { new Guid("fa5cac70-d3e5-4e8c-9a49-c6395453de09"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "JOAO DOURADO" },
                    { new Guid("fa5ef0ff-8278-419b-ac79-e7c92574bc79"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "VARGEM ALTA" },
                    { new Guid("fa768ae7-7c80-4182-940d-75e5fd97b343"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BONFIM" },
                    { new Guid("fa8b4704-9fa9-489b-8320-f0e448c75171"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "LARANJA DA TERRA" },
                    { new Guid("fa8c5239-8b49-449c-801f-132a9f341c5e"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "FLORESTA AZUL" },
                    { new Guid("faa0dc17-4138-4e64-ba74-4e32bd2bd069"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALPERCATA" },
                    { new Guid("fab8f89b-c30d-4a16-ac6d-1da554d00906"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALVORADA DE MINAS" },
                    { new Guid("facd7850-2b88-4f8d-a1d5-690d37bdd924"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "JESUPOLIS" },
                    { new Guid("faf1a2a7-8d0f-4839-bbf8-c4db7191d3a1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TRES CORACOES" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("faf38fe4-2a71-4894-8461-2ea9d9dae217"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PEDRA AZUL" },
                    { new Guid("fb45a5e1-e07d-4a88-a71f-1f94582145de"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "OCARA" },
                    { new Guid("fb4f4cc2-4c03-4d5e-91eb-74d75eb46330"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "FERNANDES TOURINHO" },
                    { new Guid("fb526b4c-27eb-43e1-afdb-7569e4cb24c4"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BRUMADO" },
                    { new Guid("fb6c92a1-211e-412a-8c88-8113776d1698"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ARAXA" },
                    { new Guid("fb70c845-56b0-40b7-9222-d75be1de9e6b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "LIVRAMENTO DE NOSSA SENHORA" },
                    { new Guid("fb792ef9-ed4f-4822-91dc-43c8e259f2cb"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SAO JOAO DO JAGUARIBE" },
                    { new Guid("fb801de6-4cb1-4040-9b40-b89f9404b670"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "UBAIRA" },
                    { new Guid("fb9c1dfa-c0a4-4319-8c99-052b37a84b4e"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BETIM" },
                    { new Guid("fbdc7073-5e23-44f5-961f-16554ed37114"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "SENADOR SA" },
                    { new Guid("fbef63bb-cfae-429e-ade1-60ef845ed379"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "TABULEIRO" },
                    { new Guid("fbf4cfab-9446-4fec-8c5d-ea6e58a01ded"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "VILA NOVA DOS MARTIRIOS" },
                    { new Guid("fc110dd2-0d5b-4bde-8b55-0e0273009a7f"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "LIMOEIRO DO NORTE" },
                    { new Guid("fc1c2930-dbc5-4bda-a022-feac7f7a8f43"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "CARNAUBAL" },
                    { new Guid("fc2c2281-7c15-416e-a9ea-ef8c7f7b0c27"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CONCEICAO DO PARA" },
                    { new Guid("fc340a5a-eb0a-4666-ab42-a8fe52ffbd1b"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "BELA VISTA DO MARANHAO" },
                    { new Guid("fc405a65-6918-4d86-9d14-34907100422a"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "UBA" },
                    { new Guid("fc5fa740-2df9-4c47-aa56-bd41ccf42a56"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "CARLOS CHAGAS" },
                    { new Guid("fc618b82-2a62-4f9a-b497-eba0599e75df"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "LEANDRO FERREIRA" },
                    { new Guid("fc7b1973-a762-4c79-bdba-19ee4180611c"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CANTANHEDE" },
                    { new Guid("fcb26148-2ce5-403f-8fb3-a3e97513b82b"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "TABOCAS DO BREJO VELHO" },
                    { new Guid("fcf93bdb-46a5-4a1c-9c12-d0538c80f2fc"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "JAPARAIBA" },
                    { new Guid("fd253470-5c68-4ae9-8831-ab5fdb7baae1"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MARIPA DE MINAS" },
                    { new Guid("fd537eee-173c-4360-96f4-b7536253ac9a"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "JAGUARETAMA" },
                    { new Guid("fd6218d4-ab7b-4776-a282-417d47ce38ca"), new Guid("a5ede577-fb1f-4241-87bf-5ddc88940687"), "CARIACICA" },
                    { new Guid("fd638e73-1944-4443-805c-ef5f6ea3f5fe"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "INDAIABIRA" },
                    { new Guid("fd951281-ad8a-4426-8325-c0ae50cfaa7d"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "SAO JOAO DO SOTER" },
                    { new Guid("fd97fbd1-fb8a-45b3-a816-9bf678605e52"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "PINDARE-MIRIM" },
                    { new Guid("fda2f559-0e82-41e7-b8fa-b01675c48682"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "TRIZIDELA DO VALE" },
                    { new Guid("fdb95ae9-7764-420a-ab26-0e6a9d659d66"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MANHUACU" },
                    { new Guid("fdba0d4f-cbca-4cbe-8c13-4000ff3a0f35"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SANTOS DUMONT" },
                    { new Guid("fdd14b10-88de-468a-8d7d-68c7a424d3b5"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "BONITO DE MINAS" },
                    { new Guid("fe01a165-7755-43f4-920d-42b60af933d2"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "MUTUIPE" },
                    { new Guid("fe04367f-10ef-4858-9dc4-0d727d2a9297"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "BENJAMIN CONSTANT" },
                    { new Guid("fe050f9d-4c36-458f-aa0a-711ba7c5c0fb"), new Guid("f8649009-0894-4ebe-a649-e7a9ab7893f7"), "LARANJAL DO JARI" },
                    { new Guid("fe2a5f56-8820-4b8f-a3c1-ce4f44860afd"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PECANHA" },
                    { new Guid("fe2d597c-2aed-4a65-87a8-ceb9f6704d36"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "NOVA PORTEIRINHA" },
                    { new Guid("fe2f328f-ba28-4f90-b167-c933fa0507ac"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "URUCANIA" },
                    { new Guid("fe5976f7-76e1-4d88-bac1-ad69f84b01cd"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "BELMONTE" },
                    { new Guid("fe9157bf-87f9-4d62-9e14-b26ae994cc8f"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PAINS" },
                    { new Guid("fea6197e-a082-40ea-bcb5-9bcc4c5c6eab"), new Guid("7376e701-2ab1-4552-807d-627a9cbfed50"), "CARAUARI" },
                    { new Guid("febb188d-a682-4d57-b5cf-c6528e2ddbe3"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ALTEROSA" }
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "EstadoId", "Nome" },
                values: new object[,]
                {
                    { new Guid("fec116cd-b38b-4352-b573-fb094923da0e"), new Guid("d55e7051-9a5f-4582-8858-765257fb4e2d"), "EDEALINA" },
                    { new Guid("fec50fff-b406-4866-b891-4b75c90bf57e"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "QUIXELO" },
                    { new Guid("ff1e6f44-0a08-4a88-ae9c-7674c19f8960"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PINTOPOLIS" },
                    { new Guid("ff2b00f3-24eb-4567-a8e2-6efa6ae1c926"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "SAO JOAO DEL REI" },
                    { new Guid("ff4b2291-6436-42d3-9da4-f0dae6440a02"), new Guid("160f16e3-f932-45c8-9d27-a3636c53b8fe"), "PIRANHAS" },
                    { new Guid("ff5c5e18-76c1-49eb-86d4-ba2c6ce56a88"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "MAMONAS" },
                    { new Guid("ff62c2c6-61bb-4599-9d4d-51b3ff8cd2bb"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "HORIZONTE" },
                    { new Guid("ff70b7db-ea48-4328-93e3-d5d156528ad5"), new Guid("432f6c81-2e45-4cb4-a9da-a041704e345d"), "MISSAO VELHA" },
                    { new Guid("ff7543ce-d330-44e8-bb87-83c09420f6a4"), new Guid("e6051ad2-6eb4-4540-b24b-26d2eea3d2ca"), "ITAGUACU DA BAHIA" },
                    { new Guid("ff7b2ba7-767b-4929-b6b8-370966e367a9"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "LAGO VERDE" },
                    { new Guid("ff88ff2f-d816-4e02-b012-680572d6f9e2"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "ESTREITO" },
                    { new Guid("ff8a35de-0322-4360-ae43-f35b556effda"), new Guid("853f114f-c716-4414-ba99-16f09b37a939"), "CAPINZAL DO NORTE" },
                    { new Guid("ffacb7e9-9825-4efc-ba4d-943dad857314"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "ACUCENA" },
                    { new Guid("fff9b7a7-c3d3-46e2-b71e-c01548b1d716"), new Guid("384891ad-6783-475e-92aa-667d899c84a8"), "PERDOES" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0046173a-2945-4d67-bc59-393e23cc0d8d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("00571265-5a18-4f09-8326-2050b084baac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("00ac73e3-46ab-495f-88c9-6b85a96eb09b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("00f4134b-0382-4b0a-88db-6045fbcc377a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("01208e36-0f55-45b4-aeb2-c83d50f22e08"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("01446710-66bd-4a55-b035-b1bf84c7f988"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("019aea2d-6c9c-4dd6-afc9-f36b78f8e539"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("021c5d47-3b13-47d1-9ae0-c8185945dc24"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("02308cb4-27b7-4577-bbc4-375303a6e853"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("023835bf-38c0-44a4-8dae-cc992943d69b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("023867e7-7f55-4882-84fc-3dca47a07b9f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("02474fe9-fcd7-438c-9d53-2af8af79ba8b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("026295d2-7100-425d-b8b5-59a1229cbe4d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("027c9f30-25be-46f1-8344-ef836685c7e6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0293d7a6-3dfe-4a60-bf84-8390721ea9e1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("029cdcbc-e649-4d53-ab40-b155ff6204e7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("02bff3f9-d2a0-46fb-b7ca-2ef38cca9a3a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("02c53be9-40df-46ae-886f-f6a60060ea7b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("02e4f530-744a-40a3-b4c5-805212062741"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("02f1992b-dd24-4e67-86f4-407cf0347808"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0315780e-be95-4f88-86b5-0170d7fbf096"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("032bad30-5ea5-42d5-9634-0cc6f53fcd13"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("032de41a-3036-4c1f-af15-f9293fcfa0d1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("03696668-6d89-470a-b997-cf645062a5ae"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("03853713-db3d-4879-afc1-4ea6f6d4d8e8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("03b63b29-0f80-4e17-bf0a-7dcbf6f5683e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("03bdb15e-c1a4-4292-8fee-37964ec8ce98"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("03cb954f-13a3-4a88-9da6-3464e2bb5ed3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("03d19354-8ecc-41ec-9a40-d93bcc39e977"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("03efc359-5fa6-449c-919d-d64c7fa8b8e8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("03f16f4d-a93d-43c8-a44b-4b2b20979abb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("04029ef2-8dde-4402-b986-149e949b21a6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("047d68d4-8fea-4d46-bd74-4980b891532f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("049f89e6-eb48-4560-85f5-8119523c6a76"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("04a79551-7b94-4152-8a95-2611b031e2d9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("04c3cb67-015e-4b63-a24d-d8c29dcdcb70"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("04d6ac42-63e0-42be-a43e-74b320d27f87"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("04dbc33c-11eb-4ff4-a804-8c0a1791dcef"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("04f3e655-9cef-49c9-9aa7-710bc403c5ce"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("04f9ea30-9b07-44d7-a607-914c03ac15df"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0500d259-7568-4cce-b822-d7ac52bea32b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("054eb3de-3fc6-4788-bbe2-03fd7c2e1082"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("05665a1d-da9d-4f54-b853-8fb8ae11c652"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("05e7c143-41fe-4087-8ab2-f356300dee7e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("05f2d076-1bba-4df5-80f2-ccc0ddbc958d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("06043080-1036-49a2-ac47-d338df9c65fe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0604bcc6-f036-4a64-8da6-e547ee7f9270"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("060b276e-b87f-4bde-95d6-e7e7bf6d3679"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("065a81aa-b48d-41b4-a0c5-539c0339666b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("065fa8c6-17b7-469f-a56f-55c7176ec2d9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("068df452-ef4e-4a05-8d12-7b1d4a4b01a6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("06ca98d1-194e-4f9c-b1d7-65487621675e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("06d1eee0-df15-4170-84d3-6b7078047c92"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("06f8aa2f-7766-4296-92f8-15045cb32674"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("070274f8-a3fd-4680-8f06-b296bb2bf363"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("07128dbd-800a-4cdf-b073-0800810c6afe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0722835b-c5eb-4db9-a682-5103c1e3a6e2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("075df655-f6f3-4448-846b-6e013ded1420"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("079b63b1-5be9-4676-a256-56d55b7ae90e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("079f09af-8e00-465f-b253-c66325b6f033"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("07c44514-0817-4356-88eb-7204be1ca710"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("07c7f02f-42aa-48cd-8c2d-e1b4e4fa67f3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("07d29031-4e23-4ef3-92f8-17189dd7c65a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("07e046fd-12cb-4bea-a6be-159c6898fa3d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("07ec2fab-2b2e-4e2a-97d4-43e59d2a82fa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("07f4cb9b-628b-4c1f-aa36-970baba9db63"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0801ddc8-e942-4b7a-8796-759848a57256"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("08038765-c5c1-4735-8a16-65096d394af2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("085d1c46-4dc8-45ba-b1c4-4520768da3fd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0878f91b-fb6e-4a9c-97f7-fad04fd307c1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("08faae8e-26a9-4d0d-82d3-fdecda9edd17"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("095b5b87-7d76-44b9-8c0e-6f02be64598f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("095eb1ff-d98a-49ed-9644-f747112136a3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0990399b-95bf-4cef-911e-bc7aa7a2ca6e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("09a3cdcf-b235-4d11-892c-5ee7c160390f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("09b0693d-60fc-4609-96c7-5d742e8b6e4f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("09b3c0ad-a74f-45d7-9098-392ab2bbd840"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("09d60e27-bf9e-4f5d-81e7-7b55ce7af344"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0a020a5b-5290-4146-a859-92f3796f50b4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0a07e0f8-6488-4217-bd3c-7c5051943d61"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0a3ba37f-f733-4c16-b036-d8098abc73fd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0a4af495-6d8c-45c9-85c1-b6803bb2eae7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0a5478a3-9f69-418e-858b-f74826ae04be"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0a59d010-3ee7-4ec3-aa73-38939be6d163"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0a5a3f04-216e-4e83-a156-a4f3c35fe5f3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0a6fc4cd-c516-4ea8-9e76-830fcd3432d1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0a72a800-aa5e-4a97-ac95-5d25b34cc4c7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0a7d76a5-f247-4bac-8bcb-bd66df951fc6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0a934c79-0ff5-4ea4-82e2-4d01b1c3b7b0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0ad35250-b0ca-4021-8f16-cb3a5006fa5b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0ad513de-650e-42c0-8f87-9be6dca38d23"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0adc0b7f-56cc-461d-9309-abfc22cafdc2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0ae21bd1-6876-4eba-971d-7b1d814e079c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0b148557-7ddb-4526-915f-3eb253cee476"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0b2d392f-b33a-4d00-9c6f-b4046f085474"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0b3ed5af-4910-4539-82f6-802cb7b85f2f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0b615538-196c-4f20-8dde-d59d9d0f3ac9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0b7c292d-145e-4a2a-a204-62a18cd04e2d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0bb4a154-a488-4d2b-85a4-456cf1cc8a07"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0bb6ad82-de0c-4355-86e4-9d14bd78df2a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0bc76be5-28df-4954-aab0-2ff3acf7d13c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0bd701ae-7864-474b-abec-e0d55397ff69"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0c0d634d-3de9-43d3-bec9-9112f1013089"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0c1a37ab-c5e9-48c9-bf23-d1dd07306f36"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0c3af92c-f115-47c0-9dda-d7ad052c76f6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0c74d98f-1747-4361-b725-2ffc4f7092aa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0c9aaaba-63b1-4d70-a2e9-919ebe0bbbdd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0cb692c9-74f9-42c6-9674-574559cd8aef"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0cb6e80d-d93b-4dc9-9f92-370d0b7c181a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0cc0c858-89f6-4f7d-88d0-880dc08a96c8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0cda8914-8469-43dd-9848-18f087b76e31"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0d52ec37-7921-4001-b8df-25f4b19dcf1e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0d56aa96-e0b0-435d-ac4d-463aad851004"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0d56c218-f5aa-410a-8b0b-6f3ff39c58e2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0d7803b5-5525-4134-a04b-9b683fd38659"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0d9e37a1-41a4-48e4-a1fe-ad8748181cd2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0e266f49-9da4-45a1-8e93-61f0e2d49ab3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0e3f6841-2e53-4068-8756-88526f740df1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0e65b7c2-f3a5-4b6c-9bb7-cc381760ab29"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0e69e89f-2adf-412d-a3ce-0c7ebf1060b4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0e7fa79a-2f51-4f2e-aab2-40502e47108c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0e8f087c-ab1f-4e93-b3d2-1f1c83147e34"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0eafbeea-583c-47d8-9a4f-809370973dc9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0eb7b04e-336d-4c4a-9fd6-b09a3d576113"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0ef6aaad-aa83-462a-8ee7-817e420df480"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0f30eff7-d383-4a7e-87d0-337c5b7819aa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0f344bc2-c683-4964-a052-54c311fd66ea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0f440574-372a-409a-ac73-52d0f2a06e32"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0f60b06d-12d8-4e16-9aab-bcfe43b57155"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0f865076-282a-4db6-815a-8cd1936d2e46"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0f9154bf-9518-4420-86af-7d4dbdc132fb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0fa1348e-6e74-4645-9b1d-29f2dcc3be3e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0fc13cc6-50a9-4ca1-b10c-540d47bd43e6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0fdedfe3-8419-47e6-be30-580b11c84b03"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("103c3983-d4de-45da-a63b-7608b1fbb29a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("106055be-3f46-4f5e-8bd1-fbe8d719e2ce"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("107e9dae-3938-4fab-a1ad-afeab8ba1c7c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("107fc9b9-ca5a-4a51-93ae-ef905ccacf29"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("10c22b99-9c5e-493d-9f20-c3d6699b9e9b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("10ef9e9b-d191-4b80-b2b6-f31050211005"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1108ad0e-9a58-4642-b323-4262438a17c2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1111ae2f-a4ea-415c-94af-a98d3a9eed94"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("11265a3f-7a7e-43b9-b06c-a5b3c4344626"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("113ddce4-4737-40b9-80a4-f1938b58412a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("11fead0b-0271-41a6-a661-85ac0a2f3709"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("121598cc-f58d-44a9-bd5c-39ffbedf47bd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("122a9243-f676-49c9-856a-91dd1e20eea8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("123120fb-b25f-4964-99fe-ff6898202175"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("124ed314-67bc-4ebe-bfa1-dc901b71737d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("125796a4-2c7f-42de-b6e4-9845b1981d26"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("127cc86f-6812-4bf0-9f25-3f9a0f3ba27d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("12951934-6c0c-4d55-aa27-f43b48bded81"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("129dc233-41d6-4019-a5fa-06547569a680"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("129e7c2d-21a3-4910-a9a7-4a087da3e7d1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("12b5bb55-f46f-409a-a98d-8bd4be94d8e4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("12c6a8d6-c239-4c5d-baaf-20a48514cf7b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("12cbdaf3-2864-4fc7-a755-07e159db1104"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("12ddf9ae-c2b7-4a75-9ada-5919d8ce5d5c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("12f6f030-7fb2-4183-8d40-e0c9009f58bb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1317b4c9-ea37-4527-9265-33dc798a7af4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("132b9807-3af8-4ebe-90d2-acfc370a8edb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1332788f-8c23-438b-a017-8e1eb1fbb8bc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("135090d5-8d25-4209-95cf-cbe0c2b9cfd2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("13633702-9daf-4b9e-ac8f-c1436cc16f6b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("136539ec-523c-4aed-9bf4-0816bfcf30e8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("137ec34b-cbed-40c7-b77e-b3ca570a4c3b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("13896dfb-eae4-43e1-b22c-2dc051df223b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("139e04cb-ccdd-4da2-9940-4a8d7c9d1097"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("13a985d5-c90d-4073-ac94-0f173ae19880"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("13c459f7-2ba1-468e-ad16-1e31789394e5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1400cc60-12b4-4e94-8c6d-d839f1823526"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1418dbfc-3296-475e-a0c6-51160adee77e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("146511cf-2650-486c-b0a6-500a7d1a3e43"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("14a02476-b4bf-439b-980a-4f5603c7860e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("153b9b3c-2f9d-4444-b409-7c21b6c7e4ea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("153c4608-44cd-44ad-92f7-720cb168b1b5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("157c6861-45ef-41e4-8099-e285da4ffaff"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("159a0d02-f2e0-46c9-bbe4-9d0d023a840b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("159b8011-4618-48a1-8333-c0d8c746a00c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("15e22f52-a323-46f2-9a98-749571034733"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("15fb0514-7f85-4bb6-9996-f416b6ad6162"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("160e8663-66fe-4b4e-b801-092cabd2faa3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("161996f8-49db-414a-afa6-67154c41d981"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("16233694-05c2-49cf-ad70-187e994bac59"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("164f5200-c558-4df7-8a10-a6a2742f8c64"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1671c821-62bf-4e43-99e4-c76ae566db18"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("16923002-7813-4a62-89a5-7cd6e6dc82d7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("16971e7e-ebca-4c9d-b305-ede000e79ec8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("16bffbd1-4d09-43c4-afb6-ccf4edb97af8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("16e56a3d-be0f-4873-baac-c6c8255fd4fe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("170a801b-b5c5-4d1e-808d-cbbf2bce4572"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("170dd697-3e86-4209-85ae-5fc7c4b34074"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("171ac935-a0a2-4e6d-a42d-f92d6aac0784"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("171be01d-7def-4e3f-9cf5-53175bd8724f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("17339e6b-82ce-4060-ae9f-9b5022927c26"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("17894d16-0467-411e-827c-e0ac604b3707"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("17a9bc4f-2510-475d-9ddb-379bec6e3d59"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("17de2a4e-3d76-435a-90ee-8b019b1b3a27"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("18130e55-8029-45ca-ab7a-611f3cbc0c53"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("181e5fae-4592-41e0-b208-044a0f3a9c90"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("18591c20-f17d-4ad9-bb2d-f5c78fc0196a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("18784346-5957-4b02-bc5a-a2324787dcfe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1884e888-9a62-42e0-b3b2-b6cb40d5deda"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("18940aa1-a2b0-4531-b41d-992d802fe584"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("18b4238c-77c5-474e-9b6b-59dba869efeb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("18daf288-5abd-4c8d-8bca-4961df6fb565"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("194c3144-a32b-4ec6-986e-f752ff300e45"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("197eae08-b5ed-4542-b126-9c730c785efa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("199c9735-1e79-4e9a-98a0-3df2636d3c83"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("19bb5dcd-8f82-4326-a66d-e796fcb266e2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1a19dd2e-b11f-436a-bb09-15b8201853d7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1a418be5-c05b-4203-8a3c-ad2daa8bd0eb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1a9182d3-9f8d-48bc-874e-48f67cdba443"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1acabe7a-97ff-4d9b-991c-dbd58d6d575d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1acb0e18-93eb-408e-ada2-296cbdc1ce86"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1b120d3c-d27e-4779-8468-bc4cb5896d77"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1b264054-a60f-4bf9-933d-43c5e0bc1d60"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1b284d49-89cb-476c-86ec-4b6f594eabb8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1b922bc6-0318-4e3d-aee7-ce29852d88be"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1b97b19f-06be-47bb-8d9f-458c34a7b113"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1b98ad49-8897-43fd-a544-e6a839b328de"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1bb30639-f60b-4a1c-b690-c0f64676aa1c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1bc10173-6ad8-47bb-b800-d05615b8897f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1bdcaa24-a6ef-4df4-8f31-e0dfd8e1ddcf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1bde0745-63c5-421a-b81f-b802b66bf9cd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1be17e4f-f66a-468c-b80b-fa143c98b223"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1bebc43a-9fb9-4dd7-96b8-44996d1c5371"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1bf94ef7-5f95-4e3f-8bd1-3e9a822fd44d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1c07e120-9d2c-46cd-8ba4-7de56eb327ba"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1c786062-2fc4-4882-a514-d59a95d98268"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1c91068b-31b2-40fd-b0f0-45e72bc62a2d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1cb52388-e0db-4eb7-8870-393b6e62fa08"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1cbf69dd-bc21-4e7a-b3ba-4edd3410d336"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1cc95dbf-feee-44cf-9136-cf8605abefbf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1d1d6087-e5b2-4a1a-a7c1-06ec13a653f0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1d350287-b116-4eec-b4d2-6d8d00f19e3b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1d465e0f-5cbc-48e0-afd4-722fc0cc6da1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1d5c0ca1-c460-49fe-a137-f2e18227ebd2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1dc194db-4fa4-48ad-8b7a-d7e21f1ff6de"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1def4f1e-376d-435c-82ff-e6481b1005f7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1e2f0c86-c546-4c55-a483-171dede6e0ca"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1e5b8069-99c8-4b52-aa5e-a0c2c37b7e64"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1e8a15c9-858c-424d-8cd5-ec233bb6a6c0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1e8b4ee9-f644-4a89-94f0-4dca0bf8407c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1e9073c0-8260-482d-ac20-4089abac8a04"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1eaa1b40-4a91-46e9-949a-25b967c19313"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1eb0cc5b-5aca-494d-9ca1-1e9b1feda0a1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1ed1cdc0-2522-4125-a6f4-ceee5a386826"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1ef3ecf0-5578-44b1-8f09-b40fef526892"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1f109090-2537-4f35-be74-c31d9396f0ec"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1f216541-4504-4207-9bf4-a8549c66ce14"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1f8326ca-903f-4036-9ec6-4e4a7fdd4285"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1f880038-2d25-4142-9026-f36ec9701703"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1fc29a68-a6cc-4824-bf48-0024c26c715f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1fcf14d9-aff8-455e-8e7d-49c97a838dab"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1fd574bc-2238-4925-9abb-f0ead5203fc8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2000a073-1dc4-4e2e-a337-6c3def376353"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2013ef81-27b1-43e3-accc-93100ec85b8d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("201c4b81-409e-4cf2-95f3-cd3c6f65bd47"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("201e83ab-8310-45da-a245-a505966c93c7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("20291cf8-a152-4034-98bd-34aa5e6e246e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("20354207-3c43-4301-81aa-c469cbe0f728"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("203dfff1-03b5-4144-b6a4-70d2e25899da"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("20486d0b-17eb-4835-a4c0-43ca108a6ed5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("205c9edb-97f5-4886-aaaf-ae6fad92f1e4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("20810f03-a868-4a19-91b6-1323e387c444"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("20e48c4e-31d1-4bc0-ab53-55146a214f3a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("210812ee-3e63-4e29-9235-48569f2b6114"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("210a3111-b389-4ee4-9d20-553c5e7add54"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2136ebdd-6871-4e87-855a-7581ae967ec8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("21505f85-994b-4c67-93c0-cefd1d51f3c9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("215f40d3-fd34-4e5d-a7bc-4f6ea62f72e7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2190214d-578b-4122-9964-f40c2d7f8b42"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("21cd8ab1-b531-4c04-b12c-612b17ea526f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("21e7d34f-e02b-4ef2-b480-16ff82507749"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("21fee6dd-2014-4a81-a1b2-a6f03b2bb145"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("221f947b-6848-4061-8d7a-3379dbf13215"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("224e5d8d-9dc7-478f-8859-e6502a76f03b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("227f2a0f-4b87-476c-b7a8-89d758117f12"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2298e65d-5686-4ee0-b876-feffdbac450e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("22a3d511-cc8f-4e2f-a69f-2ff725f12f3e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("22a41efd-d6da-4931-a659-a86897d0dad5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("23075e9d-55f0-40fb-8c4c-047f119d2c19"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("23438491-1f45-4b0d-9783-bf08afac8521"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2345a9b1-927f-4c91-899e-6d10c77bf8be"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2345e4e1-ce4e-4a9a-8459-fba33b80a515"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("234d4b45-baa7-42d4-bd4b-f8de867929d5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("23562d35-2437-413e-b248-0f1fe17b364a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("23621b88-882f-40a1-8e92-7dce6f217822"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2375782f-24a2-426f-9cd1-90ca997107e6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("237bb29d-d395-4e2f-9481-9d92940d6e5b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("239a2dad-2d63-4bd3-8df6-b16c96d89030"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("23d6711a-d4f6-44a4-a1ca-2f26337ff8f4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("24131897-4746-4747-9a8c-cf605ae313d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2420f063-12e1-4386-821c-0aa16652f10f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("243308dc-e586-4e0d-ab9b-d9ed35e2e6aa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("24545527-3cfb-478b-890d-26311b429de0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("24801ac0-c5e5-484f-a987-9afc39a647f2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("249b1e15-d338-4580-b873-349d14f1906d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("24a22b73-964c-43b4-81c8-78c42ceb12e3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("24c6ed93-65f4-415d-b27c-3f14ed29e1de"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("24d7fe09-ee16-436b-8fe5-1c1613945086"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("24e551af-8788-4d18-8e8c-b8a475d4a5c3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("250deeda-8116-440e-a69d-ff0d0e1c10e1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("251c07c4-277a-42d9-94dc-6139be5fa3e8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("252f2817-6d18-4d6f-924b-b29b28bd186c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("253db183-2f35-4f3e-be79-a351df71c4f2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("254412ab-3000-493d-9950-17fb34734851"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("25aff3f7-f908-481b-a051-456e039d43be"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("25eb98c0-060f-41a5-b692-12d7c4ef75d7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("25f517d8-9c09-4195-8ee1-4e6a54a6626d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2656ddaf-9ce9-44e2-8a84-7138fb375e3f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("266a6f55-2802-4e3e-97d6-33ad84b92742"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("268e2644-e7ae-4bff-ba43-7386cad1025c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("269bfc6b-54c5-41f4-b951-16ff08585c9b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("26c770c6-7c48-4347-b1e6-eca81fa107b5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2710fab1-0db0-4e9e-b4df-9e44dbaac37f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("273159f3-59bc-4269-b6a8-92bd593d0754"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("27704c9e-90b7-4286-b2b9-9019a39a5e20"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2798c6f6-fc65-4af4-b29d-e5acde972e1b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("280f14c2-f6e4-4188-961e-cbc372000489"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("28314b11-41c1-4ee1-a1b4-f09de75f7c25"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("28634910-17d0-4a0f-8afc-71cba2cface3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("288b6679-93b0-469d-8627-e9ae063a0cf3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2897049b-64ab-4d21-aee3-504e28f92da6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("28a8e672-333b-44d2-bcf6-71b5a0fe1244"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("28ac5a7d-b4b6-443c-a3a6-9227bdf0903d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("29061de7-c141-4f23-9b8b-c5dab4e5198f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2925fb1b-70b2-4f4f-8cee-8d13da5135ad"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2928acee-164a-4de0-afe0-194215dc5882"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("292a89b6-5224-4499-b014-cf411c9ff04c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("293efacc-a455-4afb-9421-fed286d44657"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2954e4b7-e84d-44c0-8d0f-4b22b09d7093"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("295c06ef-7458-4511-af3a-22b6c7ee770f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("29a47bce-b83e-489c-9780-f290ba3cedc6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2a533afc-f07b-4092-a471-c866246c9a81"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2a688ea7-cc72-4222-a91d-b8378690622f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2a88f91e-5dc5-42ab-b9fe-daae9dbf32b0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2abe05a9-4cd5-4144-aab4-1d237c87661e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2ac7fde2-589b-4eec-9a3b-76da213cdc53"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2b173aad-5d99-4fcd-81b7-8804689d14b3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2b5ae185-1d61-4ba9-8c5c-f39bed94afa9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2b6385ee-1398-4fe4-a42c-9a64c7100717"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2b96bb72-3d8f-44d0-b2a1-ed6aa7816a91"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2bb15cc6-e89d-47ec-b994-cdd11e96516f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2bbb1a9d-d459-4ea5-ba86-2782b7bc2e86"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2bc90f61-a221-4d95-9518-06aaa9afd12e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2bdd9240-ad6a-43bf-b510-c8cf9c4e1ee6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2bde46fe-3480-4dac-ac06-8d6db21f697d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2bf60197-2f9b-4ee5-ae04-8a1e14c5e00a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2bfcf0c2-9366-4c78-9668-581361050f02"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2c253367-d715-43b3-bdfb-bf182b611681"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2c33005b-5d1d-4de5-88ae-9cbd938bc935"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2c752f30-8a0f-4db6-a2f0-5f2dcd14e5a6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2c97d3d2-d7ce-4e9d-81c5-6088bda97255"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2cb29176-1f76-4b9c-b090-ba15df1dd4be"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2cb58335-e4d6-4d59-bc3f-9bab60c59496"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2cd02ee5-b863-4c2c-b06d-4fa1e52776db"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2ceacab1-0aca-4fb2-9c9d-2cf28eb4b787"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2cee9ecb-144b-4144-ae20-6f1a3f7429ae"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2d3b3367-4a1b-4df6-a3b8-64651b88389b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2d898804-de60-4b5f-bf21-13befe0f3c4e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2dc17063-8e95-4627-86ee-41aa21116a21"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2dfee8cb-4005-4535-9337-89a21c99fa64"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2e0183e7-0879-4e3e-ba2c-714986777f2d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2e1c3fe4-5157-470c-b11e-0f74da662b9d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2e1de986-6e05-43b9-a35f-b74e860c6a34"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2e24586d-ac82-4327-8aee-5a7a73fa6a21"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2e29e67b-e4cd-46c3-933c-493cbfa88d98"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2e4d5438-346b-471e-8315-f230ccae4744"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2e847c18-cd10-441c-8f2c-acd12185b6ea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2e9aed52-b38d-4b4f-8fa7-168a167e92b3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2eff9983-64e8-44d0-8035-43aa880e53c9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2f59c23b-c2e3-4ba6-a7cf-c3c8ca9d0df9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2f6cd70a-7a45-410c-9aa6-1c19ee641643"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2f7b8eba-1972-4c6c-9620-b9bdcb794c44"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2fd51fc4-3929-47ff-8ac1-7179b2614a2b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2fec837b-826e-4066-8bc0-8bb15fa743f2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("30142eb8-8592-45ce-ba12-16e82f369e78"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3046d229-3b66-4fe8-85e3-f0749e3cb65c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("30738c56-d541-486e-a613-c68ada0d6abd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("307ab271-19da-4bfb-8ada-b5ab6feb2acf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("30cdc9da-b265-476d-ac49-2bab12777582"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("30f229f6-e25c-4535-aa1f-9d52c73e1d18"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("30f9d1d0-caf1-44bc-8ca6-cc582e32c637"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("31017c55-4dfa-4649-bc35-cdce32a0b654"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3123cc6a-fa6d-4f0d-8017-7e0212fecc74"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3129da4c-56a5-47b1-b6e9-91a12095dcd8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("313e37c7-b27e-4c88-9c80-024ee723d914"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3142468a-161f-47ed-bb5c-d73d45e65f88"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("314c9e47-3751-4cba-b88b-0ebca121d074"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("315ca71c-b4fe-4836-96ef-af270a24b5c4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("315f22e4-86f8-4503-af58-710b51f4a157"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("31771ec4-5acc-40e2-b4d4-1cb19fffc06c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("31925257-246b-4f00-9cb2-4b33732e134a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("319d536a-6f0b-4e53-b615-004d2175596a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("31c65b75-4c1b-4089-b795-05eb4e83a350"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("31cddcac-81f1-4edc-aac2-54b7289c9e98"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("31db46b8-6268-4b13-a517-9ac335b27311"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("31f9dd07-eb1d-43e3-9584-af1ec1c3f1a8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("322ff59a-e8b9-4aac-b235-7a722fe14e05"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("323bcdfd-ad99-481d-bf76-4a690c0df0c3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3269a27e-702c-41cd-83e6-f067f32b6790"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("32a4a98f-2f11-40d4-93df-5eae01fc9052"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("32c3bf41-05dc-4417-840b-d31acd9c254b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("32ce9e6a-a62b-404a-9621-bb5e24c73554"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("32ecb171-2b2c-4a61-b5ee-f097db6d13c1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3318fa98-4b57-40c6-80eb-f894d1112b4c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3336e47f-52bb-45e9-942a-b466ea300b0a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("333858f4-8814-4d17-8ada-3de85925022d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("333b7f92-8f90-4829-8185-6cbac2dbe859"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("33414464-ab66-40e9-896f-00299ef51bb3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("337a8d33-f93e-4847-801c-96b1fbc16b31"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("338d7f1a-dcc1-4f0e-a85d-3677c0e8bdb5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("33925165-b80f-4058-a4db-8496bd72dac2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("33c4ea2e-59e6-4be7-ac44-0386291a6a32"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("33d81390-9d45-4b74-a429-e57f33c50f09"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3404dbf7-f4d9-4722-a4c9-a3386eea4299"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("340f577a-8732-4795-ac56-767a2dff891a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("344a2415-0a7a-4c20-a8ef-8c9edd143cb7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("344afdd4-169c-4d83-b9d1-a7ae497f3d29"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("34748775-ac09-4eaa-8e4f-d15d77cf9e58"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("348e24db-3038-4e5c-a9b7-ef2aae604431"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("34992c97-db64-44ec-96ab-79fdb23269a5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("349d3a2d-2bf5-4944-86f4-f78f3bc5585c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("34d87c00-1f22-49c4-8345-696bc1f58ebc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("34ddacb4-2813-4abb-b12c-b78a0c89899b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("34f2ae6c-64a9-4619-93f1-789de47805d0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("34f93040-4ebd-424a-bbbf-57c5566621c4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("34fbb1b0-ee48-455e-898c-b27ba79d7ff6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("35218206-6806-483e-b655-9ec5381a85fe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("353be00c-ce3d-4672-ac8e-23dee7f14285"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("355fa734-dfa0-4227-a6ce-f00ab36fdd0b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3562b9af-6d42-44d9-866f-c7581b98016a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("35a2a2ca-4ab8-4734-baca-c55be2d2b847"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("35a48e86-8239-44d5-b2f8-ae6b0a1a3a61"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("35b11d37-e50d-4b29-9f98-0880ff303ef3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("35c9e05d-31e1-41c1-8b67-e4136a7f1e96"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3601e0a1-cbff-48e8-ad03-67530fe0ba2f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("36083f48-58bd-4df4-b507-b3bf000dfc24"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("36457693-2c5e-437e-9388-f6ba9cbe616b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("366ee1a1-a2db-49fb-a19c-b0b984e7688e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3676a73a-f1cf-4b2f-bc93-3a4b730f81b8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("36838d1f-6544-4d9f-8337-53d864c1a421"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("36ab4630-2b37-4de6-8d40-c4e2396947e9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("36ace506-67d9-4a15-99db-10c2ddff19e2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("36d38abf-2245-4738-9692-a101c31100ef"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("36f1c557-fe5c-47a3-bf69-ab5ca34c4b19"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("371f7a74-6e8f-4234-b3fe-61448899e1a8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3724efdf-1f70-4357-9602-48bd15289b17"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("37335877-c8a6-47e3-853c-5e5b6fcb12d7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("375b6896-2564-4556-9782-2cd28368481e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3769c6ba-806a-4b36-9cf6-262837740fb2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("37995aaa-3e63-47e8-87d9-665f6f9b879d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("37ae8530-769b-4204-a4c5-416b0f67f9dc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("37be067a-db71-4694-a6ca-99ab5c17bf7e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("37c1b1ec-8e9f-4333-8410-616ab63da921"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("37ecf469-720e-4e96-9cd5-f8e09076ebb1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3857c681-174c-4223-ad60-855ad98d3b79"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3882121e-0291-4d14-969b-b08406ee487f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("389a5f56-9e0c-4f88-9509-6d4b60e073b9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("38a94078-e755-43fc-82e9-4f4c706df2b8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("38abf0d2-e8ac-44aa-b35c-009f41e85f4c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("38d0e049-404e-4f73-b181-a9a947e2e8e5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("38e816d9-528c-4461-9b4b-cfd4566d77fa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("38ede79b-03d0-4fd0-bdaf-56ead1ad4b52"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("38f086be-ca4b-420e-bf34-b80f833ab344"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("38f3d1f1-b5be-4fc2-bc07-3c73e627a73d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("39236883-acf0-4e56-a132-03dd78addb98"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("393cb81d-bc43-4775-9982-d694a6dd77b3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("394da3c6-93fc-4232-b40a-2fd2e7f6cafe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("39830909-8f2d-4df4-b421-05f2068ed1ec"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("399b222b-7df3-447c-bc64-da7f4bdc149b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("39af68e3-fb0e-478d-8cbd-0ef7e0e5bf38"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3a00a32e-462f-4db6-bfe6-1845f588c7ab"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3a220282-7365-4758-8e97-5ee428a31cb0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3a2218c2-5a16-453b-ad52-77ce1019a1c2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3a45af45-579c-4b2f-aa0e-0f52c6e31c4c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3a62cac1-3e9e-4683-9ea5-a4dda743e17a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3a671a8c-3975-48a5-835f-d359c33f3e8e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3a6c8807-6c7a-4f82-9d1f-ff3b8fb56b77"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3a839f11-6b6f-4a22-b01a-b2e53af48717"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3ab3c590-160c-4639-9d8d-b01e7aa55888"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3aee921f-120e-4dbb-80d7-028642376aea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3af0bcd6-c7d9-4018-8cff-b513ba337487"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3afb66bc-03cf-4318-9722-f8868ead08e7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3b2d80a9-c9cc-4f37-81fd-caa883c70ea1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3b4bf0ad-aaae-4177-bd67-faf48afe06fd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3b5bd984-711d-4e29-a5bc-5bc77edb6b6a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3b67ba5e-4471-41ab-a839-fc74f222f2e3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3b6f4a1d-4211-4a2e-858d-628e9e5a147a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3b72859c-571c-4d8d-bba7-73a304a4568b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3b85954e-1c11-42db-b95b-2689f843b02a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3b967895-e116-488d-9240-8c13e77bd006"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3bad03ab-9bde-45ff-8b4b-27dc8b390236"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3bd21cf8-c558-4026-a57a-43c06af4524c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3bfaad8a-2463-4310-891d-9538f823ec74"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3c28c989-8ccf-40d7-b6d6-962196a88571"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3c59aa3f-80d8-4538-8468-b047efee9d37"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3c672ee4-8759-48cd-8418-d6c320389baf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3cba84c0-a2b2-4af6-a448-8b9fa0c479fe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3cc7b29b-fd79-4d3e-bbaa-426c597b541b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3ce1a8f6-1cbb-4ffb-8850-dbb0627dcbf0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3cfaaff5-f697-4be5-a3ec-f3166dc29336"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3d892812-401e-45ad-b416-9a911ba12ab1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3dc1979f-e678-4522-b927-03f8ee12300e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3dc1b274-d2da-44b4-9663-f5b338ad4e25"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3dd8e68c-3a69-4896-8037-fc3faf81b8c1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3df60942-0c9c-4a25-9157-c8bc8067453c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3e0ecfc9-fd2b-4b91-a67b-78b3d1d846a3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3e26f161-2d52-4973-bd5f-026c0c0b8d81"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3e3966f4-f454-4da5-938c-ae36eb64eef5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3e3cb7d1-8b32-4aaa-a0f2-616824d6a49d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3e3d8e81-46d3-43de-896d-5f2d029f2dbb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3e4f0d0f-3830-46bf-a0ad-6787f8b3b7e1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3e59725c-b8da-45dd-9f40-6568ed3f9496"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3e649a71-ef4a-4607-b95b-ea1e7a0ddde4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3e97d477-2e80-47bc-a102-748f4848c92a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3eaaa550-fcfe-4773-a081-acfecf3dc41c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3ecd2ae0-031f-49e1-8098-1d6beecebeb2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3edb312b-6b3d-4a8f-a7f1-3f167bf2d11b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3ef20c7d-3b48-45e0-89d2-022cc1bc3a22"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3f2c110d-d7f5-499d-8e7e-6770fabcbe0d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3f8a1db2-033c-4c88-9abe-a7a990119a1e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3fb9388c-ba14-42b0-b0a8-b84c74f80e67"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3fc20b73-ea09-4633-8377-f4248b765303"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3fcb6f9f-4422-4db3-a164-7cb3e88de99a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3fdb6153-473f-47e7-9166-e1b5a5639659"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3fe45a83-a900-4f6d-838d-3f523a3c7dd5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3fec168f-70f6-4cc2-b7b2-c9c5126a7f16"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("40072db3-5580-43c5-a84f-9539162087c8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("401275d5-1d69-4a39-a914-e0563b13812a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("401fa980-754c-418b-bbb6-29834a5cf35b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4049bc5e-a6b7-437d-94b6-27f643a83131"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("40720aa5-d2cb-473c-a864-c0732f06c148"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("409c9363-3033-4018-9720-95903a2d9be0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("40af0ab5-e575-411c-98f5-e065ed8438f8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("40d2aa01-2b60-4487-b008-2a1e3721564c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("40da6756-c6ed-4f05-9b58-9a1802aece47"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("41136d64-4119-46d2-9bb4-89f61acd6814"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4118386c-8a8d-4a54-b81f-596589915b1b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("41348964-396d-4b53-99d1-2a6263d0a8d1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("41475c8d-1efb-4d2d-b706-87f0bc53cfd9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("41750d78-9b4c-4d41-8e7b-23debaba4a95"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("41ebb73b-ac89-4b99-8848-5157dd48acef"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("42214b68-137b-43b7-b58b-fe6695569b76"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("42587e8c-ca25-4dd2-af28-65aa3cfaa452"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("425eb9f2-c1bb-4158-9db0-285800cf01ca"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("427b1ce1-1b4b-4a3f-a550-981ad2869ad2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("42b0fd93-5d33-4817-ba9c-a5d4fe338882"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("42c5bbe8-720c-4785-a754-4a3c71eec14b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("42f9cf95-2e2b-4ec8-b20b-336915ecd730"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("431b1891-7be1-403e-870f-3390be2c907b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("43274396-293d-40a2-9d73-ebebb1450bf3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("432d8582-f228-44e7-a7a7-f65c36be53ea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4358f432-815b-4dbe-98ad-cc2ad53c38b7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("439da1a7-5890-4e5a-9b77-b05251a00006"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("43bc680d-9e5e-4916-82aa-848029e624f3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("43bdc4cc-6c02-497c-9feb-153b1e72d0a5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("43f0c884-8868-4183-b490-30299808c664"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("443a8710-fd3d-4f00-a9a1-e1aaa79a373b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("44a605af-f04d-4ad6-be17-8fdbaf1233df"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("44cf334d-f419-4d3e-a5c4-c18b9baf1e43"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("44e1e68d-22fc-4a57-b041-af33c74cba69"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("44fa3bf1-38ef-4eb2-b81b-052da0035810"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4508a3c2-024c-474b-a3b9-370c42517eb9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("451d56df-1fff-475b-a740-6eaa6c441022"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4520e74e-1a4b-4ff3-9705-f61896534202"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4525b38a-4578-4d01-beb5-00760e3aff23"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4554350d-8dcc-4590-a288-cabb4ab8ff28"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("455e0890-b24d-41e5-ba0f-cb0148613646"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4569d25d-1fbf-4bcf-b2ca-5eaa375674ce"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("45725bd8-251c-4488-b751-64ab01bf6707"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("458ef455-e3f1-4b09-9359-4210eff29cd8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("45bc22b4-7fbe-45bd-af8c-502df76f473c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("45d6f964-9749-4290-ad1b-b83d412773c6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("463f1bab-d762-4e33-90bc-30e831ee6f45"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("464d0487-8479-4a98-93c4-675ada1bbeea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("46741bb2-d5fa-46fc-8960-4d0b559f9a75"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("468aba02-f5c8-4129-8c81-0045b2d3704c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("468c97bb-ec95-471d-91ae-c666e5a580e5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("46aa0f0e-d851-4305-b93f-941c45720f68"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("46b8329f-7d96-4602-9ab2-eb190bfafede"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("46cc42ef-dd72-41c9-b490-6ba0cfb421e6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("46dbc339-c3ef-47a2-bf2f-4ed5692dff52"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4714f846-9a20-48fe-bead-a067b20f9839"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("47180260-9534-4b43-a6de-467f01508139"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("471838b7-173a-455d-a9d5-a756f8012ce5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("472d0d35-756e-4801-a810-e30b2cabc946"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("474276ed-1ef8-4de4-9af4-2f6f465924be"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("478275bf-1f1d-4edf-abc6-d628f78eead2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("47953655-0597-45d4-aedb-efe5410c19c6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4796ffb9-efa7-4005-91cf-11169e1828a5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("479885b1-fc7c-452b-9323-54e0598063b4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("47a5b653-5025-4aa4-88e4-b9be88457921"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("47b2e70d-01ca-4136-8f3a-09e914af4d0d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("47e22bbd-20ef-4ca0-9f84-7e0f94120acf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("47fa350b-69c9-407b-ac92-3803d6df4ea6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("486b7013-edad-45cf-afe0-9c8a90314a8b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4885ef3e-f5a8-4765-9d2a-c712520d4460"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("48ac7538-27dc-4f71-9df7-2e8e5a42c911"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("48c7bc3f-24d5-43fc-9b1d-971c20d0836c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("48ed6d4d-4af3-4dd9-b747-cf182d1073f7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("491467b0-fc3b-4473-9728-87416ee12789"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("493f92a1-8b4e-476b-a700-bca30bf22643"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4945be52-675d-4a35-9b96-2126b8a7605d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("494a18d1-6d4e-4fb3-8484-82d6d93b0400"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("494ba790-80ae-47ff-881b-7dc01fa236ea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("49580e1c-87a7-4ab8-8a48-3cd091981f93"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("49764dae-db7c-4262-bbaa-090614eed7ca"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4976b515-a1cb-4fa8-87b4-5000ce1596e1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("499fd706-5914-42c0-85c2-9b520e2bc27b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("49afab94-a73f-4cf9-aaf5-b4d974916a87"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("49c04557-90e4-4847-928f-d99f5363d02f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4a1cf7cb-6f54-4253-b1bc-7b561d3822ab"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4a6827cb-b4f9-44bb-bd37-2c0fe6855b1e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4a6ec0b8-6d10-45e6-83ab-3db3b515934d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4a7c04a1-f236-4376-9031-e848ec546929"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4aaea1c0-4219-4ee7-a180-ba42032db696"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4ad26278-1b7b-4c19-92d5-0037ff5d85de"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4ae45525-cf5f-4953-8182-cc278ab32471"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4aeef8d4-ed9c-42b5-8fed-8a43b49f47cb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4b003fd7-b112-4c16-9de4-44e2db349d9f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4b2bb3e2-dfec-445a-ae99-c21d0d1f6bad"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4b6819bb-fd64-4884-9fd8-72b369bef486"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4b6d875c-1c7c-45e3-b6cd-d3b80f0f5121"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4b8301f4-78f0-4d0b-b0f9-a129a3e175b1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4bbcde97-766f-441f-9734-f78124770620"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4bcafce0-c44d-4280-a293-1d73b129b38a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4be68743-67fc-4a30-a2f2-201f4ecfd359"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4bf1ca9a-1f24-46c3-8b82-57f6c5856701"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4bf801d3-b184-43fe-a6f8-a05620cd3733"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4bfab932-790b-40bb-a864-82513c326e51"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4c4725d8-c11d-4622-b365-20aca5aa7110"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4c600e27-c274-491a-8822-468cb0b294bb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4c7c0976-d0c9-4fbe-adc1-24515811cb84"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4cdfed52-27b2-408e-bca2-1b91dc709e42"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4cf4a5aa-5165-4198-a06e-13faff350f4d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4d27b5f8-807d-4c7e-a96b-6fb9269b53a5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4d40210e-8fd0-4535-91f1-2d95fd03db5f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4d4b6f67-ed32-4e22-acfd-9380a3f20edf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4e0626ad-89f5-4d71-80b2-b1725ee990a9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4e38e694-4f15-48de-b85c-f99d84696035"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4e3c9398-5206-4abe-8bf9-bcc3f1932f4d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4e417340-bc55-4e4a-9f74-128d549ba5eb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4e4a6d82-0091-4f8c-8783-1cf43dda4773"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4e53576a-fe8b-497e-86d2-eec33b310f78"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4e8be951-3e21-414b-8c90-4d0961501142"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4e9ccbbc-fe6a-4da4-a449-f3edc69e8ae2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4eda7f30-64ec-49ea-99eb-530fcc61eec6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4ee84990-8843-4530-a02d-e11847313dbe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4f0a5d2a-41a4-4acc-ba26-b08b48b130f9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4f2d8411-32ce-46ed-9444-30e2363fa878"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4f68342a-2683-4363-8fdd-417957a446cc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4f8edd10-dd34-46bd-bac7-715775115d62"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4f9476d6-1cf5-49e3-8746-1812b4a12808"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4fb3b3e1-c274-4a87-a905-aa0c66ec5687"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4fc52404-2721-4c89-8e27-ed589b198c10"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4fd94d14-c4c7-46bc-b9a9-f711d9f015f0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4ff1be0c-5196-4203-ad3f-90465ad369fa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("50134d98-5db8-44c0-b6a0-9f3942b78634"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("50284a6a-b5e8-4087-a430-3537aedd106f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5038c9cb-b205-4fff-8d35-5f524d081d0b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("50443d7e-e28f-4918-9a13-edd516cfa58a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5055f0ea-b07d-4aa6-8e96-156dc39c9aff"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("505c8d2e-67d3-4951-8bcf-bb0d3f8ea0bf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("50698675-1e02-49d9-9a24-aa8f1e5b4e4b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5077f817-6290-435c-9d7e-15bc13391382"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("508d1ebf-e138-452e-9baa-66e6c0103a5b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("508dd013-89e5-4427-8c2c-c582c7303096"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("50a7965a-59df-4c21-a731-9806aac41337"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("50bf674c-d314-4a4d-be86-69ec8f431beb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("50d89383-5b13-400c-8ede-3a32d6877e03"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("50def404-b4d8-4354-8434-d44f1be2756a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("510ae321-59e2-42b4-a8cd-500c20c48ede"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("513cc747-fb2f-47f7-9c81-b852f5631bf6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5180a298-cbb6-43de-89c5-ac545cb4c9fc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5183580a-2b86-4702-91fa-c26135609c33"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("519f9828-4315-4fa7-9b0b-322de2c4e93a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("51ae5728-2b97-48ae-9224-b57ba142b4fa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("51b30609-fe35-4c70-acee-c769cbbdea30"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("51d8c6b2-c485-412c-8b0c-2eb3bf17d528"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("51e5a09f-8377-4f15-9cb7-0b8f2f2eab2f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("51f6b364-4d04-4bc7-8629-45c578d119e3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("52012ff7-0788-40f9-b7d0-1f0ef8207102"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("52176eb0-9a7f-44a1-ac12-2e40742cf0d8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("52272fa8-64c6-4193-980f-977e060af6d7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5237090f-4dda-4fe0-860c-9c427af2382e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("52472a30-280c-4994-bfd3-f41102cd689e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("52541a92-35f3-4c1d-a953-0e4aa6d5448e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("526feeee-d1c6-472b-89db-c66c9f14ac75"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5296dbca-3a20-437e-8256-2989b909f5fa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("52b4bb6e-f175-48f2-83ce-bca2c5655867"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("52ba14b3-8e41-4742-81f4-d1a571df690b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("52e4e7d4-0469-491e-931c-cb5da4b5d645"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("530f4c65-74f9-4af5-81cb-958c5e8d3716"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5336bc53-f1c7-4e62-9b19-04254d7e62ed"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("534c0375-9212-4af0-9d73-7f5801593c80"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("53505feb-c8bb-4f12-bd76-3b86f166014a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("536ef38b-e548-40f4-92da-e4cdc32fc957"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("53850a01-8709-42d0-9593-4173d9714563"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("538c26de-afdb-401c-ad3d-e5d98cf83588"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("539bf949-e413-4d2c-a23b-8af78da7b61d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("53a9d24c-a831-4bfa-be14-2e30b55b2b52"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("53c5b8a5-8b0d-42b8-a3a6-da7ea59bfa33"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("53ccfd42-26c5-4b31-b27e-3e4655ac7e70"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("53db968a-e95c-44fd-ab9a-77418c17f4ab"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("53fb394a-2dff-4999-9b85-9241c9ee206f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5401ab84-ff30-4e97-864c-b54562b04599"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("542a3abd-7640-4a6b-a83a-aed64caef241"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("54357c3c-61d2-4789-867b-37357d07cf6a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("54396a5c-0e72-4468-910c-3efb72fd3f0c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("54ba940b-bf06-4f83-98dd-e5e7cbfb5b15"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("54fa8e66-15c6-4cf4-901d-7523af73649f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("54fddc26-3c3e-4883-b6a5-4f79e0b864e3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("556c1bbf-ebd2-4e3d-b6d5-0ebfab671963"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("55809631-7a3c-41a5-9bbb-ad2ca794f1d1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5590e5d6-ecad-4a45-8dd4-97d7b2d9923e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("55a1c7f3-6526-4500-a91c-6b9d4a434a66"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("55a54c93-c2a1-4456-a560-d8c215349b37"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("55b8d112-c988-41db-8d46-5aac83b77024"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("55c1498c-7274-4f23-b9e0-5f22f2f98afe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("55d69a0c-867e-4703-b450-384fb5643b8b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("55dd063c-1a0f-4a57-8d21-6b94fb5c56fb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("55e6a97c-1f63-485c-a13b-40e02f3dd44b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("55efd777-845c-428a-8a99-04c771fc4441"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("55f88da9-1c15-4fd1-ab11-f581a381d150"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("561dc3e2-7e33-4279-85f7-9d3fddcf7c8f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5634ddb7-af3d-4bb0-bd92-6a5323994342"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5657c7fb-e284-4041-b9c1-4c3b72e7d9ad"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("566636ca-0544-448a-8338-ace8912d2480"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("56a6280e-3a6e-4594-8583-19b9e26ba6d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("56c87415-9684-4735-ac45-4dded6bea067"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("56ca5dd8-017b-4d03-a4f1-3eb0f99a45a2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("570f9b99-9c30-452a-b9c2-7facc2a140b5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("57319947-29f9-43ca-abb6-c651a554ade2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("573f9848-6474-4c68-86ba-30f63957dc6c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("57896a4b-8d72-47d9-bf7d-65d087e60d41"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("579879c0-6609-4ba1-ab05-82878c130e9a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("57b931aa-7e81-4f7b-a8f1-c14a7dbb5954"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("57ece2a2-bbe4-43c1-8ffb-297bf1367468"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("581397fe-9ee0-41c0-82a2-82bb032176fa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5830df13-99f9-431e-bd09-f30e072c3551"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("58483372-bf4c-441f-9829-5ac3d59cb84b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("58610c69-1e42-4d59-8aaf-7bea56d85a22"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("58a7bb5a-6c01-4271-a73f-bfaf919508ed"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("58c9af27-817b-4f51-bbd3-7e934653a2b5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("58df9a91-a87d-4cf5-84ec-54c1838281a1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5905161e-5570-4dca-88f0-c57ec89b400a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5935ec2f-6b62-4b6b-8673-1e6e68910cc7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("59883280-f559-4e98-8c9b-fbbffe79f61d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5a1fff79-d036-4e52-b564-2ebf530a9c30"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5a24deef-67f1-41f0-be5a-07f2c16a6bac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5a424cc3-9e3d-48ec-bf72-4cf26c006f0f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5a65fdc8-f029-4b5d-8d32-2f3ec38d476c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5a84d2ed-9f2c-42ee-9e36-bbd6a08abfb8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5aeec8e9-79d0-4884-bea5-af26bddf75a3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5af2aef8-073d-4a46-a3c7-c01c9d7d22f5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5b006c28-315b-4793-bbc1-3dfeb038a7da"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5b2d6097-760f-4547-9bc4-809132fb0e47"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5b436058-368d-487a-88cc-383161c8307b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5b58f496-ab86-4748-874b-77df8efdb1d4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5b72aa71-fc9d-4ef8-b11e-bd4aed51b5c3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5b8683a9-409c-48fc-99a9-f6ee11c69549"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5b9a3619-7668-46e2-a758-fbbdddd14959"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5bb3c544-762d-4ef9-82bf-297a9c277d80"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5be8ff36-5464-484d-859f-aa896cd17dad"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5bebbd4e-1a00-48f8-8a31-fafa2a214280"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5c09e8d9-c678-4d16-8482-6b1b50ff7286"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5c255566-f9a4-4cde-8f54-885235aefee9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5c45afc7-e519-483b-8862-182d7ec5839c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5c7ab5b5-3367-40ef-8dc2-483cb5473755"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5c9714c2-fefb-4eb1-8f21-60a493428e67"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5cc3ed69-263a-48c3-9826-c5f2fdbc3c39"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5d035cdb-8060-43c9-95a1-baede287faad"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5d18ed24-aa87-4ab0-a1dd-be8a20b9f952"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5d2b2ea7-e605-4797-ab00-09b97428de38"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5d35fd5d-4d77-4e69-9f45-936e9fe3b698"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5d412a7a-3e3e-4565-b570-e7e69083c7d5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5d8404a1-bf17-4d3f-b1ee-f2cfa8de80d0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5d84cb13-617a-477b-9f72-b19a8f1c4d13"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5d93cfc0-8b4f-4532-923d-308e694b109c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5d9838ea-7acd-43be-9941-a666fc1aada2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5da9078c-0253-462f-a5c6-5ca77cd2c3d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5e1551f6-0aff-4829-8109-5a52e70b4696"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5e260ea3-1867-420c-905e-df8790892d46"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5e38fc50-abbd-42ae-ab29-b3dc5f2373a3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5e59d2c3-b684-4c07-ad70-262365dd575e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5e8e9150-dc42-41e6-8758-2ec6611c5919"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5e977a08-ac5c-4c6f-a865-edd821d5b630"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5e9b7dd7-fca9-49dc-9ed5-10d46fdf8334"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5ebc8552-e88b-4c89-82bd-3c137f162332"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5ebd597e-4b62-4cdb-b446-91041ebd360f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5ec5bf01-fa35-4fd8-bfcd-8b9757c27eda"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5ece4db3-96b1-4cdd-9c04-107bac38276b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5ed06377-ed3c-4b9f-b7b2-4592fe5ebc2d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5f5e38d5-f691-4d56-b3d7-213c4696c9ee"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5f63ef54-a449-4399-b7f8-a66a434e58c8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5f837658-a197-4647-a003-92f317c740ec"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5fc74889-44ce-4c24-bca2-71d0bcd61cf3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5fd12659-9cdf-4706-8637-f0b827107f17"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5ff72b9d-cc43-4a48-abe1-1b28d75c5274"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("603d996c-c11d-485b-ba56-e3117763551c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6042e692-2bec-4cdf-b33a-a04c056646e1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("60645823-471c-4595-a4f8-c4388411f520"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("60a8157d-fb80-40e5-b7a8-15aa43595f94"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("60ae0cd9-be8e-4b2e-9288-e105e2fe1b76"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("60b5d9c2-119f-4c04-af30-f427b10f65e2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("610563c9-01e1-47b0-8414-99bf87d95350"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("61318378-e8b6-4f83-82ca-7b04078837dc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6171610b-74a8-400f-bb16-f93da2c71f2e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("619f75b2-66ca-4b2a-8b54-c177bb1aea37"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("61d7639d-c535-4f7c-9986-649f10efd43e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("61f114c5-9973-4cc4-8765-d9b4dc12bdf2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("62133cc6-9405-4ec4-be8d-41d67cf58237"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("623f254d-455e-4850-a3cc-9002ad32b677"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("624ceecf-6906-4650-9818-be274e2e7ba1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("62543263-f218-47e0-95f5-2e3574e1953a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("62631e4d-2db9-4bb1-a30a-4a0500ae0cd3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("62cf3c8b-3873-4703-995f-0becb83c76a4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("631645a2-85f6-4c27-a3c6-79e05a060704"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6335d4f1-f577-4058-964b-a08d837bd7c2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6348562c-1e75-4899-bceb-daafc0306ba6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6353d25b-d672-4e3f-b375-d08a43da9727"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("63931275-8103-4fff-9c59-434aefd82e17"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("63b7208c-31c8-4eab-8d67-c463c08fe32b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("63b9ed60-a70d-4d99-b97b-0ea9ff0a2811"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("63ce5d23-6079-41d7-8bbd-b1204567acfd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6407aa13-5fb7-440f-bf1d-4bdbc7567240"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("642645c1-1b45-4ea1-bb94-111a9c4192ce"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("64491490-b5a4-4896-8b0c-3383c0be906e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("644d1cc4-bf74-4e63-b18c-290c8d11bbe4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6451c40b-d4be-465c-bd88-5165e6d59a0e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6455c521-9883-456c-85b5-a61de468a2b6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("64626068-d10c-4286-9b70-0f2088720b0c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6486ef01-1834-4aed-ae91-44a2c3958383"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("648e8682-44a7-4503-a9c3-cbb5930ad69e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("64abea5a-471c-42cb-b9ba-632afed0c558"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("64b44934-3ff2-464c-a915-4c25c7b1fef1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("64c9dfd9-c9ba-4c27-9e4c-a49fa1e21d3e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("64ca98b5-a768-4ada-bc8d-5d38c386fab5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("64d3d02c-b5bc-49c0-b7a6-82d406dc07ae"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("64dfe97c-f7d0-4dbb-b3e8-25dbc982dfd8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("64f1ed41-ce1b-45b5-b885-c48d86ce43da"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("650cbaab-e6d7-4a0d-882e-0a0c457e0fe0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("653df837-9c86-4c0c-833f-10630acddbc0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("65441b5b-d73b-424e-82fb-f46b96c83ee8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("65535d11-cbb6-45c2-bd63-ad14ee51d226"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("658a42eb-3b96-4132-acf1-db04e304aead"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("65c9440b-eabd-4656-8417-2cc545499b3b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("65e7c97a-9d22-4246-9459-5ee1f5076fcb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6605b6cc-921e-4d5d-86ed-c92873651155"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6632f4f7-2d99-4750-b6fc-818804a4886d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("663ba296-8af0-41f0-aee4-c60e452006b2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6675e171-69b7-46be-b0cc-387b934858fe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("668e6efa-d988-4e29-9574-093fa8a98d3e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6697df64-43e5-49fe-bb77-7d3900b6b208"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("66a05878-56c9-40d2-a280-1f61630e2c97"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("66a8707d-a0e2-4739-91d7-dc6936c18d11"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("66b3cd5a-35f2-4df6-9710-a7f298896f69"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("66e52c25-daf5-48de-9ae6-577ce6e83f60"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("672f1334-9376-4839-b4ee-14ec07a77640"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("67531da8-7be4-4c91-be03-0819fbbf5e3b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6758eafa-9825-485f-92fd-fe5022e15cfe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("675b7f74-b515-49e5-8bf7-3277c8511d4a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("675c32fd-69bb-456c-88ab-a746ad97287d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("678a3a1c-0c55-4ccd-ab57-0e1f0d61ee52"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("67a475fe-0082-4652-845d-e0279cfb83b3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("67acf0c3-c2b8-4f41-8dd2-f539727c8b5e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("67c23e3c-e6c5-4271-b9ca-cf9fbd31575d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("67d176d4-0579-49f8-b2ff-30e9c7364c9c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("67d6e740-24b4-4e91-ac65-75a9ed1dd77c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("67e2cfc6-8a25-4734-b5fb-9c3fc5b6090d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("67ed5cb7-fe66-43eb-a766-697996c2fc6e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("681628e5-6cdf-4f3c-97a0-3960113a7da9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6820b10c-0ab8-430c-b3a8-b4ce82c18c84"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6827d508-251e-47e9-9359-e2543dd2ac0a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6832c9a5-d279-44d5-b1c1-967390d8b499"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("684b2970-25b1-4999-9ed8-f9f5499ee06a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("68663be3-7c20-45e7-9dbb-3f230bbc2315"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("68b03caf-375e-4d88-ac13-99877bafa0a1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("68b7f227-3860-4e20-bcd1-3ce7df2d8f46"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("68ea52ec-d5f1-4e22-b080-57b629311ef7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("68fc1fa4-6f94-4053-9513-fdf81b0b0d6e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("691e620d-0827-4a33-b984-16fcad584fd9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("69364134-ee87-4ee9-9a9e-f91e9191adc9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("694ec095-29c0-4000-94d0-01c4009cbc78"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("69775611-6f37-4e82-98e7-fac2e273fb2a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("697ac449-ca21-4480-939e-3feeb8cb1425"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6990540b-62b7-4bdf-b479-5d93035239c0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("69b742f9-27ca-49f0-a3c1-1bb6fbbda599"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("69b8991c-92de-4b7c-af72-20a2d984cc00"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("69f93516-4da3-47db-a3f1-4733178d40a7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("69fd61ef-2339-418b-8ddb-6de39f9ca86d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6a18e70c-058b-485a-9cca-9ceaf27ca685"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6a3a5041-b351-45ca-8bf0-b4dcf51c373f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6a597b89-6233-467f-aed9-7d5b47f17ef6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6a70d5a9-1af7-4c37-a99f-035a755377dd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6ac36ddc-cedc-4a3d-91c7-5ae75e4b516a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6ad3ec6e-9e9f-4a04-bb3a-0a7ca0c672ba"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6ad8e9e1-f2b8-4ff0-8664-66aeb17c35fe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6af24e23-6cea-44a2-ad39-15db1a90353b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6afe9882-6a9a-482e-b943-35e7fbcf80bd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6b34d4fb-1bc8-4915-9e9a-0e59dc470613"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6b77e2c3-2a3d-4603-925a-5548366a627b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6b8ca17e-e6e4-4c8d-96e0-5336ae45b259"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6bb32032-70df-4980-a14a-69cf1f723b07"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6bbc2452-510e-4467-8028-807b2805428c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6bd782f2-7edc-4d0d-9874-890ab6fc54da"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6befc3f7-ad9f-41fb-8b9c-8a137205bff9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6bf178f3-d696-4c29-8917-aae4f64fe647"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6bf88b81-b273-467c-ae39-637eb93d4ad1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6c2e0fd5-70a6-48fb-9279-8242c0922b16"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6c358cb7-64ff-4e35-af15-88f9bc2b17b1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6c87f766-e1cd-4cfc-a857-7c327ffacda5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6c8a5503-2d2c-4004-a086-22f9667114c8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6c9116a4-75a1-48c4-832b-4c9654b088d8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6c99170e-6dc0-4800-b526-eb6f8e5d21dd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6ca6861e-49d9-433d-ba1e-0e21607ee978"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6caec01c-c5ba-4b5f-bebe-733272c3b685"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6cafcc3a-4c68-449c-a3e5-f3005143ebef"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6cc48829-c05b-4660-b905-7e954e3f3fe0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6cc99b61-1a19-4df7-b4d7-19ea5197dc52"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6cfd3f39-0300-468f-8778-21faf291ad9b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6d15ab95-3ff7-4746-b9d9-68fb40a6614e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6d56bac3-dde0-470d-8b77-7fcc75b70b4b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6d622e31-2856-4e3f-b03d-799267b78ac5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6d8998a8-e6ea-496f-8076-072283a231ca"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6ddf3ca6-439b-4fc2-a95d-f32dcbc1d5c6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6dfebf5e-e852-4842-a653-6b1da577ec83"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6e31aead-1167-4c03-86f3-42896144bac7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6e3852de-e011-4452-9395-2f7a10e83bcb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6e58d622-7ee9-4e53-803f-3a034a2089bf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6e5c6fc1-0608-4422-bd56-30805a6aaab1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6e71b4cf-079d-4c43-bc5b-584a7b870b47"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6e975770-b194-4ead-a7e3-c79379e558fe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6ea8fe86-7717-4955-a2f8-4143bdeb001c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6eaec20d-910e-4036-9bae-d227b535e075"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6ed42fc5-5ba9-45fa-afb0-703cd3e1ee0b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6f4391fd-78b6-4c0d-bfae-ce79be9803dd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6f632548-1e74-4aa2-8550-620dfcff8d49"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6f7a9263-aa96-4015-ac70-8f6ecc8f091c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6f8493f2-db89-47b2-bfc3-fbec0e04cd04"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6fba4808-a765-4b67-95f1-b84d03d0ef9a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6ff60f39-1e90-4659-bbc2-b08987145b62"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("70128a5f-a74b-4869-98df-3e7307553eb9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("70312829-8b41-4ef4-99ea-b2bef96521a4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("70524993-477c-4927-88b4-17cabe6ff658"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("70613110-bd26-4838-9806-c853e22de572"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("70b46eca-ad4b-40a5-8e41-3593105a269e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("71029285-7637-424d-9611-27156e88ff6b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("71032468-23e3-45d4-9345-2caa8cd68aac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7130304d-cf15-46d1-94eb-cce9286670f2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("71594bf7-687c-4e98-915c-19d12dbde6cb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("71801b96-af7f-4323-a47f-5aadefec685d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("71827e93-f532-4c49-9f19-bfb5d50a47c0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("71a40b32-ffa9-4894-9c06-9002b00a3295"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("71c40591-7779-4b9f-91c6-f16da056767a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("71d21738-8baa-4626-9ce0-c0677502d0f6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("71e0d2e2-1392-48b4-9e40-250da1012aa0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("71e3c0da-84cc-4cf5-a29a-68363fb75b78"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("721d6b18-d91e-4d75-b1c6-c3fdf506bad3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7233f1f0-237d-4b17-8468-b129a370f174"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("72442978-3b23-4c17-9df7-d019b2abcdd9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("724de54a-da2d-4fe3-bedb-d850f271c116"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("725d0341-466a-4ed7-a664-998749a172b0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7268148d-61d9-4b4b-a9c0-bbcc1d7af4c2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("72706796-de19-4053-8804-4b309f23692b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("72910656-7ad8-4200-b2d9-cb7be1e5f2ba"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("72947fd7-6200-4c12-b6a1-551cf2cd800a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("72c9e354-9f13-4292-b7d3-26b06aa0607c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("72d93d7b-d32f-4257-9011-f2a9c79c6b48"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("72e98d2b-e6cb-4467-a9d4-14127d537a08"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("72ffe0ec-704e-4d8c-a73f-ff620d3e895e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("73110a6f-0dcc-4422-ae79-d4851c1bb234"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("731415c0-feb4-4245-a039-d2103164fa1b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7318399f-efd7-4e3c-96d6-b48f93234929"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7359eb16-9bf8-41f3-b667-33c7ff3dc12c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("735c28d8-ee4c-4404-91e8-6fa0d8331df9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("736c0289-cbe7-4e3e-baca-f80e72d73f06"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("738f27b0-d47c-4e26-90e2-859f966db835"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("73bb980f-91d7-4e11-9254-079786b05e5e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("73dec1dc-dfed-4768-9a66-81f39c6a1e0d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("73fa5932-d12f-4c7d-a3a3-eec0edc3c370"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("741faef1-20e3-4b78-83f5-537128fd9443"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("742d76e3-4921-4307-a0eb-345ad742432c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7449dc62-eb88-48ae-baff-4886a94d30b8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("744d2867-b50a-432e-801e-3f171cdb1f19"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("74531c3c-39ba-473b-9917-a01d305c67f6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("746988b8-d077-4de2-b66a-872a9a9a904f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("749c8770-a14b-4679-a9c3-7f75e7dd6c79"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("74d6a663-39f8-4adc-89e0-1f96fad12773"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("74f4ac5e-4b24-40d0-bc85-60a3f2e6d9e4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("74f5091a-97d3-49e8-bec7-9aa901bea492"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("74ff03a0-2220-4ad6-a34f-e57cd41705b0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("751432ce-4caf-406f-8452-37759fe8f950"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("75317638-fc52-4281-a5fe-7a3ebc1f660f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7569f047-cad4-471f-9d10-5d921496f4fe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("758dd686-3547-4620-908f-4efd04ecba64"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("75cee1c5-387c-4a01-a5cd-158a20cdc69d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("75ebc511-b163-4774-80ed-4fddba1e69d5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("75f43e95-edf5-45de-b664-ed5efb390326"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("75f6f836-2e0a-4365-9be8-f2f6182d4974"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("760168e5-668e-46a4-acee-aef3e2a2b29e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7633da55-4ef2-4880-a93b-e82a04c7ee06"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7675a3e5-4140-4929-a3b1-f1734fd6be47"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("76832a12-fcf4-4db8-aee7-266d5d0b8b21"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("76f987eb-e996-41d7-a3a3-732d154659a5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("76fdab0a-9f3b-4841-87fd-bb832518b2c6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7722f0d4-f76f-4cf7-b55b-456bd21e16fb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("77373d41-110b-4f1e-b0b0-196feac441f4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7748f158-e798-4b65-852e-e84f28975181"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("774a06f3-0afd-4bdf-b8f2-02d618742391"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("774d8490-0fd8-4bcf-9bdc-aeaf04fc4b8d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7751b131-0883-4be7-ba67-983cd2d5cb0d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("775504d3-5cc9-46e7-b06f-1230201ca96f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("776cb090-36fe-4997-9ecd-2516813b7d23"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("779a2a61-557d-44e0-967a-6edd10db2c57"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("779a563e-7f22-4af2-b182-1ee135fbfaaa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("77ba9c85-f627-4f18-95a5-9856979004f4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("77d4a9bc-acdc-4b96-84ad-fc74dd86b03f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7813b7eb-75c8-44cd-a469-4fa39c75272e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("782b585c-0d3a-4701-921b-c00f4e412022"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("786d37a4-3fba-4427-a8d3-64c404b89fab"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("78a307b4-fb00-4c21-8479-19ceca2eea6b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("78b1bf8d-f35e-4cdf-a91c-def6d452d2cf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("78c0d999-f0c9-47a3-bc89-64c3d8d03fdc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("78c5cacc-2d56-48ce-a5e5-6f3c1476632d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("78c786f4-aab2-4a84-bdac-21ca6925aa6b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("78ea04b6-9712-43d6-90f6-758142a82edd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("79369475-463f-4018-bf79-386bee6fc67c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7943880f-fd5e-4c2e-a254-63c9badf0e3e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("797c77ca-b4b2-4e91-b44a-c27246f8dadc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("79d3de04-52af-43ec-8934-de249e7df77f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7a057374-2be0-499a-918e-dc90b601e1a7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7a09f321-6d72-46bf-aee3-01e0e9cdb2a8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7a881683-c846-47c7-9aaa-8a5b883effd7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7a886e0e-8923-4643-b415-ebcaae8889fc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7a99ba2f-05cb-41b5-829f-0d1f841be8b5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7aa1061e-7726-4cb8-bd9f-8502ad5440a8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7af5f89c-0b14-45f6-b19a-c509fd05f22d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7b4ef65f-ca79-4162-84a7-37eb90a41e2e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7b73eb9a-17b0-4025-ac9e-d3ed7b21b7c1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7b912b5e-aa10-4e4f-801c-53c5bf213f8d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7bad51fc-0c40-4bd6-a0b3-8679001f3410"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7badbe9e-10bf-4f7e-b264-acc1528979d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7bae729c-9826-4cad-8b64-3d3cc27540b6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7bbe4d82-8642-4787-94a7-b0b19fe5c5be"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7bcbeb76-477a-4006-bc4b-cc0e8e6133c6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7be8da36-ca61-410c-a541-66ae6643c288"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7bf9bc51-6734-47c5-8ed3-a7a062d34995"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7bfe2eac-b7e4-4cd7-86c6-35dc94b0ac23"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7c07a129-f35c-46a3-bb51-44e97f168eb6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7c0bd410-ba11-4b42-9e51-2a0d8a89be0f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7c22d782-a3d6-4b6f-b0b1-879afd45917f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7c3d1fd0-73bf-485a-9456-bcaa2d4f3c00"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7c576b7c-73bc-486c-be59-35ee084e176f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7c7dfe23-6682-4091-b837-a8a60b40e18c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7ca150a8-66c0-43bb-88b6-85e874fc78ba"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7cd30e7b-c8e7-467a-ae4d-567f1ed55ff8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7cd72228-aa3d-4653-b50e-105b3085d147"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7d38cdca-570c-489e-9c49-e2d34cf2b15e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7d425b68-0057-407d-88a4-4b2b7096513a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7d72a94c-a117-41c9-8924-3a7c921ac15a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7dbb9f3d-384a-4822-b54e-9068f4ded162"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7dbc6ab0-a774-4ebb-b692-beb5e9e82dd5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7dc1dcd6-563a-438b-ad4a-9ef5fe89b892"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7dcab072-40e7-49c4-87ad-3dd999a50e4b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7dd61811-ef14-48fc-92ca-fd39858b4faa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7dde1480-0cca-4764-8f41-956545a4bc40"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7e0b0f3d-770c-49c6-8371-b5741724716f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7e23f6aa-2b48-49f0-8225-d43925fc9ba7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7e3a00bc-80a0-4536-b3ed-568f19384a16"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7e649373-1d0b-4084-99fe-2c48be464771"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7e6dfe4c-7df1-4f19-bfb1-2beedf4eeca3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7e7f19f9-e0b1-422e-ae7b-7ef14e9181d9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7eafeacf-cb54-49a6-b296-080b651d05c1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7ebc92aa-db65-45d7-996e-0e3e97245dc4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7ebd8bd1-60bd-403b-9093-e07100ad8aa4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7ecaf921-81a9-429c-864d-bf0566efef55"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7eed1cd0-bd70-4bfd-aeaa-f1688f1656a9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7f437bfd-db12-4fac-8086-125784d734ea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7f5bce89-39a2-4a5a-a035-bf1dca1a7213"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7f89d732-f32d-4ea6-8f1c-563e5330addf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7faf3314-5152-4855-9998-176a6c62a1f0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7fb02446-66c7-4987-9f18-e06affce93b5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7fc7d91a-025f-4a85-9629-a7c74d2df11b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7fd3b974-0c56-45d7-8bff-0e321b7bcc7f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7fdcdacc-5348-4c61-ad74-38960f764721"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7fec8656-4154-4ec9-b956-eb2e1d24aa94"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8066c6f9-5eaf-45f5-8185-6399b7ae48f4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("807007a0-fcba-4256-b1a1-75f87c27e21b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("807c365d-b995-455b-b06d-e83d1ecb367a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("807de6cc-da81-4d60-b295-e142846dc905"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("80931c19-a2bb-4963-a08a-e2b6adef0652"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("80d6ee34-4748-41f9-a753-f0adbd8cae6d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("80e25be0-5e47-4328-9137-9866ff58ca87"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("810611b6-8729-44bc-adf8-e865401c850e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("812788fb-750b-46ae-8486-223338a3efd0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8127ba19-ac4f-4c06-9ee2-df95398d855f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("81772b26-98a8-4954-ad82-9139cba0380d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("818b2483-1fac-43e6-8d57-5fed9d60c9b1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("81c50aae-e3ba-4af9-a5f2-499bd99b7dd1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("81c58a65-7151-4c83-b039-7ce4d248966d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("81d502e0-c58f-4a2b-9c90-bf04b655caed"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("82450dde-cbbb-460c-838b-c8245bb75182"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("824fa0e5-aab4-4ed5-8ffb-aba0c3a04374"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("825f2f71-6dab-4703-b6dc-fcd82e386ea9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("82764522-2bec-428d-8ae2-836bf35b280d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("82968544-93ba-4f66-b888-b5025107fcd0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("82bd7f4f-ab72-4095-9161-f6813618dd65"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("82f49135-8c24-466d-9001-7e59acab8c71"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8301400e-bfa0-4a0c-9abb-b0288091be5e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("83064a9f-6555-4a5c-aa24-e7f1301fbeed"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("83237bd9-76ca-484c-9887-344543e6408e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8351cfc5-297c-4280-8fd2-1b677e037639"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("835fd5ae-1f81-46d9-8305-800ad2929e3c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("836a471b-5224-4247-92be-7e8264b44a94"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("83897a8c-25e4-406b-8d02-edb4b01ca4b9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8393a24d-24b7-427a-8e9c-698df5d205ce"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("83a7eed1-2d53-438e-945d-edd47e114154"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("83b57072-70c4-491a-87b0-c7fa1d2e3409"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("83bb0828-cb02-4a70-8ef7-3f2851604983"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("83d21d87-d612-4b4a-b932-703e2c63c1af"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("83f15724-9f8e-4fb8-96ab-4d0cb1b98c71"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("840df711-7fe4-4740-8203-2cec206677dc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("842bfb29-6362-49ac-a0cd-9a8ae4094b29"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("844559ef-369e-4952-ae8d-6916a766fc18"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("84562b56-de64-4e99-bec6-5437e6d474a7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8471c98f-b5bb-46b4-9fe7-9b109b1ec709"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("848b8166-ee43-4754-8083-3596b860a165"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("84c2d40e-fd75-4a6d-bb43-97ae25e1c3c5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("850ffd2f-b1a2-4111-8e4d-a55af0ecdc85"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8520ba32-2d36-46d4-8304-2fda0661ee70"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("85446b4f-e85c-4bb5-a649-8ac0004aea1d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("854c3004-a542-4312-b573-0f693bfffb88"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("856d317e-4410-4c4c-a589-5d2af411b269"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("857f7b30-c776-4e1f-9e36-6dea9a1792d3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("85df197a-8b7f-418d-9f4f-24e939d04f70"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8609851c-853d-417e-b565-8aa2e00efdbf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("86463625-c3dd-4b18-9afa-2e7cfa96e499"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("867c9927-5aea-40fc-a1cd-3bac6a0bed06"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8695416b-3cb2-4511-8839-4642f9fc9a51"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("86e0f6a2-70e2-4962-bbde-80da8464aa27"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("86e6282b-f244-444f-9e64-3db90b224293"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8722d521-d7f2-4897-82bb-c193be320ba5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("874cfd5b-81a6-4541-8f77-9c7c766d0217"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("874d13c3-f827-49ec-8f6d-3c09659cf596"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8761d357-d1f0-43a6-b2e2-e616668ac4f8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("877be4f1-0722-4980-bf8e-df4239ffe23d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("879a77cb-e17e-48bf-91cb-5d09cacbfb38"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("87d7391f-05f4-4a96-99de-b7fc83d01a40"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("87e34710-7645-4a52-ae04-ade60fd39b96"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("88266df5-3bf5-44dd-bd7a-d18b3c017ddb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("883fcf65-eb22-4791-98eb-80d922a221ab"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("88a11e5b-cb61-432f-bd1c-d2dda3e89158"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("88b8ad7f-ffc9-4972-a347-5b0070469722"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("88cc8698-9639-4462-8b3e-bdeb98ad0924"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("88eb93dd-e1fa-44cb-b35c-ca3982629d8b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("89651977-1f5f-42f2-b7b2-685772c71fe7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("898dd55d-40d1-45a5-8652-1c2d7320e2e0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("89aae050-d159-4c5c-8b64-0d27d0eba3c6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("89ae775d-e3c7-419e-88c7-5de97dfd5e7e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("89c27015-99c4-42fc-aba0-69c9f0db3a9c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("89c91a56-d3d8-4fa4-918b-b4a955f2b26c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("89f0b901-ce8d-4399-a4bd-c7187e416a7d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("89fb4cce-1fb9-4094-bd27-36b46f92710e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8a07e30a-04c0-48a8-818d-975ebd4dc899"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8a37ba75-5476-4566-b884-e33d37c11a98"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8a4ae5a5-0e2a-440f-9eee-24522755acf4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8a98e7f2-780e-4d5e-8d9c-07dd3dbaf878"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8a99fa2e-ce23-4145-adc3-976149f6d6e8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8ab8f1e9-fae8-41b9-93a2-457802c87fdc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8ad70e2e-218d-4e72-b0d5-ae7153b5d86c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8af42f3b-7852-4781-b6be-d887ddce6e90"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8b0dabf7-aade-4fec-83e4-fdebd87a1187"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8b1e12ec-7cbf-4039-b78e-718604f2e6da"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8b398813-96ec-4c82-b3c0-b982e1818aed"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8b4d9508-439d-41fb-b9ea-218f54034e33"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8b5eb03d-4772-4968-9d76-41a2ee9661dd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8b633018-a579-425e-9d9a-d334f1e5114d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8b6bd0c7-79b1-4ff6-b8b2-6aa15c9c002e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8b8d192a-4b52-46d6-9e3b-8a297ba2949c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8b9811ce-0bc6-475f-9e11-d4b89f8fec46"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8b9b8936-d330-4cd9-95d8-61d31d1619a8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8be3cf82-b902-4762-a7e2-45840b4bdaf2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8be4b874-7f60-43dd-8ce4-911cca07752d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8bff000d-7592-460b-ab36-788228f864f4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8c30eafd-8ed6-494f-97e6-5fb20f23e0c3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8c3ac31e-104e-44e3-bb8f-5dcdca475887"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8c68cfc8-769e-4927-a725-b2cc7904d306"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8c9bd2f2-b622-4713-af96-69170dbdac1b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8ca8e66b-40f0-4e05-bbc4-e4ba2751f71f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8cb9386f-1b7c-445a-bad1-daca376a48e9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8cc8524a-6c61-440b-beab-094ec32ef716"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8cee7666-ec02-4ecb-9e5e-eda45c7ed0c1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8cfccf70-e105-4ae2-9af2-ac9aeee2b8e5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8d1a2a72-36c6-41f7-9c63-10872746e502"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8d9d1c2a-aef2-402e-aaad-df3fac802947"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8d9db50e-4bfc-4bdb-9f22-ea849e6dd23c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8dcc79c0-988b-4ff8-b98b-f7152678f2d1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8deb3b8c-21a1-4c4d-b989-34a046798383"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8df5a193-acd7-4e93-b2c2-ff98d17f5fea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8df70c0e-0687-409a-a2db-1ce87ed83102"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8e0e9d71-5c8a-42b2-af48-de4e64fd390d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8e3d70a1-c654-4124-b932-a34b82948829"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8e5b86ca-6e21-4adc-a246-2778080e8f8a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8e646a34-4e39-44ca-bfaf-339b7303681b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8e77cc67-51e5-419b-8dc9-8ef310c1585d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8ea509a2-e15b-47c4-bcb1-0e8717e5f627"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8ec9ef21-9303-49b9-82ea-317296c52bd1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8ef7e133-7dec-427f-b215-0d145b7da041"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8f258d9f-d354-4022-80ea-b806d008aaac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8f3c49b7-c03c-4c5f-ba05-61c4d7fdf210"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8f402b8c-01b9-49c3-9060-7832429f24fd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8f60c1e0-edc2-45b3-9f7e-f6732b0f45bd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8f734a4c-5141-4b02-be78-ca2a7f07c5a3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8f9868c5-5724-431a-8b18-1a8a06ab3881"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8fb00706-2047-4649-9d86-ab924fda6940"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8fc8a99b-3b5e-4683-b987-9bf2764e37cf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8fd16323-e86d-4893-9feb-d1c2e28c107d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8fd203b0-22da-49e0-9dfa-40f48bece1ee"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("900bcf86-5b8e-4d7c-98c7-ecbe3374a2a2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("900d14a8-77df-4568-8fa3-4d8d057ef253"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("905f4c73-410e-473c-b989-827e9f2aded8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9074760b-6539-4e8c-adcd-3fe8d63f1ba5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("907a0ad4-11b3-45ca-b13e-2d31dc3583b9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("90842a40-421a-4f71-b2f3-82a6e7f6d8c7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("908d9fe0-06ec-4c81-9fa7-217bbb1fc7e4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("90a0a20a-1128-43ae-b40c-3b5d4262888e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("90a50ffb-b550-41e4-941f-1e838bd35f6f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("90e0dfda-53c7-44cf-bdee-5fec4f30b727"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("910acec3-e0b1-475f-836e-8641606d4cc7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9122a627-5970-4004-8dfe-16e31f7ebca6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("912a0871-44ba-4d9c-8a4e-70c02b4a133d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("915463bf-3e92-47bc-8693-a1f4c3fe3569"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("916e95f3-ede1-44de-b709-c5534b2dfce5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("91749adc-da37-4039-a7a5-511aae90705b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("91b21625-67fd-4cdc-9eff-8acef9083cbe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("91b471cb-c85e-43bb-bb59-091f954c90cf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("91b7425d-d106-4773-9f31-621171b5da78"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("922a5fe9-801a-41d5-a70c-1d8232a2da1d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("92399d19-25aa-4839-9a87-a5273e434a21"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("924d1250-b78b-4644-876a-6fb6886ec392"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9257ac24-f040-4ba2-9c83-d6130de0c8bb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("925f51eb-3b7e-4356-9e7d-509f87686357"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("926b2cc7-9780-478c-9140-b128acbc226c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("926f989c-ccff-4d7e-8371-5d349fe79764"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("92963c69-f814-44be-bd73-1ae7ce9fd7f5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("92a0ea57-9eff-48d3-b653-35bf30c10356"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("92c15781-7395-4a3b-8de6-3952e5ab5562"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("92cc884c-fa7d-485f-9c69-4cbef59daa1d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("92d28198-85be-4da8-870e-c315e7bb106d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("92e35713-18b5-49f3-bd58-d0e152003345"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("92fdd810-4251-4f0c-9e1f-e6bf835a02d1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("92fdf460-ee82-45ad-b993-06d115521154"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("930f4543-a885-47e2-8fb8-631b5b8f6a3d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("931d7d07-e645-42f5-ab93-ab0cc375a8fb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("93237ce7-dacf-4975-a80f-0810f6637864"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9342827f-b0f1-46cb-9fc5-9caad4421295"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("93566a31-fc20-4231-9355-9d35ba871f53"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("938e4915-ccd0-44cd-8906-ff25b7032f03"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("93a9b6f3-b8d6-4855-81f6-1c11bead8c6a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("93b25993-ded3-432e-b5f0-4307e718898b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("93b26148-02b8-448e-91d9-4ebd92805779"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("93c097a5-cbfd-4078-8b68-7ac30d93bf60"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("93ee7e78-33be-4153-b7e6-fbe9a22b7632"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("941147c9-3731-4e63-a9d4-a38a0ebf9d51"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("941543dd-20b2-4563-99ce-553a443fe1a4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9436d5b9-2f7a-4e7d-967e-52db1b2f3fc1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("94a1c70c-a913-47d6-b9dd-564202b0264c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("94cd9145-acd4-4359-8f89-591f91e49f67"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("94cdce1d-48bb-4f1e-b1c0-e9988f007e21"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("94f21025-5df3-4f43-b8a0-83ee0e5fbf39"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("94fa4e89-51d4-434e-80e4-205059207c58"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("95062233-4c9c-4590-9b0f-2e02d8dfa53d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("951a9ad3-89b1-48c8-a3bb-a8017ca81a98"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("952c8761-70be-48eb-bed5-e9296c881484"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("95339009-604f-4c10-9679-6e19ed0e9c91"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9540a75c-aa1a-43ee-b813-8d3c12bd3727"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9548d5e8-eacf-4ce7-a9ae-c932d1dc52c5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("957c148d-136c-4cfa-b1f4-71e7f7d04c5b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("959fe448-ee8a-493c-bd7a-bad81c82bb4c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("95a2d4e6-c2ef-4822-bd68-7ae7d14ae573"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("95ba55fc-2150-4bfb-a804-b8627dba1736"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("95d2f4bd-388a-4685-86dd-c5491fb31a78"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("95d8968b-db11-4ce5-bdad-95ff37de4c3e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("960f337a-fd04-4e5c-aff6-7896844cb7fc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9634634b-537a-44ea-9b62-2dafc493f21d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("966e84fc-f350-47a6-9d1c-f6a21bdcf63f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("967ddca8-4c24-4a60-b2ff-876fa686ad9d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("96a32724-1655-4854-8809-77b2990ce353"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("96a657e8-9d1c-4f47-a002-ae525732b31b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("96b09d22-cf17-4f05-b9d6-d494d2ce58fe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("96c21caf-5ab4-42b2-879e-ff8853cdfa98"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("971470bd-81b5-4812-8a49-b86d40c9dfbf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9715d967-f5cd-4a62-b726-32a06ab41c35"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("971d534b-19e9-49a3-bebc-fb99a5ab4ccc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("972e8dfc-12aa-4c4c-8f34-d641bd63601e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("97412fdb-9a59-4a19-b52c-ae92c63f6ae3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("97632b0f-69e8-4753-acf4-8517fbe362f2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("976a563d-fa17-49c7-b61d-f85afadca113"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("97cc4451-d778-4d84-9a0d-166c00c67356"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("97f09fa0-bdc9-4e6d-9c07-3fec930d6246"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9842438a-0d4a-4ca7-9c6c-ffe589a4d6ed"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9874e12e-582d-4ae7-8792-e23bb8788aac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9882b037-74de-43ff-88b4-737164aad226"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("98be0a0e-39e6-463d-ac00-e4d353399a24"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("98c530e3-cbaf-47c7-b67d-5de588bc3938"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("98c7c112-6cbc-43a2-a5e3-b00fd896819d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("98c9cc15-9f9f-4e09-95ff-927690034c97"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("990f1c93-0d30-43f3-87d8-aa478a5f6a39"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("993f6bf1-3869-4754-9de8-b5aa71963de9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("994e15f3-5ee7-4a77-bc42-28b47664d7d3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("99ad1660-4ef8-49d8-8487-998fd1ac486d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("99c07492-cc20-4790-955b-b4099dc9d806"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("99c9febd-71de-4120-ae0d-618b2ebb7341"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("99cd5b1b-b2de-446b-8408-2e06cbd98722"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("99f6489e-810b-4e37-990e-0494540b75e5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9a1f2547-e250-4aac-b61c-805e69a69e77"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9a31bf34-f66e-44a1-86e2-1ce21daa06ec"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9a77b557-a308-4806-982b-4af3986753d5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9ab91da0-fa1f-418a-bc17-5d9ce06c199b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9acf5268-871a-4a34-9560-96e46a3ce600"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9ad3078d-bd2f-41af-8674-27b184bc9396"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9aeda8e0-cd6e-4bb7-a0ca-ca2de5625b70"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9aedf4c5-a980-4539-8296-677a4932f7f5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9b61551a-4313-4de4-a811-6678b9a23adb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9b80e635-cd3e-4032-8caf-dbcee9c596f7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9ba73a93-31e6-49cc-a806-b60179945814"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9bb4629e-2a46-4a70-be26-24f319d9d4e9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9bc6dcbc-4043-4c44-b357-fc02bb0bbecf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9c5d1917-3764-481a-96d6-642ce13ee069"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9ca356a8-41a9-43e3-b8f1-95d50dd9f57f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9ca9c0ef-7d35-4ca9-bbae-4b18a4202ac3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9cb469e5-cea4-4885-bab6-a44379e6a976"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9cece925-9199-42aa-b8a4-5bebaf00a9f9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9d144cb2-5dfa-4f99-b6dc-43f36370e39f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9d54c732-7746-41f2-8415-65572a29353c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9d6248ad-e12d-490f-87e1-40b6f54fd103"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9d6b65fb-07cf-47ac-b183-09d0effb8b2b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9d8b533f-22d5-4e08-ae28-627f89f40dfb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9dc77db0-3014-450c-a25d-9d39013ac43d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9de7dd42-f43c-47e5-84ed-82ea542cf16a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9e35eb00-1e3a-4260-bf2f-99f09beaeaa6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9e3d90d4-e6df-40ec-bb8e-8a53bd50c229"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9e70a3ca-9ab7-4dd1-8e7d-8d959b83c723"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9e7d04ba-973b-4bda-97dd-295ae00c1cab"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9ebc82f8-cb37-4b17-9d1d-0c5898bcf7c8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9ecc58d3-31a6-4883-8592-e54c5d5a2477"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9ef7d1fa-2733-469f-af55-405124930257"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9f027aa5-7905-4867-94a0-237461d1fd55"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9f0e2e66-da89-4928-b74f-740e96e41df3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9f86da85-94c2-4b25-9fa4-7649822be9e6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9f8d14d4-cf2f-44d8-9927-3d79efcd2b9e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9fa89153-8191-4906-bbc1-2e9fd856a401"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9fae98f0-7158-4b06-9a7b-0c50c509b317"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9fc1fefa-be39-4d20-be8f-77821ee2c592"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9fc6f587-5089-4005-8686-51bef509c3d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a0009933-eec3-41f5-9f18-13f2d740a4fd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a027eb77-d9db-4a0f-bf65-3474787c5bdb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a0475bea-b139-4ac4-a430-9fb5cf7657a1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a05f57f7-5cf8-4bb0-ab82-a98ecb2e20bf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a06dff3d-f1f9-4a0f-9e52-2877c82b1277"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a0d5222d-5385-4d01-a7b6-bd94801c13dc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a0ea5c6c-96ee-4f43-abc3-c3d2a63eb919"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a0fec6e0-248f-4926-80db-c0ea330d91df"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a1068da4-b7cb-47ac-a46d-ed914243d418"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a15011ec-596b-4b64-b1be-5996366ba3ac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a1528e17-e677-41ba-aa2c-e370cdc82447"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a182b7a2-f9a2-4ebf-8ace-d631004f7613"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a19947c2-1ca9-4722-9b92-94b779b00a35"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a1a5ca60-a18e-492f-9a4e-14e1f1ca3a27"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a1be6b22-614d-4aab-b514-6a38ce6a5db1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a1edf374-3218-41bf-9835-dfb946e7ebe1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a20552fe-d633-4f80-b970-d976746882cc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a2066ba1-f96e-4f64-91e7-668c7031fbeb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a2517701-d214-46e2-b578-ff14d11ffb3e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a29a89e5-3974-4193-9db7-d3367cabb862"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a2ba1fac-9ee5-4e13-8022-2920d3135a69"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a2cc4438-05a3-4295-8a95-e9b3d910fd2f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a2d37013-33af-4a91-bd98-195a91ac0da5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a2d67fa5-99fb-48bd-86a5-73fdbafd96ec"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a2de43f3-559f-43fe-b84d-f8f2b884f1c5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a2f340d6-91cc-4323-a511-bb3291383e2d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a2f62fbd-42e4-4f69-8c67-984fdeec87bb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a31230cb-8b52-4731-b959-acdc7648846f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a316fd02-926e-4735-92b9-8628e495ad54"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a31f8ceb-47cc-40f2-97da-c9dc95a5e96d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a344cebd-c7b8-4f11-a863-3f6ff4ff882a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a3508d7e-5e96-4ed2-950a-5822a5493a21"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a37c10a2-e13e-437b-8561-617f7b7ed506"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a3ba4fd5-8348-41c9-a968-e41bae434347"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a3c01bda-9696-49fb-b4d8-66623f245b12"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a412aff8-6841-45ea-90c4-d13c8c64d207"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a43ec836-867d-4bad-a7d0-77cc78678eb7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a445e849-682a-448b-bf42-97a48031de49"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a44a75d7-db05-4b70-8070-340079a4cfe4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a478b731-ae2f-41f4-b2a0-7ace72954dc3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a499c5b6-d9df-4e6f-82b6-5ddcd69994f8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a4b12a90-1819-4e8e-8789-4017da3ce71e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a4e7f57a-7dbe-4f9e-85ed-f4ccb6abde0c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a4e8055f-a9c3-4fe6-94a0-905b84cf1cb3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a4eaa7d0-63e4-4a5c-9347-854cae6ad862"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a4f036ae-3739-4503-9b92-87f51c3c9858"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a51fdc16-6a3d-4bf2-ac67-867c9da41698"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a564e12c-3ba7-4b3f-95ee-126b86ccc089"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a5664d12-60be-425b-ad66-b1c86bdf19f6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a59f3dcd-d3ee-4068-b51f-9c015de56c9d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a62b6f03-9459-4c90-a641-052df94a206b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a65fba75-c42a-4337-8348-327e07c1dff3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a6913d9f-9d95-4271-8116-e4518329774e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a6bc158b-981a-4add-9e4b-39a3372d9a25"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a6cc34da-de0c-43fa-a104-881e3d9121d4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a719d096-b0e9-4d2f-90d5-85a811dfa0c2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a729ed76-4841-4aa1-9309-fb6e65d4d7fa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a739f2c0-736a-4ef8-b68d-60b5f5485a39"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a744c10c-d523-42be-89f6-72d9fde4d1c5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a7463eb1-cf5c-45af-b645-1b70496b66ac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a747f132-9891-4c56-ad70-4ae9d51d257a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a756ecf1-3fd7-4d11-bc19-8533727f7a9c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a77b3f80-ced0-446d-b81c-f9096b210900"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a8088cae-f0f3-4532-95c3-fc682bec148c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a828de59-dc0d-4300-94a5-e784751d0db8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a83bd632-2734-439e-9a52-34b99d0c82ea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a86232af-27c5-4bb7-bd7a-8e688625fecc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a881e580-cbfb-4f1e-baad-1ab4df075f4e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a8955e0d-0692-4060-94d5-f4ee12f5d2aa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a8adf8ee-bcd2-4e82-8a85-5f9fa8afcb39"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a8cd1556-12b8-4054-8cac-f872c6978958"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a8dcbaa0-0bdb-45fd-ac42-47c3da0d701a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a8dcfe2d-f285-43b9-bd6d-4de4734047b3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a9492557-fd09-4afb-bd59-61102cd04f7d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a956955d-62b0-42d3-9be1-43243c5df0fc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a970f317-a300-4312-a65b-c38b70a5071c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a9891f3b-741b-47f6-becd-13aaf11ca420"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a995a540-5dc7-4f48-9aab-170af3cf76e3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a999b81f-aaaf-4299-bba3-63baadb5fb20"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a9f20556-d72a-4d78-bb4c-08c79c1ae9dd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("aa05f01b-336e-46f0-9a7b-e803aff750de"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("aa135064-e690-40e9-875f-803257c6644c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("aa45b9fd-d078-4abf-a498-0f46e6745bed"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("aa69aa0a-ba55-47ca-9e2b-7005383cdc9d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("aa78e23c-0014-49cb-897d-4aea5387d6e1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("aa897e94-2f37-496d-856a-313e221d8621"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("aaa78314-d215-49cd-ad4e-a82c0735c27a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("aad1bc8e-dd83-491b-a343-dbe270edcb8b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("aaedc0c4-92e6-4a30-b8ea-ac8df9eba900"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ab1205d8-bf37-4ce1-a58b-6b9ca1458abf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ab278178-2c89-4217-9172-e252d94d03dc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ab27dc32-9026-4023-8be8-847d69db176f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ab2e1988-45f4-49c5-a5da-9d4c45febf65"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ab47c844-7e72-4b3f-9b75-9f1ed47ffb27"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ab4e3b0e-d098-4749-847e-5c66b3d6b3a5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ab7d4b9a-0c55-4693-9102-67689f23d555"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ab9408a0-38be-434a-9e1f-6ad12c5314c8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("abaa23d2-c2fc-4e78-9aee-208f6bd384af"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("abae7998-2f83-489c-bc18-4e2ebabd599c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("abc12ce2-877d-4bbe-8a11-358c346a53a9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("abd7663d-3ab5-447b-8274-8dad30db6755"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("abeaeb16-dd8f-453e-be7f-3cd38dab4d91"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ac19ce1e-4f39-446e-aac3-bb8dacf07dbe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ac288805-d01f-47fe-97ae-2a56eebc575d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ac2b5ece-55dc-4d0a-a360-7fa4d7f48f4c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ac3cf170-cf55-469e-9728-9f11b13d56d3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ac3f2ea0-b8ea-480d-9b74-af6c3464dd9a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ac447347-2b97-4ca4-9e16-f886aa9e6a03"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("acb2cf2a-0a77-4cf8-94ac-9f1803bd58d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("acc4201b-d934-4d05-b2c5-a50063d0ceb9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("acde7eeb-79d4-43b0-b7da-6fbcfd2de931"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("acf3ec59-5f19-41ef-b60f-62645acb2889"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ad03e6c8-bafe-44a4-97c3-9e6306dd7345"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ad215eb3-6e7a-4fc1-93a5-40bc3b5d5478"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ad2ba71e-f029-42ff-96c4-36abf28e18a6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ad6c7044-e16e-40b5-a64f-ded0da10aab0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ad7bfe09-457e-4bab-93f9-e2fa9e787f1d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ad8c6031-9bcb-4665-9e7e-f6044a247303"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ada9500c-c280-4451-9ddb-0041d7dbd12d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ada96bcd-abda-4b08-8923-1cb7594d4015"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("adaa8e52-4b5b-4881-bb05-c2d488019df9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("addc19e9-2482-4f80-a827-e3dff571acbd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ae47efd6-3dd7-4094-8bc0-0849b4da667f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ae5ec161-ba06-41ad-a666-70efb6eda4a9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ae704306-d288-4d4d-9525-9563f1eacce4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ae8507d9-7175-485a-9202-60079dd0b6e8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ae873919-3984-4ba0-82c6-4711094c954a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ae899311-5f01-4f00-8aa5-b48136af5169"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("aef14dfa-ceaa-401a-8d49-8a04a29547c6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("af1c5d8a-18a5-4b50-b2ae-044ed0ab5160"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("af4d5720-b1d3-4a64-ae2c-cb326da6014b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("af7d4dbf-9b30-4073-b11a-d4f2c8bdca69"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b0082695-0cfb-41f8-a9bb-8c265e505e6a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b01d9427-f82b-4108-b9b1-442986604e69"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b027cf30-23bb-4058-b002-c6cdaa47e732"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b0695252-26ca-4550-9ca3-c2c3bcf319f7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b0793882-ec75-405d-993d-e7a0a0563559"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b07c8926-3cf2-4477-b6db-60f90756fd88"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b0823d74-8db1-4441-abdc-8cf3f81157b3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b084b929-41f7-4503-a971-e541105bbeea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b08e570b-32d5-4b98-b66a-5757d59b9db2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b0addaf3-4e9e-4c51-9346-0cf5754ee371"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b0c369b2-58da-4b7a-92db-6855fe00c53e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b108e1c5-854d-4e60-a7d6-5aa51726dd6b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b10a0973-a2d1-4d44-835d-2604e847ff46"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b15a15b3-7579-4a59-bbfd-54ab04d68cfd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b189e433-4498-4447-a363-1f5606ee3f99"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b19e05b2-5a91-498f-9edf-2c5b3bc691fd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b1b4ea77-5325-47b7-84cc-d9ab0f47e898"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b1bd1f4b-f9b5-4846-9259-3bc762a979a8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b216c1a4-bc56-41ca-b8c7-619832427f18"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b22f3616-3e05-49f4-aed9-c72319b28d20"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b2661f96-2cdf-496e-b4b4-e86657181f80"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b278dda8-2891-4786-abe5-e9456ffc7adf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b2db1adb-d54b-482a-bb19-aaf9db4a7754"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b2e75e65-25d1-413b-b08d-251a38b086c5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b34a132a-ee31-4178-89ac-beb8cb0d096f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b35d3898-0ee7-4034-a20b-6a1e23d437ce"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b35f9f3a-27da-433c-a043-682ed8267ecb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b3722af0-0b95-48f8-981e-2169cdb1f7c5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b3c9444c-34c9-4c82-932d-b70064af3b29"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b3c99412-71d2-4b91-a1f6-ff267473164b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b3cc337f-8c82-4734-8398-c11fd1582631"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b3fba24a-536f-4397-ada9-0c5239f8929a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b406ddf5-a6f6-4219-bd9e-8385b9bd28de"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b435d3fd-fd26-4f10-b162-e775dce6a645"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b499ed96-e76d-4496-88ff-15a749697099"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b4d93b1a-29cc-4ca2-a9fc-450ca7951144"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b4d9cd3d-6533-4923-82e1-f50d8cf5a1de"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b4ffda57-7a04-47bb-a464-3c2bec74a40e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b51846ad-1862-49e9-bb1c-cea7dd7c8b9c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b5601edf-ef1f-44ec-9742-ecc61897a5ce"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b56bc04f-58f6-4eaa-9936-b133d912e3b6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b57b686f-f50e-41ef-ba25-4432b92ed248"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b585c6f9-9a51-4945-a66d-d7a7c7906ebb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b587648e-9d73-4584-bb85-e0295ac00aaf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b58c2941-e11f-493f-9739-2fc6cdaa15b1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b59e61eb-d2ce-4dd0-9f27-a8ef35592970"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b5dabe32-003f-4441-9406-1646b16aec75"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b5ff6c37-7a25-4707-97e5-ff9e7c4feb79"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b6b3f31f-0b8e-4d4e-8ab7-bf5758fb7562"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b6cd0f00-c51a-44b8-a733-d14e4ebb2751"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b6d177f5-5934-40f0-8f9e-b721113d0097"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b71e6237-b642-447a-b0ab-d1b1fabce0b3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b7260164-9736-4dcd-a0e0-0cf8e321050f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b7878d26-aba9-49ab-895b-6e8fc7878d0b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b79bbeb4-c05b-4976-a382-ec043f9dec4a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b7d1f712-687c-4fa4-a926-91fba5459b1b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b7d65451-d2ae-4239-805e-2a6bab3674e6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b7d85b18-70a9-4df5-aac7-af3dd7dd8a3d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b7ffda1a-e40b-49b2-be1f-656bc0f30fc8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b823425d-3dce-4d55-a997-bd483beea516"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b8371274-119e-46d7-82e6-0735be5efccd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b85c9df6-00ae-444b-b9c4-b72b6b354e7b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b8bfe8f1-23e8-4e25-aba3-7c9f650eb199"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b8e2af22-90c1-4c93-86fe-136cd97f9198"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b92c1004-2edb-4489-8523-285daf2b0cdb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b953659f-ff97-4007-8ab0-32014cbfc5a7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b954f257-7d57-4978-ae87-bfa2f109acd4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b976ef16-dbc7-4b59-bf2e-d6b1e5808a4f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b99828c0-a6c3-4ec7-bdbf-f8e291dbe645"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b9a91eef-0a95-4e71-8b30-4aa2a87c8ac9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b9eb203c-4887-407e-9101-0ff65f4edd92"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ba02d58d-69f8-495b-89fc-6ff235a01feb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ba149995-633b-4839-967c-0f2806518e09"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ba250b46-40d6-45a1-84f2-9996db022947"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ba2d11fe-18e9-4961-8cce-cee0205488cc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ba3e88ad-ace6-4280-a40d-331d93e5c166"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ba625f21-5974-4db4-a6d6-8e6036662598"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ba7c1035-360c-4fb3-abd8-0c2dace02779"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ba87bb43-ccce-4eae-94e3-9b9657d6fe45"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ba9bfdf1-c926-4cc9-850c-32bb1a3d28db"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bab861c3-35eb-4a87-b893-c77795987ab4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bac09813-181a-4350-9101-c2d8a70299bf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bac654da-a9fe-41d2-85cb-8e2445930428"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bac84c91-ee73-41cf-95de-fd159d2679f1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bad883a6-5e4d-4250-8e7b-88efc711a058"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bada462d-1864-4414-93b0-cf14991509e6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("baf27581-239f-41c3-9ea2-7d31ed2b5ef3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bb26b6e2-c25f-4d46-8ea7-b9e2328d71c1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bb314b65-40aa-40b0-9666-cd71d31cbbfa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bb32db35-ba2a-443a-84f1-d76dba621e85"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bb341ccf-6f4a-495c-9744-ace13d90a6ad"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bb53be44-8478-43d9-9eaf-51f4abf8f151"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bb5b49d3-2da4-4414-8a01-4e497b0c2947"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bb74463a-ca4d-484d-9dc8-d99ce7dcda19"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bb74dfc7-eb40-422b-9654-cfdacdca46b0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bb941fe1-0dfa-48a5-923a-5ff4264f294c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bbd32ba8-4b35-40ea-8030-af56bb3b27b1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bbd498c8-9b24-4ce9-a4e8-9fb25612ab2f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bc071dfc-37c8-445b-8297-72a2c7e72f25"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bc0c95e3-2e1c-47bd-a04d-5e648932c0b3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bc185ce0-34e4-4247-80a8-fbaba8ba62b2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bc613b89-6373-4021-ac6a-6195cc9060c1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bc6742cb-67b0-47be-ad79-23ca4ad2cc0d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bc715c30-5a8d-44fe-930c-5ad1dcfbad67"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bc80f6aa-f2cd-407c-977e-b1a8c7dc65a7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bc842689-1c8e-4d09-8da0-09ac5b16bd14"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bc9028b6-696b-4c32-ac04-e7d685f2aef9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bcd3537f-3fef-4e67-9957-e0b52441f502"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bcee8718-6705-4225-aeff-987642ce293a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bd021f2a-a52b-49ea-a18e-a5e4cc02c074"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bd0dc381-7730-496f-a228-b68b53057861"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bd22a55a-0106-481d-93d0-089761fc465b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bd3c3d15-3a14-4676-b040-6eb090cf0d69"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bd520172-3ed6-497c-b804-03fdb90feb75"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bd5e4df8-6faf-4e07-990c-10d21b76a5e2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bd61d676-6677-4170-98ce-8c4e85afe4e8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bd719130-d9b0-4a56-a495-384b8749637f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bd7fd983-df1d-43de-819c-5e151b1e2afa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bd86b60b-c7dd-4c3d-8335-62581317271b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bd92ca2e-13f9-49ff-a388-0baa92defd55"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bdee4772-57ae-4503-8aba-06cb2f104de7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bdf562d3-445e-4ed8-af5e-ed8f44676e1d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bdf8c3b5-851e-4402-b438-cca41ffe71d9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("be0b81fc-964b-4b80-8db4-571a362945a3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("be249999-b16d-4719-8b9c-5b851287daa8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("be7b3be3-bf9a-42b8-8a8a-a3f5a892c207"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("be9f46fd-4124-4dc3-a07d-9ba31e83bbe6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("becd6769-a19e-45b0-abfb-7d7bf36367d0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bed19cd7-542b-4dae-8c63-b7d8c4473cc9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bf0f2f9c-eb68-4bf9-a202-09e3c62aa522"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bf3a8afb-38b6-41df-94c8-ffdac046c8c2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bf4f92c6-5c32-496d-9943-c5f6ff7783c7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bf6f0c60-6328-4da2-9ba5-0a05e280075a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bf6faaeb-3aac-4fa3-80f8-9f068c0e9a53"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bf705b4f-6a34-4215-b4cd-b228ae8f0dd2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bfe2c860-7a78-4540-9e72-1b37ce594c4d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bff4f884-8a0b-49e0-9f29-2d69dc03cc04"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bffdbabb-2a13-42ff-b8dd-130ebed241ba"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c010fdec-5d87-4994-a11c-135b015dc6cd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c0409e2b-8054-4624-b52c-6dee0066c862"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c05f4bdd-d5bc-4756-8251-7804a67847d8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c05f68ff-eb6a-422b-8045-ba6be08234e2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c082cdb3-323c-47c7-8b40-8e1969d4abcd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c0a86d05-a49f-4f94-9c56-9ecd2c9b0c35"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c0cdce6f-c5b9-4cb8-88bb-df1d4dc5205c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c0d9081c-cd27-46d1-8ec8-90551fade02d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c0ebd97f-1259-4be4-a8d0-6fde2aa92dfa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c1254c07-8ac9-4b76-b3b3-79fd0196374d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c1402f60-9fb6-4af5-9d93-8b8505ac884e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c14d00e2-71fe-407f-a893-d4492ba45611"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c151a79c-f60e-4717-9c32-8100db53c629"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c155e6ad-0919-4a0e-aa25-4b9cd4f4188a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c19fd72e-e740-4287-95ba-27c2eb06115c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c1b54ce5-9ddf-4519-8a3c-5d10d2ebf905"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c1e37aff-2602-4e8e-91e0-58a83ae9e428"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c226aa54-716a-4da7-96ce-76aebe1e8992"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c23f69e1-5b47-4dd1-9735-d801442b786a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c2b3fd0a-56b7-4397-adac-c0ca538bd42f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c2cf5f85-1ddb-424d-a581-0f38d58ff254"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c2fa3f0e-d74b-405e-baac-0ea27516fc5b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c31f207d-7d6b-4416-9754-14035d0b96ac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c337f614-ec08-476d-8c6b-0b0d7eefc0ce"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c34e2817-cb63-48b3-996d-510ca59d7dee"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c3ad1f40-849f-45df-a070-2466ef5dec38"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c3b3db4f-789d-463f-9ad3-84b0395f3b27"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c3c4677a-c9e0-46ce-b2c8-9ba6dec7fd01"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c3e8bd65-690c-4199-a2f4-0aa85e8ce8ec"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c412b7f1-0baa-4d7c-bbf8-683f069a0417"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c4206b65-3dd1-491a-8914-a8390f8d4d4d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c4390f96-2665-4aa4-9a89-b2cafa436b69"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c4470540-1d1d-4398-a350-b1d3303e0778"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c4577992-6070-4fa6-8f73-a602f1e42aff"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c46af2ab-96ee-4f3e-b9eb-4444a7ebec95"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c46afa79-9146-4619-ad4a-b1bbdd0cb5aa"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c48d5416-8867-47d3-a6d2-e8497230c520"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c4abe775-028d-4de3-8b36-bb7cf3da7fcd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c4dfbc29-224c-49f9-b3d4-ee7ee3209779"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c4e61ce4-6fc3-474b-88c5-d96867670c2c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c4faac63-f338-45e0-9afe-5ed7553ba298"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c507af75-1217-4379-b1a0-ab6e6f86c5f8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c529ae06-47ee-4f6e-87c0-140559d106c0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c5620dbb-7eee-45af-8112-3822b9ebd587"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c5705d4c-044c-44c8-9e24-f88407c1085d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c5806340-5d8c-47da-bdf6-8d41d16fbb39"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c58204d9-27e4-4f40-8539-3eaa97e8cf09"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c5950021-9b32-4447-8221-16df803a6c62"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c5b63178-3249-4153-9947-931eb13e4fa4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c5d18285-793c-4892-bb1d-2831652c2420"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c692c4c5-fda7-46e6-9f10-59e41228e7e4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c6ad8ee8-16be-4edb-989f-db2b2b3eba33"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c6cd43f1-9093-4d43-a41f-c17c13555744"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c6e2ddf2-8473-4e55-9085-c04c8082fbc1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c6ebdbe4-fafc-4b14-b6fb-468e07c1d344"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c704ac0b-ab1e-4dfe-a32b-c0ca3885f13e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c723dbef-c61e-4fe1-b432-902dfda32969"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c752dff3-b2b3-4457-b7d0-7f7bf982c45d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c75414c9-b105-456f-977a-598572e64f9f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c78e2fd5-a71c-4922-a99f-9a6c68f79b66"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c7949f15-e4e2-4cd5-98d8-b6df46361b0c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c808295b-22d3-43cd-8f61-80c0512b4c53"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c808f32c-02a1-48a7-8645-c9bb2509c918"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c81a8f6e-b2b8-4c6d-bf70-b0c639e68d4e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c843c07f-7d4d-4fb7-af0e-da2ca1d2cbe2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c8537c7d-426d-4456-a6ce-c626c78d672d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c85acc14-5f7d-488e-b042-b1194a5c0d2f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c8682bcb-367c-47bf-87af-89a32ba7e399"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c885063f-97d4-48ad-aefc-9caf93bc05f4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c8af119e-8f4b-4c8f-9a1d-63b67f9704dd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c8d60279-bac8-452d-a467-1d3bfe175fd6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c932b5a7-c6e9-4004-a80a-802b3e0f52f8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c94bae3d-53a7-409e-92fc-3724629e0e6b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c94f7e7a-835d-4760-9a52-811a4c7591f3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c95430b6-930b-43cf-9d80-5faec2849ce7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c983a68d-c6cd-495c-85ff-f6969888d9ca"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c9a7e0c2-f27a-49b5-bb2f-58df083e8a70"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c9a9d2d1-7eb0-4347-90c2-3d17ccb0b813"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c9bb4e34-55b1-44bc-8561-3bbec4f6fc4c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ca31f52e-e421-4d75-986a-721f6449f3a6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ca342b83-d928-42f4-942b-0c94a49b96c4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ca3fdc42-52b3-425a-be0c-43dbfb2f56ad"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ca503472-607b-4a4d-988f-793f46f0e05c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ca696571-f21c-452d-bb36-c5de3338c6e6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ca750edb-aed0-4eb8-a0cf-92777bb25073"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ca783c03-525b-4054-9d02-c14c98dc15d3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ca8f426b-33a2-4f66-9128-7e5f9bdd7eb3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ca91932b-750a-4a93-8781-c47ecfc29ec7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("caa7ec75-92ab-467d-9211-5ed922bcf9ef"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("caad9404-2273-4fa0-b35e-423f663d4533"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cac9448b-0534-4e12-9ad3-19834035f457"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cadb3e43-b167-491e-b7d6-251fa7414865"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cb45d41b-654d-4f35-8cdc-3fccf0e7ce8e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cb809c09-4f1b-4226-8059-2bb43e4ca2ff"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cba7e2cb-effc-41d5-893a-dda89aafc6d7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cbb357cb-a0bc-45eb-aefd-b52d5a5556a9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cbdddee9-78b6-42ce-b7f4-ab72dd693e5d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cbe29d8f-ae5f-4dde-9f0e-cd2b523b4254"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cbf024fd-396a-43c3-aabc-133f08182e28"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cc395557-1a6b-4e21-a096-b08fe4c60463"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cc7d3ccd-a637-4fc7-bb69-e91e9d0d922b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cc81972f-c352-4927-81c7-87e28cec8141"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cca49122-8950-427e-8402-942d70c2425b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cca60511-808e-499c-8ede-98ac9bfe6418"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ccc6c5a4-4ed4-4dd2-84c3-8182e9ec4715"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ccd5c8a0-524d-4776-8954-baa910e3b398"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cce0baa6-1297-4f39-922c-a81e7362e775"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ccf6aebd-3bcc-4d2f-9b3d-2ab54e5fd318"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cd3ceacf-0890-456c-a786-93dedf38710e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cd3e434e-b04a-4315-8411-a5c2e00f6c08"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cd56eb36-949e-463d-a85f-ca430908d7f9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cdb4ca18-4a86-4ddc-b823-6d94520d5157"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cdb512c8-3a05-4328-9dc6-7920ec6108e0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cdcf694a-ca8a-4d97-82ec-72b55e37f0bc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cddd5904-ffdc-4867-93a8-e7f9db78fedf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cdfc9e9d-7d69-494d-85db-746435946882"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cdfdf634-4382-4934-a88a-5c39135e0904"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ce070032-03bf-417e-8778-5ab3729a744e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ce0d3c7f-fd19-4bc6-8778-8f11b613dc26"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ce2b5a9e-2fca-4bee-99af-cb17fe06a003"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ce2fe743-f829-4a18-9353-eef3ebf5e789"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ce4cd8ff-dacd-4e99-b685-207057d83437"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ce579cf5-39e9-478a-983a-b383be8e4710"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ce7bde9a-f903-468f-8b13-45d4a653f171"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ce9f1725-7176-4009-a9d7-be15a8844dd0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ceb02cbd-db51-4521-8abf-4d81f8630e7c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cecd4060-c621-4e1c-8ae7-b4c4f2ff2d63"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ced02619-fc2e-4c49-b404-f40e8b736732"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cef98d3c-801c-456e-9ac7-e0a04134effc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cf147024-7e21-46fc-93e5-bf65baa70ad0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cf448925-4b69-47ac-a452-714090063e88"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cfa0afef-62d9-45f1-973e-85544675ca42"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cfc71ebc-1a13-47d9-926f-03be5fd865ac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cfe70a16-baf4-482b-ac43-db1346243016"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cff2ba9b-e951-42ab-a526-63de6edfc87d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d0056885-a55f-43fe-aa6f-2ca88ae1abbd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d0063b0e-3ece-40be-a40d-137dbf5ee93c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d03d5436-8e7c-48d5-8600-e35de7ae1fb2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d03fb534-5c41-4839-aaf7-a6220b23b94d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d046ab42-d058-4667-8c53-d045cbeb9a6b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d04bb969-3fe2-4409-941b-b6a0dc6019f0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d04e1797-80ec-4d68-b6b4-fc40da487c57"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d0550081-9eb3-4b0c-9b98-23f5d6b319eb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d0a8b1ed-d598-4829-ba2d-5b91ee0a7f38"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d0ab3f78-afc9-44cd-aada-cbd46322852a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d0b3ea91-e493-4cd8-9a66-72067a799758"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d0ee9261-497b-43c8-baab-f0dace8dbdc5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d12c2c21-9311-4a80-bb9b-bdd649eccc3e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d16ac77d-3320-4d9a-b58c-e04fdd010b89"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d186a1da-6c1e-4982-b124-60b8c90cf806"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d194e1d3-ff6d-4195-81d3-783e81c00b66"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d1c139aa-b725-42fd-9c6a-7c98f42a4b57"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d1e6ab1b-70af-4b9f-ac37-b45d10439b3b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d1e9957a-6060-437e-b6d1-a0b8ae88c93a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d20a211e-9e37-4f00-ae57-bbd6f37e9a95"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d2155086-f1b3-494a-a813-6eade37982e3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d2367a71-e12d-4df2-a7ab-e59a44b464bb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d23fc1b9-3311-40db-844f-913ff678f35c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d25721c6-72cd-4d34-b5a3-1c61f8d6ead7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d27a9d9b-ac66-45ff-af82-38ceb725290e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d2aab07b-1338-4c2e-8ab9-07224d0db003"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d2b83e22-5e3a-461c-94fa-6bfac88193df"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d2c544b0-16f6-4578-ae0f-53f253261c61"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d2de3779-19c1-47cb-8e0b-aeb148c0a8b8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d2de3be0-2200-41fc-ae55-c4824a268b38"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d306edd9-7f0a-4fb0-8c29-e8ed61a8195f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d3b8ca90-323d-466c-8cb2-969ce740b478"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d3e52650-7ed8-43ca-b989-106fb1ede6d4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d3f0357e-7bc4-4a57-bf78-773fcd00f903"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d3f412de-c10f-41b7-864f-eac75c7684d4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d3fa25c6-d00b-43e1-accc-dfc37e81b8dd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d40b9e31-a41b-45ee-b5e9-a338336e1995"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d410b4f1-d0e1-4c25-a368-a9f0ec2ce58b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d420911e-c5ab-4ae1-b245-d2487b08d246"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d4333b0c-074e-4f71-80b3-cfc6e6633ec8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d44b5dda-17fc-43eb-8fe2-26f4cb09f103"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d463af99-5d77-46cf-a706-ff2904219e40"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d46fe97d-6d2e-438c-abe3-102891b843e1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d47ec0c9-b5b1-4380-9947-a6ac7da53d73"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d484de6f-4cdc-4292-9968-2dd576278ecf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d4a2039e-f577-469f-8967-f836f8afa97e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d4d675fb-6126-4ac8-9988-9ad42aca92ee"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d4e58126-eba0-4271-a518-4a1397050ce5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d50cd478-90fa-42d8-8be5-7d219f0ca84e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d519fd5e-7205-4253-8d8f-13aec00b6ec3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d522c570-b925-40cc-9530-7fdf8bb6cf63"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d527e14e-ead1-47d3-ac45-0af2f8e3e641"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d52a721b-b0f4-4323-9294-1bf02194fef7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d539926d-44c5-472e-85e3-ab22db1d6a79"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d53ef8a8-faba-4219-8928-37cb06a7cef2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d579f9da-fede-48b9-9e73-d6bdfe4d2332"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d5875a31-cd3c-4283-885d-5ae83755d42f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d598ff0a-b464-4baf-ab03-b47750bbd66d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d5abc90d-f696-420c-aa0e-57922a376065"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d5aded5d-9aa5-4940-a020-4b9696daf02a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d60295f6-8b66-4317-8d8c-f2b92bb1bcc1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d613b247-115c-4600-84f0-dceadd299348"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d65a50be-1994-4b91-8631-2af82ef277bb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d6be7722-f84c-473d-8d46-ff0ed0ab65fd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d6cac080-cc87-4228-9f32-a576e4aad1f8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d6d8e1ba-2605-4b22-a34f-16efa1bab5ca"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d6ea8d30-e7dc-4c4c-af08-31d3139aaf59"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d704b1d5-760e-4675-990e-d535bb3cd6ac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d7069b6e-88e4-4f1a-b991-e48003078abe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d70b007d-8169-4cc4-9b8a-363be36e17ce"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d745b8b3-b439-4235-a2b8-c54f9442cb91"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d7488d6e-f75f-478f-a8fd-67be333f403e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d762ca23-03cd-4351-a3b1-1f6aab823e84"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d7868e3e-016c-40f6-aa74-62eace70db8f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d789e0e1-6f87-4549-9e46-bf0d82bbf95a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d7c34875-9732-403c-82fa-05d9e5268980"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d7ccf8d8-2e1a-403c-8f17-96e0e99bafd8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d7d0c1fd-dfe6-4bf1-9dd1-e1b9b3bc2b88"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d7ecd922-7900-4e2d-a047-5c178e663ed6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d8186ff9-1f01-477d-8a22-9a926859c02b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d8220458-0a60-44c1-b7a5-a8a411a87353"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d8830583-8a1a-42c9-8af0-c7348029a652"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d90464a5-3eff-4816-b7c9-3a3f9d453cb9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d91290bb-06a6-49f3-9db0-45288971bc2d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d91b0712-3d88-425a-884e-529cbc29eaad"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d95a4149-162c-4cf8-9f82-cfcd1cdcf90f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d9633773-2d7f-419c-af8a-8d90dbe49c42"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d980da3a-1bc7-4306-860b-8bdf2fe25cac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d9b0f54a-7345-4c70-b47b-d164ef19ebb7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d9bf2308-9c3d-4304-af17-573e6ed82732"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d9e3e2ce-f86e-4bdf-90a3-5dd2bd0ab5f6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d9fe969f-f8f8-4528-bac1-47dcd1d43cc4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d9fff66e-ea4f-4737-9899-a138885f7a5f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("da257c2a-4ba7-4999-9d81-4af0777f14df"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("da322844-7df9-47da-bd9f-28a809c1e0ca"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("da40cf1b-b743-43d0-9a7d-fcd93dab9a21"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("da4361c0-7828-4741-a0b3-0bc275f36f58"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("da4b5697-a68d-4911-8ab6-e2a769a4c5db"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("db097bc1-45fa-46f1-b0b0-7b67b76de385"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("db30dae4-df1b-403b-9c93-372aee66015d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("db3b2ae4-89c2-4d32-babd-8b6bf411d29b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("db4633f8-40a3-41a1-b928-6107930f3d21"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("db6c8590-5c9e-4446-8517-f3c3487ccdd2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dbe5606c-ac02-4381-a9a4-6169d183e629"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dbf80e2b-cce8-4160-9417-371c9f1de7d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dbffcc93-aa2a-4444-b52b-eec379b86984"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dc1230bf-aca8-4984-ba17-7a098befe835"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dc22cb2e-4e2c-4b1b-ab69-86716b4c2191"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dc510ebe-541a-46dd-9e55-e7025e8c35ee"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dc849825-d9e3-407f-99f2-cd334a081c87"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dcf03269-00cd-4fc4-b4ab-ad33320ef151"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dcfae23c-50a2-4c08-ae7f-43f6c61366a2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dcfb41c2-6305-4283-9909-7b02f05cf9d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dcfe4917-ed5c-4305-a59d-bf9d50a33289"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dd0231c4-4848-4e30-9193-24032b7a42ac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dd68a8ef-bdfd-4481-9619-b04867741711"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dd6976bb-36bc-4384-875a-563c1aa3c218"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dde97e54-c14a-4a89-af5c-14b1ca66f5a9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ddeaa54d-7170-4803-a8c5-e48a6c8a6e1b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("de0684d4-829d-4d2e-9edc-595dfdf4dc65"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("de42a32d-78c4-44b5-ace4-7d3dc37bd762"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("de552092-5cc3-4396-b2f0-cce1c42b2038"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("de5a9b7d-a27d-4c27-b4fd-704502472920"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("de8c7003-5f0a-44bf-889b-a6be3a86b0bd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dee85521-4b13-4a6f-ab5d-0a5933764e6d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("def2aa34-5a33-4b65-a500-8026d070a738"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("df635820-936f-4604-b308-64b58dfab400"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("df94a7e6-48d8-429f-92b9-082bae380b96"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dfad4d26-0019-4286-9edb-f739ad7255f0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dfb72e2e-dfa8-4062-a519-aeeafe1c6dc7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dfc2fe0f-581c-4986-9975-4631fb6775ad"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dfcadc48-9102-4424-8456-dac9d42d632c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dfcfae61-fbcc-461a-9b23-20aa1a0c94c7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dfdd9ca2-3419-4bad-ba15-69d4435d82e8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e00fc9c5-546b-4c3b-af51-4fd84ef615b8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e015582f-aa74-43c0-bfef-c057222856e7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e01989fc-7775-4366-bd39-257d568cd933"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e0369b37-d25a-483e-8b02-fd05bc41b713"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e0548bb4-358a-4ef8-9518-9fef38b30ed5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e068166d-2541-44be-b55a-3c10e5f7cfb9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e09608d5-8741-4b8f-b50c-165c8c2b09f6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e0cc4b96-7f61-4cde-a117-e9294122d9a4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e0e0ee52-dde1-45ff-bdb4-5b31746c7fe2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e0e6367f-281a-4a35-953e-fac16636c458"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e0fc59d0-e612-465d-9efb-a30bcfba1e4b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e160250a-5c19-47db-ad61-33caf968d705"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e1866315-ec3e-49e9-8dfc-78d80d4e828d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e1be1d08-2932-49f3-ac4d-b385d4a09b43"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e1c78a01-ae77-458d-bae6-a0c09b3db9df"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e1df2d5b-bbc1-4442-9ee6-d564b93f3bb5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e1fd7714-0ab6-4829-9f53-9337e2d3d3c7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e2093579-7a2e-4c51-8ac5-04630f16304d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e20b5e1e-ea10-43f3-97c1-2882d3887d9a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e229ce18-051d-42a3-b9b3-63197c14db2b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e237fdbb-6493-42b4-bace-034f793acb36"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e23b1162-c294-4bf5-94cd-e0a89d9166d1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e257edfb-c95f-4e0c-be44-fb3739f4d716"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e27eceda-3fa8-484c-ba82-8dfda4a3b3a7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e28f405c-5ce4-46a8-bc18-b564e88d5566"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e2b3d2e2-b92e-42e6-89df-0aecfd210713"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e2b484b1-5f02-4e22-95eb-248efdffff95"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e2d64a1c-2f35-4300-9368-753e9b9e28ea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e321d901-5aa0-463d-9f39-f0da3faa1dc0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e32a1ea1-63ad-4749-b702-09ad440a924d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e348f1e8-4a63-454e-a7ba-54ef48e821ce"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e384c6fd-14f2-4d67-bdc6-eb422a41588b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e3852885-a7c9-4456-86ac-bea94abd3213"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e39e0d1d-8d62-4667-82c2-2c514e74783c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e424e9d6-5fda-4bd8-8bc5-510b13694de7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e431df9d-0099-4fec-acaf-1f174e77cefc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e46c68c2-faab-4bcd-87d3-2c9d39336653"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e472bd13-0387-4348-8e60-57a9013d7d32"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e47ab588-bba4-40cd-88d0-14fcf02aa27f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e4af6cc8-0b9d-4657-922c-3c6e5c4b83df"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e50032d7-1e78-453d-b26b-881d78073650"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e51ebcf3-6736-4a24-a24f-c1748bc615a0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e537d8f4-feef-41db-a556-0926184419d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e553c31c-8aee-415b-a261-e756b99ad2d8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e557425e-24bc-4921-a09c-3648f3baaef1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e56eb8e0-ea08-4ee3-bbe1-bfb312652eb0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e5779643-4f46-4d78-a05a-0e675c575c13"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e5a0e69e-98b3-4a48-ad91-0207c0a5c696"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e5cff0a0-abc1-4694-bbc8-89c949a3c3f5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e5dad49c-922c-45e4-aaf3-41b0e8ba27d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e5fe5b15-c7d9-47d7-9f32-8efc552226b4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e611c111-8e03-496c-93fa-30f5aac3c216"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e647b9cb-c07b-4e7a-a96f-22db63a7b599"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e66aaf2b-525d-45dc-a93d-aa5c223edc20"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e66cee7c-2bcb-4d40-9d84-9dc6442c6a73"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e6cd6585-6430-43b0-8ddb-ff2f8ae01e15"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e6d8b5e4-cb66-4b07-b0e6-5fe42d3b0995"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e6e916ca-46bf-4f73-9f14-350bb05af1b0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e70c1b6c-e04c-4368-814e-9f52b08c183e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e723242b-e42e-48d7-8575-314fd0c44e6d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e7504116-880d-48f5-ad6e-7ffc5c4fd8a9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e78c950a-aedb-40b3-9508-12145edb4fef"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e79fcb3c-cd05-4fad-a6bf-fdef4f7ef25f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e7aefd0f-386f-4467-b51f-210af5cde503"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e7c758f8-2b63-4a84-b50f-def8e48eafa3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e7d81dc7-62a9-480e-bb78-9ad300e542f8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e7e290fb-8438-4757-9554-76bbaf60f8a3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e7ee9bc0-b876-46d8-803e-7983503fcc80"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e8142591-74a6-46bf-9e2d-16f3faa09280"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e81edc90-7f5c-4250-b9ec-f5b832fdb133"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e835cfdd-af34-4818-abdf-c69b154fad62"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e856abab-b5f5-4068-a0a2-84f91ffabd29"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e887ec74-2a8d-4496-83ff-3908b0cd42cf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e8a47b69-6dd3-4f87-869b-8eca5c17e122"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e8b3e67e-6b4b-459c-9bcc-9fa6ddfe23cb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e8ebebe4-f46e-4239-802f-20473c4a4a1e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e8fae44f-08d4-4464-9579-d4ee4cd9a423"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e905367a-9669-4f4b-8e82-12f2432ccbfc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e910b541-4d9e-49e0-a52c-febedd521772"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e926d826-6012-4847-859a-5d4824fa4a0d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e941a6e2-b4c7-40eb-b785-73c4cdf78050"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e944463d-cc90-4059-841e-6895f198e048"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e955fa76-4168-471c-9d57-974c424941ab"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e98e01cf-6205-4646-8957-dc84138673c7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e98f01b5-1576-4bed-a7e6-ab722ed6fe66"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e99b6e82-8200-4029-8fcd-c4778902a38b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e9a5a151-63f9-4bcc-8789-e56f984d96a7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e9a6b9c0-88e6-4638-819e-6d1b35d07557"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e9d4fdd1-085d-416c-b61e-b27d8077174e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ea1109bc-1679-4ac5-b5f7-1b69b7742773"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ea1df4ca-01d1-4ebc-8b01-9ebde9190e72"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ea44dca3-f8d4-40f0-af8a-87dd2ad521a6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ea7d8696-bff2-47c1-9e5b-ccb1a7260325"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ea7e6463-6b34-476d-b19b-25392b10eb02"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ea7f9b65-176c-49d1-ac11-f61b9d17343f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eaa682d7-2564-46d5-9ef8-56a907270261"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eae84c9d-8d33-4d3b-960a-f085d3bf0641"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eae9ce54-605e-4d1a-a53c-536583effcdd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eaed97cc-0744-4a72-b020-99c49a32fefd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eb002ee8-0759-4514-97e4-018569792833"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eb2b85cd-3d61-4e48-aed3-4c37c6d1df65"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eb38b18f-4484-4c9a-8cab-5418dd96d936"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eb450257-11c8-4c85-b3a9-12c2fa876deb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eb98a786-c2bc-4529-9e0d-fcd952b50bef"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eb9cfa6e-38f8-4216-96af-2946d4eb2c47"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ebadd2fe-1963-4c38-b128-49b5442596ea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ebc8418e-a192-48a2-b7da-ee6f5fee6318"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ebce2882-51f5-4eb3-813d-2ea488e8d02d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ebd89935-fc29-4153-a9e8-ac6f5e8f86b8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ebef6750-7a0e-4ba1-b3c5-affa2a593896"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ebfe6315-763e-433d-b613-ecf1f2401872"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ec190151-cfa6-4622-848e-b6be2fd0031b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ec1cc7dc-2f68-46d5-9202-0e1d0fd66002"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ec2d5503-1b8e-441c-8f8d-24dc397fa3bc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ec3e3fef-89f3-4026-80cd-daae032f4a20"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ec479ac2-d38f-4ced-82dd-7bcef323a7ef"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ec87bcbe-ead4-4625-921c-f53834c3583d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ecc86649-a897-403b-a996-2058108845b9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ecdf0c22-5927-4a53-b6df-fcdafe47ec6f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ece45c4c-03ec-4620-b04a-0873d42a5695"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eceb5a5d-bb93-4b2d-8f1b-d661a4a530d6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ecf419b6-7629-449b-8cef-75dcd713bdaf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ecff514c-3cc8-4ef5-8d57-34e29b5a2fea"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ed65a1e1-1036-4d42-8227-61531f7e9d40"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ed79dccf-62ee-47f6-acd1-806a17f3e9b2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ed7d5c8c-ee10-4cfe-bd1d-40c65811388a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ed941b5c-0a89-40d5-a479-9545defad3f5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("edc41f9d-d06a-4e45-bfd2-248bfba7606d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("edfacf69-40d1-4a21-b04f-4dffd3c855de"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ee016374-36a4-4990-ade6-84f847e62b52"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ee29bca6-e39e-4081-ad00-84f5e29f15df"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ee2e0faa-e571-4e7b-bc19-fe5275d725ef"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ee300cf2-ab91-4717-b281-1be1b4ab5180"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ee5e845b-4fd1-44b5-8d55-66531783e530"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ee77a1c8-d1d9-49c5-a997-c2d0bf9e080e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ee9a6042-383e-43c1-9b9d-b989cf52b94a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eed1f18a-0f5a-43f9-ae3b-f2d9b99f706a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eede7f61-4f3e-4291-9ec8-611882d28169"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eee6a0a6-fcc0-49b0-aa97-c4e40b60ac0b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eee8ad5d-93ec-4e44-969f-59c5731ff389"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eeeb9ec3-e2ea-4cc4-bc86-4de246206f38"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("eef2b891-7c00-4474-afae-1ffc28604e64"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef0bb7ae-c86e-4fce-9b9e-ce1bd8798f6c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef0f6dfc-f5db-4925-b7d2-0cab99e2434c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef186c67-e97d-4b75-9639-cbfd4840a79d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef2ee617-9621-4f7f-82c4-e03d546abe84"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef37148c-55b9-4d84-a520-71c5d13d41a6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef38f940-4bae-4a52-9ca4-a1a1a7dc8186"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef47e511-2500-44d7-a2fe-0946607d181a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef54d2a3-c00d-4a9c-8a4b-a2fd94162713"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef5b01ef-c67f-41ab-8cb1-dc2a7e51ca8d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef5f6672-049a-4ea6-97a3-145f9379a7b7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef6435b0-7c46-4ea8-ad85-4b3dc9226f1a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef6b0c07-1613-423e-8e51-b69251e1f89c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ef9e668b-98b5-4c4d-a025-15fd8b6fd62f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("efab1b1b-22cf-4a87-8059-c1ac0f887395"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("efe73af4-e274-43ed-b29d-c632e84e1fe9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f004beb8-ca27-4e2d-bc53-8b02c306c1bf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f006b8c8-74c3-4f97-a535-a8229171a1e9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f01cf383-16d7-4f46-b808-c5786ad57075"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f02f07b5-8faf-412d-803f-d49c3929a814"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f035d93e-0e3d-4701-9ba1-bd8d767d4c0c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f03f03ee-f19e-4d94-aa74-8d87ed768a2c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f0492f5c-745d-43b1-895a-894735d4f146"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f0c7bb78-93f2-4714-85ec-5b0be4a13d85"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f0c9b861-ae19-44d3-9698-ea0509423ae9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f0e6b57d-763f-4746-8393-4ae110c7bda9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f118a07c-44e2-43e1-9b4e-a3750a9db9f4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f11ea05c-60de-4b3f-aa81-30c4a1662f48"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f1219b80-5329-40de-9889-944a6f47bd2b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f122f3a2-4fd7-4fb0-96dc-a5e75e732988"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f12ed523-b3da-4df2-988e-d6e1936a07de"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f13342cb-6924-45e3-9551-0122fb738f95"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f1fddcc0-bb41-494a-af66-7c8c292ca71b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f26c98e2-24af-47ef-827b-0f99d0b7b676"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f273eb72-7dce-4c1e-a126-1ac1d1740032"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f2c6e4dd-374e-4bc6-9763-d08745a01cbf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f2f9e9ce-abb2-4e3e-afe9-b5f31300791f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f2ffc666-64f6-4517-9915-27f0c56013dd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f30b5656-3b92-41f5-83b8-a91fb0a9f0fe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f31785bd-ab81-45ae-a0e6-0b5ebc0f4395"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f3231629-30f9-4d2f-b611-07044d7ac524"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f33eca04-062d-404a-bc9f-969689db54e0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f3492478-68e9-4706-b97d-cdfd2d070b84"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f361a00f-21b7-4e2b-9b56-1936558789b8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f380cdbf-6081-495d-bcf8-07d11c6f095b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f3d0b49f-cce1-4512-b7a6-051fe2877882"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f3f592f8-8552-4287-9b0c-4f6a32204675"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f40cbc3b-f079-4d1f-a85f-e767e6d6509f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f426c271-df7f-426c-9a82-260139011ad4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f443a0a6-dd88-4970-a754-fcfd1ac8ba1e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f45a54e5-4f59-40a3-be67-3559312f7391"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f46b1a22-6b8a-4439-a20b-74473f7e56ab"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f49564d5-1bbf-425a-a66d-3847e2b1db85"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f4d1154c-b1c1-4c77-b12a-c21ab2bfa150"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f552e780-7892-4c28-b101-ff7f55b071b8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f57351fb-bcfa-486e-a7a2-82ea1feca3b5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f57b873d-e3bd-4af2-a4ac-2ff118fe472a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f5b8498d-b1d4-4df8-83d7-c94a2f2c3d53"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f5c60910-643d-4cfa-bc04-ad0d27ae965a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f5cbf2e4-2e3b-499e-b60d-cc916a2f4a37"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f5d1136f-a718-4c33-b1ba-07944eec0603"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f61eec84-82c1-4937-a267-934099006641"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f624886a-3c35-4a6d-a604-841c2c7ac319"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f634d7b8-a114-4efe-ba87-cda8f856ccf0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f63c9489-79ae-4474-9b3e-4eb0fc5115ac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f671584d-a05b-436c-a808-cc1801af3c8c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f67f2a23-23f8-4e51-aaca-92c09afc654f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f69c7448-955d-44c6-9dc0-0c941ebbd6e6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f6b696d9-5533-4ec8-900a-3e0d2a32a05d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f6dbd47f-57fa-4aa4-9aa1-7a8815eb82e6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f6ed3511-82d6-4a56-bc79-23f96bb2128d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f7275ee8-2797-468b-9cf6-0091fa0fc83b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f7772c7a-6ac6-46b9-a193-18b797ac868f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f787c7ec-0864-4314-a41f-a64632469e47"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f788f855-e1f5-4c83-9dac-54d8c0a9e776"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f7ed5d21-70fa-4dfe-acc6-d791aebcec6e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f82ae292-9d4d-4b7c-a659-6777b1af97a9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f84bac34-17e4-413d-a7d9-c6f9ad285e5d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f85e71be-a3e1-40e1-a196-eed7d4cc2c7b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f85f0b78-ffe0-486f-920c-f34eedff8090"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f8abea63-66cd-4aa5-9edd-c26d9443b734"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f8be4f74-84d4-4a9f-87d4-00e3c06e352c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f8dcbdc3-eb8b-4955-af66-fac81fb17b19"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f911f44d-1e32-4f3a-9030-c90eaf354a2d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f95b6223-64da-4181-85df-4658754b3431"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f99c155a-b83a-4eff-8dc9-2f4a3c353dad"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f9a58d56-b184-4cb2-a3e1-fdf04a287fa3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f9a71e50-cb0c-40d9-ad5b-7c6d93b53d67"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f9b2c097-e7e4-4e06-9b2b-275a99a0a4d6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f9bba1eb-e83c-4317-998a-ec7aa4862491"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f9c81a3f-b213-46f1-b2b4-25428fababf2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f9f99500-efc2-4810-907e-54f23d7c0750"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fa3d458b-465b-4f83-8be0-b49d8e325aa6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fa438f7e-eeee-4e6d-9e05-842967bc6b68"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fa5cac70-d3e5-4e8c-9a49-c6395453de09"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fa5ef0ff-8278-419b-ac79-e7c92574bc79"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fa768ae7-7c80-4182-940d-75e5fd97b343"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fa8b4704-9fa9-489b-8320-f0e448c75171"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fa8c5239-8b49-449c-801f-132a9f341c5e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("faa0dc17-4138-4e64-ba74-4e32bd2bd069"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fab8f89b-c30d-4a16-ac6d-1da554d00906"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("facd7850-2b88-4f8d-a1d5-690d37bdd924"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("faf1a2a7-8d0f-4839-bbf8-c4db7191d3a1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("faf38fe4-2a71-4894-8461-2ea9d9dae217"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fb45a5e1-e07d-4a88-a71f-1f94582145de"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fb4f4cc2-4c03-4d5e-91eb-74d75eb46330"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fb526b4c-27eb-43e1-afdb-7569e4cb24c4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fb6c92a1-211e-412a-8c88-8113776d1698"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fb70c845-56b0-40b7-9222-d75be1de9e6b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fb792ef9-ed4f-4822-91dc-43c8e259f2cb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fb801de6-4cb1-4040-9b40-b89f9404b670"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fb9c1dfa-c0a4-4319-8c99-052b37a84b4e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fbdc7073-5e23-44f5-961f-16554ed37114"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fbef63bb-cfae-429e-ade1-60ef845ed379"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fbf4cfab-9446-4fec-8c5d-ea6e58a01ded"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fc110dd2-0d5b-4bde-8b55-0e0273009a7f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fc1c2930-dbc5-4bda-a022-feac7f7a8f43"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fc2c2281-7c15-416e-a9ea-ef8c7f7b0c27"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fc340a5a-eb0a-4666-ab42-a8fe52ffbd1b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fc405a65-6918-4d86-9d14-34907100422a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fc5fa740-2df9-4c47-aa56-bd41ccf42a56"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fc618b82-2a62-4f9a-b497-eba0599e75df"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fc7b1973-a762-4c79-bdba-19ee4180611c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fcb26148-2ce5-403f-8fb3-a3e97513b82b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fcf93bdb-46a5-4a1c-9c12-d0538c80f2fc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fd253470-5c68-4ae9-8831-ab5fdb7baae1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fd537eee-173c-4360-96f4-b7536253ac9a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fd6218d4-ab7b-4776-a282-417d47ce38ca"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fd638e73-1944-4443-805c-ef5f6ea3f5fe"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fd951281-ad8a-4426-8325-c0ae50cfaa7d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fd97fbd1-fb8a-45b3-a816-9bf678605e52"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fda2f559-0e82-41e7-b8fa-b01675c48682"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fdb95ae9-7764-420a-ab26-0e6a9d659d66"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fdba0d4f-cbca-4cbe-8c13-4000ff3a0f35"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fdd14b10-88de-468a-8d7d-68c7a424d3b5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fe01a165-7755-43f4-920d-42b60af933d2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fe04367f-10ef-4858-9dc4-0d727d2a9297"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fe050f9d-4c36-458f-aa0a-711ba7c5c0fb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fe2a5f56-8820-4b8f-a3c1-ce4f44860afd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fe2d597c-2aed-4a65-87a8-ceb9f6704d36"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fe2f328f-ba28-4f90-b167-c933fa0507ac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fe5976f7-76e1-4d88-bac1-ad69f84b01cd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fe9157bf-87f9-4d62-9e14-b26ae994cc8f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fea6197e-a082-40ea-bcb5-9bcc4c5c6eab"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("febb188d-a682-4d57-b5cf-c6528e2ddbe3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fec116cd-b38b-4352-b573-fb094923da0e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fec50fff-b406-4866-b891-4b75c90bf57e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ff1e6f44-0a08-4a88-ae9c-7674c19f8960"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ff2b00f3-24eb-4567-a8e2-6efa6ae1c926"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ff4b2291-6436-42d3-9da4-f0dae6440a02"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ff5c5e18-76c1-49eb-86d4-ba2c6ce56a88"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ff62c2c6-61bb-4599-9d4d-51b3ff8cd2bb"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ff70b7db-ea48-4328-93e3-d5d156528ad5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ff7543ce-d330-44e8-bb87-83c09420f6a4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ff7b2ba7-767b-4929-b6b8-370966e367a9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ff88ff2f-d816-4e02-b012-680572d6f9e2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ff8a35de-0322-4360-ae43-f35b556effda"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ffacb7e9-9825-4efc-ba4d-943dad857314"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fff9b7a7-c3d3-46e2-b71e-c01548b1d716"));
        }
    }
}
