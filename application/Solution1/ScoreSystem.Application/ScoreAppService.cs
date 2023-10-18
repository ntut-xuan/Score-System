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

    public async Task AddAsync(ScoreInput input, CancellationToken cancellationToken = default)
    {
        foreach (var scoreRecord in input.Scores)
        {
            var model = _mapper.Map<ScoreSystemModel>(scoreRecord);
            model.User = input.User;
            model.RecordId = input.RecordId;
            model.Title = input.Title;
            model.CreateTime = DateTime.Now;
            await _scoreSystem.AddRecordAsync(model);
        }
    }
}