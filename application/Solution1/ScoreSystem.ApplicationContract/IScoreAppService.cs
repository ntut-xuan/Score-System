namespace ScoreSystem.ApplicationContract;

public interface IScoreAppService
{
    Task AddAsync(ScoreRecordInput input, CancellationToken cancellationToken = default);
}