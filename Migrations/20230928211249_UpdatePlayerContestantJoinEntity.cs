using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContestantsApi.Migrations
{
    public partial class UpdatePlayerContestantJoinEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GbContestantId",
                table: "PlayersContestants",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayersContestants_GbContestantId",
                table: "PlayersContestants",
                column: "GbContestantId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersContestants_GbContestants_GbContestantId",
                table: "PlayersContestants",
                column: "GbContestantId",
                principalTable: "GbContestants",
                principalColumn: "GbContestantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayersContestants_GbContestants_GbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropIndex(
                name: "IX_PlayersContestants_GbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropColumn(
                name: "GbContestantId",
                table: "PlayersContestants");
        }
    }
}
