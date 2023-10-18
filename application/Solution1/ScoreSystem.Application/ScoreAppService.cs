using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ScoreSystem.ApplicationContract;
using ScoreSystem.Domain;
using ScoreSystem.EFCore.Model;

namespace ScoreSystem.Application;

public class ScoreAppService : IScoreAppService
{
    private readonly IEFScoreSystem _scoreSystem;
    private readonly IMapper _mapper;
    
    public ScoreAppService(IEFScoreSystem efScoreSystem, IMapper mapper)
    {
        _scoreSystem = efScoreSystem;
        _mapper = mapper;
    }

    public async Task AddAsync(ScoreRecordInput input, CancellationToken cancellationToken = default)
    {
        await _scoreSystem.AddRecordAsync(_mapper.Map<ScoreSystemModel>(input));
    }
}