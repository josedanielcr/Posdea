using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Posdea.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class userstructurechanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "avatar",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "avatar",
                table: "Users");
        }
    }
}
