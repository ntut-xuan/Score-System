using ScoreSystem.EFCore.Model;

namespace ScoreSystem.Domain;

public interface IEFScoreSystem
{
    Task AddRecordAsync(ScoreSystemModel scoreSystemModel);
}