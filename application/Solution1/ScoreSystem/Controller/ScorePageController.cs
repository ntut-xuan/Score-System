using System.Text;
using Microsoft.AspNetCore.Mvc;
using RazorLight;
using ScoreSystem.Template;

namespace ScoreSystem.Controller;

public class ScorePageController : ControllerBase
{
    private readonly IRazorLightEngine _razorLightEngine;

    public ScorePageController(IRazorLightEngine razorLightEngine)
    {
        _razorLightEngine = razorLightEngine;
    }
    
    [HttpGet("/Score")]
    public async Task<IActionResult> GetScorePage()
    {
        var page = await _razorLightEngine.CompileRenderAsync("Template.ClientSide", new ClientSideModel());

        return Content(page, "text/html", Encoding.UTF8);
    }
}