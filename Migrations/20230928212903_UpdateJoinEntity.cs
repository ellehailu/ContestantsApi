using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContestantsApi.Migrations
{
    public partial class UpdateJoinEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "selectionFiveGb",
                table: "PlayersContestants");

            migrationBuilder.DropColumn(
                name: "selectionFourGb",
                table: "PlayersContestants");

            migrationBuilder.DropColumn(
                name: "selectionOneGb",
                table: "PlayersContestants");

            migrationBuilder.DropColumn(
                name: "selectionThreeGb",
                table: "PlayersContestants");

            migrationBuilder.DropColumn(
                name: "selectionTwoGb",
                table: "PlayersContestants");

            migrationBuilder.AddColumn<int>(
                name: "selectionFiveGbGbContestantId",
                table: "PlayersContestants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "selectionFourGbGbContestantId",
                table: "PlayersContestants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "selectionOneGbGbContestantId",
                table: "PlayersContestants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "selectionThreeGbGbContestantId",
                table: "PlayersContestants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "selectionTwoGbGbContestantId",
                table: "PlayersContestants",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlayersContestants_selectionFiveGbGbContestantId",
                table: "PlayersContestants",
                column: "selectionFiveGbGbContestantId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersContestants_selectionFourGbGbContestantId",
                table: "PlayersContestants",
                column: "selectionFourGbGbContestantId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersContestants_selectionOneGbGbContestantId",
                table: "PlayersContestants",
                column: "selectionOneGbGbContestantId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersContestants_selectionThreeGbGbContestantId",
                table: "PlayersContestants",
                column: "selectionThreeGbGbContestantId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersContestants_selectionTwoGbGbContestantId",
                table: "PlayersContestants",
                column: "selectionTwoGbGbContestantId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersContestants_GbContestants_selectionFiveGbGbContestant~",
                table: "PlayersContestants",
                column: "selectionFiveGbGbContestantId",
                principalTable: "GbContestants",
                principalColumn: "GbContestantId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersContestants_GbContestants_selectionFourGbGbContestant~",
                table: "PlayersContestants",
                column: "selectionFourGbGbContestantId",
                principalTable: "GbContestants",
                principalColumn: "GbContestantId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersContestants_GbContestants_selectionOneGbGbContestantId",
                table: "PlayersContestants",
                column: "selectionOneGbGbContestantId",
                principalTable: "GbContestants",
                principalColumn: "GbContestantId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersContestants_GbContestants_selectionThreeGbGbContestan~",
                table: "PlayersContestants",
                column: "selectionThreeGbGbContestantId",
                principalTable: "GbContestants",
                principalColumn: "GbContestantId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayersContestants_GbContestants_selectionTwoGbGbContestantId",
                table: "PlayersContestants",
                column: "selectionTwoGbGbContestantId",
                principalTable: "GbContestants",
                principalColumn: "GbContestantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayersContestants_GbContestants_selectionFiveGbGbContestant~",
                table: "PlayersContestants");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayersContestants_GbContestants_selectionFourGbGbContestant~",
                table: "PlayersContestants");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayersContestants_GbContestants_selectionOneGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayersContestants_GbContestants_selectionThreeGbGbContestan~",
                table: "PlayersContestants");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayersContestants_GbContestants_selectionTwoGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropIndex(
                name: "IX_PlayersContestants_selectionFiveGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropIndex(
                name: "IX_PlayersContestants_selectionFourGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropIndex(
                name: "IX_PlayersContestants_selectionOneGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropIndex(
                name: "IX_PlayersContestants_selectionThreeGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropIndex(
                name: "IX_PlayersContestants_selectionTwoGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropColumn(
                name: "selectionFiveGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropColumn(
                name: "selectionFourGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropColumn(
                name: "selectionOneGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropColumn(
                name: "selectionThreeGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.DropColumn(
                name: "selectionTwoGbGbContestantId",
                table: "PlayersContestants");

            migrationBuilder.AddColumn<string>(
                name: "selectionFiveGb",
                table: "PlayersContestants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "selectionFourGb",
                table: "PlayersContestants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "selectionOneGb",
                table: "PlayersContestants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "selectionThreeGb",
                table: "PlayersContestants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "selectionTwoGb",
                table: "PlayersContestants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
