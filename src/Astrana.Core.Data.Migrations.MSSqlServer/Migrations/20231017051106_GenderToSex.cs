using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Astrana.Core.Data.Migrations.MSSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class GenderToSex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("00964717-7288-4998-8d71-64d24073776c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("02bd29e6-995c-43da-a159-289585130e60"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("038247c8-ca4e-4282-9689-c7187640728d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("049e9bf4-2c75-4b3d-83ee-34a859f90f84"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("04f753ba-4c99-48ca-b2b8-c8e357b7823a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("064c2bf2-b1ae-40b9-b039-e865380fc94a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("067410c1-3ee8-4ede-bd87-b4014b5d9790"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("073484cd-ba6c-4c77-b38d-bcfdf4118ce1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("090eb86a-ddbf-4d6c-99b5-f5d122b068f9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("0a641661-51d0-4573-9a08-7c0951717bbd"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("0aefc8af-fb9f-4aa6-9c7b-abaf9e2ba48d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("0bd10ad8-ec92-498d-87bf-8a4be188ac03"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("0c1047a6-d10c-4103-ad9b-bc99c3401150"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("0c6d912d-71a8-4cd4-b216-533763d55fe5"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("0e0a41e2-34ce-4a75-b4df-f46ccac81d08"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("0f22de26-c87e-4584-ab20-916b6f5dc756"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("134b49eb-2c53-47ac-abb4-ad02a0816244"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("13bd21b6-5293-4be5-a0d5-a9a364ab8011"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("173f7707-4ef8-4a6d-a8bd-2da91019e6b7"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("184232a4-9abd-4a9e-bd1a-0712172658bd"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1b75180f-1c82-481d-8378-def67a7d9b42"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1d724366-7c55-46dd-961d-9dcd94c57b99"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1e04941b-87e1-46b6-9d55-22b188b82f09"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1e67d4ac-8f59-449c-bf2b-2105685d8b5c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("20c0550b-1a16-417d-a7de-760f513f57a6"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("20f46dc3-3172-4763-a2bc-f4e9ac884d55"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("20fd49ee-ea93-4bf8-b0ab-89adf84daabb"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("22a6f4b7-4f52-459e-a58d-13ae9decade0"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("23cecd95-2563-440c-b6ca-36bbabe761e4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("24052cfe-ecaa-4a86-a26a-bffc25b1dac4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("24d4629b-4f3f-4cb7-b03f-1dfd784f5d28"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("26bf83fd-ef3b-4c2b-b129-dd42e6a247a1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("26c9afa8-828e-4460-b785-66567449aeb0"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("27664c03-7c77-47ee-971f-611fe6b16345"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("276c5b70-8232-4d27-883e-6c4a2b411ff6"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2811a842-2097-42ad-9695-01d172d47f20"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("288f3a50-e653-48f4-a433-9982c4e25ff7"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("28d29c20-606f-46da-8a57-48e5be0676f3"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("28f11444-ef2e-445d-8e43-2dbd88ae4179"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2ec79b08-8559-465b-934c-ed5d5550219a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2f521729-99e3-48a4-bb47-64941fec6300"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2f5ad539-259a-4300-b74a-d0c0d6fb5ec1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2fca4f35-3b91-4ef3-83d8-daa1dd24eeee"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("312c8dcb-6e08-470a-8af8-0b0f424cf633"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("319e5ebf-64d3-4fd0-8ee0-83fba26572f9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("321a746d-c0e2-4305-a528-b734f791a687"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("32f021eb-2d5d-4dbc-a7fe-7620582ce66d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("33bc4721-4ec6-48b9-8bbb-825837901768"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("35c31cfe-b7b5-4b57-bad9-df497682645c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("39d73f01-f1d0-4d66-a961-1cf4ed3a0761"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("3c117a18-4c64-466c-b45d-ae111cbb421a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("3cf5f7f8-4f63-45ce-8abc-cad1ba704775"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("3e2652de-067a-41fc-8b91-b6ae2baa997a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("3f110d3d-6b1a-49f6-8379-15d6abcf2cc1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("41a4dc7d-ca24-48ea-ab28-9e16cabdaab3"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("41bff1cd-3c5a-43d6-9622-50f7ccb0a23a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("41eea50d-e3ad-4c83-aea3-c47df84c4c71"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("44537352-20c4-4884-b33b-2bf86d15a6c1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4476e47c-64d8-4862-baa7-9bb2c5a25491"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("47ab7be1-8cd4-42d0-948a-7344ed68a3d0"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4991ffb7-b6d8-49ac-8651-bafabea95627"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4a483910-b112-44a1-a636-00c99cba2021"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4bfd5994-6618-428d-a080-21b59700dca4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4c1c6488-c92f-462e-bf33-593acf1b80e5"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4dc5aeda-ec2d-4f34-bdad-6fb6fd8d853f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4f0be5fd-406a-4d5e-bc38-f41ce4714e57"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("50731f1a-04ff-46d6-a69e-a156b796a25c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("518aec63-47c2-4c65-badc-2d7baf6da775"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("53394a65-e07e-4e34-ac9c-0dca73d5d407"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("54762e74-b663-4185-b88e-1521672113b8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("55e7a986-c9fc-47f9-bb11-f06ce1f537b4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5628fdf1-a651-4e1e-b816-d71ea5d17af0"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("56c5aa89-fe1d-4c8d-9060-285bf6ccbe0e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("56f52c3f-267c-4533-ac44-349427f956ac"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("576c86b6-a338-4f01-9839-16d766b5ed6a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("578c3cf1-af85-4bdf-9ca5-794d8be08399"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5ac9699e-e3b8-4348-9a1a-0e556199f178"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5d2f2dd3-9c04-45dc-bfc8-0e0d4bbd2734"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5ece44c4-448d-47ce-b824-d9910e4b7bb9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5f5eb2fc-5d01-4a14-8038-aef780d045f3"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6073d4e8-398c-4263-af53-3a91fe60d609"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("621ed9ad-ca2c-4a4d-a2cd-fd16d2abb50f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("631b42ae-f541-4150-9aaa-f6ad3ab69944"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("64d15a89-be39-4bbd-8ee8-4fa944a0afd9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6652f89d-f6fb-40b5-9fbe-603447af997d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6730ebd8-2d41-41f3-a768-5355ce4e61ec"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("67b6f795-b346-41b7-b21b-3680ea86518f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("68802abd-e1a0-415f-8f42-56ffa68f0099"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6938234a-f3e9-4f66-a0aa-8f6d12a841b7"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6971104f-e0d3-4191-8325-022e747534e5"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("69a2806c-803e-471f-a8fe-40fcbdcc459d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6ae150f0-4440-4ead-bed2-55d6c8c8c07a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6b3f04ac-e886-4476-a627-43bf331d1f84"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6c5373c1-009c-4130-a4e9-98be82f95089"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6d1899c0-756b-45ce-bebf-efbd6a4c90fe"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6da2a09d-a29e-42ff-8ff2-e0fb9ce3f49e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("70310c75-415e-492b-abde-b24d3e65c7ae"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("73189ab7-3de7-4e9e-a5cc-250e1a515dbc"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("74adbfbb-0212-4457-9aaa-8ace80532693"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("7624fa8b-dae9-40e5-97ce-05dfc3468f37"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("772c24ce-a2e6-4a1e-afd2-f643f6c26f9b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("773932e3-9552-4943-ac53-998dd38a6370"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("775bdaf4-5dfd-474a-b6bd-d899f7d45950"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("77cddbdc-05a5-4176-85e9-0f5e5542cc28"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("79dacaad-6a5f-4af5-9a20-1f46f87d9454"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("7a82dcd9-0e73-4668-a9bb-69c4a5d8c83f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("7b2bc23e-b7f1-4378-bb52-f23cfe51c3a0"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("7d4eda56-a58a-4512-bab6-8f8491e19217"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("814a0a10-dd88-4087-8fce-3186b72e6a8e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("8155ea9b-d6d5-4902-aaaf-c7121504fcdf"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("84525d5a-7625-499a-9b91-c1d4c90a27cd"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("84c1755b-ec5b-4c49-9d42-acd909969abc"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("84e716f3-e248-4d4b-8a0e-f50ee1475a14"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("854fb5b0-d229-4040-88a7-6d57b08d2954"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("86be6271-e1c1-43d4-90d1-89b389d975ae"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("89fe9000-2fd5-45af-906f-e05f94505ee9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("8bfb9bde-2615-4247-9627-51735b778a62"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("940372c9-6f75-4613-a0be-fd34003ad764"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("946adb5b-3a85-4727-9302-828f2a2a4be5"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9488fff1-525e-48d3-8173-bb5dbbf29898"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("94b69469-9af7-4055-8c40-042ba065cff4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("94cf0dbd-aca1-4b4a-9828-821aa0345f0d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("983b9f35-41c6-40ce-aaa8-26ccfaf5ce28"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("995e59ce-6f49-421c-8417-906e32d93d24"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9af331ed-c114-4207-8516-2eb420614859"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9b44f97e-07c0-4a6b-9902-ae52c60f47a1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9bc501bd-8bab-4409-b762-2f0d2a8439b5"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9d2569e3-56b0-44f6-8778-976527cf9295"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9de2b7a4-168f-43d4-ac16-9623453cd165"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9f0ba732-fa3c-4b29-9f77-f2a6821f42fb"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a05b5370-0fc6-422a-ac83-8cb8bcc0630e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a5f567f6-3533-48dc-87fd-73734fd6340f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a63457ab-ac95-464f-b877-17122128789e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a6c61f61-31c4-49d3-8bd9-c43f4838d526"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a6fd39b2-4969-4297-a2bc-3df0a92c9f39"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a7c57ddc-0840-461c-9e12-0632f33cc0af"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a7d64f18-58e6-4953-bfca-62e876aab5e3"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a9f22c05-931f-458a-be99-27fe697371f1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("ab7041f4-e0d3-4c1d-8d69-826aea667cbb"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("ab8361f8-e29f-4e87-8d6e-610f54d80f41"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("ac718977-4209-47bf-8adc-6710f658c2f0"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("adc23553-8832-4441-b845-ec911b9f6ad6"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("afab1d56-8058-484f-9d0b-bdff206c3a45"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b06ecb67-3d99-4c12-b86f-dd251f8b8c2b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b25bd1c7-6230-4694-944a-7cf87ab8525c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b27f8c16-7b88-4596-bd00-967c78a8cb53"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b34cd0c9-588d-4f79-9562-bb7abb5892e3"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b42f79e9-0dba-4890-8e54-804136d5aa32"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b702e656-0670-467b-a692-bd6851167326"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b932e746-f50c-464a-93d9-964dcd9824bf"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bab28b47-09c3-45b3-8738-3ba3dbeea67c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bb4f740b-07e7-47d1-a1f6-b424a2f6a142"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bb6d73e6-182b-42bf-9649-79f292f67529"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bcfa1830-4e8e-4c71-a870-e181216355b0"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("be5bd35c-d219-4da7-8f06-87e135a06f93"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("beee1bf8-8faa-48da-9633-9cc4ff36406e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bfa98b5c-e19e-4e52-9414-a805936d2417"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bfabf833-2116-47ba-85d7-1e15feb9ea44"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c0824490-7af2-4322-a9fe-35615ec8d5e6"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c0b6f32e-e7d0-423d-a3fb-f9a7229c7a95"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c3c3d774-4bb1-40d5-a74f-72342f1f32b6"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c4c48404-5805-4807-a591-04f749159fbe"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c6e48664-b2f9-4dbe-ba64-d1bf13f78c42"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c7ef6094-a521-42cf-ad75-1b67954686ba"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("caa710b8-ac40-4b20-a549-03cbcef29ecd"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("cd069aa8-e159-47fe-a1c6-c4fdc9dfce6f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d04db183-061c-4a6c-92b1-4d2d48908100"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d27f8f11-6992-42ce-bbb5-c373a4cbc856"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d371a5b0-329d-4ab5-b7f7-da270f71252b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d3e3fe6d-bc89-4e8d-9401-88dc72aafa69"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d413cac5-6b73-49fb-a7e0-780f45169ee8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d6a22864-d7d4-4d75-aa95-21be720dde31"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d7d1f50c-9dc8-4ace-ad6b-19281e464953"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d9839c64-1ad3-4fec-9af3-96123bf1e425"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d994a6a1-b745-40c9-b669-68dfa865e009"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("dafbca74-8f23-4bc8-a159-a1f54e15b3e4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("db625a3d-91c5-436a-a86f-cb284f63716c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("de26b2f2-6f00-478f-9874-b01f2d7fdadd"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e0c0b1df-4513-4d3d-89be-bc002c7c83d1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e0c66880-4690-4438-be37-cccafa3782eb"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e0cf205d-9411-4abc-bb34-ebb454b5b9c9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e19f0037-399d-42b5-b420-1ca8e307f692"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e3cb1447-79b7-4418-9f8d-ca2f22df9da3"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e4020ccc-73ef-405b-907e-79d73694caba"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e666d3bf-6279-40bb-b8dd-9e0dc35b918c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("ee3b52a9-bbe4-495b-b99b-d66bd6df6e49"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f179829a-b879-4fa7-b1fc-150246a7d2fe"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f2e6f11c-39c6-4a63-9505-3f5c09ebbe18"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f321fc29-e1a4-441c-84b2-2429b0b63880"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f5caa19f-b5ac-470f-b941-11502e55005c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f6ce71bc-2ad9-4224-931d-4c7952e568e4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f7cc648c-458c-4fc1-bc5f-b4c328e8ec6e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f98c5b06-4a14-4737-a5eb-35c407c2be65"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f9d845d9-4c52-4e20-82c3-e9fe50a6cb43"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fa9517a6-3b61-4ae8-876b-40fa8e56d7a6"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("faa407e4-4f76-4410-a100-b5326b6b66ca"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fb444d0f-6c33-4a9d-9ba0-a4168479c79c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fca3649d-8765-4656-9184-6b7416688f99"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("04410dd1-9d5f-4a73-acc5-1aeab42a9a5b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("165cbe5e-1db9-4c82-9cfe-5a18c977dc0e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("170a4c38-1ca5-4733-b9ea-bd323ebd4aca"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("46e07ae0-486e-4005-8627-43364dc24fb2"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("99393d7f-391f-474e-9cdb-835dc6015e2f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("9f4475ba-d4a3-428d-a0ad-5dda0deaaa88"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("aa6e11b7-10cb-4bc9-9a0f-071588b3a5d3"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("c589b4ac-7b33-40e3-b9d8-fa53202370ee"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("f10e5f73-a2cf-40da-b5d7-656aea34398b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("013a9b63-03b8-4eab-b0a8-f1cfd8850840"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("4a0f5249-c415-4408-83e9-62e5a5e85d74"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("7f0e603b-a61f-49d4-8d4d-4f15ae5c1f71"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("908f782d-4420-4071-bc1c-2a5506f1a8bb"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("a5eb79ab-3594-48bd-aeb6-be786cf478b7"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("a73dc3c2-3c25-490e-ad17-3e8fab4f072b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("c2c2339a-0f32-41fd-9fff-1ea199a894eb"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("f0e2411e-ad11-4644-9ccb-69d394a1b22f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("0045fc7c-b41d-4a36-af65-4b1535c6087d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("1729c0af-c1ce-40d2-b6a7-5c510d0cb084"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("38abb707-2752-48c1-a230-f977ed58b718"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("4dd8aa9f-5300-4da4-9906-775f7c9bdfdf"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("4f8f263e-9dfc-4397-bfc3-1f6bdc1d4d39"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("7e3b6b91-8c1f-4f8b-89e4-7ba6479a4a0e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("9e4c339b-26c6-4373-a63d-c8bd55ab79b0"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("ddd17fd2-9aa2-4485-80d7-c65f3a957da8"));

            migrationBuilder.RenameColumn(
                name: "Gender",
                schema: "user",
                table: "UserProfiles",
                newName: "Sex");

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(9576), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Feelings",
                columns: new[] { "FeelingId", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "IconName", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ShortCode", "UnicodeIcon" },
                values: new object[,]
                {
                    { new Guid("028631bc-f775-43b2-8f5e-2acda5824db8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "better", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Better", "feeling_name_better", "", "" },
                    { new Guid("02d4736f-0ed0-4e4f-8363-7ae783edc752"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lazy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Lazy", "feeling_name_lazy", "", "" },
                    { new Guid("03b1ad99-bf95-4f6f-af00-a2f404ca2b65"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thirsty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Thirsty", "feeling_name_thirsty", "", "" },
                    { new Guid("03c45b4c-6dad-4f6d-a1a1-448aa03696b4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nauseous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Nauseous", "feeling_name_nauseous", "", "" },
                    { new Guid("04814c4c-4772-4292-bacc-802736bcd2bd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bored", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Bored", "feeling_name_bored", "", "" },
                    { new Guid("0c75133d-a2bb-4771-9415-e9a5863448e9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "loved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Loved", "feeling_name_loved", "", "🥰" },
                    { new Guid("0c8d230c-4d1a-4c9d-9475-80b3edfe3d0e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "alive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Alive", "feeling_name_alive", "", "" },
                    { new Guid("0fc92a25-d265-49ed-a7c6-6615209192e3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ready", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Ready", "feeling_name_ready", "", "" },
                    { new Guid("10214977-365a-4248-a20c-0825414f0172"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "weak", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Weak", "feeling_name_weak", "", "" },
                    { new Guid("124813e9-1cd1-4dfc-bf15-c7bddaad1a17"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "threatened", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Threatened", "feeling_name_threatened", "", "" },
                    { new Guid("14470652-0249-4b07-8bfd-f1658c1aeb42"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "aggravated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Aggravated", "feeling_name_aggravated", "", "" },
                    { new Guid("1500a195-d011-4457-a49c-e15cc63bcc1f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rich", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Rich", "feeling_name_rich", "", "🤑" },
                    { new Guid("15685cfb-fccb-4f5b-bc58-3dc02e741008"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "impatient", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Impatient", "feeling_name_impatient", "", "" },
                    { new Guid("1652d73a-f4f8-47c0-8f34-e200f89f69dc"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "busy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Busy", "feeling_name_busy", "", "" },
                    { new Guid("17c7bc55-6c3c-476f-9db5-d6b650ac94eb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "evil", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Evil", "feeling_name_evil", "", "" },
                    { new Guid("183d9984-12d6-439f-881d-7a013e714ecf"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "beautiful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Beautiful", "feeling_name_beautiful", "", "" },
                    { new Guid("18e180ba-c5b5-44d2-8564-7f11ee59bdd5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "miserable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Miserable", "feeling_name_miserable", "", "" },
                    { new Guid("1966f6df-69e2-41a5-be73-c43f3236cbe8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "offended", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Offended", "feeling_name_offended", "", "" },
                    { new Guid("19ebdefb-bcd1-4b7e-90aa-0d17263aa88f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "well", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Well", "feeling_name_well", "", "" },
                    { new Guid("1b976872-804b-4865-89f1-9ffca9958da8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "proud", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Proud", "feeling_name_proud", "", "" },
                    { new Guid("1cc563ef-bbd7-48ae-a30a-6fe2b9b6c16e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dirty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Dirty", "feeling_name_dirty", "", "" },
                    { new Guid("1d239f26-fbb5-44e4-91b4-3b18e393e99a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amazing", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Amazing", "feeling_name_amazing", "", "" },
                    { new Guid("1d2a1fec-a949-4154-862b-1cd487d29538"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "heartbroken", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Heartbroken", "feeling_name_heartbroken", "", "" },
                    { new Guid("1d54db2e-c176-48d2-b3d4-1f3010f4a2df"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Mad", "feeling_name_mad", "", "" },
                    { new Guid("1ee4bfcd-ad30-49cb-96be-ae4e5c6d5adc"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "exhausted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Exhausted", "feeling_name_exhausted", "", "" },
                    { new Guid("2042821a-f9d0-4d79-ad2b-2448b81df68a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "super", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Super", "feeling_name_super", "", "" },
                    { new Guid("206540e1-6b0c-430e-ac07-0f07e67fedda"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stuck", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Stuck", "feeling_name_stuck", "", "" },
                    { new Guid("23c5fce0-4db9-4276-9df1-4904379d972d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "numb", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Numb", "feeling_name_numb", "", "" },
                    { new Guid("24c0e091-1426-40f2-8e40-b4be30acf564"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "comfortable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Comfortable", "feeling_name_comfortable", "", "" },
                    { new Guid("25f6b07a-273f-4621-8945-70f4ec5f2a7f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "relaxed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Relaxed", "feeling_name_relaxed", "", "" },
                    { new Guid("26a2a5a1-2e2f-47fe-a088-78d17c07a220"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "trapped", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Trapped", "feeling_name_trapped", "", "" },
                    { new Guid("26b77fb1-9176-4798-8858-c92e5c60c87c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "human", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Human", "feeling_name_human", "", "" },
                    { new Guid("27652c78-2fb2-4487-8360-a42e53c5f195"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "anxious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Anxious", "feeling_name_anxious", "", "" },
                    { new Guid("27a75cdb-55cc-44ac-be8f-6146576da1f5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tired", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Tired", "feeling_name_tired", "", "" },
                    { new Guid("2c256164-99f3-4ca8-a4e6-3adfe2e7712b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "small", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Small", "feeling_name_small", "", "" },
                    { new Guid("2d380e07-593e-48f2-b5a0-8475d7f1d330"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "energised", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Energised", "feeling_name_energised", "", "" },
                    { new Guid("2d5d8863-7739-4c86-a8e7-ad334b2b9800"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "safe", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Safe", "feeling_name_safe", "", "" },
                    { new Guid("2dbf7647-a7f1-47f9-af35-439e705a8fa6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "appreciated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Appreciated", "feeling_name_appreciated", "", "" },
                    { new Guid("2e6a73f9-66ee-4483-8da5-977aada0266d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "drained", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Drained", "feeling_name_drained", "", "" },
                    { new Guid("2ef94209-39a3-4f83-b5e4-f2d2a47d4a72"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "disappointed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Disappointed", "feeling_name_disappointed", "", "" },
                    { new Guid("2f0c1821-2c82-4c4e-86a8-ab5534a0d30d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "yucky", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Yucky", "feeling_name_yucky", "", "" },
                    { new Guid("2f4b0b19-b882-4dac-becf-3b291401d20d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "glad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Glad", "feeling_name_glad", "", "" },
                    { new Guid("309e6cd1-3628-4998-8aab-a734afae2090"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "broken", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Broken", "feeling_name_broken", "", "" },
                    { new Guid("35435ed3-5a70-4620-9779-5b6681ade365"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "inspired", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Inspired", "feeling_name_inspired", "", "" },
                    { new Guid("38212858-b40a-4ed9-a594-59b070d50ba2"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "confident", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Confident", "feeling_name_confident", "", "😏" },
                    { new Guid("38336107-a04b-44b2-8711-590b9a9e60ae"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "great", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Great", "feeling_name_great", "", "" },
                    { new Guid("3991bb48-9c99-4e6f-b6d1-026737f92414"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Sad", "feeling_name_sad", "", "🙁" },
                    { new Guid("3b23fb60-88cf-4925-8fdc-3330310677f1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "challenged", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Challenged", "feeling_name_challenged", "", "" },
                    { new Guid("3b7e7504-027b-4bc0-8131-d533a4f65f99"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "satisfied", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Satisfied", "feeling_name_satisfied", "", "" },
                    { new Guid("406caf19-dc49-428e-bc68-fccfdb61ea88"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "insecure", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Insecure", "feeling_name_insecure", "", "" },
                    { new Guid("41ae6725-da72-4c14-a9e0-003e3ce02ad8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "strange", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Strange", "feeling_name_strange", "", "" },
                    { new Guid("41e59e54-be10-4d79-be7f-12fee35b1176"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "delighted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Delighted", "feeling_name_delighted", "", "" },
                    { new Guid("423daf63-a7dd-431f-81c9-6e1ae8dc6f97"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "grateful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Grateful", "feeling_name_grateful", "", "😄" },
                    { new Guid("43e4b9fa-a448-45b2-9f40-30f2d04a7c99"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worse", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Worse", "feeling_name_worse", "", "" },
                    { new Guid("4737ecbf-b753-4838-82c7-041a14d57257"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "asleep", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Asleep", "feeling_name_asleep", "", "" },
                    { new Guid("474299ce-560e-4292-880b-e320b6436b41"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "peaceful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Peaceful", "feeling_name_peaceful", "", "" },
                    { new Guid("4799361d-bb9f-4a33-8e5e-bba6e8bde70a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "OK", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Ok", "feeling_name_OK", "", "👌" },
                    { new Guid("491a5aa1-6618-4798-83f8-539bc73159e1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mighty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Mighty", "feeling_name_mighty", "", "" },
                    { new Guid("49c640db-215a-463b-8201-ecbd75843432"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "surprised", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Surprised", "feeling_name_surprised", "", "" },
                    { new Guid("4a878e01-4039-4e32-b167-7a5e1aacddfa"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lovely", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Lovely", "feeling_name_lovely", "", "🥰" },
                    { new Guid("4c258798-78d1-475c-8724-953543f6f01a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "light", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Light", "feeling_name_light", "", "" },
                    { new Guid("4effcaf2-ed9e-4e4b-ad91-2986870e9b6c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pumped", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Pumped", "feeling_name_pumped", "", "" },
                    { new Guid("4f3eac30-6cda-4125-896e-4aa3c1bae075"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sore", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Sore", "feeling_name_sore", "", "" },
                    { new Guid("4f93e2c0-29fc-4a24-bdac-90aedf4c2404"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worthless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Worthless", "feeling_name_worthless", "", "" },
                    { new Guid("52649244-328c-4fb6-bd9b-5ddf2cc07b36"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "down", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Down", "feeling_name_down", "", "" },
                    { new Guid("540600e3-b883-4416-813a-3c84c88aebe6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stressed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Stressed", "feeling_name_stressed", "", "" },
                    { new Guid("540ff1d6-6197-4294-b75f-038e52b70db9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "chill", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Chill", "feeling_name_chill", "", "" },
                    { new Guid("55a4243b-3422-44ce-b666-baf4d0f13f46"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thoughtful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Thoughtful", "feeling_name_thoughtful", "", "🤔" },
                    { new Guid("55d516aa-08c2-4e86-bdd7-051e508689cb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sick", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Sick", "feeling_name_sick", "", "🤢" },
                    { new Guid("57c444be-c71b-4a09-853b-1f3801192beb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "accomplished", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Accomplished", "feeling_name_accomplished", "", "" },
                    { new Guid("58b81adb-13ea-4a54-bbf4-806b5c341fd1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dumb", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Dumb", "feeling_name_dumb", "", "" },
                    { new Guid("5a272e06-d6fe-447f-9316-e26b7e5c0658"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "warm", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Warm", "feeling_name_warm", "", "" },
                    { new Guid("5b345189-a401-4066-8b84-8e710c068458"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "different", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Different", "feeling_name_different", "", "" },
                    { new Guid("5b7d6777-36f5-4ee6-9848-04913c026041"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "upset", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Upset", "feeling_name_upset", "", "" },
                    { new Guid("5ca3c138-443b-4bda-b655-b6fdf97947f0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "overwhelmed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Overwhelmed", "feeling_name_overwhelmed", "", "" },
                    { new Guid("5cbba6ed-6590-4868-b9a3-a5cc1c114f0a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "puzzled", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Puzzled", "feeling_name_puzzled", "", "" },
                    { new Guid("5cc0c1ca-4937-44a0-9f86-64ac90ae9cfe"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thankful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Thankful", "feeling_name_thankful", "", "😄" },
                    { new Guid("5d14a327-96ca-41bb-8ab7-852f5b952845"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hungry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Hungry", "feeling_name_hungry", "", "" },
                    { new Guid("60cd12ea-ac87-4b23-ad9d-1176893c1c87"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ashamed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Ashamed", "feeling_name_ashamed", "", "" },
                    { new Guid("61e7c7fa-7291-4cdb-992f-83eec3eb9588"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "betrayed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Betrayed", "feeling_name_betrayed", "", "" },
                    { new Guid("62ce6df7-8034-453b-a2eb-792206f6d4db"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "curious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Curious", "feeling_name_curious", "", "" },
                    { new Guid("62ffbeed-1811-45a1-b207-b2af328d2612"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "perfect", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Perfect", "feeling_name_perfect", "", "" },
                    { new Guid("6364a590-040e-452f-ae9d-d84cec6055d4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "embarrassed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Embarrassed", "feeling_name_embarrassed", "", "" },
                    { new Guid("63ac6fba-c784-4f16-8afd-12e9699bc28f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "kind", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Kind", "feeling_name_kind", "", "" },
                    { new Guid("6414094d-d055-4345-8b6c-2d324911b637"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worried", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Worried", "feeling_name_worried", "", "" },
                    { new Guid("65caa8b8-f096-4e3d-b3d3-c3cc54aeceab"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "naked", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Naked", "feeling_name_naked", "", "" },
                    { new Guid("682c3c74-779a-44d9-b9ac-03699bfae2c9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "jealous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Jealous", "feeling_name_jealous", "", "" },
                    { new Guid("69eb5ea6-44dd-4048-8b75-c266dd29b33b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "guilty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Guilty", "feeling_name_guilty", "", "" },
                    { new Guid("6a89bdd9-748b-432e-8837-5a36bc46704a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "invisible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Invisible", "feeling_name_invisible", "", "🫥" },
                    { new Guid("6ab2bbb1-e6a1-467d-977b-86be064e3623"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "positive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Positive", "feeling_name_positive", "", "" },
                    { new Guid("6ad4cf5e-42cc-43ef-96f2-2ec8ff18bb0d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "honoured", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Honoured", "feeling_name_honoured", "", "" },
                    { new Guid("6af002d9-ee95-4999-a629-395b0b5b73a5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cool", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Cool", "feeling_name_cool", "", "" },
                    { new Guid("6da32232-1957-4a13-bd1d-5dd653c60779"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unimportant", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Unimportant", "feeling_name_unimportant", "", "" },
                    { new Guid("6e238c90-43da-42e2-b398-4fabfe4987cd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pretty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Pretty", "feeling_name_pretty", "", "" },
                    { new Guid("6eb6ff00-cb09-4ed8-a048-dc962b0964b7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "scared", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Scared", "feeling_name_scared", "", "" },
                    { new Guid("6f66e4e7-10ac-417e-9558-46c1127f7907"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "perplexed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Perplexed", "feeling_name_perplexed", "", "" },
                    { new Guid("70195869-493c-47fb-8a1e-a720af8a9f9d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awesome", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Awesome", "feeling_name_awesome", "", "" },
                    { new Guid("70d32eeb-5c73-4a3c-b3bd-9f9d030720cc"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lonely", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Lonely", "feeling_name_lonely", "", "" },
                    { new Guid("714fd590-0609-47d0-8139-360da6a534dc"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cute", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Cute", "feeling_name_cute", "", "" },
                    { new Guid("723503ee-3103-44d7-bad9-a1e8e0295ad9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unloved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Unloved", "feeling_name_unloved", "", "" },
                    { new Guid("74feed8e-70eb-4d32-ba5b-ece8b27aaff4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "depressed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Depressed", "feeling_name_depressed", "", "" },
                    { new Guid("7582dec4-4786-4be7-bb59-5ed367383ac2"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wonderful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Wonderful", "feeling_name_wonderful", "", "" },
                    { new Guid("77243152-ad89-488b-817c-82e8235703d8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blah", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Blah", "feeling_name_blah", "", "" },
                    { new Guid("7b866603-e54c-4280-83ec-1a5c1b6fa14d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sleepy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Sleepy", "feeling_name_sleepy", "", "" },
                    { new Guid("7de93c24-4834-4f04-af97-39c2cb1134f8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "furious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Furious", "feeling_name_furious", "", "" },
                    { new Guid("7deadfbc-6ab0-4b3c-8046-1f8c36d8131e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "goofy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Goofy", "feeling_name_goofy", "", "🤪" },
                    { new Guid("7df97ff9-fbf3-4c92-b069-ff533e8a447c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nostalgic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Nostalgic", "feeling_name_nostalgic", "", "" },
                    { new Guid("7e2df330-f067-46a4-bc4b-ff344f1b0225"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hurt", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Hurt", "feeling_name_hurt", "", "" },
                    { new Guid("81732217-edee-4f67-bac5-d3690f357c65"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "secure", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Secure", "feeling_name_secure", "", "" },
                    { new Guid("826197e3-dd50-4c1b-8343-7d42b5948d02"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "crazy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Crazy", "feeling_name_crazy", "", "🤪" },
                    { new Guid("82dc4dad-79e6-4cce-8fd0-7693828cb108"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "regret", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Regret", "feeling_name_regret", "", "" },
                    { new Guid("835434bd-b345-44b7-bb1c-560fcff1f9e8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "missing", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Missing", "feeling_name_missing", "", "" },
                    { new Guid("881adec8-f124-4b27-80f4-23388a9d55c1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "normal", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Normal", "feeling_name_normal", "", "" },
                    { new Guid("891b9c5d-70f4-498a-88f1-96944f6e21de"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "meh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Meh", "feeling_name_meh", "", "😐️" },
                    { new Guid("8bcef76d-a9f2-42ee-8fee-da17d88af189"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "professional", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Professional", "feeling_name_professional", "", "" },
                    { new Guid("8e06b868-6894-44b5-8cce-9702b4a567a7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awkward", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Awkward", "feeling_name_awkward", "", "" },
                    { new Guid("90ea9308-f213-43f3-a226-0d22e990e596"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "helpless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Helpless", "feeling_name_helpless", "", "" },
                    { new Guid("917a5865-0b77-42b6-bd73-b50770b2717e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sarcastic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Sarcastic", "feeling_name_sarcastic", "", "" },
                    { new Guid("91ae002e-385c-4b93-a9c0-4edf8e39424d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "confused", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Confused", "feeling_name_confused", "", "😕" },
                    { new Guid("93d5ed32-f822-40be-ac40-efc38169a84c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "happy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Happy", "feeling_name_happy", "", "😀" },
                    { new Guid("9af16d69-f1ac-40b1-a319-bc437abb352b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "funny", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Funny", "feeling_name_funny", "", "" },
                    { new Guid("9e83e8a6-f34f-4cb0-b404-3a35fddc2887"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amused", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Amused", "feeling_name_amused", "", "" },
                    { new Guid("9eb04e50-2c51-484f-b39d-c2e1ef9e6d47"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "free", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Free", "feeling_name_free", "", "" },
                    { new Guid("9edd7168-4011-4a50-bdd1-77815a316606"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "low", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Low", "feeling_name_low", "", "" },
                    { new Guid("9f970fcc-6ed7-4d51-88ff-c0bd21e45a00"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fantastic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Fantastic", "feeling_name_fantastic", "", "" },
                    { new Guid("a07d825c-0979-4692-abe6-8239964503e3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "full", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Full", "feeling_name_full", "", "" },
                    { new Guid("a2832a65-5147-49b5-8494-a8e05bbdac57"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "calm", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Calm", "feeling_name_calm", "", "" },
                    { new Guid("a2994840-2e8a-45e7-b658-9ce23435148f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hung-over", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Hung-Over", "feeling_name_hung-over", "", "" },
                    { new Guid("a384c832-0b01-471c-8a72-906f40e8eb76"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "alone", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Alone", "feeling_name_alone", "", "" },
                    { new Guid("a552d8eb-3716-4640-a1ff-909d04586dd1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Awful", "feeling_name_awful", "", "" },
                    { new Guid("aaebd8dc-ccb1-429e-ad86-0316a300928e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "in love", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "In Love", "feeling_name_in_love", "", "🥰" },
                    { new Guid("adfee0ed-fad7-4f73-9a49-13e052ca9ed5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nervous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Nervous", "feeling_name_nervous", "", "" },
                    { new Guid("ae72fbdd-1498-4fc8-b95d-2b429fa7afb8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rough", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Rough", "feeling_name_rough", "", "" },
                    { new Guid("af5e22e3-3485-4ccf-b37c-8aaa02b1eef7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "shy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Shy", "feeling_name_shy", "", "" },
                    { new Guid("b08f61ee-92df-43e5-910d-c4503faa84ef"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "qualified", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Qualified", "feeling_name_qualified", "", "" },
                    { new Guid("b3537a7d-76c4-44ab-9803-6afc1113c808"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "useless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Useless", "feeling_name_useless", "", "" },
                    { new Guid("b5eaa145-6503-49a3-9917-f34cf34aded8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "old", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Old", "feeling_name_old", "", "" },
                    { new Guid("b6f801e3-8b85-495c-b5aa-ebb3e702ccd4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pained", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Pained", "feeling_name_pained", "", "" },
                    { new Guid("b73cdfbd-2dab-450b-8a1d-bdcf96db1f8d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Bad", "feeling_name_bad", "", "" },
                    { new Guid("b8c7e468-6ac7-42a0-aa89-ead644908b40"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "silly", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Silly", "feeling_name_silly", "", "😜" },
                    { new Guid("b8c9246d-53b1-4223-b51a-13159519d66b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "terrible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Terrible", "feeling_name_terrible", "", "" },
                    { new Guid("b921deb6-7916-499c-b4da-5d782127b9ed"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "important", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Important", "feeling_name_important", "", "" },
                    { new Guid("bc191512-27b8-472f-9452-4f3e9205c23e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "broke", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Broke", "feeling_name_broke", "", "" },
                    { new Guid("bccaab3a-3d30-49b5-a675-64a99488f8aa"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "motivated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Motivated", "feeling_name_motivated", "", "" },
                    { new Guid("bd0a57b8-d79e-4881-b456-86c1361ef50d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "uncomfortable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Uncomfortable", "feeling_name_uncomfortable", "", "" },
                    { new Guid("bd196ec0-9944-4cc1-946f-bedee4e94a72"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rested", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Rested", "feeling_name_rested", "", "" },
                    { new Guid("bd9aba73-7eb4-4fff-bbce-8b2f38e29b05"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "irritated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Irritated", "feeling_name_irritated", "", "" },
                    { new Guid("bed3ce59-6d38-4c43-a96b-501bf80a6e6d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lucky", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Lucky", "feeling_name_lucky", "", "" },
                    { new Guid("bfb14bf6-f8e2-4cfe-8b73-1c7d136c5064"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "refreshed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Refreshed", "feeling_name_refreshed", "", "" },
                    { new Guid("c247aa23-7f74-4c48-9066-bf37faeb4ddf"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sorry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Sorry", "feeling_name_sorry", "", "" },
                    { new Guid("c4df1d3c-db76-4e28-aa39-f6463f8c1c82"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nice", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Nice", "feeling_name_nice", "", "" },
                    { new Guid("c536963b-dc19-46a4-9fdf-9b1f650d1c0a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "drunk", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Drunk", "feeling_name_drunk", "", "" },
                    { new Guid("c7b7a872-a537-4cc7-a357-813c67bf5532"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fabulous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Fabulous", "feeling_name_fabulous", "", "" },
                    { new Guid("c8479aa5-8cbd-47c6-9f7a-103976a25c8d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "jolly", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Jolly", "feeling_name_jolly", "", "" },
                    { new Guid("c90fda68-4044-4841-96d9-904257a17cb3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hyper", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Hyper", "feeling_name_hyper", "", "" },
                    { new Guid("c9d7f7ed-525f-4cfe-9c3a-3fb6ae467184"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blissful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Blissful", "feeling_name_blissful", "", "😊" },
                    { new Guid("ca8bf7a9-0ac4-49a0-ab0f-038f21692a0b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "annoyed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Annoyed", "feeling_name_annoyed", "", "😒" },
                    { new Guid("cb024a69-21bc-4873-9ae5-a44e3c2f7bf5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "deep", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Deep", "feeling_name_deep", "", "" },
                    { new Guid("cbba1074-f6ee-4778-ab8f-cf7e03e98337"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ignored", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Ignored", "feeling_name_ignored", "", "" },
                    { new Guid("cc0358dd-535b-407b-ba36-1858f18c6cbc"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "excited", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Excited", "feeling_name_excited", "", "🤩" },
                    { new Guid("cf3d34d6-8fbc-4d7b-9f83-494556d2422d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "optimistic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Optimistic", "feeling_name_optimistic", "", "" },
                    { new Guid("d032c436-65c7-4b46-ac9d-8a3b44eab0a4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "horrible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Horrible", "feeling_name_horrible", "", "" },
                    { new Guid("d07f49ad-7895-4283-b1f6-a20ec0a6e866"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "joyful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Joyful", "feeling_name_joyful", "", "" },
                    { new Guid("d1cf46a6-842f-491d-9bad-25a9d325f2d7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "special", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Special", "feeling_name_special", "", "" },
                    { new Guid("d257f70b-93db-42fb-a661-0831a4f7b9a9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unwanted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Unwanted", "feeling_name_unwanted", "", "" },
                    { new Guid("d676cdcc-c30d-41e8-bd5f-3f56fc6b8a27"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stupid", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Stupid", "feeling_name_stupid", "", "" },
                    { new Guid("d6e14eaa-f53c-4ded-b9e0-d1c463fc457c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amazed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Amazed", "feeling_name_amazed", "", "" },
                    { new Guid("d78e25f8-5f97-4e76-8422-4ead268cf4dd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "incomplete", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Incomplete", "feeling_name_incomplete", "", "" },
                    { new Guid("dae44c92-9754-407c-b5c5-73f362e4f582"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "concerned", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Concerned", "feeling_name_concerned", "", "" },
                    { new Guid("db8bf1f3-eda5-441b-bbae-b1010c9fed95"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "weird", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Weird", "feeling_name_weird", "", "" },
                    { new Guid("dc471c85-5bee-4345-ad02-a9485c737da0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lost", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Lost", "feeling_name_lost", "", "" },
                    { new Guid("df3b8d48-cbd1-45dc-8bc7-58a0115f011e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "privileged", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Privileged", "feeling_name_privileged", "", "" },
                    { new Guid("e067074d-de94-4c6b-9361-4e50008433ea"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cheated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Cheated", "feeling_name_cheated", "", "" },
                    { new Guid("e0a681da-52a7-4803-a325-b76791b56488"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "strong", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Strong", "feeling_name_strong", "", "" },
                    { new Guid("e0be6f0d-280d-4002-8933-0b37cc84114f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "emotional", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Emotional", "feeling_name_emotional", "", "" },
                    { new Guid("e34087fb-c670-48da-8a39-1c709a19e692"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "festive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Festive", "feeling_name_festive", "", "" },
                    { new Guid("e518941b-202a-4086-8ecb-e5c9991168f8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "good", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Good", "feeling_name_good", "", "" },
                    { new Guid("e646bcb7-85a1-4faa-ab22-f4663f6a008c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hopeful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Hopeful", "feeling_name_hopeful", "", "" },
                    { new Guid("e6908276-c16b-441e-b827-6019f0e6bac9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "generous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Generous", "feeling_name_generous", "", "" },
                    { new Guid("e962dca4-8e1f-42fb-a48c-7881ab719435"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mischievous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Mischievous", "feeling_name_mischievous", "", "" },
                    { new Guid("e99dcfdc-ada5-44fb-ba02-e7c597d29b20"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "smart", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Smart", "feeling_name_smart", "", "" },
                    { new Guid("eaa5b765-35c8-4117-a32d-6381b3c9e641"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "relieved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Relieved", "feeling_name_relieved", "", "" },
                    { new Guid("eb0e16c6-2807-4d95-a935-98b4d28d4335"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "afraid", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Afraid", "feeling_name_afraid", "", "😨" },
                    { new Guid("ebfb514b-1ce9-48e4-9b93-257290895e20"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "healthy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Healthy", "feeling_name_healthy", "", "😊" },
                    { new Guid("f00ea920-2fef-453d-b897-cc4620b34182"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "angry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Angry", "feeling_name_angry", "", "😠" },
                    { new Guid("f046c5c5-128d-461a-8a54-f79cb8701f51"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Fed", "feeling_name_fed", "", "" },
                    { new Guid("f270e09a-0860-4a38-b189-58cf07303142"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blessed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Blessed", "feeling_name_blessed", "", "😇" },
                    { new Guid("f3bcc0dc-f7c8-410f-b43e-5d10dbbe69ec"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "determined", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Determined", "feeling_name_determined", "", "" },
                    { new Guid("f6db017d-3faf-4b67-824d-e7d1e31ce9ce"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "frustrated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Frustrated", "feeling_name_frustrated", "", "" },
                    { new Guid("fa0a558c-492a-4165-948d-0bd24a143982"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wanted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Wanted", "feeling_name_wanted", "", "" },
                    { new Guid("fa2aaa8e-de1b-4e57-9529-bd2eb6b4eeef"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hopeless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Hopeless", "feeling_name_hopeless", "", "" },
                    { new Guid("fad0a0cd-37bd-449d-a9d3-744e62c02f18"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cold", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Cold", "feeling_name_cold", "", "" },
                    { new Guid("fb0bc483-9542-437c-a0f9-35dab542bd9e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "whole", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Whole", "feeling_name_whole", "", "" },
                    { new Guid("fb0e1d4d-b000-4103-868c-15c1dbfef3b1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fine", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Fine", "feeling_name_fine", "", "" },
                    { new Guid("fc4d0549-1915-474a-a1ef-73b0a649c151"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "welcome", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Welcome", "feeling_name_welcome", "", "" },
                    { new Guid("fc7cba02-79ae-47a9-8182-192be15db3ef"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "crappy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Crappy", "feeling_name_crappy", "", "" },
                    { new Guid("fcbd18ff-eaf1-4589-a259-0409123e913a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fresh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Fresh", "feeling_name_fresh", "", "" },
                    { new Guid("fd36f52a-9fbc-4428-b890-5c593c592a98"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blue", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(1788), new TimeSpan(0, 0, 0, 0, 0)), "Blue", "feeling_name_blue", "", "" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "Direction", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ThreeLetterCode", "TwoLetterCode" },
                values: new object[,]
                {
                    { new Guid("07d45156-2a0c-4888-b430-6de8dd3216b9"), "ZU", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), "Zulu", "language_name_zu", "ZUL", "ZU" },
                    { new Guid("1b183233-744c-43ac-bf02-764fbc3dd221"), "FR", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), "French", "language_name_fr", "FRA", "FR" },
                    { new Guid("1c4ccb5d-df13-4781-b6d4-adcde4fb5662"), "HI", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), "Hindi", "language_name_hi", "HIN", "HI" },
                    { new Guid("3466ab9a-9a55-4e78-b0a3-a02122e33b8f"), "RU", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), "Russian", "language_name_ru", "RUS", "RU" },
                    { new Guid("61eeca5b-b0f5-4b7f-9fad-e8cb637e5a63"), "HE", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 1, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), "Hebrew", "language_name_he", "HEB", "HE" },
                    { new Guid("805fbf3c-59cf-4a63-aff6-c374f92fc797"), "ZH", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), "Chinese", "language_name_zh", "ZHO", "ZH" },
                    { new Guid("b48dc8af-07bb-497c-a991-185c7973e4a2"), "AF", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), "Afrikaans", "language_name_af", "AFR", "AF" },
                    { new Guid("bed801a0-6416-4b54-8a49-21c68b4c9e30"), "ES", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), "Spanish", "language_name_es", "ESP", "ES" },
                    { new Guid("e177f501-b47f-4a4b-bf28-446c6df606c6"), "EN", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(7593), new TimeSpan(0, 0, 0, 0, 0)), "English", "language_name_en", "ENG", "EN" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Reactions",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "IconName", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "UnicodeIcon" },
                values: new object[,]
                {
                    { new Guid("20788f1b-1726-4a6b-8453-a3acddc5aaa0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wow", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), "Wow", "reaction_name_wow", "1" },
                    { new Guid("3c3f5939-f359-48f2-98e6-c69639d3424d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "love", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), "Love", "reaction_name_love", "1" },
                    { new Guid("817a8597-9f5f-4b4f-b3bb-bf28eddd88cd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "like", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), "Like", "reaction_name_like", "1" },
                    { new Guid("a439b585-5d5f-49f5-a4b9-e8912dc54303"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), "Sad", "reaction_name_sad", "1" },
                    { new Guid("ad9a1575-3f9b-4fe9-8328-1f7feddb7327"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "angry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), "Angry", "reaction_name_angry", "1" },
                    { new Guid("c787bc85-c8dc-48ca-894a-224f0dc93c85"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "laugh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), "Haha", "reaction_name_laugh", "1" },
                    { new Guid("e84ff2fc-de72-466d-b1aa-185cfbe18092"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dislike", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), "Dislike", "reaction_name_dislike", "1" },
                    { new Guid("fa9c3d04-b6d6-4aeb-b50e-0b315cb6223a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "care", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 324, DateTimeKind.Unspecified).AddTicks(747), new TimeSpan(0, 0, 0, 0, 0)), "Care", "reaction_name_care", "1" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Settings",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DataType", "DefaultValue", "HelpText", "LastModifiedBy", "LastModifiedTimestamp", "Name", "SettingCategoryId", "ShortDescription", "Value" },
                values: new object[,]
                {
                    { new Guid("185f218c-9498-426a-95df-37bcc79f2950"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), 1, "0", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), "Multi-factor Authentication", null, "Turn multi-factor authentication on/off.", null },
                    { new Guid("3a7b8bde-1759-4627-9a95-024de2b690a4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), 21, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), "Default Skin Tone", null, "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.", "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C" },
                    { new Guid("3dc70ce7-c84b-46f5-a108-39d3608b2967"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), 4, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), "Idp Issuer Signing Key Secret", null, "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.", "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C" },
                    { new Guid("67dc7d1a-ab7d-4195-9597-53b9f7a64e8b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), 4, "localhost", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), "Host Name", null, "The address of the Astrana instance.", null },
                    { new Guid("7cfb8da9-0274-49bc-a765-147fbcc19480"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), 4, "AUS Eastern Standard Time", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), "Time Zone", null, "The time zone of the Astrana instance user.", null },
                    { new Guid("a86944b0-6e81-40c3-be81-1991ee3114a4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), 4, "AU", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), "Regional Format", null, "Formats for dates, times and numbers.", null },
                    { new Guid("c13e29bc-117b-4a3e-9485-367fb6979b21"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), 4, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), "Host Port Number", null, "The host port number of the Astrana instance.", null },
                    { new Guid("c672c189-a767-4683-a735-5607f496d0bd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), 4, "EN", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 17, 5, 11, 6, 323, DateTimeKind.Unspecified).AddTicks(3248), new TimeSpan(0, 0, 0, 0, 0)), "Language Code", null, "The language code of the Astrana instance user.", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("028631bc-f775-43b2-8f5e-2acda5824db8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("02d4736f-0ed0-4e4f-8363-7ae783edc752"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("03b1ad99-bf95-4f6f-af00-a2f404ca2b65"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("03c45b4c-6dad-4f6d-a1a1-448aa03696b4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("04814c4c-4772-4292-bacc-802736bcd2bd"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("0c75133d-a2bb-4771-9415-e9a5863448e9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("0c8d230c-4d1a-4c9d-9475-80b3edfe3d0e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("0fc92a25-d265-49ed-a7c6-6615209192e3"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("10214977-365a-4248-a20c-0825414f0172"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("124813e9-1cd1-4dfc-bf15-c7bddaad1a17"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("14470652-0249-4b07-8bfd-f1658c1aeb42"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1500a195-d011-4457-a49c-e15cc63bcc1f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("15685cfb-fccb-4f5b-bc58-3dc02e741008"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1652d73a-f4f8-47c0-8f34-e200f89f69dc"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("17c7bc55-6c3c-476f-9db5-d6b650ac94eb"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("183d9984-12d6-439f-881d-7a013e714ecf"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("18e180ba-c5b5-44d2-8564-7f11ee59bdd5"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1966f6df-69e2-41a5-be73-c43f3236cbe8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("19ebdefb-bcd1-4b7e-90aa-0d17263aa88f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1b976872-804b-4865-89f1-9ffca9958da8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1cc563ef-bbd7-48ae-a30a-6fe2b9b6c16e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1d239f26-fbb5-44e4-91b4-3b18e393e99a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1d2a1fec-a949-4154-862b-1cd487d29538"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1d54db2e-c176-48d2-b3d4-1f3010f4a2df"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("1ee4bfcd-ad30-49cb-96be-ae4e5c6d5adc"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2042821a-f9d0-4d79-ad2b-2448b81df68a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("206540e1-6b0c-430e-ac07-0f07e67fedda"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("23c5fce0-4db9-4276-9df1-4904379d972d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("24c0e091-1426-40f2-8e40-b4be30acf564"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("25f6b07a-273f-4621-8945-70f4ec5f2a7f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("26a2a5a1-2e2f-47fe-a088-78d17c07a220"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("26b77fb1-9176-4798-8858-c92e5c60c87c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("27652c78-2fb2-4487-8360-a42e53c5f195"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("27a75cdb-55cc-44ac-be8f-6146576da1f5"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2c256164-99f3-4ca8-a4e6-3adfe2e7712b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2d380e07-593e-48f2-b5a0-8475d7f1d330"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2d5d8863-7739-4c86-a8e7-ad334b2b9800"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2dbf7647-a7f1-47f9-af35-439e705a8fa6"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2e6a73f9-66ee-4483-8da5-977aada0266d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2ef94209-39a3-4f83-b5e4-f2d2a47d4a72"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2f0c1821-2c82-4c4e-86a8-ab5534a0d30d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("2f4b0b19-b882-4dac-becf-3b291401d20d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("309e6cd1-3628-4998-8aab-a734afae2090"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("35435ed3-5a70-4620-9779-5b6681ade365"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("38212858-b40a-4ed9-a594-59b070d50ba2"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("38336107-a04b-44b2-8711-590b9a9e60ae"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("3991bb48-9c99-4e6f-b6d1-026737f92414"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("3b23fb60-88cf-4925-8fdc-3330310677f1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("3b7e7504-027b-4bc0-8131-d533a4f65f99"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("406caf19-dc49-428e-bc68-fccfdb61ea88"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("41ae6725-da72-4c14-a9e0-003e3ce02ad8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("41e59e54-be10-4d79-be7f-12fee35b1176"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("423daf63-a7dd-431f-81c9-6e1ae8dc6f97"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("43e4b9fa-a448-45b2-9f40-30f2d04a7c99"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4737ecbf-b753-4838-82c7-041a14d57257"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("474299ce-560e-4292-880b-e320b6436b41"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4799361d-bb9f-4a33-8e5e-bba6e8bde70a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("491a5aa1-6618-4798-83f8-539bc73159e1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("49c640db-215a-463b-8201-ecbd75843432"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4a878e01-4039-4e32-b167-7a5e1aacddfa"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4c258798-78d1-475c-8724-953543f6f01a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4effcaf2-ed9e-4e4b-ad91-2986870e9b6c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4f3eac30-6cda-4125-896e-4aa3c1bae075"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("4f93e2c0-29fc-4a24-bdac-90aedf4c2404"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("52649244-328c-4fb6-bd9b-5ddf2cc07b36"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("540600e3-b883-4416-813a-3c84c88aebe6"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("540ff1d6-6197-4294-b75f-038e52b70db9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("55a4243b-3422-44ce-b666-baf4d0f13f46"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("55d516aa-08c2-4e86-bdd7-051e508689cb"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("57c444be-c71b-4a09-853b-1f3801192beb"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("58b81adb-13ea-4a54-bbf4-806b5c341fd1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5a272e06-d6fe-447f-9316-e26b7e5c0658"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5b345189-a401-4066-8b84-8e710c068458"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5b7d6777-36f5-4ee6-9848-04913c026041"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5ca3c138-443b-4bda-b655-b6fdf97947f0"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5cbba6ed-6590-4868-b9a3-a5cc1c114f0a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5cc0c1ca-4937-44a0-9f86-64ac90ae9cfe"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("5d14a327-96ca-41bb-8ab7-852f5b952845"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("60cd12ea-ac87-4b23-ad9d-1176893c1c87"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("61e7c7fa-7291-4cdb-992f-83eec3eb9588"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("62ce6df7-8034-453b-a2eb-792206f6d4db"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("62ffbeed-1811-45a1-b207-b2af328d2612"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6364a590-040e-452f-ae9d-d84cec6055d4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("63ac6fba-c784-4f16-8afd-12e9699bc28f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6414094d-d055-4345-8b6c-2d324911b637"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("65caa8b8-f096-4e3d-b3d3-c3cc54aeceab"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("682c3c74-779a-44d9-b9ac-03699bfae2c9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("69eb5ea6-44dd-4048-8b75-c266dd29b33b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6a89bdd9-748b-432e-8837-5a36bc46704a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6ab2bbb1-e6a1-467d-977b-86be064e3623"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6ad4cf5e-42cc-43ef-96f2-2ec8ff18bb0d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6af002d9-ee95-4999-a629-395b0b5b73a5"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6da32232-1957-4a13-bd1d-5dd653c60779"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6e238c90-43da-42e2-b398-4fabfe4987cd"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6eb6ff00-cb09-4ed8-a048-dc962b0964b7"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("6f66e4e7-10ac-417e-9558-46c1127f7907"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("70195869-493c-47fb-8a1e-a720af8a9f9d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("70d32eeb-5c73-4a3c-b3bd-9f9d030720cc"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("714fd590-0609-47d0-8139-360da6a534dc"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("723503ee-3103-44d7-bad9-a1e8e0295ad9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("74feed8e-70eb-4d32-ba5b-ece8b27aaff4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("7582dec4-4786-4be7-bb59-5ed367383ac2"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("77243152-ad89-488b-817c-82e8235703d8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("7b866603-e54c-4280-83ec-1a5c1b6fa14d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("7de93c24-4834-4f04-af97-39c2cb1134f8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("7deadfbc-6ab0-4b3c-8046-1f8c36d8131e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("7df97ff9-fbf3-4c92-b069-ff533e8a447c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("7e2df330-f067-46a4-bc4b-ff344f1b0225"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("81732217-edee-4f67-bac5-d3690f357c65"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("826197e3-dd50-4c1b-8343-7d42b5948d02"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("82dc4dad-79e6-4cce-8fd0-7693828cb108"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("835434bd-b345-44b7-bb1c-560fcff1f9e8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("881adec8-f124-4b27-80f4-23388a9d55c1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("891b9c5d-70f4-498a-88f1-96944f6e21de"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("8bcef76d-a9f2-42ee-8fee-da17d88af189"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("8e06b868-6894-44b5-8cce-9702b4a567a7"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("90ea9308-f213-43f3-a226-0d22e990e596"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("917a5865-0b77-42b6-bd73-b50770b2717e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("91ae002e-385c-4b93-a9c0-4edf8e39424d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("93d5ed32-f822-40be-ac40-efc38169a84c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9af16d69-f1ac-40b1-a319-bc437abb352b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9e83e8a6-f34f-4cb0-b404-3a35fddc2887"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9eb04e50-2c51-484f-b39d-c2e1ef9e6d47"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9edd7168-4011-4a50-bdd1-77815a316606"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("9f970fcc-6ed7-4d51-88ff-c0bd21e45a00"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a07d825c-0979-4692-abe6-8239964503e3"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a2832a65-5147-49b5-8494-a8e05bbdac57"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a2994840-2e8a-45e7-b658-9ce23435148f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a384c832-0b01-471c-8a72-906f40e8eb76"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("a552d8eb-3716-4640-a1ff-909d04586dd1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("aaebd8dc-ccb1-429e-ad86-0316a300928e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("adfee0ed-fad7-4f73-9a49-13e052ca9ed5"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("ae72fbdd-1498-4fc8-b95d-2b429fa7afb8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("af5e22e3-3485-4ccf-b37c-8aaa02b1eef7"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b08f61ee-92df-43e5-910d-c4503faa84ef"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b3537a7d-76c4-44ab-9803-6afc1113c808"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b5eaa145-6503-49a3-9917-f34cf34aded8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b6f801e3-8b85-495c-b5aa-ebb3e702ccd4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b73cdfbd-2dab-450b-8a1d-bdcf96db1f8d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b8c7e468-6ac7-42a0-aa89-ead644908b40"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b8c9246d-53b1-4223-b51a-13159519d66b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("b921deb6-7916-499c-b4da-5d782127b9ed"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bc191512-27b8-472f-9452-4f3e9205c23e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bccaab3a-3d30-49b5-a675-64a99488f8aa"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bd0a57b8-d79e-4881-b456-86c1361ef50d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bd196ec0-9944-4cc1-946f-bedee4e94a72"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bd9aba73-7eb4-4fff-bbce-8b2f38e29b05"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bed3ce59-6d38-4c43-a96b-501bf80a6e6d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("bfb14bf6-f8e2-4cfe-8b73-1c7d136c5064"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c247aa23-7f74-4c48-9066-bf37faeb4ddf"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c4df1d3c-db76-4e28-aa39-f6463f8c1c82"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c536963b-dc19-46a4-9fdf-9b1f650d1c0a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c7b7a872-a537-4cc7-a357-813c67bf5532"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c8479aa5-8cbd-47c6-9f7a-103976a25c8d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c90fda68-4044-4841-96d9-904257a17cb3"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("c9d7f7ed-525f-4cfe-9c3a-3fb6ae467184"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("ca8bf7a9-0ac4-49a0-ab0f-038f21692a0b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("cb024a69-21bc-4873-9ae5-a44e3c2f7bf5"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("cbba1074-f6ee-4778-ab8f-cf7e03e98337"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("cc0358dd-535b-407b-ba36-1858f18c6cbc"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("cf3d34d6-8fbc-4d7b-9f83-494556d2422d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d032c436-65c7-4b46-ac9d-8a3b44eab0a4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d07f49ad-7895-4283-b1f6-a20ec0a6e866"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d1cf46a6-842f-491d-9bad-25a9d325f2d7"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d257f70b-93db-42fb-a661-0831a4f7b9a9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d676cdcc-c30d-41e8-bd5f-3f56fc6b8a27"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d6e14eaa-f53c-4ded-b9e0-d1c463fc457c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("d78e25f8-5f97-4e76-8422-4ead268cf4dd"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("dae44c92-9754-407c-b5c5-73f362e4f582"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("db8bf1f3-eda5-441b-bbae-b1010c9fed95"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("dc471c85-5bee-4345-ad02-a9485c737da0"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("df3b8d48-cbd1-45dc-8bc7-58a0115f011e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e067074d-de94-4c6b-9361-4e50008433ea"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e0a681da-52a7-4803-a325-b76791b56488"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e0be6f0d-280d-4002-8933-0b37cc84114f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e34087fb-c670-48da-8a39-1c709a19e692"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e518941b-202a-4086-8ecb-e5c9991168f8"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e646bcb7-85a1-4faa-ab22-f4663f6a008c"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e6908276-c16b-441e-b827-6019f0e6bac9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e962dca4-8e1f-42fb-a48c-7881ab719435"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("e99dcfdc-ada5-44fb-ba02-e7c597d29b20"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("eaa5b765-35c8-4117-a32d-6381b3c9e641"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("eb0e16c6-2807-4d95-a935-98b4d28d4335"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("ebfb514b-1ce9-48e4-9b93-257290895e20"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f00ea920-2fef-453d-b897-cc4620b34182"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f046c5c5-128d-461a-8a54-f79cb8701f51"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f270e09a-0860-4a38-b189-58cf07303142"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f3bcc0dc-f7c8-410f-b43e-5d10dbbe69ec"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("f6db017d-3faf-4b67-824d-e7d1e31ce9ce"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fa0a558c-492a-4165-948d-0bd24a143982"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fa2aaa8e-de1b-4e57-9529-bd2eb6b4eeef"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fad0a0cd-37bd-449d-a9d3-744e62c02f18"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fb0bc483-9542-437c-a0f9-35dab542bd9e"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fb0e1d4d-b000-4103-868c-15c1dbfef3b1"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fc4d0549-1915-474a-a1ef-73b0a649c151"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fc7cba02-79ae-47a9-8182-192be15db3ef"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fcbd18ff-eaf1-4589-a259-0409123e913a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Feelings",
                keyColumn: "FeelingId",
                keyValue: new Guid("fd36f52a-9fbc-4428-b890-5c593c592a98"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("07d45156-2a0c-4888-b430-6de8dd3216b9"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("1b183233-744c-43ac-bf02-764fbc3dd221"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("1c4ccb5d-df13-4781-b6d4-adcde4fb5662"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("3466ab9a-9a55-4e78-b0a3-a02122e33b8f"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("61eeca5b-b0f5-4b7f-9fad-e8cb637e5a63"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("805fbf3c-59cf-4a63-aff6-c374f92fc797"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("b48dc8af-07bb-497c-a991-185c7973e4a2"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("bed801a0-6416-4b54-8a49-21c68b4c9e30"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Languages",
                keyColumn: "Id",
                keyValue: new Guid("e177f501-b47f-4a4b-bf28-446c6df606c6"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("20788f1b-1726-4a6b-8453-a3acddc5aaa0"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("3c3f5939-f359-48f2-98e6-c69639d3424d"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("817a8597-9f5f-4b4f-b3bb-bf28eddd88cd"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("a439b585-5d5f-49f5-a4b9-e8912dc54303"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("ad9a1575-3f9b-4fe9-8328-1f7feddb7327"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("c787bc85-c8dc-48ca-894a-224f0dc93c85"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("e84ff2fc-de72-466d-b1aa-185cfbe18092"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Reactions",
                keyColumn: "Id",
                keyValue: new Guid("fa9c3d04-b6d6-4aeb-b50e-0b315cb6223a"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("185f218c-9498-426a-95df-37bcc79f2950"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("3a7b8bde-1759-4627-9a95-024de2b690a4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("3dc70ce7-c84b-46f5-a108-39d3608b2967"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("67dc7d1a-ab7d-4195-9597-53b9f7a64e8b"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("7cfb8da9-0274-49bc-a765-147fbcc19480"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("a86944b0-6e81-40c3-be81-1991ee3114a4"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("c13e29bc-117b-4a3e-9485-367fb6979b21"));

            migrationBuilder.DeleteData(
                schema: "config",
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("c672c189-a767-4683-a735-5607f496d0bd"));

            migrationBuilder.RenameColumn(
                name: "Sex",
                schema: "user",
                table: "UserProfiles",
                newName: "Gender");

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(9196), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Feelings",
                columns: new[] { "FeelingId", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "IconName", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ShortCode", "UnicodeIcon" },
                values: new object[,]
                {
                    { new Guid("00964717-7288-4998-8d71-64d24073776c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "determined", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Determined", "feeling_name_determined", "", "" },
                    { new Guid("02bd29e6-995c-43da-a159-289585130e60"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hung-over", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Hung-Over", "feeling_name_hung-over", "", "" },
                    { new Guid("038247c8-ca4e-4282-9689-c7187640728d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nice", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Nice", "feeling_name_nice", "", "" },
                    { new Guid("049e9bf4-2c75-4b3d-83ee-34a859f90f84"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "frustrated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Frustrated", "feeling_name_frustrated", "", "" },
                    { new Guid("04f753ba-4c99-48ca-b2b8-c8e357b7823a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fantastic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Fantastic", "feeling_name_fantastic", "", "" },
                    { new Guid("064c2bf2-b1ae-40b9-b039-e865380fc94a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "calm", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Calm", "feeling_name_calm", "", "" },
                    { new Guid("067410c1-3ee8-4ede-bd87-b4014b5d9790"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "betrayed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Betrayed", "feeling_name_betrayed", "", "" },
                    { new Guid("073484cd-ba6c-4c77-b38d-bcfdf4118ce1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stupid", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Stupid", "feeling_name_stupid", "", "" },
                    { new Guid("090eb86a-ddbf-4d6c-99b5-f5d122b068f9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amazed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Amazed", "feeling_name_amazed", "", "" },
                    { new Guid("0a641661-51d0-4573-9a08-7c0951717bbd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "normal", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Normal", "feeling_name_normal", "", "" },
                    { new Guid("0aefc8af-fb9f-4aa6-9c7b-abaf9e2ba48d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "positive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Positive", "feeling_name_positive", "", "" },
                    { new Guid("0bd10ad8-ec92-498d-87bf-8a4be188ac03"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nostalgic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Nostalgic", "feeling_name_nostalgic", "", "" },
                    { new Guid("0c1047a6-d10c-4103-ad9b-bc99c3401150"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lazy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Lazy", "feeling_name_lazy", "", "" },
                    { new Guid("0c6d912d-71a8-4cd4-b216-533763d55fe5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "insecure", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Insecure", "feeling_name_insecure", "", "" },
                    { new Guid("0e0a41e2-34ce-4a75-b4df-f46ccac81d08"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "secure", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Secure", "feeling_name_secure", "", "" },
                    { new Guid("0f22de26-c87e-4584-ab20-916b6f5dc756"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "numb", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Numb", "feeling_name_numb", "", "" },
                    { new Guid("134b49eb-2c53-47ac-abb4-ad02a0816244"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "asleep", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Asleep", "feeling_name_asleep", "", "" },
                    { new Guid("13bd21b6-5293-4be5-a0d5-a9a364ab8011"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bored", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Bored", "feeling_name_bored", "", "" },
                    { new Guid("173f7707-4ef8-4a6d-a8bd-2da91019e6b7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "kind", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Kind", "feeling_name_kind", "", "" },
                    { new Guid("184232a4-9abd-4a9e-bd1a-0712172658bd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stressed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Stressed", "feeling_name_stressed", "", "" },
                    { new Guid("1b75180f-1c82-481d-8378-def67a7d9b42"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "confident", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Confident", "feeling_name_confident", "", "😏" },
                    { new Guid("1d724366-7c55-46dd-961d-9dcd94c57b99"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hurt", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Hurt", "feeling_name_hurt", "", "" },
                    { new Guid("1e04941b-87e1-46b6-9d55-22b188b82f09"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Fed", "feeling_name_fed", "", "" },
                    { new Guid("1e67d4ac-8f59-449c-bf2b-2105685d8b5c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fresh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Fresh", "feeling_name_fresh", "", "" },
                    { new Guid("20c0550b-1a16-417d-a7de-760f513f57a6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "exhausted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Exhausted", "feeling_name_exhausted", "", "" },
                    { new Guid("20f46dc3-3172-4763-a2bc-f4e9ac884d55"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worried", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Worried", "feeling_name_worried", "", "" },
                    { new Guid("20fd49ee-ea93-4bf8-b0ab-89adf84daabb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "generous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Generous", "feeling_name_generous", "", "" },
                    { new Guid("22a6f4b7-4f52-459e-a58d-13ae9decade0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "surprised", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Surprised", "feeling_name_surprised", "", "" },
                    { new Guid("23cecd95-2563-440c-b6ca-36bbabe761e4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "delighted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Delighted", "feeling_name_delighted", "", "" },
                    { new Guid("24052cfe-ecaa-4a86-a26a-bffc25b1dac4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cute", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Cute", "feeling_name_cute", "", "" },
                    { new Guid("24d4629b-4f3f-4cb7-b03f-1dfd784f5d28"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lonely", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Lonely", "feeling_name_lonely", "", "" },
                    { new Guid("26bf83fd-ef3b-4c2b-b129-dd42e6a247a1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mighty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Mighty", "feeling_name_mighty", "", "" },
                    { new Guid("26c9afa8-828e-4460-b785-66567449aeb0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "depressed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Depressed", "feeling_name_depressed", "", "" },
                    { new Guid("27664c03-7c77-47ee-971f-611fe6b16345"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "heartbroken", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Heartbroken", "feeling_name_heartbroken", "", "" },
                    { new Guid("276c5b70-8232-4d27-883e-6c4a2b411ff6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "better", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Better", "feeling_name_better", "", "" },
                    { new Guid("2811a842-2097-42ad-9695-01d172d47f20"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "regret", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Regret", "feeling_name_regret", "", "" },
                    { new Guid("288f3a50-e653-48f4-a433-9982c4e25ff7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "free", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Free", "feeling_name_free", "", "" },
                    { new Guid("28d29c20-606f-46da-8a57-48e5be0676f3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Mad", "feeling_name_mad", "", "" },
                    { new Guid("28f11444-ef2e-445d-8e43-2dbd88ae4179"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wonderful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Wonderful", "feeling_name_wonderful", "", "" },
                    { new Guid("2ec79b08-8559-465b-934c-ed5d5550219a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amused", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Amused", "feeling_name_amused", "", "" },
                    { new Guid("2f521729-99e3-48a4-bb47-64941fec6300"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "concerned", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Concerned", "feeling_name_concerned", "", "" },
                    { new Guid("2f5ad539-259a-4300-b74a-d0c0d6fb5ec1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mischievous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Mischievous", "feeling_name_mischievous", "", "" },
                    { new Guid("2fca4f35-3b91-4ef3-83d8-daa1dd24eeee"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hungry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Hungry", "feeling_name_hungry", "", "" },
                    { new Guid("312c8dcb-6e08-470a-8af8-0b0f424cf633"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "afraid", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Afraid", "feeling_name_afraid", "", "😨" },
                    { new Guid("319e5ebf-64d3-4fd0-8ee0-83fba26572f9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "embarrassed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Embarrassed", "feeling_name_embarrassed", "", "" },
                    { new Guid("321a746d-c0e2-4305-a528-b734f791a687"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "missing", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Missing", "feeling_name_missing", "", "" },
                    { new Guid("32f021eb-2d5d-4dbc-a7fe-7620582ce66d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unloved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Unloved", "feeling_name_unloved", "", "" },
                    { new Guid("33bc4721-4ec6-48b9-8bbb-825837901768"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "annoyed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Annoyed", "feeling_name_annoyed", "", "😒" },
                    { new Guid("35c31cfe-b7b5-4b57-bad9-df497682645c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "small", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Small", "feeling_name_small", "", "" },
                    { new Guid("39d73f01-f1d0-4d66-a961-1cf4ed3a0761"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dirty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Dirty", "feeling_name_dirty", "", "" },
                    { new Guid("3c117a18-4c64-466c-b45d-ae111cbb421a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sick", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Sick", "feeling_name_sick", "", "🤢" },
                    { new Guid("3cf5f7f8-4f63-45ce-8abc-cad1ba704775"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worthless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Worthless", "feeling_name_worthless", "", "" },
                    { new Guid("3e2652de-067a-41fc-8b91-b6ae2baa997a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "guilty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Guilty", "feeling_name_guilty", "", "" },
                    { new Guid("3f110d3d-6b1a-49f6-8379-15d6abcf2cc1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "anxious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Anxious", "feeling_name_anxious", "", "" },
                    { new Guid("41a4dc7d-ca24-48ea-ab28-9e16cabdaab3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "impatient", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Impatient", "feeling_name_impatient", "", "" },
                    { new Guid("41bff1cd-3c5a-43d6-9622-50f7ccb0a23a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ashamed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Ashamed", "feeling_name_ashamed", "", "" },
                    { new Guid("41eea50d-e3ad-4c83-aea3-c47df84c4c71"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "healthy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Healthy", "feeling_name_healthy", "", "😊" },
                    { new Guid("44537352-20c4-4884-b33b-2bf86d15a6c1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lost", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Lost", "feeling_name_lost", "", "" },
                    { new Guid("4476e47c-64d8-4862-baa7-9bb2c5a25491"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "joyful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Joyful", "feeling_name_joyful", "", "" },
                    { new Guid("47ab7be1-8cd4-42d0-948a-7344ed68a3d0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "energised", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Energised", "feeling_name_energised", "", "" },
                    { new Guid("4991ffb7-b6d8-49ac-8651-bafabea95627"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "angry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Angry", "feeling_name_angry", "", "😠" },
                    { new Guid("4a483910-b112-44a1-a636-00c99cba2021"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "strange", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Strange", "feeling_name_strange", "", "" },
                    { new Guid("4bfd5994-6618-428d-a080-21b59700dca4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "special", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Special", "feeling_name_special", "", "" },
                    { new Guid("4c1c6488-c92f-462e-bf33-593acf1b80e5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "shy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Shy", "feeling_name_shy", "", "" },
                    { new Guid("4dc5aeda-ec2d-4f34-bdad-6fb6fd8d853f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "comfortable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Comfortable", "feeling_name_comfortable", "", "" },
                    { new Guid("4f0be5fd-406a-4d5e-bc38-f41ce4714e57"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "inspired", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Inspired", "feeling_name_inspired", "", "" },
                    { new Guid("50731f1a-04ff-46d6-a69e-a156b796a25c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thankful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Thankful", "feeling_name_thankful", "", "😄" },
                    { new Guid("518aec63-47c2-4c65-badc-2d7baf6da775"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "good", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Good", "feeling_name_good", "", "" },
                    { new Guid("53394a65-e07e-4e34-ac9c-0dca73d5d407"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "uncomfortable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Uncomfortable", "feeling_name_uncomfortable", "", "" },
                    { new Guid("54762e74-b663-4185-b88e-1521672113b8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "trapped", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Trapped", "feeling_name_trapped", "", "" },
                    { new Guid("55e7a986-c9fc-47f9-bb11-f06ce1f537b4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "old", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Old", "feeling_name_old", "", "" },
                    { new Guid("5628fdf1-a651-4e1e-b816-d71ea5d17af0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "relaxed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Relaxed", "feeling_name_relaxed", "", "" },
                    { new Guid("56c5aa89-fe1d-4c8d-9060-285bf6ccbe0e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nauseous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Nauseous", "feeling_name_nauseous", "", "" },
                    { new Guid("56f52c3f-267c-4533-ac44-349427f956ac"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "curious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Curious", "feeling_name_curious", "", "" },
                    { new Guid("576c86b6-a338-4f01-9839-16d766b5ed6a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "motivated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Motivated", "feeling_name_motivated", "", "" },
                    { new Guid("578c3cf1-af85-4bdf-9ca5-794d8be08399"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "accomplished", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Accomplished", "feeling_name_accomplished", "", "" },
                    { new Guid("5ac9699e-e3b8-4348-9a1a-0e556199f178"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "OK", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Ok", "feeling_name_OK", "", "👌" },
                    { new Guid("5d2f2dd3-9c04-45dc-bfc8-0e0d4bbd2734"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "well", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Well", "feeling_name_well", "", "" },
                    { new Guid("5ece44c4-448d-47ce-b824-d9910e4b7bb9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "aggravated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Aggravated", "feeling_name_aggravated", "", "" },
                    { new Guid("5f5eb2fc-5d01-4a14-8038-aef780d045f3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "scared", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Scared", "feeling_name_scared", "", "" },
                    { new Guid("6073d4e8-398c-4263-af53-3a91fe60d609"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blissful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Blissful", "feeling_name_blissful", "", "😊" },
                    { new Guid("621ed9ad-ca2c-4a4d-a2cd-fd16d2abb50f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "perfect", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Perfect", "feeling_name_perfect", "", "" },
                    { new Guid("631b42ae-f541-4150-9aaa-f6ad3ab69944"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "invisible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Invisible", "feeling_name_invisible", "", "🫥" },
                    { new Guid("64d15a89-be39-4bbd-8ee8-4fa944a0afd9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "satisfied", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Satisfied", "feeling_name_satisfied", "", "" },
                    { new Guid("6652f89d-f6fb-40b5-9fbe-603447af997d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "professional", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Professional", "feeling_name_professional", "", "" },
                    { new Guid("6730ebd8-2d41-41f3-a768-5355ce4e61ec"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rough", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Rough", "feeling_name_rough", "", "" },
                    { new Guid("67b6f795-b346-41b7-b21b-3680ea86518f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dumb", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Dumb", "feeling_name_dumb", "", "" },
                    { new Guid("68802abd-e1a0-415f-8f42-56ffa68f0099"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cold", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Cold", "feeling_name_cold", "", "" },
                    { new Guid("6938234a-f3e9-4f66-a0aa-8f6d12a841b7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "challenged", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Challenged", "feeling_name_challenged", "", "" },
                    { new Guid("6971104f-e0d3-4191-8325-022e747534e5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "warm", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Warm", "feeling_name_warm", "", "" },
                    { new Guid("69a2806c-803e-471f-a8fe-40fcbdcc459d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "broken", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Broken", "feeling_name_broken", "", "" },
                    { new Guid("6ae150f0-4440-4ead-bed2-55d6c8c8c07a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "jolly", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Jolly", "feeling_name_jolly", "", "" },
                    { new Guid("6b3f04ac-e886-4476-a627-43bf331d1f84"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "busy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Busy", "feeling_name_busy", "", "" },
                    { new Guid("6c5373c1-009c-4130-a4e9-98be82f95089"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "in love", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "In Love", "feeling_name_in_love", "", "🥰" },
                    { new Guid("6d1899c0-756b-45ce-bebf-efbd6a4c90fe"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blue", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Blue", "feeling_name_blue", "", "" },
                    { new Guid("6da2a09d-a29e-42ff-8ff2-e0fb9ce3f49e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sore", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Sore", "feeling_name_sore", "", "" },
                    { new Guid("70310c75-415e-492b-abde-b24d3e65c7ae"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ready", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Ready", "feeling_name_ready", "", "" },
                    { new Guid("73189ab7-3de7-4e9e-a5cc-250e1a515dbc"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lucky", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Lucky", "feeling_name_lucky", "", "" },
                    { new Guid("74adbfbb-0212-4457-9aaa-8ace80532693"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "festive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Festive", "feeling_name_festive", "", "" },
                    { new Guid("7624fa8b-dae9-40e5-97ce-05dfc3468f37"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "evil", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Evil", "feeling_name_evil", "", "" },
                    { new Guid("772c24ce-a2e6-4a1e-afd2-f643f6c26f9b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "different", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Different", "feeling_name_different", "", "" },
                    { new Guid("773932e3-9552-4943-ac53-998dd38a6370"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cool", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Cool", "feeling_name_cool", "", "" },
                    { new Guid("775bdaf4-5dfd-474a-b6bd-d899f7d45950"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blah", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Blah", "feeling_name_blah", "", "" },
                    { new Guid("77cddbdc-05a5-4176-85e9-0f5e5542cc28"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "important", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Important", "feeling_name_important", "", "" },
                    { new Guid("79dacaad-6a5f-4af5-9a20-1f46f87d9454"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hyper", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Hyper", "feeling_name_hyper", "", "" },
                    { new Guid("7a82dcd9-0e73-4668-a9bb-69c4a5d8c83f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "confused", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Confused", "feeling_name_confused", "", "😕" },
                    { new Guid("7b2bc23e-b7f1-4378-bb52-f23cfe51c3a0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "overwhelmed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Overwhelmed", "feeling_name_overwhelmed", "", "" },
                    { new Guid("7d4eda56-a58a-4512-bab6-8f8491e19217"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "weird", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Weird", "feeling_name_weird", "", "" },
                    { new Guid("814a0a10-dd88-4087-8fce-3186b72e6a8e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "perplexed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Perplexed", "feeling_name_perplexed", "", "" },
                    { new Guid("8155ea9b-d6d5-4902-aaaf-c7121504fcdf"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "beautiful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Beautiful", "feeling_name_beautiful", "", "" },
                    { new Guid("84525d5a-7625-499a-9b91-c1d4c90a27cd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "silly", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Silly", "feeling_name_silly", "", "😜" },
                    { new Guid("84c1755b-ec5b-4c49-9d42-acd909969abc"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "drained", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Drained", "feeling_name_drained", "", "" },
                    { new Guid("84e716f3-e248-4d4b-8a0e-f50ee1475a14"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "low", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Low", "feeling_name_low", "", "" },
                    { new Guid("854fb5b0-d229-4040-88a7-6d57b08d2954"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nervous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Nervous", "feeling_name_nervous", "", "" },
                    { new Guid("86be6271-e1c1-43d4-90d1-89b389d975ae"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "goofy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Goofy", "feeling_name_goofy", "", "🤪" },
                    { new Guid("89fe9000-2fd5-45af-906f-e05f94505ee9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "deep", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Deep", "feeling_name_deep", "", "" },
                    { new Guid("8bfb9bde-2615-4247-9627-51735b778a62"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "great", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Great", "feeling_name_great", "", "" },
                    { new Guid("940372c9-6f75-4613-a0be-fd34003ad764"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cheated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Cheated", "feeling_name_cheated", "", "" },
                    { new Guid("946adb5b-3a85-4727-9302-828f2a2a4be5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Awful", "feeling_name_awful", "", "" },
                    { new Guid("9488fff1-525e-48d3-8173-bb5dbbf29898"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "chill", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Chill", "feeling_name_chill", "", "" },
                    { new Guid("94b69469-9af7-4055-8c40-042ba065cff4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "jealous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Jealous", "feeling_name_jealous", "", "" },
                    { new Guid("94cf0dbd-aca1-4b4a-9828-821aa0345f0d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "super", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Super", "feeling_name_super", "", "" },
                    { new Guid("983b9f35-41c6-40ce-aaa8-26ccfaf5ce28"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "down", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Down", "feeling_name_down", "", "" },
                    { new Guid("995e59ce-6f49-421c-8417-906e32d93d24"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "offended", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Offended", "feeling_name_offended", "", "" },
                    { new Guid("9af331ed-c114-4207-8516-2eb420614859"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "loved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Loved", "feeling_name_loved", "", "🥰" },
                    { new Guid("9b44f97e-07c0-4a6b-9902-ae52c60f47a1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "excited", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Excited", "feeling_name_excited", "", "🤩" },
                    { new Guid("9bc501bd-8bab-4409-b762-2f0d2a8439b5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rested", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Rested", "feeling_name_rested", "", "" },
                    { new Guid("9d2569e3-56b0-44f6-8778-976527cf9295"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wanted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Wanted", "feeling_name_wanted", "", "" },
                    { new Guid("9de2b7a4-168f-43d4-ac16-9623453cd165"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "terrible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Terrible", "feeling_name_terrible", "", "" },
                    { new Guid("9f0ba732-fa3c-4b29-9f77-f2a6821f42fb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "incomplete", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Incomplete", "feeling_name_incomplete", "", "" },
                    { new Guid("a05b5370-0fc6-422a-ac83-8cb8bcc0630e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lovely", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Lovely", "feeling_name_lovely", "", "🥰" },
                    { new Guid("a5f567f6-3533-48dc-87fd-73734fd6340f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sarcastic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Sarcastic", "feeling_name_sarcastic", "", "" },
                    { new Guid("a63457ab-ac95-464f-b877-17122128789e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "smart", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Smart", "feeling_name_smart", "", "" },
                    { new Guid("a6c61f61-31c4-49d3-8bd9-c43f4838d526"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blessed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Blessed", "feeling_name_blessed", "", "😇" },
                    { new Guid("a6fd39b2-4969-4297-a2bc-3df0a92c9f39"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tired", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Tired", "feeling_name_tired", "", "" },
                    { new Guid("a7c57ddc-0840-461c-9e12-0632f33cc0af"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ignored", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Ignored", "feeling_name_ignored", "", "" },
                    { new Guid("a7d64f18-58e6-4953-bfca-62e876aab5e3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "helpless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Helpless", "feeling_name_helpless", "", "" },
                    { new Guid("a9f22c05-931f-458a-be99-27fe697371f1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "safe", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Safe", "feeling_name_safe", "", "" },
                    { new Guid("ab7041f4-e0d3-4c1d-8d69-826aea667cbb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "light", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Light", "feeling_name_light", "", "" },
                    { new Guid("ab8361f8-e29f-4e87-8d6e-610f54d80f41"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "useless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Useless", "feeling_name_useless", "", "" },
                    { new Guid("ac718977-4209-47bf-8adc-6710f658c2f0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "whole", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Whole", "feeling_name_whole", "", "" },
                    { new Guid("adc23553-8832-4441-b845-ec911b9f6ad6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "proud", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Proud", "feeling_name_proud", "", "" },
                    { new Guid("afab1d56-8058-484f-9d0b-bdff206c3a45"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hopeless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Hopeless", "feeling_name_hopeless", "", "" },
                    { new Guid("b06ecb67-3d99-4c12-b86f-dd251f8b8c2b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pained", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Pained", "feeling_name_pained", "", "" },
                    { new Guid("b25bd1c7-6230-4694-944a-7cf87ab8525c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "refreshed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Refreshed", "feeling_name_refreshed", "", "" },
                    { new Guid("b27f8c16-7b88-4596-bd00-967c78a8cb53"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stuck", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Stuck", "feeling_name_stuck", "", "" },
                    { new Guid("b34cd0c9-588d-4f79-9562-bb7abb5892e3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "yucky", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Yucky", "feeling_name_yucky", "", "" },
                    { new Guid("b42f79e9-0dba-4890-8e54-804136d5aa32"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amazing", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Amazing", "feeling_name_amazing", "", "" },
                    { new Guid("b702e656-0670-467b-a692-bd6851167326"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "alive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Alive", "feeling_name_alive", "", "" },
                    { new Guid("b932e746-f50c-464a-93d9-964dcd9824bf"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awkward", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Awkward", "feeling_name_awkward", "", "" },
                    { new Guid("bab28b47-09c3-45b3-8738-3ba3dbeea67c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "puzzled", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Puzzled", "feeling_name_puzzled", "", "" },
                    { new Guid("bb4f740b-07e7-47d1-a1f6-b424a2f6a142"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "threatened", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Threatened", "feeling_name_threatened", "", "" },
                    { new Guid("bb6d73e6-182b-42bf-9649-79f292f67529"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awesome", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Awesome", "feeling_name_awesome", "", "" },
                    { new Guid("bcfa1830-4e8e-4c71-a870-e181216355b0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "honoured", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Honoured", "feeling_name_honoured", "", "" },
                    { new Guid("be5bd35c-d219-4da7-8f06-87e135a06f93"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "crazy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Crazy", "feeling_name_crazy", "", "🤪" },
                    { new Guid("beee1bf8-8faa-48da-9633-9cc4ff36406e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "crappy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Crappy", "feeling_name_crappy", "", "" },
                    { new Guid("bfa98b5c-e19e-4e52-9414-a805936d2417"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "full", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Full", "feeling_name_full", "", "" },
                    { new Guid("bfabf833-2116-47ba-85d7-1e15feb9ea44"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "grateful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Grateful", "feeling_name_grateful", "", "😄" },
                    { new Guid("c0824490-7af2-4322-a9fe-35615ec8d5e6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "broke", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Broke", "feeling_name_broke", "", "" },
                    { new Guid("c0b6f32e-e7d0-423d-a3fb-f9a7229c7a95"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fine", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Fine", "feeling_name_fine", "", "" },
                    { new Guid("c3c3d774-4bb1-40d5-a74f-72342f1f32b6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "drunk", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Drunk", "feeling_name_drunk", "", "" },
                    { new Guid("c4c48404-5805-4807-a591-04f749159fbe"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thoughtful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Thoughtful", "feeling_name_thoughtful", "", "🤔" },
                    { new Guid("c6e48664-b2f9-4dbe-ba64-d1bf13f78c42"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "strong", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Strong", "feeling_name_strong", "", "" },
                    { new Guid("c7ef6094-a521-42cf-ad75-1b67954686ba"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Sad", "feeling_name_sad", "", "🙁" },
                    { new Guid("caa710b8-ac40-4b20-a549-03cbcef29ecd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pretty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Pretty", "feeling_name_pretty", "", "" },
                    { new Guid("cd069aa8-e159-47fe-a1c6-c4fdc9dfce6f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rich", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Rich", "feeling_name_rich", "", "🤑" },
                    { new Guid("d04db183-061c-4a6c-92b1-4d2d48908100"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "relieved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Relieved", "feeling_name_relieved", "", "" },
                    { new Guid("d27f8f11-6992-42ce-bbb5-c373a4cbc856"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "emotional", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Emotional", "feeling_name_emotional", "", "" },
                    { new Guid("d371a5b0-329d-4ab5-b7f7-da270f71252b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "disappointed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Disappointed", "feeling_name_disappointed", "", "" },
                    { new Guid("d3e3fe6d-bc89-4e8d-9401-88dc72aafa69"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "welcome", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Welcome", "feeling_name_welcome", "", "" },
                    { new Guid("d413cac5-6b73-49fb-a7e0-780f45169ee8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Bad", "feeling_name_bad", "", "" },
                    { new Guid("d6a22864-d7d4-4d75-aa95-21be720dde31"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "alone", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Alone", "feeling_name_alone", "", "" },
                    { new Guid("d7d1f50c-9dc8-4ace-ad6b-19281e464953"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "peaceful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Peaceful", "feeling_name_peaceful", "", "" },
                    { new Guid("d9839c64-1ad3-4fec-9af3-96123bf1e425"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "funny", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Funny", "feeling_name_funny", "", "" },
                    { new Guid("d994a6a1-b745-40c9-b669-68dfa865e009"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pumped", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Pumped", "feeling_name_pumped", "", "" },
                    { new Guid("dafbca74-8f23-4bc8-a159-a1f54e15b3e4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "qualified", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Qualified", "feeling_name_qualified", "", "" },
                    { new Guid("db625a3d-91c5-436a-a86f-cb284f63716c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sorry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Sorry", "feeling_name_sorry", "", "" },
                    { new Guid("de26b2f2-6f00-478f-9874-b01f2d7fdadd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "optimistic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Optimistic", "feeling_name_optimistic", "", "" },
                    { new Guid("e0c0b1df-4513-4d3d-89be-bc002c7c83d1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "furious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Furious", "feeling_name_furious", "", "" },
                    { new Guid("e0c66880-4690-4438-be37-cccafa3782eb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "happy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Happy", "feeling_name_happy", "", "😀" },
                    { new Guid("e0cf205d-9411-4abc-bb34-ebb454b5b9c9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thirsty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Thirsty", "feeling_name_thirsty", "", "" },
                    { new Guid("e19f0037-399d-42b5-b420-1ca8e307f692"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "upset", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Upset", "feeling_name_upset", "", "" },
                    { new Guid("e3cb1447-79b7-4418-9f8d-ca2f22df9da3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "miserable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Miserable", "feeling_name_miserable", "", "" },
                    { new Guid("e4020ccc-73ef-405b-907e-79d73694caba"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worse", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Worse", "feeling_name_worse", "", "" },
                    { new Guid("e666d3bf-6279-40bb-b8dd-9e0dc35b918c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "irritated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Irritated", "feeling_name_irritated", "", "" },
                    { new Guid("ee3b52a9-bbe4-495b-b99b-d66bd6df6e49"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sleepy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Sleepy", "feeling_name_sleepy", "", "" },
                    { new Guid("f179829a-b879-4fa7-b1fc-150246a7d2fe"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "weak", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Weak", "feeling_name_weak", "", "" },
                    { new Guid("f2e6f11c-39c6-4a63-9505-3f5c09ebbe18"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "naked", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Naked", "feeling_name_naked", "", "" },
                    { new Guid("f321fc29-e1a4-441c-84b2-2429b0b63880"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "privileged", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Privileged", "feeling_name_privileged", "", "" },
                    { new Guid("f5caa19f-b5ac-470f-b941-11502e55005c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "glad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Glad", "feeling_name_glad", "", "" },
                    { new Guid("f6ce71bc-2ad9-4224-931d-4c7952e568e4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "appreciated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Appreciated", "feeling_name_appreciated", "", "" },
                    { new Guid("f7cc648c-458c-4fc1-bc5f-b4c328e8ec6e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hopeful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Hopeful", "feeling_name_hopeful", "", "" },
                    { new Guid("f98c5b06-4a14-4737-a5eb-35c407c2be65"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "human", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Human", "feeling_name_human", "", "" },
                    { new Guid("f9d845d9-4c52-4e20-82c3-e9fe50a6cb43"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unimportant", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Unimportant", "feeling_name_unimportant", "", "" },
                    { new Guid("fa9517a6-3b61-4ae8-876b-40fa8e56d7a6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unwanted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Unwanted", "feeling_name_unwanted", "", "" },
                    { new Guid("faa407e4-4f76-4410-a100-b5326b6b66ca"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "meh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Meh", "feeling_name_meh", "", "😐️" },
                    { new Guid("fb444d0f-6c33-4a9d-9ba0-a4168479c79c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "horrible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Horrible", "feeling_name_horrible", "", "" },
                    { new Guid("fca3649d-8765-4656-9184-6b7416688f99"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fabulous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(974), new TimeSpan(0, 0, 0, 0, 0)), "Fabulous", "feeling_name_fabulous", "", "" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "Direction", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ThreeLetterCode", "TwoLetterCode" },
                values: new object[,]
                {
                    { new Guid("04410dd1-9d5f-4a73-acc5-1aeab42a9a5b"), "RU", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), "Russian", "language_name_ru", "RUS", "RU" },
                    { new Guid("165cbe5e-1db9-4c82-9cfe-5a18c977dc0e"), "ZU", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), "Zulu", "language_name_zu", "ZUL", "ZU" },
                    { new Guid("170a4c38-1ca5-4733-b9ea-bd323ebd4aca"), "HI", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), "Hindi", "language_name_hi", "HIN", "HI" },
                    { new Guid("46e07ae0-486e-4005-8627-43364dc24fb2"), "ZH", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), "Chinese", "language_name_zh", "ZHO", "ZH" },
                    { new Guid("99393d7f-391f-474e-9cdb-835dc6015e2f"), "AF", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), "Afrikaans", "language_name_af", "AFR", "AF" },
                    { new Guid("9f4475ba-d4a3-428d-a0ad-5dda0deaaa88"), "HE", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 1, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), "Hebrew", "language_name_he", "HEB", "HE" },
                    { new Guid("aa6e11b7-10cb-4bc9-9a0f-071588b3a5d3"), "EN", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), "English", "language_name_en", "ENG", "EN" },
                    { new Guid("c589b4ac-7b33-40e3-b9d8-fa53202370ee"), "FR", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), "French", "language_name_fr", "FRA", "FR" },
                    { new Guid("f10e5f73-a2cf-40da-b5d7-656aea34398b"), "ES", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 0, 0, 0, 0)), "Spanish", "language_name_es", "ESP", "ES" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Reactions",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "IconName", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "UnicodeIcon" },
                values: new object[,]
                {
                    { new Guid("013a9b63-03b8-4eab-b0a8-f1cfd8850840"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wow", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), "Wow", "reaction_name_wow", "1" },
                    { new Guid("4a0f5249-c415-4408-83e9-62e5a5e85d74"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "love", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), "Love", "reaction_name_love", "1" },
                    { new Guid("7f0e603b-a61f-49d4-8d4d-4f15ae5c1f71"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dislike", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), "Dislike", "reaction_name_dislike", "1" },
                    { new Guid("908f782d-4420-4071-bc1c-2a5506f1a8bb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), "Sad", "reaction_name_sad", "1" },
                    { new Guid("a5eb79ab-3594-48bd-aeb6-be786cf478b7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "angry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), "Angry", "reaction_name_angry", "1" },
                    { new Guid("a73dc3c2-3c25-490e-ad17-3e8fab4f072b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "laugh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), "Haha", "reaction_name_laugh", "1" },
                    { new Guid("c2c2339a-0f32-41fd-9fff-1ea199a894eb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "care", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), "Care", "reaction_name_care", "1" },
                    { new Guid("f0e2411e-ad11-4644-9ccb-69d394a1b22f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "like", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 124, DateTimeKind.Unspecified).AddTicks(44), new TimeSpan(0, 0, 0, 0, 0)), "Like", "reaction_name_like", "1" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Settings",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DataType", "DefaultValue", "HelpText", "LastModifiedBy", "LastModifiedTimestamp", "Name", "SettingCategoryId", "ShortDescription", "Value" },
                values: new object[,]
                {
                    { new Guid("0045fc7c-b41d-4a36-af65-4b1535c6087d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), 4, "AU", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), "Regional Format", null, "Formats for dates, times and numbers.", null },
                    { new Guid("1729c0af-c1ce-40d2-b6a7-5c510d0cb084"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), 4, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), "Host Port Number", null, "The host port number of the Astrana instance.", null },
                    { new Guid("38abb707-2752-48c1-a230-f977ed58b718"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), 4, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), "Idp Issuer Signing Key Secret", null, "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.", "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C" },
                    { new Guid("4dd8aa9f-5300-4da4-9906-775f7c9bdfdf"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), 4, "localhost", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), "Host Name", null, "The address of the Astrana instance.", null },
                    { new Guid("4f8f263e-9dfc-4397-bfc3-1f6bdc1d4d39"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), 4, "AUS Eastern Standard Time", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), "Time Zone", null, "The time zone of the Astrana instance user.", null },
                    { new Guid("7e3b6b91-8c1f-4f8b-89e4-7ba6479a4a0e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), 21, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), "Default Skin Tone", null, "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.", "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C" },
                    { new Guid("9e4c339b-26c6-4373-a63d-c8bd55ab79b0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), 1, "0", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), "Multi-factor Authentication", null, "Turn multi-factor authentication on/off.", null },
                    { new Guid("ddd17fd2-9aa2-4485-80d7-c65f3a957da8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), 4, "EN", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 12, 3, 59, 30, 123, DateTimeKind.Unspecified).AddTicks(5166), new TimeSpan(0, 0, 0, 0, 0)), "Language Code", null, "The language code of the Astrana instance user.", null }
                });
        }
    }
}
