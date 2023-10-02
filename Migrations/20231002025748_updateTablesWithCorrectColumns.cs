using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContestantsApi.Migrations
{
    public partial class updateTablesWithCorrectColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BipContestants",
                columns: table => new
                {
                    BipContestantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PastAppearance = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Photo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EpOneScore = table.Column<int>(type: "int", nullable: false),
                    EpTwoScore = table.Column<int>(type: "int", nullable: false),
                    EpThreeScore = table.Column<int>(type: "int", nullable: false),
                    EpFourScore = table.Column<int>(type: "int", nullable: false),
                    EpFiveScore = table.Column<int>(type: "int", nullable: false),
                    EpSixScore = table.Column<int>(type: "int", nullable: false),
                    EpSevenScore = table.Column<int>(type: "int", nullable: false),
                    EpEightScore = table.Column<int>(type: "int", nullable: false),
                    EpNineScore = table.Column<int>(type: "int", nullable: false),
                    EpTenScore = table.Column<int>(type: "int", nullable: false),
                    EpElevenScore = table.Column<int>(type: "int", nullable: false),
                    EpTweleveScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BipContestants", x => x.BipContestantId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GbContestants",
                columns: table => new
                {
                    GbContestantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Hometown = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Occupation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Bio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Photo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EpOneScore = table.Column<int>(type: "int", nullable: false),
                    EpTwoScore = table.Column<int>(type: "int", nullable: false),
                    EpThreeScore = table.Column<int>(type: "int", nullable: false),
                    EpFourScore = table.Column<int>(type: "int", nullable: false),
                    EpFiveScore = table.Column<int>(type: "int", nullable: false),
                    EpSixScore = table.Column<int>(type: "int", nullable: false),
                    EpSevenScore = table.Column<int>(type: "int", nullable: false),
                    EpEightScore = table.Column<int>(type: "int", nullable: false),
                    EpNineScore = table.Column<int>(type: "int", nullable: false),
                    EpTenScore = table.Column<int>(type: "int", nullable: false),
                    EpElevenScore = table.Column<int>(type: "int", nullable: false),
                    EpTweleveScore = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GbContestants", x => x.GbContestantId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PlayersContestants",
                columns: table => new
                {
                    PlayerContestantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FbID = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SelectionOneGb = table.Column<int>(type: "int", nullable: false),
                    SelectionTwoGb = table.Column<int>(type: "int", nullable: false),
                    SelectionThreeGb = table.Column<int>(type: "int", nullable: false),
                    SelectionFourGb = table.Column<int>(type: "int", nullable: false),
                    SelectionFiveGb = table.Column<int>(type: "int", nullable: false),
                    SelectionOneBIP = table.Column<int>(type: "int", nullable: false),
                    SelectionTwoBIP = table.Column<int>(type: "int", nullable: false),
                    SelectionThreeBIP = table.Column<int>(type: "int", nullable: false),
                    SelectionFourBIP = table.Column<int>(type: "int", nullable: false),
                    SelectionFiveBIP = table.Column<int>(type: "int", nullable: false),
                    PlayerBIPEpisodeTotal = table.Column<int>(type: "int", nullable: false),
                    PlayerGbEpisodeTotal = table.Column<int>(type: "int", nullable: false),
                    WeekNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersContestants", x => x.PlayerContestantID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "BipContestants",
                columns: new[] { "BipContestantId", "EpEightScore", "EpElevenScore", "EpFiveScore", "EpFourScore", "EpNineScore", "EpOneScore", "EpSevenScore", "EpSixScore", "EpTenScore", "EpThreeScore", "EpTweleveScore", "EpTwoScore", "Name", "PastAppearance", "Photo" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Greer Blitzer", "'The Bachelor' Season 27 (Zach's Season)", "https://cdn1.edgedatg.com/aws/v2/abc/BachelorinParadise/person/4292042/e00e354fe7bce194bba130edb606b033/1600x640-Q90_e00e354fe7bce194bba130edb606b033.jpg" },
                    { 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Brayden Bowers", "'The Bachelorette' Season 20 (Charity's Season)", "https://cdn1.edgedatg.com/aws/v2/abc/BachelorinParadise/person/4292478/0258a7bdd5e631f96301a45cec36ae0d/1600x640-Q90_0258a7bdd5e631f96301a45cec36ae0d.jpg" },
                    { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Aaron Bryant", "'The Bachelorette' Season 20 (Charity's Season)", "https://cdn1.edgedatg.com/aws/v2/abc/BachelorinParadise/person/4292467/fa63ab10e12ad52ffed9a4dedb258604/1600x640-Q90_fa63ab10e12ad52ffed9a4dedb258604.jpg" },
                    { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Peter Cappio", "'The Bachelorette' Season 20 (Charity's Season)", "https://cdn1.edgedatg.com/aws/v2/abc/BachelorinParadise/person/4292412/b52d663e093fa2d3ef40b1d3cb5e9db4/1600x640-Q90_b52d663e093fa2d3ef40b1d3cb5e9db4.jpg" },
                    { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Jess Girod", "'The Bachelor' Season 27 (Zach's Season)", "https://cdn1.edgedatg.com/aws/v2/abc/BachelorinParadise/person/4292038/0dc615979cb7fa655f4c0cddbbf66c62/1600x640-Q90_0dc615979cb7fa655f4c0cddbbf66c62.jpg" }
                });

            migrationBuilder.InsertData(
                table: "GbContestants",
                columns: new[] { "GbContestantId", "Age", "Bio", "EpEightScore", "EpElevenScore", "EpFiveScore", "EpFourScore", "EpNineScore", "EpOneScore", "EpSevenScore", "EpSixScore", "EpTenScore", "EpThreeScore", "EpTweleveScore", "EpTwoScore", "Hometown", "Name", "Occupation", "Photo" },
                values: new object[,]
                {
                    { 1, 61, "Anna is a woman of the world. She has traveled to over 20 countries but is still looking for her travel partner for life. Anna has three daughters, and loves hiking and skiing with them. The adventurous matriarch is looking for a kind, confident, sensitive and emotionally intelligent man with whom to share her life. When Anna isn't spending time with her family, she loves foraging for mushrooms, and learning about new herbs and plants. She also loves to cook and is ready to prepare a gourmet dish for our Golden Bachelor. Gerry, I hope you're hungry for love and a delicious meal!", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Summit, New Jersey", "Anna", "Retired Nutritionist", "https://cdn1.edgedatg.com/aws/v2/abc/TheGoldenBachelor/person/4294438/9c25cb3bea4b9c277338669beda608db/1600x640-Q90_9c25cb3bea4b9c277338669beda608db.jpg" },
                    { 2, 65, "April is ready to ride off into the sunset with our Golden Bachelor. It's easy to see what makes April a great catch with her zest for life, fun personality and extremely close family. She talks to them daily and makes sure to exchange 'I love yous' every time they chat. Dating since losing her partner has been difficult for her, so April is looking forward to the opportunity of a lifetime to look for love with the Golden Bachelor. When she's not spending time with her kids and grandkids, April loves dancing to Taylor Swift, watching 'Bridgerton' and playing with her two dogs. April also isn't afraid of thrill seeking and loves a good roller coaster. April and Gerry, buckle up because this is going to be the ride of your lives!", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Port St. Lucie, Florida", "April", "Therapist", "https://cdn1.edgedatg.com/aws/v2/abc/TheGoldenBachelor/person/4294445/94b387296bf78ad01de721dda7510b2a/1600x640-Q90_94b387296bf78ad01de721dda7510b2a.jpg" },
                    { 3, 73, "Christina is a sweet soul who's ready to find love. She says she's the happiest she's ever been and is hoping to find someone with whom to share her golden years. Christina calls this chapter of life her 'go-go' years, not the 'slow-go' years, so hopefully Gerry can keep up! Christina is extremely proud of her career, and while she's retired now, working her way up the corporate ladder without a college degree is still one of her biggest accomplishments. Christina loves playing pickleball, listening to Paul McCartney, and horseback riding. She also isn't afraid of adventure and has plans to go skydiving (for a second time) with her oldest grandson. Wheels up, our hearts are ready for takeoff!", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "Sierra Madre, California", "Christina", "Retired Purchasing Manager", "https://cdn1.edgedatg.com/aws/v2/abc/TheGoldenBachelor/person/4294446/c034b5b38f9b64ea4d49b34bed57aba4/1600x640-Q90_c034b5b38f9b64ea4d49b34bed57aba4.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BipContestants");

            migrationBuilder.DropTable(
                name: "GbContestants");

            migrationBuilder.DropTable(
                name: "PlayersContestants");
        }
    }
}
