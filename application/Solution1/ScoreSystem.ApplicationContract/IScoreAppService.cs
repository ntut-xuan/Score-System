namespace ScoreSystem.ApplicationContract;

public interface IScoreAppService
{
    Task AddAsync(ScoreInput input, CancellationToken cancellationToken = default);
}