namespace trackerLibrary;

public class MatchupEntryModel
{
    public TeamModel TeamCompeting { get; set; }
    public double Score { get; set; }
    public MatchupModel ParentMatchup { get; set; }
    public MatchupEntryModel(double initialScore)
    {
        Console.WriteLine("Andresitoo");
    }
}