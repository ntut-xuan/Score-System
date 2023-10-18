namespace ScoreSystem.ApplicationContract;

public class ScoreInput
{
    public Guid RecordId { get; set; }
    public string User { get; set; }
    public string Title { get; set; }
    public IEnumerable<ScoreRecordInput> Scores { get; set; }
}