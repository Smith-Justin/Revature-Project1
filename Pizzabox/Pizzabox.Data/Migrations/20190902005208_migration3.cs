using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzabox.Data.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Toppings",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Sizes",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "LoginInfos",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Crusts",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_Name",
                table: "Toppings",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_Name",
                table: "Sizes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LoginInfos_Email",
                table: "LoginInfos",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Crusts_Name",
                table: "Crusts",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Toppings_Name",
                table: "Toppings");

            migrationBuilder.DropIndex(
                name: "IX_Sizes_Name",
                table: "Sizes");

            migrationBuilder.DropIndex(
                name: "IX_LoginInfos_Email",
                table: "LoginInfos");

            migrationBuilder.DropIndex(
                name: "IX_Crusts_Name",
                table: "Crusts");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Toppings",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Sizes",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "LoginInfos",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Crusts",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
