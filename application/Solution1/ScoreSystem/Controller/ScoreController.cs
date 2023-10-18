using Microsoft.AspNetCore.Mvc;
using ScoreSystem.ApplicationContract;

namespace ScoreSystem.Controller;

public class ScoreController : ControllerBase
{
    private readonly IScoreAppService _scoreAppService;

    public ScoreController(IScoreAppService scoreAppService)
    {
        _scoreAppService = scoreAppService;
    }
    
    [HttpPost("/api/v1/submit")]
    public async Task<IActionResult> Submit([FromBody] ScoreRecordInput input, CancellationToken cancellationToken)
    {
        await _scoreAppService.AddAsync(input, cancellationToken);
        return Ok();
    }
}