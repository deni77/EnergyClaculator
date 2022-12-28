using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyCalculator.Infrastructure.Migrations
{
    public partial class RemoveNameIngredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Ingredients");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2787b74e-3c0v-466f-m8af-654d56fd9010",
                column: "ConcurrencyStamp",
                value: "52225e02-fb19-4f94-b2fb-5a9ec4399a68");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "08d2b8f1-b19d-4f98-a355-bc47f9e963fe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5090a05b-7485-4e3e-9b18-54097e75c39b", "AQAAAAEAACcQAAAAEC7jonvNpp2dOo6Qo8tHiAHHmFFSwJPHipUMYCXTtnfemv1PxS+a8EbPy/5nmUmztA==", "da0e572d-55e5-4301-b0f8-e4e4035dfa20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87612856-d498-4529-b453-bgrfd8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87a121e3-fd21-410d-89d6-9c05a6555f20", "AQAAAAEAACcQAAAAEDsxSW/0L7v/GFL9Da4UAA2iUmAEdWEtO0tvhMULc1Gg59MyHfIcB53I/Q+XXLGD5g==", "2584b877-3a6f-4538-8a53-482d111c3f52" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Ingredients",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2787b74e-3c0v-466f-m8af-654d56fd9010",
                column: "ConcurrencyStamp",
                value: "424f3585-2e93-49ee-8dd8-8f38c618b143");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "77b03e1b-698f-4179-84f7-fd2c5b0337e9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45540a7e-e71c-4fd7-9baf-04db471a6ba3", "AQAAAAEAACcQAAAAEL6So22CfAhAzjRvTF14GvPa/tcF8K8vuJ/KXkK2iDTfX9paMuNl7eGM2348m6pDig==", "9454660c-6ae6-4b3a-882a-de57d6f888d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87612856-d498-4529-b453-bgrfd8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "373ceefc-b497-4273-b737-2d717e080788", "AQAAAAEAACcQAAAAELfvNEI9AQG7HqJmiRDDFL4+zvrNaVxeat02oTrAg4KQG2B6bd/2+eFRtNS+mm5RFw==", "10e3a34e-cd14-43bd-9b55-56c3f632b34a" });
        }
    }
}
