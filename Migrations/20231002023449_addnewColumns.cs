using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContestantsApi.Migrations
{
    public partial class addnewColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SelectionOneGbelectionTwoGb",
                table: "PlayersContestants",
                newName: "SelectionTwoGb");

            migrationBuilder.RenameColumn(
                name: "SeasonTotal",
                table: "GbContestants",
                newName: "EpTwoScore");

            migrationBuilder.RenameColumn(
                name: "SeasonTotal",
                table: "BipContestants",
                newName: "EpTwoScore");

            migrationBuilder.AddColumn<int>(
                name: "EpEightScore",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpElevenScore",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpFiveScore",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpFourScore",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpNineScore",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpOneScore",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpSevenScore",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpSixScore",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpTenScore",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpThreeScore",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpTweleveScore",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpEightScore",
                table: "BipContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpElevenScore",
                table: "BipContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpFiveScore",
                table: "BipContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpFourScore",
                table: "BipContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpNineScore",
                table: "BipContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpOneScore",
                table: "BipContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpSevenScore",
                table: "BipContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpSixScore",
                table: "BipContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpTenScore",
                table: "BipContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpThreeScore",
                table: "BipContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EpTweleveScore",
                table: "BipContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EpEightScore",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "EpElevenScore",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "EpFiveScore",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "EpFourScore",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "EpNineScore",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "EpOneScore",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "EpSevenScore",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "EpSixScore",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "EpTenScore",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "EpThreeScore",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "EpTweleveScore",
                table: "GbContestants");

            migrationBuilder.DropColumn(
                name: "EpEightScore",
                table: "BipContestants");

            migrationBuilder.DropColumn(
                name: "EpElevenScore",
                table: "BipContestants");

            migrationBuilder.DropColumn(
                name: "EpFiveScore",
                table: "BipContestants");

            migrationBuilder.DropColumn(
                name: "EpFourScore",
                table: "BipContestants");

            migrationBuilder.DropColumn(
                name: "EpNineScore",
                table: "BipContestants");

            migrationBuilder.DropColumn(
                name: "EpOneScore",
                table: "BipContestants");

            migrationBuilder.DropColumn(
                name: "EpSevenScore",
                table: "BipContestants");

            migrationBuilder.DropColumn(
                name: "EpSixScore",
                table: "BipContestants");

            migrationBuilder.DropColumn(
                name: "EpTenScore",
                table: "BipContestants");

            migrationBuilder.DropColumn(
                name: "EpThreeScore",
                table: "BipContestants");

            migrationBuilder.DropColumn(
                name: "EpTweleveScore",
                table: "BipContestants");

            migrationBuilder.RenameColumn(
                name: "SelectionTwoGb",
                table: "PlayersContestants",
                newName: "SelectionOneGbelectionTwoGb");

            migrationBuilder.RenameColumn(
                name: "EpTwoScore",
                table: "GbContestants",
                newName: "SeasonTotal");

            migrationBuilder.RenameColumn(
                name: "EpTwoScore",
                table: "BipContestants",
                newName: "SeasonTotal");
        }
    }
}
