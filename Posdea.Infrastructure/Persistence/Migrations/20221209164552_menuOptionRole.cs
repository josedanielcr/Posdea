using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Posdea.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class menuOptionRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuOptions_Roles_RoleId",
                table: "MenuOptions");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "MenuOptions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "MenuOptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuOptions_Roles_RoleId",
                table: "MenuOptions",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuOptions_Roles_RoleId",
                table: "MenuOptions");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "MenuOptions");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "MenuOptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuOptions_Roles_RoleId",
                table: "MenuOptions",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
