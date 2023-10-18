namespace ScoreSystem.ApplicationContract;

public class ScoreRecordInput
{
    public Guid RecordId { get; set; }
    public string Suite { get; set; }
    public int Passed { get; set; }
    public int Failed { get; set; }
    public int Score { get; set; }
    public string User { get; set; }
}