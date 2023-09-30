namespace ContestantsApi.Models
{
    public class PlayerContestant
    {
        public int PlayerContestantID { get; set; }

        public string FbID { get; set; }

        public string Email { get; set; }

        public int SelectionOneGb { get; set; }

        public int SelectionOneGbelectionTwoGb { get; set; }

        public int SelectionThreeGb { get; set; }

        public int SelectionFourGb { get; set; }

        public int SelectionFiveGb { get; set; }

        public int PlayerEpisodeTotal { get; set; }

        public int WeekNumber { get; set; }
    }
}