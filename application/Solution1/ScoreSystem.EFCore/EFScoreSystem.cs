using AutoMapper;
using ScoreSystem.Domain;
using ScoreSystem.EFCore.Model;

namespace ScoreSystem.EFCore;

public class EFScoreSystem : IEFScoreSystem
{
    private readonly EFScoreSystemDbContext _dbContext = new EFScoreSystemDbContext();
    private readonly IMapper _mapper;

    public EFScoreSystem(IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public async Task AddRecordAsync(ScoreSystemModel scoreSystemModel)
    {
        await _dbContext.ScoreRecords.AddAsync(_mapper.Map<ScoreRecord>(scoreSystemModel));

        await _dbContext.SaveChangesAsync();
    }
}