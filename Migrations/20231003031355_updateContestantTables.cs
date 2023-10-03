using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContestantsApi.Migrations
{
    public partial class updateContestantTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "GbContestants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "BipContestants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "BipContestants",
                keyColumn: "BipContestantId",
                keyValue: 1,
                column: "Status",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "BipContestants",
                keyColumn: "BipContestantId",
                keyValue: 2,
                column: "Status",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "BipContestants",
                keyColumn: "BipContestantId",
                keyValue: 3,
                column: "Status",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "BipContestants",
                keyColumn: "BipContestantId",
                keyValue: 4,
                column: "Status",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "BipContestants",
                keyColumn: "BipContestantId",
                keyValue: 5,
                column: "Status",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "GbContestants",
                keyColumn: "GbContestantId",
                keyValue: 1,
                column: "Status",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "GbContestants",
                keyColumn: "GbContestantId",
                keyValue: 2,
                column: "Status",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "GbContestants",
                keyColumn: "GbContestantId",
                keyValue: 3,
                column: "Status",
                value: "Active");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "BipContestants");
        }
    }
}
