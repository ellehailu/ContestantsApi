using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContestantsApi.Migrations
{
    public partial class addEndpointsPlayerContestant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "weekNumber",
                table: "PlayersContestants",
                newName: "WeekNumber");

            migrationBuilder.RenameColumn(
                name: "selectionThreeGb",
                table: "PlayersContestants",
                newName: "SelectionThreeGb");

            migrationBuilder.RenameColumn(
                name: "selectionOneGb",
                table: "PlayersContestants",
                newName: "SelectionOneGb");

            migrationBuilder.RenameColumn(
                name: "selectionFourGb",
                table: "PlayersContestants",
                newName: "SelectionFourGb");

            migrationBuilder.RenameColumn(
                name: "selectionFiveGb",
                table: "PlayersContestants",
                newName: "SelectionFiveGb");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "PlayersContestants",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "selectionTwoGb",
                table: "PlayersContestants",
                newName: "SelectionOneGbelectionTwoGb");

            migrationBuilder.RenameColumn(
                name: "playerSeasonTotal",
                table: "PlayersContestants",
                newName: "PlayerEpisodeTotal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeekNumber",
                table: "PlayersContestants",
                newName: "weekNumber");

            migrationBuilder.RenameColumn(
                name: "SelectionThreeGb",
                table: "PlayersContestants",
                newName: "selectionThreeGb");

            migrationBuilder.RenameColumn(
                name: "SelectionOneGb",
                table: "PlayersContestants",
                newName: "selectionOneGb");

            migrationBuilder.RenameColumn(
                name: "SelectionFourGb",
                table: "PlayersContestants",
                newName: "selectionFourGb");

            migrationBuilder.RenameColumn(
                name: "SelectionFiveGb",
                table: "PlayersContestants",
                newName: "selectionFiveGb");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "PlayersContestants",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "SelectionOneGbelectionTwoGb",
                table: "PlayersContestants",
                newName: "selectionTwoGb");

            migrationBuilder.RenameColumn(
                name: "PlayerEpisodeTotal",
                table: "PlayersContestants",
                newName: "playerSeasonTotal");
        }
    }
}
