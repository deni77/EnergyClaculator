using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyCalculator.Infrastructure.Migrations
{
    public partial class UserIdinIngredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2787b74e-3c0v-466f-m8af-654d56fd9010",
                column: "ConcurrencyStamp",
                value: "3d51b22c-0d5c-4681-b66d-ae5a6aee3db2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "f2b23b10-cb25-45e7-b197-67ae9418a084");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cddfd3d5-5fee-40f7-bcb0-f7f5dc5d9049", "AQAAAAEAACcQAAAAECA9O2RdQ0mh5E/N9/omgmoRSj6/Xciz7+M74hYG80UDAXuaeIxRrAfPu6AH03hS3Q==", "d709f04d-47ab-4738-8c60-d4121417cea8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87612856-d498-4529-b453-bgrfd8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04f34c14-8a51-4ca5-9be7-bc021bd80114", "AQAAAAEAACcQAAAAEEi2a3+dKeaBiaodq/snCBL1MVw9/g0Q7Q4hcvx7wtFiIbzJEIgPp4aGJBJL9YPlhQ==", "4d588c86-d40f-489c-b176-9d8be6ad5e4a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
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
    }
}
