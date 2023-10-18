namespace ScoreSystem.EFCore.Model;

public class ScoreSystemModel
{
    public string User { get; set; }
    public Guid RecordId { get; set; }
    public string Suite { get; set; }
    public int Passed { get; set; }
    public int Failed { get; set; }
    public int Score { get; set; }
    public DateTime CreateTime { get; set; }
}