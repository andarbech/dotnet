namespace trackerLibrary;

public class TournamentModel
{
    public string TournamentName { get; set; }
    public decimal EntryFeed { get; set; }
    public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
    public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
    public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
}