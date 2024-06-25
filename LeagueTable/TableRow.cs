namespace LeagueTable
{
    public class TableRow
    {
        public string TeamName { get; set; }
        public int Rank { get; set; }
        public int Wins { get; set; }
        public int Defeats { get; set; }
        public int Ties { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsConceded { get; set; }
        public int GoalsDifference
        {
            get { return this.GoalsScored - this.GoalsConceded; }
        }
        public int Points
        {
            get { return this.Wins * 3 + this.Ties; }
        }

        public TableRow(
            string teamName,
            int rank,
            int wins,
            int defeats,
            int ties,
            int goalsScored,
            int goalsConceded
        )
        {
            this.TeamName = teamName;
            this.Rank = rank;
            this.Wins = wins;
            this.Defeats = defeats;
            this.Ties = ties;
            this.GoalsScored = goalsScored;
            this.GoalsConceded = goalsConceded;
        }

        public override string ToString()
        {
            return $"{TeamName, 20} {Rank, 2} {Wins, 2} {Defeats, 2} {Ties, 2} {GoalsScored, 2} {GoalsConceded, 2} {GoalsDifference, 2} {Points, 2}";
        }
    }
}
