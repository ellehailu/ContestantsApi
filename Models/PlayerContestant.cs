namespace ContestantsApi.Models
{
    public class PlayerContestant
    {
        public int PlayerContestantID { get; set; }

        public string FbID { get; set; }

        public int selectionOneGb { get; set; }

        public int selectionTwoGb { get; set; }

        public int selectionThreeGb { get; set; }

        public int selectionFourGb { get; set; }

        public int selectionFiveGb { get; set; }

        public int playerSeasonTotal { get; set; }

        public GbContestant GbContestant { get; set; }

        public int weekNumber { get; set; }
    }
}