using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyCalculator.Infrastructure.Migrations
{
    public partial class RenameIngredientAndReceipt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalQuantity",
                table: "Receipts",
                newName: "TotalCalories");

            migrationBuilder.RenameColumn(
                name: "TotalQuantity",
                table: "Ingredients",
                newName: "TotalCalories");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalCalories",
                table: "Receipts",
                newName: "TotalQuantity");

            migrationBuilder.RenameColumn(
                name: "TotalCalories",
                table: "Ingredients",
                newName: "TotalQuantity");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2787b74e-3c0v-466f-m8af-654d56fd9010",
                column: "ConcurrencyStamp",
                value: "1e395b1f-e770-4ce4-b56d-a9157042135d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "191b5426-dde5-4cb4-a120-3dbcc2802e6a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b300b6e8-9722-4c43-867c-9df6442229c9", "AQAAAAEAACcQAAAAEEbpleRYIeIFvkGQLe/bvP45ZkMoFJRf9IW5rmx4o7vQyASHxnivOa0Byz7y3z3+zQ==", "928ba0cd-ed5c-4321-98f7-99608e072832" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87612856-d498-4529-b453-bgrfd8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2edb665d-99c6-40cd-bf22-e46ef7522384", "AQAAAAEAACcQAAAAECDKq0kBO3cHszw5Dd+2/sxXpEF8qmKtraIEjEXUug0Ec2cdMALL9+CDqJCTPLb3cQ==", "6285540d-bd2e-41f4-8ea7-c3c78cbbef5d" });
        }
    }
}
