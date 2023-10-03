namespace ContestantsApi.Models
{
    public class PlayerContestant
    {
        public int PlayerContestantID { get; set; }

        public string FbID { get; set; }

        public string Email { get; set; }

        public int SelectionOneGb { get; set; }

        public int SelectionTwoGb { get; set; }

        public int SelectionThreeGb { get; set; }

        public int SelectionFourGb { get; set; }

        public int SelectionFiveGb { get; set; }

        public int SelectionOneBIP { get; set; }

        public int SelectionTwoBIP { get; set; }

        public int SelectionThreeBIP { get; set; }

        public int SelectionFourBIP { get; set; }

        public int SelectionFiveBIP { get; set; }

        public int PlayerBIPEpisodeTotal { get; set; }
        
        public int PlayerGbEpisodeTotal { get; set; }

        public int WeekNumber { get; set; }
    }
}