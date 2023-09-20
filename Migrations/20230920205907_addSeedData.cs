using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContestantsApi.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "GbContestants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "BipContestants",
                columns: new[] { "BipContestantId", "Name", "PastAppearance", "Photo", "SeasonTotal" },
                values: new object[,]
                {
                    { 1, "Greer Blitzer", "'The Bachelor' Season 27 (Zach's Season)", "https://cdn1.edgedatg.com/aws/v2/abc/BachelorinParadise/person/4292042/e00e354fe7bce194bba130edb606b033/1600x640-Q90_e00e354fe7bce194bba130edb606b033.jpg", 0 },
                    { 2, "Brayden Bowers", "'The Bachelorette' Season 20 (Charity's Season)", "https://cdn1.edgedatg.com/aws/v2/abc/BachelorinParadise/person/4292478/0258a7bdd5e631f96301a45cec36ae0d/1600x640-Q90_0258a7bdd5e631f96301a45cec36ae0d.jpg", 0 },
                    { 3, "Aaron Bryant", "'The Bachelorette' Season 20 (Charity's Season)", "https://cdn1.edgedatg.com/aws/v2/abc/BachelorinParadise/person/4292467/fa63ab10e12ad52ffed9a4dedb258604/1600x640-Q90_fa63ab10e12ad52ffed9a4dedb258604.jpg", 0 },
                    { 4, "Peter Cappio", "'The Bachelorette' Season 20 (Charity's Season)", "https://cdn1.edgedatg.com/aws/v2/abc/BachelorinParadise/person/4292412/b52d663e093fa2d3ef40b1d3cb5e9db4/1600x640-Q90_b52d663e093fa2d3ef40b1d3cb5e9db4.jpg", 0 },
                    { 5, "Jess Girod", "'The Bachelor' Season 27 (Zach's Season)", "https://cdn1.edgedatg.com/aws/v2/abc/BachelorinParadise/person/4292038/0dc615979cb7fa655f4c0cddbbf66c62/1600x640-Q90_0dc615979cb7fa655f4c0cddbbf66c62.jpg", 0 }
                });

            migrationBuilder.InsertData(
                table: "GbContestants",
                columns: new[] { "GbContestantId", "Age", "Bio", "Hometown", "Name", "Occupation", "Photo", "SeasonTotal" },
                values: new object[,]
                {
                    { 1, 61, "Anna is a woman of the world. She has traveled to over 20 countries but is still looking for her travel partner for life. Anna has three daughters, and loves hiking and skiing with them. The adventurous matriarch is looking for a kind, confident, sensitive and emotionally intelligent man with whom to share her life. When Anna isn't spending time with her family, she loves foraging for mushrooms, and learning about new herbs and plants. She also loves to cook and is ready to prepare a gourmet dish for our Golden Bachelor. Gerry, I hope you're hungry for love and a delicious meal!", "Summit, New Jersey", "Anna", "Retired Nutritionist", "https://cdn1.edgedatg.com/aws/v2/abc/TheGoldenBachelor/person/4294438/9c25cb3bea4b9c277338669beda608db/1600x640-Q90_9c25cb3bea4b9c277338669beda608db.jpg", 0 },
                    { 2, 65, "April is ready to ride off into the sunset with our Golden Bachelor. It's easy to see what makes April a great catch with her zest for life, fun personality and extremely close family. She talks to them daily and makes sure to exchange 'I love yous' every time they chat. Dating since losing her partner has been difficult for her, so April is looking forward to the opportunity of a lifetime to look for love with the Golden Bachelor. When she's not spending time with her kids and grandkids, April loves dancing to Taylor Swift, watching 'Bridgerton' and playing with her two dogs. April also isn't afraid of thrill seeking and loves a good roller coaster. April and Gerry, buckle up because this is going to be the ride of your lives!", "Port St. Lucie, Florida", "April", "Therapist", "https://cdn1.edgedatg.com/aws/v2/abc/TheGoldenBachelor/person/4294445/94b387296bf78ad01de721dda7510b2a/1600x640-Q90_94b387296bf78ad01de721dda7510b2a.jpg", 0 },
                    { 3, 73, "Christina is a sweet soul who's ready to find love. She says she's the happiest she's ever been and is hoping to find someone with whom to share her golden years. Christina calls this chapter of life her 'go-go' years, not the 'slow-go' years, so hopefully Gerry can keep up! Christina is extremely proud of her career, and while she's retired now, working her way up the corporate ladder without a college degree is still one of her biggest accomplishments. Christina loves playing pickleball, listening to Paul McCartney, and horseback riding. She also isn't afraid of adventure and has plans to go skydiving (for a second time) with her oldest grandson. Wheels up, our hearts are ready for takeoff!", "Sierra Madre, California", "Christina", "Retired Purchasing Manager", "https://cdn1.edgedatg.com/aws/v2/abc/TheGoldenBachelor/person/4294446/c034b5b38f9b64ea4d49b34bed57aba4/1600x640-Q90_c034b5b38f9b64ea4d49b34bed57aba4.jpg", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BipContestants",
                keyColumn: "BipContestantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BipContestants",
                keyColumn: "BipContestantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BipContestants",
                keyColumn: "BipContestantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BipContestants",
                keyColumn: "BipContestantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BipContestants",
                keyColumn: "BipContestantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GbContestants",
                keyColumn: "GbContestantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GbContestants",
                keyColumn: "GbContestantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GbContestants",
                keyColumn: "GbContestantId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Age",
                table: "GbContestants");
        }
    }
}
