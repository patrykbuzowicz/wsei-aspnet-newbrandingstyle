using Microsoft.EntityFrameworkCore.Migrations;

namespace NewBrandingStyle.Web.Migrations
{
    public partial class AddUserIdToCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPublic",
                table: "Companies",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Companies",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublic",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Companies");
        }
    }
}
