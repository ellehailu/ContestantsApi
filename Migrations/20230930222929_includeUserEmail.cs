using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContestantsApi.Migrations
{
    public partial class includeUserEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "PlayersContestants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "PlayersContestants");
        }
    }
}
