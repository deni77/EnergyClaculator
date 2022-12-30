using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EnergyCalculator.Infrastructure.Migrations
{
    public partial class DoobleInAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "TotalCalories",
                table: "Receipts",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CaloriesPer100grams",
                table: "Products",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "TotalCalories",
                table: "Ingredients",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "QuantityForIngredient",
                table: "Ingredients",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2787b74e-3c0v-466f-m8af-654d56fd9010",
                column: "ConcurrencyStamp",
                value: "17f014ca-1c17-46f8-bf14-6d83dda31e72");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "26ee4db5-1243-4a23-a935-b23e15f51299");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5bb641f-5c2c-4d9a-bb77-647098226c01", "AQAAAAEAACcQAAAAEGMjRJSeKr+MA5xMJw2w7PteCOUkPBrFB86ePmWr7QglRvatWy5272fNfx1HwUl6NQ==", "4a6a36ac-32f9-4cc0-ad72-d37b9236b66c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87612856-d498-4529-b453-bgrfd8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "641fef9c-7534-4a6f-8864-fb86b4a40841", "AQAAAAEAACcQAAAAELk2H2xRHn40KjIoQydO+zm5ISdWzKwXZj9DAZwghRcTy3wl9gZNccEH87Tk8MCj8g==", "d1146cda-e786-4e4c-a9cb-24a0a6e5bd99" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalCalories",
                table: "Receipts",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "CaloriesPer100grams",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "TotalCalories",
                table: "Ingredients",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "QuantityForIngredient",
                table: "Ingredients",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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
    }
}
