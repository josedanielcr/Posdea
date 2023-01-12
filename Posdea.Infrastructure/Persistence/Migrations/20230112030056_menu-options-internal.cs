using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Posdea.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class menuoptionsinternal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MenuOptionId",
                table: "MenuOptions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuOptions_MenuOptionId",
                table: "MenuOptions",
                column: "MenuOptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuOptions_MenuOptions_MenuOptionId",
                table: "MenuOptions",
                column: "MenuOptionId",
                principalTable: "MenuOptions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuOptions_MenuOptions_MenuOptionId",
                table: "MenuOptions");

            migrationBuilder.DropIndex(
                name: "IX_MenuOptions_MenuOptionId",
                table: "MenuOptions");

            migrationBuilder.DropColumn(
                name: "MenuOptionId",
                table: "MenuOptions");
        }
    }
}
